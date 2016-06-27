using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_DentalClaimTracker.Reporting.Data
{
    class AgingReportRow
    {
        public string CompanyName { get; set; }
        public string GroupPlan { get; set; }
        public string GroupNumber { get; set; }
        public string CompanyPhone { get; set; }
        public int ClaimID { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime DateOfService { get; set; }
        public string Subscriber { get; set; }
        public string Type { get; set; }
        public string IDNum { get; set; }
        public string Patient { get; set; }
        public DateTime Birthday { get; set; }
        public decimal Estimate { get; set; }
        public decimal Total { get; set; }
        public string RevisitDate { get; set; }
        public DateTime? LastEdit { get; set; }
        public string CurrentStatus { get; set; }
    }
}
