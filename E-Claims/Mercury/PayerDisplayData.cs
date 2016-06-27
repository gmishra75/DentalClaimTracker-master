using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_DentalClaimTracker.E_Claims.Mercury
{
    class PayerDisplayData
    {
        public int ID { get; set; }
        public string PayerID { get; set; }
        public string DisplayData { get; set; }

        public PayerDisplayData(string displayData, string payerID, int id)
        {
            DisplayData = displayData;
            PayerID = payerID;
            ID = id;
        }

        public override string ToString()
        {
            return DisplayData;
        }
    }
}
