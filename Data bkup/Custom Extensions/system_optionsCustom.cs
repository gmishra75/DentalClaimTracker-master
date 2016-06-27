using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace C_DentalClaimTracker
{
    static class system_options
    {
        internal static void SetImportFlag(bool value)
        {
            string sql = "UPDATE system_options SET is_importing = ";

            if (value)
                sql += "1";
            else
                sql += "0";

            user u = new user();

            u.ExecuteNonQuery(sql);

            if (value)
                Properties.Settings.Default.OpenedExclusive = true;
        }

        internal static bool ImportFlag
        {
            get
            {
                bool toReturn;
                user u = new user();
                DataTable dt = u.Search("SELECT is_importing FROM system_options WHERE id = 1");

                toReturn = System.Convert.ToBoolean(dt.Rows[0][0]);

                return toReturn;
            }
        }

        internal static string ApexEDISaveFolder
        {
            get
            {
                string toReturn;
                user u = new user();

                DataTable dt = u.Search("SELECT apex_folder FROM system_options WHERE id = 1");

                toReturn = Convert.ToString(dt.Rows[0][0]);

                return toReturn;
            }
            set
            {
                user u = new user();

                u.ExecuteNonQuery("UPDATE system_options SET apex_folder = '" + value.Replace(@"\", @"\\") + "' WHERE id = 1");
            }
        }

        internal static DateTime GetLastImportDate()
        {
            DateTime toReturn = new DateTime(1999, 1, 1);
            try
            {

                user u = new user();
                DataTable dt = u.Search("SELECT last_import_date FROM system_options WHERE id = 1");

                toReturn = System.Convert.ToDateTime(dt.Rows[0][0]);

            }
            catch { }

            return toReturn;

        }

        internal static void SetLastImportDate(DateTime lastDate)
        {
            try
            {
                user u = new user();
                u.ExecuteNonQuery("UPDATE system_options SET last_import_date = '" +
                    CommonFunctions.ToMySQLDateTime(lastDate) + "'");

                
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error in system_options.SetLastImportDate", LogSeverity.Error, err, true);
            }
        }

        internal static int ResendRevisit
        {
            get
            {
                return GetIntColumn("resend_revisit_date");
            }
            set
            {
                SetIntColumn("resend_revisit_date", value);
            }
        }

        private static void SetIntColumn(string colName, int value)
        {
            user u = new user();
            u.ExecuteNonQuery("UPDATE system_options SET " + colName + " = " + value);
            
        }

        private static void SetDateColumn(string colName, DateTime value)
        {
            user u = new user();
            u.ExecuteNonQuery("UPDATE system_options SET " + colName + " = '" + CommonFunctions.ToMySQLDate(value) + "'");
            
        }

        

        private static int GetIntColumn(string colToGet)
        {
            int toReturn = -1;
            user u = new user();
            DataTable dt = u.Search("SELECT " + colToGet + " FROM system_options");


            try
            {
                toReturn = Convert.ToInt32(dt.Rows[0][0]);
            }
            catch
            {
                // let it slide and just return -1
            }
            return toReturn;
        }

        internal static int ResendStatus
        {
            get
            {
                return GetIntColumn("resend_status");
            }
            set
            {
                SetIntColumn("resend_status", value);
            }
        }

        internal static bool EclaimsSecondaryShowExtraInfo
        {
            get
            {
                bool toReturn = true;
                user u = new user();
                DataTable dt = u.Search("SELECT show_secondary_info_eclaims FROM system_options");

                try
                {
                    toReturn = Convert.ToBoolean(dt.Rows[0][0]); 
                }
                catch
                {
                    // let it slide and just return true
                }
                return toReturn;
            }
            set
            {
                user u = new user();
                u.ExecuteNonQuery("UPDATE system_options SET show_secondary_info_eclaims = " + Convert.ToInt32(value));
                
            }
        }

        internal static int MaxClaimsInBatch
        {
            get
            {
                return GetIntColumn("max_claims_in_batch");
            }
            set
            {
                SetIntColumn("max_claims_in_batch", value);
            }
        }

        public static bool LimitPredetermsOnSearch
        {
            get
            {
                return Convert.ToBoolean(GetIntColumn("limit_predeterm_date"));
            }
            set
            {
                SetIntColumn("limit_predeterm_date", Convert.ToInt32(value));
            }
        }

        public static DateTime PredetermSearchDateMinimum
        {
            get
            {
                DateTime toReturn = new DateTime(1999, 1, 1);
                try
                {

                    user u = new user();
                    DataTable dt = u.Search("SELECT predeterm_minimum_date FROM system_options WHERE id = 1");

                    toReturn = System.Convert.ToDateTime(dt.Rows[0][0]);

                }
                catch { }

                return toReturn;
            }
            set
            {
                SetDateColumn("predeterm_minimum_date", value);
            }
        }
    }
}
