using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace C_DentalClaimTracker.E_Claims.Mercury
{
    class EligibilityHelper
    {
        public static string ConvertFromTable(DataTable allData)
        {
            string recordData = "";
            XMLEligibilityData xh;
            
            foreach (DataRow aRow in allData.Rows)
            {
                xh = new XMLEligibilityData();

                /*
                 payer.inscoName AS PAYER_NAME, payer.insID + '-' + payer.insDB AS Payer_ID, payer.STREET AS PAYER_ADDRESS1, 
                 * payer.STREET2 AS PAYER_ADDRESS2, payer.CITY AS PAYER_CITY, payer.STATE AS PAYER_STATE,payer.ZIP AS PAYER_ZIP, 
appt.APPTDATE AS APPT_DATE, appt.time_hour AS APPT_HOUR, appt.time_minute AS APPT_MINUTE,
prov.NAME_FIRST AS Provider_FirstName, prov.NAME_LAST AS Provider_LastName, prov.ID1 AS Provider_NPI, prov.STATEID AS 
                 * Provider_LicenseNo, 'CT' AS provider_state,
sub.patid + '-' + sub.patdb as Subscriber_ID, sub.lastname AS Subscriber_LastName, sub.firstname AS Subscriber_FirstName, 
                 * sub.gender AS Subscriber_Gender, sub.birthdate AS Subscriber_DOB, payer.GroupNum as GroupNo, dep.patID 
                 * + '-' + dep.patDB AS SubscriberDependentID,
dep.PRINSREL AS PatientRelation,
dep.patID + '-' + dep.PATDB as DependentID, dep.LastName as Dependent_LastName, dep.FirstName as Dependent_FirstName, 
                 * dep.gender AS Dependent_Gender, dep.BirthDate as Dependent_DOB
                 */

                // Fill in all of our data here
                Dictionary<string, string> PayerInfo = GetMercuryPayerID(aRow["PAYER_NAME"].ToString());

                xh.PayerName = PayerInfo["name"];
                xh.PayerID = PayerInfo["id"];
                xh.PAYER_ADDRESS1 = aRow["PAYER_Address1"].ToString();
                xh.PAYER_ADDRESS2 = aRow["PAYER_Address2"].ToString();
                xh.PAYER_CITY = aRow["PAYER_City"].ToString();
                xh.PAYER_ZIP = aRow["PAYER_Zip"].ToString();
                xh.EligibilityDate = DateTime.Today.ToShortDateString();
                xh.AppointmentDate = aRow["APPT_Date"].ToString();
                xh.AppointmentTime = string.Format("{0}:{1}", aRow["APPT_Hour"].ToString(), aRow["APPT_Minute"].ToString());
                xh.EligibilityType = "D";
                xh.ProviderLastName = aRow["PROVIDER_LastName"].ToString();
                xh.ProviderFirstName = aRow["PROVIDER_FirstName"].ToString();
                xh.ProviderNPI = aRow["PROVIDER_NPI"].ToString();
                xh.ProviderLicenceNo = aRow["PROVIDER_LicenseNo"].ToString();
                xh.ProviderLicenseState = "CT";
                xh.SubscriberID = aRow["SUBSCRIBER_ID"].ToString();
                xh.SubscriberLastName = aRow["SUBSCRIBER_LastName"].ToString();
                xh.SubscriberFirstName = aRow["SUBSCRIBER_FirstName"].ToString();
                xh.SubscriberGender = aRow["SUBSCRIBER_Gender"].ToString();
                xh.SubscriberDOB = aRow["SUBSCRIBER_DOB"].ToString();
                xh.SubscriberGroupNo = aRow["GroupNo"].ToString();
                xh.PatientRelation = ConvertRelation(aRow["PatientRelation"].ToString());
                xh.DependentID = aRow["DEPENDENT_ID"].ToString();
                xh.DependentLastName = aRow["DEPENDENT_LastName"].ToString();
                xh.DependentFirstName = aRow["DEPENDENT_FirstName"].ToString();
                xh.DependentGender = aRow["DEPENDENT_Gender"].ToString();
                xh.DependentDOB = aRow["DEPENDENT_DOB"].ToString();


                recordData += xh.RecordAsString + "\n";
            }

            xh = new XMLEligibilityData();
            return xh.FullXMLAsString(recordData);
        }

        private static string ConvertRelation(string relation)
        {
            if (relation == "1")
                return "SELF";
            if (relation == "2")
                return "SPOUSE";
            else if (relation == "3")
                return "CHILD";
            else
                return "OTHER";
        }


        /// <summary>
        /// Tries to find a match for the payer on this claim. If a match isn't found, pops up a form asking the user to choose one.
        /// </summary>
        /// <param name="c"></param>
        private static Dictionary<string, string> GetMercuryPayerID(string payer_name)
        {
            mercury_payer_list mpl = new mercury_payer_list();
            Dictionary<string, string> easyMatches = mpl.SearchIncludeAlias(payer_name);

            if (easyMatches == null)
            {
                // Ask the user to select a payer id
                Mercury.frmFindMercuryPayer toShow = new Mercury.frmFindMercuryPayer(payer_name);
                toShow.ShowDialog();

                easyMatches = new Dictionary<string, string>();
                easyMatches.Add("id", toShow.PayerID);
                easyMatches.Add("name", toShow.PayerName);
            }


            return easyMatches;
        }

        /// <summary>
        /// Removes/replaces any invalid characters
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private static string CleanData(string toClean)
        {
            return toClean.Replace("&", "and");
        }


        /// <summary>
        /// Takes a nullable date time and returns it in the mercury format, or as an empty string if it's null
        /// </summary>
        /// <param name="oldDate"></param>
        /// <returns></returns>
        private static string ConvertDateTime(DateTime? oldDate)
        {
            if (oldDate.HasValue)
                return ConvertToMercuryDateTime(oldDate.Value);
            else
                return "";
        }
        
        private static string ConvertToMercuryDateTime(DateTime date)
        {
            return date.ToString("MM/dd/yyyy");
        }

        private static string ConvertToMercuryDateTime(string dateString)
        {
            try
            {
                DateTime toConvert = Convert.ToDateTime(dateString);
                return ConvertToMercuryDateTime(toConvert);
            }
            catch
            {
                return dateString;
            }
        }
    }
}
