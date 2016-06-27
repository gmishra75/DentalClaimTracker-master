using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_DentalClaimTracker.E_Claims.Mercury
{
    class XMLEligibilityData
    {
        #region Get/Sets

        public string TRANS_ID { set { InsertValue("TRANS_ID", value); } }
        public string PRIORITY { set { InsertValue("PRIORITY", value); } }
        public string PayerName { set { InsertValue("PayerName", value); } }
        public string PayerID { set { InsertValue("PayerID", value); } }
        public string PAYER_ADDRESS1 { set { InsertValue("PAYER_ADDRESS1", value); } }
        public string PAYER_ADDRESS2 { set { InsertValue("PAYER_ADDRESS2", value); } }
        public string PAYER_CITY { set { InsertValue("PAYER_CITY", value); } }
        public string PAYER_STATE { set { InsertValue("PAYER_STATE", value); } }
        public string PAYER_ZIP { set { InsertValue("PAYER_ZIP", value); } }
        public string EligibilityDate { set { InsertValue("EligibilityDate", value); } }
        public string AppointmentDate { set { InsertValue("AppointmentDate", value); } }
        public string AppointmentTime { set { InsertValue("AppointmentTime", value); } }
        public string EligibilityType { set { InsertValue("EligibilityType", value); } }
        public string ProviderLastName { set { InsertValue("ProviderLastName", value); } }
        public string ProviderFirstName { set { InsertValue("ProviderFirstName", value); } }
        public string ProviderNPI { set { InsertValue("ProviderNPI", value); } }
        public string ProviderLicenceNo { set { InsertValue("ProviderLicenceNo", value); } }
        public string ProviderLicenseState { set { InsertValue("ProviderLicenseState", value); } }
        public string ProviderAdditionalID { set { InsertValue("ProviderAdditionalID", value); } }
        public string SubscriberTraceNo { set { InsertValue("SubscriberTraceNo", value); } }
        public string SubscriberID { set { InsertValue("SubscriberID", value); } }
        public string SubscriberLastName { set { InsertValue("SubscriberLastName", value); } }
        public string SubscriberFirstName { set { InsertValue("SubscriberFirstName", value); } }
        public string SubscriberGender { set { InsertValue("SubscriberGender", value); } }
        public string SubscriberDOB { set { InsertValue("SubscriberDOB", value); } }
        public string SubscriberGroupNo { set { InsertValue("SubscriberGroupNo", value); } }
        public string SubscriberDependentID { set { InsertValue("SubscriberDependentID", value); } }
        public string PatientRelation { set { InsertValue("PatientRelation", value); } }
        public string DependentTraceNo { set { InsertValue("DependentTraceNo", value); } }
        public string DependentID { set { InsertValue("DependentID", value); } }
        public string DependentLastName { set { InsertValue("DependentLastName", value); } }
        public string DependentFirstName { set { InsertValue("DependentFirstName", value); } }
        public string DependentGender { set { InsertValue("DependentGender", value); } }
        public string DependentDOB { set { InsertValue("DependentDOB", value); } }
        
        #endregion

        public XMLEligibilityData()
        {
        }

        public string RecordAsString
        {
            get { return baseXML; }
        }

        public string FullXMLAsString(string recordData)
        {
            return fullXML.Replace("<<RECORDDATA>>", recordData);
        }

        /// <summary>
        /// Sets the value for a given element. Does not replace existing value, appends to it
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public void InsertValue(string element, string newValue)
        {
            var errorText = string.Empty; // Only way an error can occur here is if the programer messes up, so throw a generic exception if there's a problem
            if (element != "")
            {
                string elementName = "<" + element + ">";
                if (baseXML.IndexOf(elementName) > 0)
                    baseXML = baseXML.Replace(elementName, elementName + newValue);
                else
                    errorText = "Element not found";

            }
            else
                errorText = "Empty string passed.";


            if (errorText != "")
                throw new Exception("An error occurred in XMLHelper.ReplaceValue: " + errorText);
        }

        private string fullXML = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
@"<EDITRANSACTION>
	<XML_STANDARD_VERSION>DCOPLUS270Q1010</XML_STANDARD_VERSION>
	<GroupID>CBO000639</GroupID>
	<LocationID>302</LocationID>
	<TRAN_REF_NUMBER>12345</TRAN_REF_NUMBER>
	<<RECORDDATA>>
</EDITRANSACTION>";

        public string baseXML = "<Record>" +
        @"<TRANS_ID></TRANS_ID>
		<PRIORITY></PRIORITY>
		<PayerName></PayerName>
		<PayerID></PayerID>
		<PAYER_ADDRESS1></PAYER_ADDRESS1>
		<PAYER_ADDRESS2></PAYER_ADDRESS2>
		<PAYER_CITY></PAYER_CITY>
		<PAYER_STATE></PAYER_STATE>
		<PAYER_ZIP></PAYER_ZIP>
		<EligibilityDate></EligibilityDate>
		<AppointmentDate></AppointmentDate>
		<AppointmentTime></AppointmentTime>
		<EligibilityType>D</EligibilityType>
		<ProviderLastName></ProviderLastName>
		<ProviderFirstName></ProviderFirstName>
		<ProviderNPI></ProviderNPI>
		<ProviderLicenceNo></ProviderLicenceNo>
		<ProviderLicenseState></ProviderLicenseState>
		<ProviderAdditionalID></ProviderAdditionalID>
		<SubscriberTraceNo></SubscriberTraceNo>
		<SubscriberID></SubscriberID>
		<SubscriberLastName></SubscriberLastName>
		<SubscriberFirstName></SubscriberFirstName>
		<SubscriberGender></SubscriberGender>
		<SubscriberDOB></SubscriberDOB>
		<SubscriberGroupNo></SubscriberGroupNo>
		<SubscriberDependentID></SubscriberDependentID>
		<PatientRelation></PatientRelation>
		<DependentTraceNo></DependentTraceNo>
		<DependentID></DependentID>
		<DependentLastName></DependentLastName>
		<DependentFirstName></DependentFirstName>
		<DependentGender></DependentGender>
		<DependentDOB></DependentDOB>
	</Record>";
    }
}
