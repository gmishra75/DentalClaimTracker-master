using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using C_DentalClaimTracker.General;

namespace C_DentalClaimTracker.Claims_Primary.SearchResults
{
    public class MainSearchSearchResultList : SortableBindingList<MainSearchSearchResult>
    { }

    public class MainSearchSearchResult
    {
        // name, dateob, carrier, amount, dos, type, revisit date, provider, status, last edit, system id 1, system id2, claim object
        private string _name;
        private DateTime? _dateOfBirth;
        private string _carrier;
        private string _amount;
        private DateTime? _dateOfService;
        private string _type;
        private DateTime? _revisitDate;
        private string _provider;
        private string _status;
        private string _lastEdit;
        private string _systemID1;
        private string _systemID2;
        private claim _claimObject;
        private string _assignTo;
        private string _dateOfServiceRange;
        public DateTime? LastSendDate { get; set; }


        public MainSearchSearchResult(string name, DateTime? dateOfBirth, string carrier, string amount, DateTime? dateOfService,
            string type, DateTime? revisitDate, string assignTo, string provider, string status, string lastEdit, string systemID1, string systemID2, 
            claim claimObject, string dosRange, DateTime? lastSendDate)
        {
            _name = name;
            _dateOfBirth = dateOfBirth;
            _carrier = carrier;
            _amount = amount;
            _dateOfService = dateOfService;
            _type = type;
            _revisitDate = revisitDate;
            _provider = provider;
            _status = status;
            _lastEdit = lastEdit;
            _systemID1 = systemID1;
            _systemID2 = systemID2;
            _claimObject = claimObject;
            _assignTo = assignTo;
            _dateOfServiceRange = dosRange;
            LastSendDate = lastSendDate;
        
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public DateTime? DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        public string Carrier
        {
            get { return _carrier; }
            set { _carrier = value; }
        }
        public string Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public DateTime? DateOfService
        {
            get { return _dateOfService; }
            set { _dateOfService = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public DateTime? RevisitDate
        {
            get { return _revisitDate; }
            set { _revisitDate = value; }
        }
        public string Provider
        {
            get { return _provider; }
            set { _provider = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string LastEdit
        {
            get { return _lastEdit; }
            set { _lastEdit = value; }
        }
        public string SystemID1
        {
            get { return _systemID1; }
            set { _systemID1 = value; }
        }
        public string SystemID2
        {
            get { return _systemID2; }
            set { _systemID2 = value; }
        }
        public claim ClaimObject
        {
            get { return _claimObject; }
            set { _claimObject = value; }
        }
        public string AssignTo
        {
            get { return _assignTo; }
            set { _assignTo = value; }
        }
        public string DateOfServiceRange
        {
            get { return _dateOfServiceRange; }
            set { _dateOfServiceRange = value; }
        }
    }
}
