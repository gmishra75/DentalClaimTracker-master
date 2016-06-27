using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace C_DentalClaimTracker
{
    public partial class insurance_company_group : DataObject
    {
        public List<insurance_company_groups_filters> GetFilters
        {
            get
            {
                List<insurance_company_groups_filters> toReturn = new List<insurance_company_groups_filters>();
                insurance_company_groups_filters icg = new insurance_company_groups_filters();

                DataTable matches = icg.Search("SELECT * FROM insurance_company_groups_filters WHERE icg_id = " + id);

                foreach (DataRow aRow in matches.Rows)
                {
                    icg = new insurance_company_groups_filters();
                    icg.Load(aRow);
                    toReturn.Add(icg);
                }

                return toReturn;
            }
        }

        public List<string> GetFiltersTextOnly
        {
            get
            {
                List<string> toReturn = new List<string>();
                insurance_company_groups_filters icg = new insurance_company_groups_filters();

                DataTable matches = icg.Search("SELECT * FROM insurance_company_groups_filters WHERE icg_id = " + id);

                foreach (DataRow aRow in matches.Rows)
                {
                    icg = new insurance_company_groups_filters(aRow);
                    toReturn.Add(icg.filter_text);
                }

                return toReturn;
            }
        }

        internal void SaveFilters(System.Windows.Forms.ListBox.ObjectCollection filters)
        {
            // Clear the existing filters then add the new ones
            ExecuteNonQuery("DELETE FROM insurance_company_groups_filters WHERE icg_id = " + id);

            foreach (string aFilter in filters)
            {
                insurance_company_groups_filters icg = new insurance_company_groups_filters();
                icg.icg_id = id;
                icg.filter_text = aFilter;
                icg.Save();
            }
        }

        internal object GetFiltersAsString()
        {
            string toReturn = "";

            foreach (insurance_company_groups_filters aFilter in GetFilters) {
                if (toReturn != string.Empty)
                    toReturn += ", ";

                toReturn += aFilter.filter_text;
            }
            return toReturn;
        }

        public override void Delete()
        {
            ExecuteNonQuery("DELETE FROM insurance_company_groups_filters WHERE icg_id = " + id);
            base.Delete();
        }

        public override string ToString()
        {
            return name;
        }

        internal List<company> GetMatchingCompanies()
        {
            List<company> toReturn = new List<company>();
            string finalSQL = provider_eligibility_restrictions.GenerateCompanySQL("*", GetFiltersTextOnly);
            company workingComp = new company();

            foreach (DataRow aRow in workingComp.Search(finalSQL).Rows)
            {
                workingComp = new company(aRow);
                toReturn.Add(workingComp);
            }

            return toReturn;
        }
    }
}
