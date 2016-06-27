using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace C_DentalClaimTracker.E_Claims.Mercury
{
    class MercuryHelper
    {
        enum MercuryClaimTypes
        {
            C, // Statement of actual service
            P, // Predeterm
            E // EPSDT/Title XIX
        }

        public static List<string> ConvertBatchToXML(NHDG.NHDGCommon.Claims.ClaimBatch toConvert, string targetFolder)
        {
            List<string> fileData = new List<string>();
            XMLClaimData xh;
            foreach (NHDG.NHDGCommon.Claims.Claim aClaim in toConvert.Claims)
            {
                xh = new XMLClaimData();
                claim localClaim = new claim();
                localClaim.LoadWithDentrixIDs(aClaim.Identity.ClaimID.ToString(), aClaim.Identity.ClaimDB.ToString());

                string claimtype;

                if (localClaim.claim_type == claim.ClaimTypes.Predeterm || localClaim.claim_type == claim.ClaimTypes.SecondaryPredeterm)
                    claimtype = "P";
                else
                    claimtype = "C";

                xh.CLAIM_TYPE = claimtype;
                
                // BILLING_PROVIDER
                xh.BILLING_LASTNAME = "NEW HAVEN DENTAL GROUP";
                xh.BILLING_FIRSTNAME = "";
                xh.BILLING_ADDRESS1 = "123 York St";
                xh.BILLING_ADDRESS2 = "4L";
                xh.BILLING_CITY = "New Haven";
                xh.BILLING_STATE = "CT";
                xh.BILLING_ZIP = "06511";
                xh.BILLING_NPIN = "1609916089";
                xh.BILLING_STATE_LICENCE = "03419";
                xh.BILLING_TIN_SSN = "061025204";
                xh.BILLING_PHONE = "203-781-8051";
                xh.BILLING_ADDITIONAL_ID = "";
                // PAYTO_PROVIDER
                xh.PAYTO_LASTNAME = CleanData(localClaim.doctor_last_name);
                xh.PAYTO_FIRSTNAME = CleanData(localClaim.doctor_first_name);
                xh.PAYTO_ADDRESS1 = CleanData(localClaim.doctor_address);
                xh.PAYTO_ADDRESS2 = CleanData(localClaim.doctor_address2);
                xh.PAYTO_CITY = CleanData(localClaim.doctor_city);
                xh.PAYTO_STATE = CleanData(localClaim.doctor_state);
                xh.PAYTO_ZIP = CleanData(localClaim.doctor_zip);
                xh.PAYTO_NPIN = CleanData(aClaim.BillingDentist.NPINumber);
                xh.PAYTO_STATE_LICENCE = "";                                                            // ***
                xh.PAYTO_TIN = CleanData(aClaim.BillingDentist.TIN);
                xh.PAYTO_SSN = "";                                                                      // *** Do we need this?
                xh.PAYTO_PHONE = CleanData(localClaim.doctor_phone_number_object.FormattedPhone);
                xh.PAYTO_ADDITIONAL_ID = "";                                                            // *** additional ID
                // RENDERING_PROVIDER
                xh.RENDERING_PROVIDER_LASTNAME = CleanData(localClaim.doctor_last_name);
                xh.RENDERING_PROVIDER_FIRSTNAME = CleanData(localClaim.doctor_first_name);
                xh.RENDERING_PROVIDER_SIGNATURE_DATE = "";                                              // *** Signature date
                xh.RENDERING_PROVIDER_ADDRESS1 = CleanData(localClaim.doctor_address);
                xh.RENDERING_PROVIDER_ADDRESS2 = CleanData(localClaim.doctor_address2);
                xh.RENDERING_PROVIDER_CITY = CleanData(localClaim.doctor_city);
                xh.RENDERING_PROVIDER_STATE = CleanData(localClaim.doctor_state);
                xh.RENDERING_PROVIDER_ZIP = CleanData(localClaim.doctor_zip);
                xh.RENDERING_PROVIDER_NPIN = CleanData(aClaim.BillingDentist.NPINumber);
                xh.RENDERING_PROVIDER_LICENSE_NUMBER = CleanData(aClaim.BillingDentist.License);
                if (localClaim.doctor_first_name.Contains("Eva"))                                                                               // *** Hard-coded for the periodontist right now
                    xh.RENDERING_PROVIDER_SPECIALTY = "1223P0300X"; // Periodontics                                                   
                else
                    xh.RENDERING_PROVIDER_SPECIALTY = "122300000X";
                xh.RENDERING_PROVIDER_PHONE = CleanData(localClaim.doctor_phone_number_object.FormattedPhone);
                xh.RENDERING_PROVIDER_ADDITIONAL_ID = "";                                               // *** additional ID
                // SUBSCRIBER
                xh.SUBSCRIBER_LASTNAME = CleanData(localClaim.subscriber_last_name);
                xh.SUBSCRIBER_FIRSTNAME = CleanData(localClaim.subscriber_first_name);
                xh.SUBSCRIBER_MIDDLENAME = CleanData(localClaim.subscriber_middle_initial);
                xh.SUBSCRIBER_SUFFIX = "";
                xh.SUBSCRIBER_ADDRESS1 = CleanData(localClaim.subscriber_address);
                xh.SUBSCRIBER_ADDRESS2 = CleanData(localClaim.subscriber_address2);
                xh.SUBSCRIBER_CITY = CleanData(localClaim.subscriber_city);
                xh.SUBSCRIBER_STATE = CleanData(localClaim.subscriber_state);
                xh.SUBSCRIBER_ZIP = CleanData(localClaim.subscriber_zip);
                xh.SUBSCRIBER_DOB = ConvertDateTime(localClaim.subscriber_dob);
                xh.SUBSCRIBER_GENDER = ConvertGender(aClaim.Subscriber.Sex);
                xh.SUBSCRIBER_ID = CleanData(aClaim.Subscriber.ID);
                xh.SUBSCRIBER_GROUP_PLAN_NAME = CleanData(localClaim.subscriber_group_name);
                xh.SUBSCRIBER_GROUP_PLAN_NUMBER = CleanData(localClaim.subscriber_group_number);
                xh.SUBSCRIBER_EMPLOYER_NAME = CleanData(aClaim.Subscriber.Employer.Name);
                xh.SUBSCRIBER_INSURANCE_SEQUENCE = "P";                                                 // *** Not sure how this should be used
                xh.SUBSCRIBER_SIGNATURE = "Yes";                                                           
                xh.SUBSCRIBER_SIGNATURE_DATE = "";                                                      // *** Another signature date field, not sure
                // PATIENT
                xh.PATIENT_RELATION = ConvertRelationship(aClaim.Patient.SubscriberRelationship);       // *** Excel document lists this as subscriber_relation, do all relationships work the same way?
                xh.PATIENT_STUDENTSTATUS = CleanData(aClaim.Patient.StudentStatus);                                // We're ignoring this currently
                xh.PATIENT_LASTNAME = CleanData(localClaim.patient_last_name);
                xh.PATIENT_FIRSTNAME = CleanData(localClaim.patient_first_name);
                xh.PATIENT_MIDDLENAME = CleanData(localClaim.patient_middle_initial);
                xh.PATIENT_SUFFIX = "";
                xh.PATIENT_ADDRESS1 = CleanData(localClaim.patient_address);
                xh.PATIENT_ADDRESS2 = CleanData(localClaim.patient_address2);
                xh.PATIENT_CITY = CleanData(localClaim.patient_city);
                xh.PATIENT_STATE = CleanData(localClaim.patient_state);
                xh.PATIENT_ZIP = CleanData(localClaim.patient_zip);
                xh.PATIENT_DOB = ConvertDateTime(localClaim.patient_dob);
                xh.PATIENT_GENDER = ConvertGender(aClaim.Patient.Sex);
                xh.PATIENT_ID = CleanData(aClaim.Patient.ID);
                xh.PATIENT_SIGNATURE = "Yes";                                                              
                xh.PATIENT_SIGNATURE_DATE = "";                                                         // *** Signature date
                // PRIMARY_PAYER                                                                        // *** Primary payer section, not sure what this is
                xh.PRIMARY_PAYER_NAME = CleanData(localClaim.payer_name);
                xh.PRIMARY_PAYER_ID = CleanData(localClaim.payer_id);                                 // This should be the electronic ID used in eclaims
                xh.PRIMARY_PAYER_ADDRESS1 = CleanData(aClaim.GeneralInformation.Carrier.Address.Street1);
                xh.PRIMARY_PAYER_ADDRESS2 = CleanData(aClaim.GeneralInformation.Carrier.Address.Street2);
                xh.PRIMARY_PAYER_CITY = CleanData(aClaim.GeneralInformation.Carrier.Address.City);
                xh.PRIMARY_PAYER_STATE = CleanData(aClaim.GeneralInformation.Carrier.Address.State); 
                xh.PRIMARY_PAYER_ZIP = CleanData(aClaim.GeneralInformation.Carrier.Address.Zip);
                // OTHER_COVERAGE
                if (aClaim.OtherPolicy == null)
                    xh.OTHERPAYER_FLAG = "N";
                else
                {
                    xh.OTHERPAYER_FLAG = "Y";
                    CommonFunctions.FormattedName subscriberName = CommonFunctions.GetFormattedName(aClaim.OtherPolicy.SubscriberName);
                    xh.OTHER_SUBSCRIBER_LASTNAME = subscriberName.LastName;
                    xh.OTHER_SUBSCRIBER_FIRSTNAME = subscriberName.FirstName;
                    xh.OTHER_SUBSCRIBER_MIDDLENAME = subscriberName.MiddleInitial;
                    xh.OTHER_SUBSCRIBER_SUFFIX = "";
                    xh.OTHER_SUBSCRIBER_DOB = ConvertToMercuryDateTime(aClaim.OtherPolicy.SubscriberBirthDate);
                    xh.OTHER_SUBSCRIBER_GENDER = ConvertGender(aClaim.OtherPolicy.SubscriberSex);
                    xh.OTHER_SUBSCRIBER_ID = CleanData(aClaim.OtherPolicy.SubscriberID);
                    xh.OTHER_SUBSCRIBER_GROUP_PLAN_NAME = CleanData(aClaim.OtherPolicy.PlanName);
                    xh.OTHER_SUBSCRIBER_GROUP_PLAN_NUMBER = CleanData(aClaim.OtherPolicy.PolicyNumber);
                    xh.OTHER_SUBSCRIBER_RELATION = ConvertRelationshipString(aClaim.OtherPolicy.PatientRelationship);
                    xh.OTHER_SUBSCRIBER_ADDRESS1 = CleanData(aClaim.OtherPolicy.SubscriberAddress.Street1);
                    xh.OTHER_SUBSCRIBER_ADDRESS2 = CleanData(aClaim.OtherPolicy.SubscriberAddress.Street2);
                    xh.OTHER_SUBSCRIBER_CITY = CleanData(aClaim.OtherPolicy.SubscriberAddress.City);
                    xh.OTHER_SUBSCRIBER_STATE = CleanData(aClaim.OtherPolicy.SubscriberAddress.State);
                    xh.OTHER_SUBSCRIBER_ZIP = CleanData(aClaim.OtherPolicy.SubscriberAddress.Zip);
                    xh.OTHER_SUBSCRIBER_INSURANCE_SEQUENCE = "S";                                        // May need to look into this more
                    xh.OTHER_SUBSCRIBER_COB_PAYER_PAID_AMT =  "";                                       // Same as above - leaving this blank for now
                    xh.OTHER_SUBSCRIBER_COB_PATIENT_RESP_AMT = "";                                      // Same as above - leaving this blank for now
                    //  *********************** Not sure what to fill in for this entire Other Payer section


                    Dictionary<string, string> payerInfo = GetOtherPayerID(aClaim.OtherPolicy.PlanName);
                    if (payerInfo != null)
                    {
                        xh.OTHERPAYER_NAME = payerInfo["name"];
                        xh.OTHERPAYER_ID = payerInfo["id"];
                    }
                    else
                    {
                        xh.OTHERPAYER_NAME = CleanData(aClaim.OtherPolicy.PlanName);
                        xh.OTHERPAYER_ID = CleanData(aClaim.OtherPolicy.SubscriberID);
                    }
                    xh.OTHERPAYER_ADDRESS1 = CleanData(aClaim.OtherPolicy.InsuranceAddress.Street1);                                                        
                    xh.OTHERPAYER_ADDRESS2 = CleanData(aClaim.OtherPolicy.InsuranceAddress.Street2);
                    xh.OTHERPAYER_CITY = CleanData(aClaim.OtherPolicy.InsuranceAddress.City);
                    xh.OTHERPAYER_STATE = CleanData(aClaim.OtherPolicy.InsuranceAddress.State);
                    xh.OTHERPAYER_ZIP = CleanData(aClaim.OtherPolicy.InsuranceAddress.Zip);
                    xh.OTHERPAYER_CONTACT_NAME = "";
                    xh.OTHERPAYER_CONTACT_EMAIL = "";
                    xh.OTHERPAYER_CONTACT_TELEPHONE = "";
                    xh.OTHERPAYER_CONTACT_FAX = "";
                    xh.OTHERPAYER_CLAIM_PAID_DATE = "";
                    // ********************************************************************************************
                }
                // CLAIM
                xh.CLAIM_NUMBER = localClaim.id.ToString();                                                       
                xh.SERVICE_DATE = ConvertDateTime(localClaim.date_of_service);
                xh.PREDIDENTIFICATION = "";                                                             // *** PRED Identification?
                xh.OTHERFEE = "";                                                                       // Ignore
                xh.TOTAL_AMOUNT = localClaim.amount_of_claim.ToString();
                
                // ***** COME BACK TO THIS - Missing teeth
                // MISSING_TOOTHS
                // xh.MISSING_TOOTH = "";
                
                                                                                                        // *** Diagnosis qualifier and diagnosis codes don't appear to be available
                xh.DIAG_QUALIFIER = "";                                                                 // For now, ignore
                // DIAGNOSIS_CODES
                xh.DIAGNOSIS_CODES_A = "";
                xh.DIAGNOSIS_CODES_D = "";
                xh.DIAGNOSIS_CODES_D = "";
                xh.DIAGNOSIS_CODES_D = "";


                xh.CLAIM_NOTES = "";
                xh.PLACE_SERVICE = "OFF";
                // Enclosures 
                xh.ENCLOSURES_RADIOGRAPH = CleanData(aClaim.AncillaryData.NumRadiographsEnclosed.ToString());      
                xh.ENCLOSURES_ORAL_IMAGES = "";                                                         // Ignore
                xh.ENCLOSURES_MODELS = "";                                                              // Ignore

                xh.ORTHOCLAIM = CommonFunctions.ToYesNo(aClaim.AncillaryData.Orthodontics.TreatmentForOrthodontics)[0].ToString();
                xh.APPLIANCE_PLACEMENT_DATE = ConvertToMercuryDateTime(aClaim.AncillaryData.Orthodontics.DateAppliancePlaced);
                if (ConvertEmptyToN(aClaim.AncillaryData.Prosthesis.InitialReplacement) == "N")
                    xh.PLACEMENT_TYPE = "Initial";                                                                 
                else
                    xh.PLACEMENT_TYPE = "Replacement";
                xh.MONTHS_TREATMENT_REMAININT = CleanData(aClaim.AncillaryData.Orthodontics.RemainingMonths.ToString());
                xh.REPLACEMENT_PROSTHESIS = ConvertEmptyToN(aClaim.AncillaryData.Prosthesis.InitialReplacement);
                xh.PROIR_PLACEMENT_DATE = ConvertToMercuryDateTime(aClaim.AncillaryData.Prosthesis.PriorPlacement);
                
                xh.OCCUPATIONAL_ILLNESS = "N";                                                           // Ignore this, we track auto or other
                
                if (aClaim.BillingDentist.Accident.Type == NHDG.NHDGCommon.Claims.AccidentType.Automobile)
                {
                    xh.AUTO_ACCIDENT = "Y"; 
                    xh.OTHER_ACCIDENT = "N";
                }
                else if (aClaim.BillingDentist.Accident.Type == NHDG.NHDGCommon.Claims.AccidentType.Other)
                {
                    xh.OTHER_ACCIDENT = "Y"; 
                    xh.AUTO_ACCIDENT = "N";
                }   
                else
                {
                    xh.AUTO_ACCIDENT = "N";
                    xh.OTHER_ACCIDENT = "N";
                }

                xh.ACCIDENT_DATE = aClaim.AncillaryData.DateOfAccident;
                xh.ACCIDENT_STATE = aClaim.AncillaryData.AccidentState;
                xh.ADMISSION_DATE = "";                                                                 // Ignore
                xh.TOT_TREATMENT_PERIOD = "";                                                           // Ignore
                
                // We just won't have any attachments for now, can ask if this is important though
                // ATTACHMENTS
                xh.ATTACHMENT_ID = "";
                
                // LINE_SERVICE
                foreach (NHDG.NHDGCommon.Claims.Treatment t in aClaim.TreatmentInformation.Treatments)
                {
                    LineHelper lh = new LineHelper();
                    lh.SERVICE_DATE = ConvertToMercuryDateTime(t.ProcedureDate);
                    lh.CAVITY_DESIGNATION = "";                                                         // Ignore
                    lh.TOOTH_SYSTEM = "";                                                               // Ignore
                    


                    lh.PROCEDURE_CODE = t.ProcedureCode;
                    lh.DIAGNOSIS_POINTER = "";                                                          // *** Ignore for now, we're not using on ADA form
                    lh.QUANTITY = t.Quantity;
                    lh.PROCEDURE_DESCRIPTION = CleanData(t.Description);
                    lh.FEE = t.Fee;
                    lh.LINE_NOTES = "";

                    try
                    {
                        // teeth
                        foreach (string aTooth in ConvertToothsToList(t.Tooth, t.ToothEnd))
                        {
                            lh.InsertTooth(aTooth);
                        }
                    }
                    catch (Exception ex)
                    {
                        C_DentalClaimTracker.LoggingHelper.Log(ex, false);
                        // Send it anyway, but log an error here
                    }

                    // surfaces                                                                         
                    if (t.Surface != "")
                    {
                        foreach(char aChar in t.Surface.ToCharArray())
                            lh.InsertSurface(aChar.ToString());
                    }


                    xh.InsertLineService(lh);
                }

                fileData.Add(xh.MainDocAsString);
            }

            return fileData;
        }

        private static Dictionary<string, string> GetOtherPayerID(string payerName)
        {
            mercury_payer_list mpl = new mercury_payer_list();
            Dictionary<string, string> easyMatches = mpl.SearchIncludeAlias(payerName);

            if (easyMatches == null)
            {
                // Ask the user to select a payer id
                Mercury.frmFindMercuryPayer toShow = new Mercury.frmFindMercuryPayer(payerName);
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
        /// Takes a tooth start and a tooth end and converts them to a list[string]
        /// </summary>
        /// <param name="toothStart"></param>
        /// <param name="toothEnd"></param>
        /// <returns></returns>
        private static IEnumerable<string> ConvertToothsToList(string toothStart, string toothEnd)
        {
            List<string> toReturn = new List<string>();

            if (toothStart == "0" || toothStart == "")
            {
                // There are no teeth
            }
            else if (toothStart == toothEnd)
            {
                // There's only one tooth
                toReturn.Add(toothStart);
            }
            else
            {
                try
                {
                    int tStart = Convert.ToInt32(toothStart);
                    int tEnd = Convert.ToInt32(toothEnd);

                    if (tStart < tEnd)
                    {
                        for (int i = tStart; i <= tEnd; i++)
                        {
                            toReturn.Add(i.ToString());
                        }
                    }
                    else
                    {
                        for (int i = tEnd; i >= tStart; i--)
                        {
                            toReturn.Add(i.ToString());
                        }
                    }
                }
                catch
                {
                    throw new Exception("An error occurred converting teeth");
                }
            }

            return toReturn;
        }

        private static string ConvertEmptyToN(string s)
        {
            if (s == "")
                return "N";
            else

                return s;
        }

        /// <summary>
        /// Returns either U, M, F (unknown, male, female)
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        private static string ConvertGender(NHDG.NHDGCommon.Claims.Gender gender)
        {
            if (gender.ToString().Length > 0)
                return gender.ToString()[0].ToString();
            else
                return "U";
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

        /// <summary>
        /// Converts a local relationship to the mercury relationship
        /// </summary>
        /// <param name="rel"></param>
        /// <returns></returns>
        private static string ConvertRelationship(NHDG.NHDGCommon.Claims.Relationship rel)
        {
            return ConvertRelationshipString(rel.ToString());
        }

        /// <summary>
        ///  Converts a local relationship string to a mercury relationship
        /// </summary>
        /// <param name="relationship"></param>
        /// <returns></returns>
        private static string ConvertRelationshipString(string relationship)
        {
            switch (relationship)
            {
                case "Self":
                    return "18";
                case "Spouse":
                    return "01";
                case "Child":
                    return "76";
                case "Other":
                case "None":
                case "":
                default:
                    return "21";
            }
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
