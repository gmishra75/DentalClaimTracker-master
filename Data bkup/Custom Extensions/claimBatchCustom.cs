using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace C_DentalClaimTracker
{
    public partial class claim_batch : DataObject
    {
        /// <summary>
        /// Override. Deletes all references to claim batch in batch_claim_list, then erases batch.
        /// </summary>
        public override void Delete()
        {
            ExecuteNonQuery("DELETE FROM batch_claim_list WHERE batch_id = " + id);
            base.Delete();
        }

        public void AddClaimList(List<int> claimIDs)
        {
            foreach (int anId in claimIDs)
                AddClaim(anId);
        }

        /// <summary>
        /// CUSTOM Get/Set for the string handling. Returns None if the data is null, otherwise converts the string as necessary
        /// </summary>
        public clsClaimEnums.SentMethods handling
        {
            get
            {

                if (this["handling"] is string)
                {
                    string val = (string)this["handling"];

                    if (val == "ApexEDI")
                        return clsClaimEnums.SentMethods.ApexEDI;
                    else if (val == "Paper")
                        return clsClaimEnums.SentMethods.Paper;
                    else
                        return clsClaimEnums.SentMethods.None;
                    
                }
                else
                    return clsClaimEnums.SentMethods.None;
            }
            set
            {
                if (value == clsClaimEnums.SentMethods.None)
                    this["handling"] = "";    
                else if (value == clsClaimEnums.SentMethods.ApexEDI)
                    this["handling"] = "ApexEDI";
                else
                    this["handling"] = "Paper";
            }
        }

        /// <summary>
        /// Retrieves the handling as a string value (ApexEDI, Paper, or "")
        /// </summary>
        public string handlingAsString
        {
            get
            {
                return CommonFunctions.DBNullToString(this["handling"]);
            }
        }


        public void AddClaim(int claimID)
        {
            batch_claim_list bcl = new batch_claim_list();
            bcl.batch_id = id;
            bcl.claim_id = claimID;
            bcl.still_in_batch = true;
            bcl["last_send_date"] = batch_date;
            bcl.Save();
        }

        /// <summary>
        /// Chees to see if there is already a resend batch for today, if so returns it.
        /// Otherwise creates a new apex-resend batch for today
        /// </summary>
        /// <returns></returns>
        internal static claim_batch GetApexResendBatchForToday()
        {
            return GetDailyBatch(clsClaimEnums.SentMethods.ApexEDI, "Resend Daily Summary", "N/A");
        }

        /// <summary>
        /// Checks to see if there is already a paper batch for today, if so returns it.
        /// Otherwise creates a new paper batch for today.
        /// </summary>
        /// <returns></returns>
        internal static claim_batch GetPaperBatchForToday()
        {
            return GetDailyBatch(clsClaimEnums.SentMethods.Paper, "Standard Paper Batch");

        }

        private static claim_batch GetDailyBatch(clsClaimEnums.SentMethods batchSendMethod, string batchInfo, string serverName = "")
        {
            claim_batch toReturn = new claim_batch();

            DataTable matches = toReturn.Search("SELECT * FROM claim_batch WHERE handling = '" + batchSendMethod + "' AND " +
                "DateDiff(batch_date, NOW()) = 0");

            if (matches.Rows.Count > 0)
            {
                toReturn.Load(matches.Rows[0]);
            }
            else
            {
                toReturn.handling = batchSendMethod;
                toReturn.batch_date = DateTime.Now;
                toReturn.source = 0;
                toReturn.batch_info = batchInfo;
                if (serverName == string.Empty)
                    toReturn.server_name = C_DentalClaimTracker.General.RegistryData.LocalComputerName;
                else
                    toReturn.server_name = serverName;
                toReturn.Save();
            }

            return toReturn;
        }

        internal List<claim> GetMatchingClaims()
        {
            List<claim> toReturn = new List<claim>();

            try
            {
                DataTable dt = Search("SELECT c.* FROM batch_claim_list b " +
                "INNER JOIN claims c on b.claim_id = c.id WHERE b.batch_id = " + id +
                    " AND b.still_in_batch = true ORDER BY c.open desc, c.patient_last_name, c.patient_first_name");

                foreach (DataRow aClaim in dt.Rows)
                {
                    claim newClaim = new claim();
                    newClaim.Load(aClaim);
                    toReturn.Add(newClaim);
                }
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error in Retrieving matching claims", LogSeverity.Error, err, false);
                MessageBox.Show("There was an error retrieving the matching claims.\n\n" + err.Message);
            }

            return toReturn;
        }

        /// <summary>
        /// The default save folder for this batch. Includes closing /
        /// </summary>
        /// <returns></returns>
        internal string SaveFolder
        {
            get
            {
                return Application.StartupPath + "\\Batch Processing\\" + handling + "\\" + 
                    CommonFunctions.DateToFilePathFormat(batch_date) + "\\";
            }
        }

        internal string XMLSavePath
        {
            get
            {
                return SaveFolder + "batchdata.xml";
            }
        }

        internal string ApexEDIPath
        {
            get
            {
                return SaveFolder + "batchdata.apexedi";
            }
        }

        internal void SetSentDate(int claimID)
        {
            ExecuteNonQuery("UPDATE batch_claim_list SET last_send_date = '" + DateTime.Now.ToString("yyyy:MM:dd HH:mm:ss") +
                "' WHERE batch_id = " + id + " AND claim_id = " + claimID);
        }

        internal static claim_batch FindApexBatchWithDate(DateTime fileDate)
        {
            claim_batch toReturn = new claim_batch();
            string sql = "SELECT * FROM claim_batch WHERE TimeDiff(batch_date, '" + CommonFunctions.ToMySQLDateTime(fileDate) +
                "') = 0";
            DataTable dt = toReturn.Search(sql);

            if (dt.Rows.Count > 0)
            {
                toReturn.Load(dt.Rows[0]);

                if (dt.Rows.Count > 1)
                {
                    System.Diagnostics.Debug.WriteLine("Too many batches returned from the FindApexBatchWithDateFunction");
                }
            }
            else
                toReturn = null;

            return toReturn;
        }

        internal static claim_batch GetApexMostRecentBatch()
        {
            claim_batch toReturn = new claim_batch(); 
            DataTable dt = toReturn.Search("SELECT TOP 1 * FROM claim_batch WHERE handling = " + 
                (int) clsClaimEnums.SentMethods.ApexEDI + "ORDER BY batch_date desc");

            if (dt.Rows.Count > 0)
            {
                toReturn.Load(dt.Rows[0]);
            }
            else
                toReturn = null;

            return toReturn;
        }
    }
}
