using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace C_DentalClaimTracker
{
    public partial class provider_eligibility_restrictions : DataObject
    {
        public company LinkedInsurance
        {
            get
            {
                if (CommonFunctions.DBNullToZero(this["insurance_id"]) > 0)
                    return new company((int)this["insurance_id"]);
                else
                    throw new DataObjectException.NoCurrentRecordException();
            }
        }

        /// <summary>
        /// Searches to see whether a claim should substitute another provider's information based off of the information
        /// in the passed claim.
        /// </summary>
        /// <param name="toSearch">The claim to search for a restriction on</param>
        /// <returns></returns>
        public static claim FindEligibilityRestrictions(claim toSearch)
        {
            return FindEligibilityRestrictions(toSearch, GetAllDataAsList());
        }

        public static List<provider_eligibility_restrictions> GetAllDataAsList()
        {
            List<provider_eligibility_restrictions> toReturn = new List<provider_eligibility_restrictions>();
            provider_eligibility_restrictions per = new provider_eligibility_restrictions();
            DataTable dt = per.GetAllData();

            foreach (DataRow aRow in dt.Rows)
            {
                per = new provider_eligibility_restrictions();
                per.Load(aRow);

                toReturn.Add(per);
            }

            return toReturn;
        }

        /// <summary>
        /// Searches the given list to see whether a claim should substitute another provider's information based off of the information
        /// in the passed claim.
        /// </summary>
        /// <param name="toSearch">The claim to search for a restriction on</param>
        /// <param name="restrictionsList">The set of restrictions to search through</param>
        /// <returns></returns>
        public static claim FindEligibilityRestrictions(claim toSearch, List<provider_eligibility_restrictions> restrictionsList)
        {
            
            claim switchToClaim = null;

            foreach (provider_eligibility_restrictions restriction in restrictionsList)
            {
                bool valid = true;
                if (toSearch.date_of_service > restriction.start_date)
                {
                    if (restriction.end_date.HasValue)
                    {
                        if (toSearch.date_of_service > restriction.end_date)
                            valid = false;
                    }

                    if (restriction.provider_id != toSearch.doctor_provider_id)
                        valid = false;
                    else
                    {
                        // Check sql for applicability to rules
                        // unfortunately have to create a huge sql statement
                        // Should look roughly like this: 
                        // SELECT id FROM companies WHERE name NOT LIKE '1' AND name NOT LIKE '2' AND (name like '%a%' OR name like 'b')
                        List<int> providerIDs = new List<int>();
                        string finalSQL = GenerateCompanySQL("id", ConvertEligibilityListToStringArray(restriction.GetLinkedCompanyFilters()));

                        DataTable matches = toSearch.Search(finalSQL);

                        foreach (DataRow aMatch in matches.Rows)
                            providerIDs.Add((int) aMatch["id"]);

                        if (!providerIDs.Contains(toSearch.company_id))
                            valid = false;
                    }
                }
                else
                    valid = false;

                if (valid)
                {
                    switchToClaim = FindClaimByProviderID(restriction.switch_to_provider_id);
                }
            }


            return switchToClaim;
        }

        private static List<string> ConvertEligibilityListToStringArray(List<provider_eligibility_companies> toConvert)
        {
            List<string> toReturn = new List<string>();
            foreach (provider_eligibility_companies pec in toConvert)
                toReturn.Add(pec.restriction_text);

            return toReturn;
        }

        public static string GenerateCompanySQL(string selectColumns, List<string> CompanyFilters, bool oppositeResults = false)
        {
            string notWhere = string.Empty;
            string where = string.Empty;
            string finalSQL = "SELECT " + selectColumns + " FROM companies";

            foreach (string aFilter in CompanyFilters)
            {
                if (aFilter.StartsWith("NOT "))
                {
                    if (oppositeResults)
                        where += String.Format(" OR name LIKE '{0}'", aFilter.Substring(4));
                    else
                        notWhere += String.Format(" AND name NOT LIKE '{0}'", aFilter.Substring(4));
                }
                else
                {
                    if (oppositeResults)
                        notWhere += String.Format(" AND name NOT LIKE '{0}'", aFilter);
                    else
                        where += String.Format(" OR name LIKE '{0}'", aFilter);
                }
            }

            if ((notWhere != string.Empty) || (where != string.Empty))
                finalSQL += " WHERE ";
            else
                finalSQL += " WHERE 0=1 "; // force 0 matches

            if (notWhere != string.Empty) // Remove initial and
                notWhere = notWhere.Substring(4);

            if (where != string.Empty) // Remove initial or
                where = where.Substring(4);

            finalSQL += notWhere;

            if ((notWhere != string.Empty) && (where != string.Empty))
                if (oppositeResults)
                    finalSQL += " OR ";
                else
                    finalSQL += " AND ";

            if (where != string.Empty)
                finalSQL += " (" + where + ")";

            finalSQL += " ORDER BY name";
            return finalSQL;
        }

        private List<provider_eligibility_companies> GetLinkedCompanyFilters()
        {
            List<provider_eligibility_companies> toReturn = new List<provider_eligibility_companies>();
            provider_eligibility_companies pec;
            DataTable dt = Search("SELECT * FROM provider_eligibility_companies WHERE per_id = " + id);
            foreach (DataRow aMatch in dt.Rows)
            {
                pec = new provider_eligibility_companies();
                pec.Load(aMatch);
                toReturn.Add(pec);
            }

            return toReturn;
        }

        public static claim FindClaimByProviderID(string ProviderID)
        {
            claim toReturn = new claim();

            DataTable matches = toReturn.Search("SELECT * FROM claims WHERE doctor_provider_id = '" + ProviderID +
                "' LIMIT 1");

            if (matches.Rows.Count > 0)
            {
                toReturn.Load(matches.Rows[0]);

                return toReturn;
            }
            else
                return null;
        }

        internal List<string> GetCompanyCriteria()
        {
            List<string> toReturn = new List<string>();
            claim workingClaim = new claim();

            DataTable matches = workingClaim.Search("SELECT * FROM provider_eligibility_companies WHERE per_id = " + id);

            foreach (DataRow aRow in matches.Rows) {
                toReturn.Add(aRow["restriction_text"].ToString());
            }

            return toReturn;
        }

        /// <summary>
        /// Returns the list of company criteria as a string
        /// </summary>
        /// <returns></returns>
        internal string GetCompanyCriteriaAsString()
        {
            return String.Join(", ", GetCompanyCriteria().ToArray());
        }

        internal void SaveFilters(System.Windows.Forms.ListBox.ObjectCollection filters)
        {
            // Clear the existing filters then add the new ones
            ExecuteNonQuery("DELETE FROM provider_eligibility_companies WHERE per_id = " + id);

            foreach (string aFilter in filters)
            {
                provider_eligibility_companies pec = new provider_eligibility_companies();
                pec.per_id = id;
                pec.restriction_text = aFilter;
                pec.Save();
            }

        }

        
    }
}
