using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace C_DentalClaimTracker
{
    partial class company
    {
        public int NumberOfAddresses
        {
            get
            {
                DataTable matches = Search("SELECT COUNT(*) FROM company_contact_info WHERE company_id = " + id);

                return (System.Convert.ToInt32(matches.Rows[0][0]));
            }
        }

        public override string ToString()
        {
            return name;
        }

        internal List<company_contact_info> GetLinkedAddresses()
        {
            List<company_contact_info> toReturn = new List<company_contact_info>();
            company_contact_info workingInfo;
            DataTable matches = Search("SELECT * FROM company_contact_info WHERE company_id = " + id);

            foreach (DataRow anInfo in matches.Rows)
            {
                workingInfo = new company_contact_info();
                workingInfo.Load(anInfo);
                toReturn.Add(workingInfo);
            }

            return toReturn;
        }

        internal company_contact_info GetFirstContactInfo()
        {
            DataTable results = Search("SELECT * FROM company_contact_info WHERE company_id = " + id + 
                " ORDER BY order_id");

            if (results.Rows.Count > 0)
            {
                company_contact_info toReturn = new company_contact_info();
                toReturn.Load(results.Rows[0]);

                return toReturn;
            }
            else
                return null;
        }

        /// <summary>
        /// Returns a list of all companies sorted by name
        /// </summary>
        /// <returns></returns>
        internal static List<company> GetSortedList()
        {
            List<company> toReturn = new List<company>();
            company workingCompany = new company();

            DataTable allData = workingCompany.GetAllData("name");

            foreach (DataRow aRow in allData.Rows)
            {
                workingCompany = new company();
                workingCompany.Load(aRow);

                toReturn.Add(workingCompany);
            }

            return toReturn;


        }
    }
}
