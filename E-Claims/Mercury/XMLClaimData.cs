using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace C_DentalClaimTracker.E_Claims.Mercury
{
    class XMLClaimData
    {

        #region Get/Sets
        
        public string XML_STANDARD_VERSION { set { InsertValue("XML_STANDARD_VERSION", value); } }
        public string USERNAME { set { InsertValue("USERNAME", value); } }
        public string PASSWORD { set { InsertValue("PASSWORD", value); } }
        public string CBOID { set { InsertValue("CBOID", value); } }
        public string PRIORITY { set { InsertValue("PRIORITY", value); } }
        public string TRAN_REF_NUMBER { set { InsertValue("TRAN_REF_NUMBER", value); } }
        public string CLAIM_TYPE { set { InsertValue("CLAIM_TYPE", value); } }
        
        public string SUBMITTER_ID { set { InsertValue("SUBMITTER_ID", value); } }
        public string SUBMITTER_LASTNAME { set { InsertValue("SUBMITTER_LASTNAME", value); } }
        public string SUBMITTER_FIRSTNAME { set { InsertValue("SUBMITTER_FIRSTNAME", value); } }
        public string SUBMITTER_EMAIL { set { InsertValue("SUBMITTER_EMAIL", value); } }
        public string SUBMITTER_TELEPHONE { set { InsertValue("SUBMITTER_TELEPHONE", value); } }
        public string SUBMITTER_FAX { set { InsertValue("SUBMITTER_FAX", value); } }
        
        public string BILLING_LASTNAME { set { InsertValue("BILLING_LASTNAME", value); } }
        public string BILLING_FIRSTNAME { set { InsertValue("BILLING_FIRSTNAME", value); } }
        public string BILLING_ADDRESS1 { set { InsertValue("BILLING_ADDRESS1", value); } }
        public string BILLING_ADDRESS2 { set { InsertValue("BILLING_ADDRESS2", value); } }
        public string BILLING_CITY { set { InsertValue("BILLING_CITY", value); } }
        public string BILLING_STATE { set { InsertValue("BILLING_STATE", value); } }
        public string BILLING_ZIP { set { InsertValue("BILLING_ZIP", value); } }
        public string BILLING_NPIN { set { InsertValue("BILLING_NPIN", value); } }
        public string BILLING_STATE_LICENCE { set { InsertValue("BILLING_STATE_LICENCE", value); } }
        public string BILLING_TIN_SSN { set { InsertValue("BILLING_TIN_SSN", value); } }
        public string BILLING_PHONE { set { InsertValue("BILLING_PHONE", value); } }
        public string BILLING_ADDITIONAL_ID { set { InsertValue("BILLING_ADDITIONAL_ID", value); } }
        
        public string PAYTO_LASTNAME { set { InsertValue("PAYTO_LASTNAME", value); } }
        public string PAYTO_FIRSTNAME { set { InsertValue("PAYTO_FIRSTNAME", value); } }
        public string PAYTO_ADDRESS1 { set { InsertValue("PAYTO_ADDRESS1", value); } }
        public string PAYTO_ADDRESS2 { set { InsertValue("PAYTO_ADDRESS2", value); } }
        public string PAYTO_CITY { set { InsertValue("PAYTO_CITY", value); } }
        public string PAYTO_STATE { set { InsertValue("PAYTO_STATE", value); } }
        public string PAYTO_ZIP { set { InsertValue("PAYTO_ZIP", value); } }
        public string PAYTO_NPIN { set { InsertValue("PAYTO_NPIN", value); } }
        public string PAYTO_STATE_LICENCE { set { InsertValue("PAYTO_STATE_LICENCE", value); } }
        public string PAYTO_TIN { set { InsertValue("PAYTO_TIN", value); } }
        public string PAYTO_SSN { set { InsertValue("PAYTO_SSN", value); } }
        public string PAYTO_PHONE { set { InsertValue("PAYTO_PHONE", value); } }
        public string PAYTO_ADDITIONAL_ID { set { InsertValue("PAYTO_ADDITIONAL_ID", value); } }
        
        public string RENDERING_PROVIDER_LASTNAME { set { InsertValue("RENDERING_PROVIDER_LASTNAME", value); } }
        public string RENDERING_PROVIDER_FIRSTNAME { set { InsertValue("RENDERING_PROVIDER_FIRSTNAME", value); } }
        public string RENDERING_PROVIDER_SIGNATURE_DATE { set { InsertValue("RENDERING_PROVIDER_SIGNATURE_DATE", value); } }
        public string RENDERING_PROVIDER_ADDRESS1 { set { InsertValue("RENDERING_PROVIDER_ADDRESS1", value); } }
        public string RENDERING_PROVIDER_ADDRESS2 { set { InsertValue("RENDERING_PROVIDER_ADDRESS2", value); } }
        public string RENDERING_PROVIDER_CITY { set { InsertValue("RENDERING_PROVIDER_CITY", value); } }
        public string RENDERING_PROVIDER_STATE { set { InsertValue("RENDERING_PROVIDER_STATE", value); } }
        public string RENDERING_PROVIDER_ZIP { set { InsertValue("RENDERING_PROVIDER_ZIP", value); } }
        public string RENDERING_PROVIDER_NPIN { set { InsertValue("RENDERING_PROVIDER_NPIN", value); } }
        public string RENDERING_PROVIDER_LICENSE_NUMBER { set { InsertValue("RENDERING_PROVIDER_LICENSE_NUMBER", value); } }
        public string RENDERING_PROVIDER_SPECIALTY { set { InsertValue("RENDERING_PROVIDER_SPECIALTY", value); } }
        public string RENDERING_PROVIDER_PHONE { set { InsertValue("RENDERING_PROVIDER_PHONE", value); } }
        public string RENDERING_PROVIDER_ADDITIONAL_ID { set { InsertValue("RENDERING_PROVIDER_ADDITIONAL_ID", value); } }
        
        public string SUBSCRIBER_LASTNAME { set { InsertValue("SUBSCRIBER_LASTNAME", value); } }
        public string SUBSCRIBER_FIRSTNAME { set { InsertValue("SUBSCRIBER_FIRSTNAME", value); } }
        public string SUBSCRIBER_MIDDLENAME { set { InsertValue("SUBSCRIBER_MIDDLENAME", value); } }
        public string SUBSCRIBER_SUFFIX { set { InsertValue("SUBSCRIBER_SUFFIX", value); } }
        public string SUBSCRIBER_ADDRESS1 { set { InsertValue("SUBSCRIBER_ADDRESS1", value); } }
        public string SUBSCRIBER_ADDRESS2 { set { InsertValue("SUBSCRIBER_ADDRESS2", value); } }
        public string SUBSCRIBER_CITY { set { InsertValue("SUBSCRIBER_CITY", value); } }
        public string SUBSCRIBER_STATE { set { InsertValue("SUBSCRIBER_STATE", value); } }
        public string SUBSCRIBER_ZIP { set { InsertValue("SUBSCRIBER_ZIP", value); } }
        public string SUBSCRIBER_DOB { set { InsertValue("SUBSCRIBER_DOB", value); } }
        public string SUBSCRIBER_GENDER { set { InsertValue("SUBSCRIBER_GENDER", value); } }
        public string SUBSCRIBER_ID { set { InsertValue("SUBSCRIBER_ID", value); } }
        public string SUBSCRIBER_GROUP_PLAN_NAME { set { InsertValue("SUBSCRIBER_GROUP_PLAN_NAME", value); } }
        public string SUBSCRIBER_GROUP_PLAN_NUMBER { set { InsertValue("SUBSCRIBER_GROUP_PLAN_NUMBER", value); } }
        public string SUBSCRIBER_EMPLOYER_NAME { set { InsertValue("SUBSCRIBER_EMPLOYER_NAME", value); } }
        public string SUBSCRIBER_INSURANCE_SEQUENCE { set { InsertValue("SUBSCRIBER_INSURANCE_SEQUENCE", value); } }
        public string SUBSCRIBER_SIGNATURE { set { InsertValue("SUBSCRIBER_SIGNATURE", value); } }
        public string SUBSCRIBER_SIGNATURE_DATE { set { InsertValue("SUBSCRIBER_SIGNATURE_DATE", value); } }
        
        public string PATIENT_RELATION { set { InsertValue("PATIENT_RELATION", value); } }
        public string PATIENT_STUDENTSTATUS { set { InsertValue("PATIENT_STUDENTSTATUS", value); } }
        public string PATIENT_LASTNAME { set { InsertValue("PATIENT_LASTNAME", value); } }
        public string PATIENT_FIRSTNAME { set { InsertValue("PATIENT_FIRSTNAME", value); } }
        public string PATIENT_MIDDLENAME { set { InsertValue("PATIENT_MIDDLENAME", value); } }
        public string PATIENT_SUFFIX { set { InsertValue("PATIENT_SUFFIX", value); } }
        public string PATIENT_ADDRESS1 { set { InsertValue("PATIENT_ADDRESS1", value); } }
        public string PATIENT_ADDRESS2 { set { InsertValue("PATIENT_ADDRESS2", value); } }
        public string PATIENT_CITY { set { InsertValue("PATIENT_CITY", value); } }
        public string PATIENT_STATE { set { InsertValue("PATIENT_STATE", value); } }
        public string PATIENT_ZIP { set { InsertValue("PATIENT_ZIP", value); } }
        public string PATIENT_DOB { set { InsertValue("PATIENT_DOB", value); } }
        public string PATIENT_GENDER { set { InsertValue("PATIENT_GENDER", value); } }
        public string PATIENT_ID { set { InsertValue("PATIENT_ID", value); } }
        public string PATIENT_SIGNATURE { set { InsertValue("PATIENT_SIGNATURE", value); } }
        public string PATIENT_SIGNATURE_DATE { set { InsertValue("PATIENT_SIGNATURE_DATE", value); } }
        
        public string PRIMARY_PAYER_NAME { set { InsertValue("PRIMARY_PAYER_NAME", value); } }
        public string PRIMARY_PAYER_ID { set { InsertValue("PRIMARY_PAYER_ID", value); } }
        public string PRIMARY_PAYER_ADDRESS1 { set { InsertValue("PRIMARY_PAYER_ADDRESS1", value); } }
        public string PRIMARY_PAYER_ADDRESS2 { set { InsertValue("PRIMARY_PAYER_ADDRESS2", value); } }
        public string PRIMARY_PAYER_CITY { set { InsertValue("PRIMARY_PAYER_CITY", value); } }
        public string PRIMARY_PAYER_STATE { set { InsertValue("PRIMARY_PAYER_STATE", value); } }
        public string PRIMARY_PAYER_ZIP { set { InsertValue("PRIMARY_PAYER_ZIP", value); } }
        
        public string OTHERPAYER_FLAG { set { InsertValue("OTHERPAYER_FLAG", value); } }
        public string OTHER_SUBSCRIBER_LASTNAME { set { InsertValue("OTHER_SUBSCRIBER_LASTNAME", value); } }
        public string OTHER_SUBSCRIBER_FIRSTNAME { set { InsertValue("OTHER_SUBSCRIBER_FIRSTNAME", value); } }
        public string OTHER_SUBSCRIBER_MIDDLENAME { set { InsertValue("OTHER_SUBSCRIBER_MIDDLENAME", value); } }
        public string OTHER_SUBSCRIBER_SUFFIX { set { InsertValue("OTHER_SUBSCRIBER_SUFFIX", value); } }
        public string OTHER_SUBSCRIBER_DOB { set { InsertValue("OTHER_SUBSCRIBER_DOB", value); } }
        public string OTHER_SUBSCRIBER_GENDER { set { InsertValue("OTHER_SUBSCRIBER_GENDER", value); } }
        public string OTHER_SUBSCRIBER_ID { set { InsertValue("OTHER_SUBSCRIBER_ID", value); } }
        public string OTHER_SUBSCRIBER_GROUP_PLAN_NAME { set { InsertValue("OTHER_SUBSCRIBER_GROUP_PLAN_NAME", value); } }
        public string OTHER_SUBSCRIBER_GROUP_PLAN_NUMBER { set { InsertValue("OTHER_SUBSCRIBER_GROUP_PLAN_NUMBER", value); } }
        public string OTHER_SUBSCRIBER_RELATION { set { InsertValue("OTHER_SUBSCRIBER_RELATION", value); } }
        public string OTHER_SUBSCRIBER_ADDRESS1 { set { InsertValue("OTHER_SUBSCRIBER_ADDRESS1", value); } }
        public string OTHER_SUBSCRIBER_ADDRESS2 { set { InsertValue("OTHER_SUBSCRIBER_ADDRESS2", value); } }
        public string OTHER_SUBSCRIBER_CITY { set { InsertValue("OTHER_SUBSCRIBER_CITY", value); } }
        public string OTHER_SUBSCRIBER_STATE { set { InsertValue("OTHER_SUBSCRIBER_STATE", value); } }
        public string OTHER_SUBSCRIBER_ZIP { set { InsertValue("OTHER_SUBSCRIBER_ZIP", value); } }
        public string OTHER_SUBSCRIBER_INSURANCE_SEQUENCE { set { InsertValue("OTHER_SUBSCRIBER_INSURANCE_SEQUENCE", value); } }
        public string OTHER_SUBSCRIBER_COB_PAYER_PAID_AMT { set { InsertValue("OTHER_SUBSCRIBER_COB_PAYER_PAID_AMT", value); } }
        public string OTHER_SUBSCRIBER_COB_PATIENT_RESP_AMT { set { InsertValue("OTHER_SUBSCRIBER_COB_PATIENT_RESP_AMT", value); } }
        public string OTHERPAYER_NAME { set { InsertValue("OTHERPAYER_NAME", value); } }
        public string OTHERPAYER_ID { set { InsertValue("OTHERPAYER_ID", value); } }
        public string OTHERPAYER_ADDRESS1 { set { InsertValue("OTHERPAYER_ADDRESS1", value); } }
        public string OTHERPAYER_ADDRESS2 { set { InsertValue("OTHERPAYER_ADDRESS2", value); } }
        public string OTHERPAYER_CITY { set { InsertValue("OTHERPAYER_CITY", value); } }
        public string OTHERPAYER_STATE { set { InsertValue("OTHERPAYER_STATE", value); } }
        public string OTHERPAYER_ZIP { set { InsertValue("OTHERPAYER_ZIP", value); } }
        public string OTHERPAYER_CONTACT_NAME { set { InsertValue("OTHERPAYER_CONTACT_NAME", value); } }
        public string OTHERPAYER_CONTACT_EMAIL { set { InsertValue("OTHERPAYER_CONTACT_EMAIL", value); } }
        public string OTHERPAYER_CONTACT_TELEPHONE { set { InsertValue("OTHERPAYER_CONTACT_TELEPHONE", value); } }
        public string OTHERPAYER_CONTACT_FAX { set { InsertValue("OTHERPAYER_CONTACT_FAX", value); } }
        public string OTHERPAYER_CLAIM_PAID_DATE { set { InsertValue("OTHERPAYER_CLAIM_PAID_DATE", value); } }
        
        public string CLAIM_NUMBER { set { InsertValue("CLAIM_NUMBER", value); } }
        public string SERVICE_DATE { set { InsertValue("SERVICE_DATE", value); } }
        public string PREDIDENTIFICATION { set { InsertValue("PRED-IDENTIFICATION", value); } }
        public string OTHERFEE { set { InsertValue("OTHERFEE", value); } }
        public string TOTAL_AMOUNT { set { InsertValue("TOTAL_AMOUNT", value); } }
        
        public string MISSING_TOOTH { set { InsertValue("MISSING_TOOTH", value); } } // Allow multiple
        public string DIAG_QUALIFIER { set { InsertValue("DIAG_QUALIFIER", value); } }
        
        public string DIAGNOSIS_CODES_A { set { InsertValue("DIAGNOSIS_CODES_A", value); } }
        public string DIAGNOSIS_CODES_B { set { InsertValue("DIAGNOSIS_CODES_B", value); } }
        public string DIAGNOSIS_CODES_C { set { InsertValue("DIAGNOSIS_CODES_C", value); } }
        public string DIAGNOSIS_CODES_D { set { InsertValue("DIAGNOSIS_CODES_D", value); } }
        public string CLAIM_NOTES { set { InsertValue("CLAIM_NOTES", value); } }
        public string PLACE_SERVICE { set { InsertValue("PLACE_SERVICE", value); } }
        public string ENCLOSURES { set { InsertValue("ENCLOSURES", value); } }
        public string ENCLOSURES_RADIOGRAPH { set { InsertValue("ENCLOSURES_RADIOGRAPH", value); } }
        public string ENCLOSURES_ORAL_IMAGES { set { InsertValue("ENCLOSURES_ORAL_IMAGES", value); } }
        public string ENCLOSURES_MODELS { set { InsertValue("ENCLOSURES_MODELS", value); } }
        public string ORTHOCLAIM { set { InsertValue("ORTHOCLAIM", value); } }
        public string APPLIANCE_PLACEMENT_DATE { set { InsertValue("APPLIANCE_PLACEMENT_DATE", value); } }
        public string PLACEMENT_TYPE { set { InsertValue("PLACEMENT_TYPE", value); } }
        public string MONTHS_TREATMENT_REMAININT { set { InsertValue("MONTHS_TREATMENT_REMAININT", value); } }
        public string REPLACEMENT_PROSTHESIS { set { InsertValue("REPLACEMENT_PROSTHESIS", value); } }
        public string PROIR_PLACEMENT_DATE { set { InsertValue("PROIR_PLACEMENT_DATE", value); } }
        public string OCCUPATIONAL_ILLNESS { set { InsertValue("OCCUPATIONAL_ILLNESS", value); } }
        public string AUTO_ACCIDENT { set { InsertValue("AUTO_ACCIDENT", value); } }
        public string OTHER_ACCIDENT { set { InsertValue("OTHER_ACCIDENT", value); } }
        public string ACCIDENT_DATE { set { InsertValue("ACCIDENT_DATE", value); } }
        public string ACCIDENT_STATE { set { InsertValue("ACCIDENT_STATE", value); } }
        public string ADMISSION_DATE { set { InsertValue("ADMISSION_DATE", value); } }
        public string TOT_TREATMENT_PERIOD { set { InsertValue("TOT_TREATMENT_PERIOD", value); } }
        

        public string ATTACHMENT_ID { set { InsertValue("ATTACHMENT_ID", value); } }// Allow multiple, maybe not used
        
        // This needs to be added individually in the <LINE_SERVICE> element
        public string LINE { set { InsertValue("LINE", value); } }
        // public string SERVICE_DATE { set { InsertValue("SERVICE_DATE", value); } }
        public string CAVITY_DESIGNATION { set { InsertValue("CAVITY_DESIGNATION", value); } }
        public string TOOTH_SYSTEM { set { InsertValue("TOOTH_SYSTEM", value); } }
        public string TOOTHS { set { InsertValue("TOOTHS", value); } }
        public string TOOTHNUMBER { set { InsertValue("TOOTHNUMBER", value); } }
        public string SURFACES { set { InsertValue("SURFACES", value); } }
        public string TOOTHSURFACE { set { InsertValue("TOOTHSURFACE", value); } }
        public string PROCEDURE_CODE { set { InsertValue("PROCEDURE_CODE", value); } }
        public string DIAGNOSIS_POINTER { set { InsertValue("DIAGNOSIS_POINTER", value); } }
        public string QUANTITY { set { InsertValue("QUANTITY", value); } }
        public string PROCEDURE_DESCRIPTION { set { InsertValue("PROCEDURE_DESCRIPTION", value); } }
        public string FEE { set { InsertValue("FEE", value); } }
        public string LINE_NOTES { set { InsertValue("LINE_NOTES", value); } }


        

        #endregion

        public XMLClaimData()
        {
        }

        public string MainDocAsString
        {
            get { return baseXML; }
        }

        /// <summary>
        /// Inserts a string as a new LineServiceValue
        /// </summary>
        /// <param name="newValue"></param>
        public void InsertLineService(LineHelper newValue)
        {
            baseXML = baseXML.Replace(LINEIDENTIFIER, LINEIDENTIFIER + newValue.ToXML());
        }

        public void InsertToothInfo(string toothValue)
        {
            baseXML = baseXML.Replace(TOOTHIDENTIFIER, TOOTHIDENTIFIER + "\n<MISSINGTOOTH>" + toothValue + "</MISSINGTOOTH>");
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

        public void Save(string filePath)
        {
            try
            {
                System.IO.File.WriteAllText(filePath, MainDocAsString);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        #region baseXML
        string baseXML =
    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
@"<EDITRANSACTION>
	<XML_STANDARD_VERSION>DCOPLUS1000</XML_STANDARD_VERSION>
	<USERNAME>NEWHAVENDE</USERNAME>
	<PASSWORD></PASSWORD>
	<CBOID>CBO000639</CBOID>
	<PRIORITY>1</PRIORITY> <!--Currenlty allowed values 1 or 2-->
	<TRAN_REF_NUMBER>000012345</TRAN_REF_NUMBER>
	<CLAIM_TYPE></CLAIM_TYPE><!--BOX 1-->
	<SUBMITTER> <!-- from user config -->
		<SUBMITTER_ID>302</SUBMITTER_ID><!--BOX 58-->
		<SUBMITTER_LASTNAME>New Haven Dental Group</SUBMITTER_LASTNAME>
		<SUBMITTER_FIRSTNAME></SUBMITTER_FIRSTNAME>
		<SUBMITTER_EMAIL></SUBMITTER_EMAIL>
		<SUBMITTER_TELEPHONE></SUBMITTER_TELEPHONE>
		<SUBMITTER_FAX></SUBMITTER_FAX>
	</SUBMITTER>		
	<BILLING_PROVIDER>
		<BILLING_LASTNAME></BILLING_LASTNAME><!--BOX 48-->
		<BILLING_FIRSTNAME></BILLING_FIRSTNAME><!--BOX 48-->
		<BILLING_ADDRESS1></BILLING_ADDRESS1>		<!--BOX 48-->
		<BILLING_ADDRESS2></BILLING_ADDRESS2>		<!--BOX 48-->
		<BILLING_CITY></BILLING_CITY>		<!--BOX 48-->
		<BILLING_STATE></BILLING_STATE>		<!--BOX 48-->
		<BILLING_ZIP></BILLING_ZIP>		<!--BOX 48-->
		<BILLING_NPIN></BILLING_NPIN><!--BOX 49-->
		<BILLING_STATE_LICENCE></BILLING_STATE_LICENCE>	<!--BOX 50-->
		<BILLING_TIN_SSN></BILLING_TIN_SSN><!--BOX 51-->
		<BILLING_PHONE></BILLING_PHONE>		<!--BOX 52-->
		<BILLING_ADDITIONAL_ID></BILLING_ADDITIONAL_ID> <!--BOX 52A-->
	</BILLING_PROVIDER>		
	<PAYTO_PROVIDER>
		<PAYTO_LASTNAME></PAYTO_LASTNAME>
		<PAYTO_FIRSTNAME></PAYTO_FIRSTNAME>
		<PAYTO_ADDRESS1></PAYTO_ADDRESS1>
		<PAYTO_ADDRESS2></PAYTO_ADDRESS2>
		<PAYTO_CITY></PAYTO_CITY>
		<PAYTO_STATE></PAYTO_STATE>
		<PAYTO_ZIP></PAYTO_ZIP>
		<PAYTO_NPIN></PAYTO_NPIN>
		<PAYTO_STATE_LICENCE></PAYTO_STATE_LICENCE>
		<PAYTO_TIN></PAYTO_TIN>
		<PAYTO_SSN></PAYTO_SSN>
		<PAYTO_PHONE></PAYTO_PHONE>
		<PAYTO_ADDITIONAL_ID></PAYTO_ADDITIONAL_ID>
	</PAYTO_PROVIDER>
	<RENDERING_PROVIDER>
		<RENDERING_PROVIDER_LASTNAME></RENDERING_PROVIDER_LASTNAME>		<!--BOX 53-->
		<RENDERING_PROVIDER_FIRSTNAME></RENDERING_PROVIDER_FIRSTNAME>		<!--BOX 53-->
		<RENDERING_PROVIDER_SIGNATURE_DATE></RENDERING_PROVIDER_SIGNATURE_DATE>		<!--BOX 53-->
		<RENDERING_PROVIDER_ADDRESS1></RENDERING_PROVIDER_ADDRESS1>	<!--BOX 56-->
		<RENDERING_PROVIDER_ADDRESS2></RENDERING_PROVIDER_ADDRESS2>	<!--BOX 56-->
		<RENDERING_PROVIDER_CITY></RENDERING_PROVIDER_CITY>	<!--BOX 56-->
		<RENDERING_PROVIDER_STATE></RENDERING_PROVIDER_STATE> <!--BOX 56-->
		<RENDERING_PROVIDER_ZIP></RENDERING_PROVIDER_ZIP>	<!--BOX 56-->
		<RENDERING_PROVIDER_NPIN></RENDERING_PROVIDER_NPIN>		<!--BOX 54-->
		<RENDERING_PROVIDER_LICENSE_NUMBER></RENDERING_PROVIDER_LICENSE_NUMBER>		<!--BOX 55-->
		<RENDERING_PROVIDER_SPECIALTY></RENDERING_PROVIDER_SPECIALTY>		<!--BOX 56A-->
		<RENDERING_PROVIDER_PHONE></RENDERING_PROVIDER_PHONE>		<!--BOX 57-->
		<RENDERING_PROVIDER_ADDITIONAL_ID></RENDERING_PROVIDER_ADDITIONAL_ID>		<!--BOX 58-->
	</RENDERING_PROVIDER>
	<SUBSCRIBER>
		<SUBSCRIBER_LASTNAME></SUBSCRIBER_LASTNAME><!--BOX 12-->
		<SUBSCRIBER_FIRSTNAME></SUBSCRIBER_FIRSTNAME><!--BOX 12-->
		<SUBSCRIBER_MIDDLENAME></SUBSCRIBER_MIDDLENAME><!--BOX 12-->
		<SUBSCRIBER_SUFFIX></SUBSCRIBER_SUFFIX><!--BOX 12-->
		<SUBSCRIBER_ADDRESS1></SUBSCRIBER_ADDRESS1> <!--BOX 12-->
		<SUBSCRIBER_ADDRESS2></SUBSCRIBER_ADDRESS2>		<!--BOX 12-->
		<SUBSCRIBER_CITY></SUBSCRIBER_CITY>		<!--BOX 12-->
		<SUBSCRIBER_STATE></SUBSCRIBER_STATE>		<!--BOX 12-->
		<SUBSCRIBER_ZIP></SUBSCRIBER_ZIP>		<!--BOX 12-->
		<SUBSCRIBER_DOB></SUBSCRIBER_DOB><!--BOX 13-->
		<SUBSCRIBER_GENDER></SUBSCRIBER_GENDER><!--BOX 14-->
		<SUBSCRIBER_ID></SUBSCRIBER_ID><!--BOX 15-->
		<SUBSCRIBER_GROUP_PLAN_NAME></SUBSCRIBER_GROUP_PLAN_NAME>
		<SUBSCRIBER_GROUP_PLAN_NUMBER></SUBSCRIBER_GROUP_PLAN_NUMBER><!--BOX 16-->
		<SUBSCRIBER_EMPLOYER_NAME></SUBSCRIBER_EMPLOYER_NAME> <!--Box17-->
		<SUBSCRIBER_INSURANCE_SEQUENCE></SUBSCRIBER_INSURANCE_SEQUENCE>
		<SUBSCRIBER_SIGNATURE></SUBSCRIBER_SIGNATURE><!--BOX 37-->
		<SUBSCRIBER_SIGNATURE_DATE></SUBSCRIBER_SIGNATURE_DATE><!--BOX 37-->
	</SUBSCRIBER>
	<PATIENT>
		<PATIENT_RELATION></PATIENT_RELATION>		<!--BOX 18-->
		<PATIENT_STUDENTSTATUS></PATIENT_STUDENTSTATUS>		<!-- Box19 -->
		<PATIENT_LASTNAME></PATIENT_LASTNAME><!--BOX 20-->
		<PATIENT_FIRSTNAME></PATIENT_FIRSTNAME><!--BOX 20-->
		<PATIENT_MIDDLENAME></PATIENT_MIDDLENAME><!--BOX 20-->
		<PATIENT_SUFFIX></PATIENT_SUFFIX><!--BOX 20-->
		<PATIENT_ADDRESS1></PATIENT_ADDRESS1><!--BOX 20-->
		<PATIENT_ADDRESS2></PATIENT_ADDRESS2><!--BOX 20-->
		<PATIENT_CITY></PATIENT_CITY><!--BOX 20-->
		<PATIENT_STATE></PATIENT_STATE><!--BOX 20-->
		<PATIENT_ZIP></PATIENT_ZIP><!--BOX 20-->
		<PATIENT_DOB></PATIENT_DOB>		<!--BOX 21-->
		<PATIENT_GENDER></PATIENT_GENDER><!--BOX 22-->
		<PATIENT_ID></PATIENT_ID>		<!--BOX 23-->
		<PATIENT_SIGNATURE></PATIENT_SIGNATURE>	<!--BOX 36-->
		<PATIENT_SIGNATURE_DATE></PATIENT_SIGNATURE_DATE><!--BOX 36-->
	</PATIENT>
	<PRIMARY_PAYER>
		<PRIMARY_PAYER_NAME></PRIMARY_PAYER_NAME> 		<!--BOX 3-->
		<PRIMARY_PAYER_ID></PRIMARY_PAYER_ID> 
		<PRIMARY_PAYER_ADDRESS1></PRIMARY_PAYER_ADDRESS1>		<!--BOX 3-->
		<PRIMARY_PAYER_ADDRESS2></PRIMARY_PAYER_ADDRESS2>		<!--BOX 3-->
		<PRIMARY_PAYER_CITY></PRIMARY_PAYER_CITY>		<!--BOX 3-->
		<PRIMARY_PAYER_STATE></PRIMARY_PAYER_STATE>		<!--BOX 3-->
		<PRIMARY_PAYER_ZIP></PRIMARY_PAYER_ZIP>		<!--BOX 3-->
	</PRIMARY_PAYER>
	<OTHER_COVERAGE>
		<OTHERPAYER_FLAG></OTHERPAYER_FLAG>		<!--BOX 4-->
		<OTHER_SUBSCRIBER_LASTNAME></OTHER_SUBSCRIBER_LASTNAME>			<!--BOX 5-->
		<OTHER_SUBSCRIBER_FIRSTNAME></OTHER_SUBSCRIBER_FIRSTNAME>			<!--BOX 5-->
		<OTHER_SUBSCRIBER_MIDDLENAME></OTHER_SUBSCRIBER_MIDDLENAME>			<!--BOX 5-->
		<OTHER_SUBSCRIBER_SUFFIX></OTHER_SUBSCRIBER_SUFFIX>			<!--BOX 5-->
		<OTHER_SUBSCRIBER_DOB></OTHER_SUBSCRIBER_DOB>			<!--BOX 6-->
		<OTHER_SUBSCRIBER_GENDER></OTHER_SUBSCRIBER_GENDER>			<!--BOX 7-->
		<OTHER_SUBSCRIBER_ID></OTHER_SUBSCRIBER_ID>			<!--BOX 8-->
		<OTHER_SUBSCRIBER_GROUP_PLAN_NAME></OTHER_SUBSCRIBER_GROUP_PLAN_NAME>
		<OTHER_SUBSCRIBER_GROUP_PLAN_NUMBER></OTHER_SUBSCRIBER_GROUP_PLAN_NUMBER>			<!--BOX 9-->
		<OTHER_SUBSCRIBER_RELATION></OTHER_SUBSCRIBER_RELATION>			<!--BOX 10-->
		<OTHER_SUBSCRIBER_ADDRESS1></OTHER_SUBSCRIBER_ADDRESS1>
		<OTHER_SUBSCRIBER_ADDRESS2></OTHER_SUBSCRIBER_ADDRESS2>
		<OTHER_SUBSCRIBER_CITY></OTHER_SUBSCRIBER_CITY>
		<OTHER_SUBSCRIBER_STATE></OTHER_SUBSCRIBER_STATE>
		<OTHER_SUBSCRIBER_ZIP></OTHER_SUBSCRIBER_ZIP>
		<OTHER_SUBSCRIBER_INSURANCE_SEQUENCE></OTHER_SUBSCRIBER_INSURANCE_SEQUENCE>
		<OTHER_SUBSCRIBER_COB_PAYER_PAID_AMT></OTHER_SUBSCRIBER_COB_PAYER_PAID_AMT>
		<OTHER_SUBSCRIBER_COB_PATIENT_RESP_AMT></OTHER_SUBSCRIBER_COB_PATIENT_RESP_AMT>
		<OTHERPAYER_NAME></OTHERPAYER_NAME>		<!--BOX 11-->
		<OTHERPAYER_ID></OTHERPAYER_ID>
		<OTHERPAYER_ADDRESS1></OTHERPAYER_ADDRESS1>		<!--BOX 11-->
		<OTHERPAYER_ADDRESS2></OTHERPAYER_ADDRESS2>		<!--BOX 11-->
		<OTHERPAYER_CITY></OTHERPAYER_CITY>		<!--BOX 11-->
		<OTHERPAYER_STATE></OTHERPAYER_STATE>		<!--BOX 11-->
		<OTHERPAYER_ZIP></OTHERPAYER_ZIP>		<!--BOX 11-->
		<OTHERPAYER_CONTACT_NAME></OTHERPAYER_CONTACT_NAME>
		<OTHERPAYER_CONTACT_EMAIL></OTHERPAYER_CONTACT_EMAIL>
		<OTHERPAYER_CONTACT_TELEPHONE></OTHERPAYER_CONTACT_TELEPHONE>
		<OTHERPAYER_CONTACT_FAX></OTHERPAYER_CONTACT_FAX>
		<OTHERPAYER_CLAIM_PAID_DATE></OTHERPAYER_CLAIM_PAID_DATE>
	</OTHER_COVERAGE>
	<CLAIM>
  	<CLAIM_NUMBER></CLAIM_NUMBER>
		<SERVICE_DATE></SERVICE_DATE>
		<PRED-IDENTIFICATION></PRED-IDENTIFICATION><!--BOX 2-->
		<OTHERFEE></OTHERFEE>	<!--BOX 31a-->
		<TOTAL_AMOUNT></TOTAL_AMOUNT><!--BOX 32-->
		<MISSING_TOOTHS>
        </MISSING_TOOTHS>
		<DIAG_QUALIFIER></DIAG_QUALIFIER> <!--BOX 34--> <!-- ICD-9 = B; ICD-10 = AB -->
		<DIAGNOSIS_CODES>  <!--BOX 34a--> 
			<DIAGNOSIS_CODES_A> </DIAGNOSIS_CODES_A> <!--Primay Diagnosis code-->
			<DIAGNOSIS_CODES_D> </DIAGNOSIS_CODES_D>
			<DIAGNOSIS_CODES_D> </DIAGNOSIS_CODES_D>
			<DIAGNOSIS_CODES_D> </DIAGNOSIS_CODES_D>
		</DIAGNOSIS_CODES>
		<CLAIM_NOTES></CLAIM_NOTES><!--BOX 35-->
		<PLACE_SERVICE></PLACE_SERVICE> <!--BOX 38 -->  <!-- 11 - Office, 22 - Hospital, ECF - ECF, OTH - Other -->
		<ENCLOSURES></ENCLOSURES> <!--BOX 39 (ADA@2012)--> <!-- If used this box need to below three boxes for ADA 2012 version -->
		<ENCLOSURES_RADIOGRAPH></ENCLOSURES_RADIOGRAPH> <!--BOX 39 (ADA@2006)-->
		<ENCLOSURES_ORAL_IMAGES></ENCLOSURES_ORAL_IMAGES>	<!--BOX 39 (ADA@2006)-->
		<ENCLOSURES_MODELS></ENCLOSURES_MODELS>	<!--BOX 39 (ADA@2006)-->
		<ORTHOCLAIM></ORTHOCLAIM> <!--BOX 40-->
		<APPLIANCE_PLACEMENT_DATE></APPLIANCE_PLACEMENT_DATE>	  <!--BOX 41-->
		<PLACEMENT_TYPE></PLACEMENT_TYPE>
		<MONTHS_TREATMENT_REMAININT></MONTHS_TREATMENT_REMAININT>		  <!--BOX 42-->
		<REPLACEMENT_PROSTHESIS></REPLACEMENT_PROSTHESIS>		  <!--BOX 43-->
		<PROIR_PLACEMENT_DATE></PROIR_PLACEMENT_DATE>		  <!--BOX 44-->
		<OCCUPATIONAL_ILLNESS></OCCUPATIONAL_ILLNESS>		  <!--BOX 45-->
		<AUTO_ACCIDENT></AUTO_ACCIDENT>		  <!--BOX 45-->
		<OTHER_ACCIDENT></OTHER_ACCIDENT>		  <!--BOX 45-->
		<ACCIDENT_DATE></ACCIDENT_DATE>		  <!--BOX 46-->
		<ACCIDENT_STATE></ACCIDENT_STATE>		  <!--BOX 47-->
		<ADMISSION_DATE></ADMISSION_DATE>
		<TOT_TREATMENT_PERIOD></TOT_TREATMENT_PERIOD>
		<ATTACHMENTS> <!-- This <ATTACHMENT_ID> can be repeated as required -->
			<ATTACHMENT_ID></ATTACHMENT_ID>
			<!-- Repeat <ATTACHMENT_ID> as required -->
		</ATTACHMENTS>		  
		<LINE_SERVICE>
        </LINE_SERVICE>
	</CLAIM>
</EDITRANSACTION>";

        const string LINEIDENTIFIER = "<LINE_SERVICE>";

        const string TOOTHIDENTIFIER = "<MISSING_TOOTHS>";
        #endregion
    }

    class LineHelper
    {
        public string SERVICE_DATE { set { InsertValue("SERVICE_DATE", value); } }
        public string CAVITY_DESIGNATION { set { InsertValue("CAVITY_DESIGNATION", value); } }
        public string TOOTH_SYSTEM { set { InsertValue("TOOTH_SYSTEM", value); } }
        public string PROCEDURE_CODE { set { InsertValue("PROCEDURE_CODE", value); } }
        public string DIAGNOSIS_POINTER { set { InsertValue("DIAGNOSIS_POINTER", value); } }
        public string QUANTITY { set { InsertValue("QUANTITY", value); } }
        public string PROCEDURE_DESCRIPTION{ set { InsertValue("PROCEDURE_DESCRIPTION", value); } }
        public string FEE { set { InsertValue("FEE", value); } }
        public string LINE_NOTES { set { InsertValue("LINE_NOTES", value); } }

        public LineHelper() { }
        
        public string ToXML()
        {
            return lineXML;
        }

        public void InsertTooth(string val)
        {
            lineXML = lineXML.Replace(TOOTHMARKER, "<TOOTHNUMBER>" + val + "</TOOTHNUMBER>\n" + TOOTHMARKER);
        }

        public void InsertSurface(string val)
        {
            lineXML = lineXML.Replace(SURFACEMARKER, "<TOOTHSURFACE>" + val + "</TOOTHSURFACE>\n" + SURFACEMARKER);
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
                if (lineXML.IndexOf(elementName) > 0)
                    lineXML = lineXML.Replace(elementName, elementName + newValue);
                else
                    errorText = "Element not found";

            }
            else
                errorText = "Empty string passed.";


            if (errorText != "")
                throw new Exception("An error occurred in XMLHelper.ReplaceValue: " + errorText);
        }

        string lineXML = @"<LINE><SERVICE_DATE></SERVICE_DATE><!--BOX 24-->
			<CAVITY_DESIGNATION></CAVITY_DESIGNATION><!-- Box 25 -->
			<TOOTH_SYSTEM></TOOTH_SYSTEM><!-- Box 26 -->
			<TOOTHS><!-- Box 27 --> 
			" + TOOTHMARKER + @"
			</TOOTHS>
			<SURFACES><!-- Box 28 -->
			  " + SURFACEMARKER + @"
			</SURFACES>
			<PROCEDURE_CODE></PROCEDURE_CODE><!--BOX 29-->
			<DIAGNOSIS_POINTER></DIAGNOSIS_POINTER> <!--BOX 29a-->
			<QUANTITY></QUANTITY> <!--BOX 29b-->
			<PROCEDURE_DESCRIPTION></PROCEDURE_DESCRIPTION><!--BOX 30-->
			<FEE></FEE><!--BOX 31-->
			<LINE_NOTES></LINE_NOTES></LINE>";

        const string TOOTHMARKER = "<!-- TOOTHMARKER -->";
        const string SURFACEMARKER = "<!--  SURFACEMARKER  -->";
    }
}
