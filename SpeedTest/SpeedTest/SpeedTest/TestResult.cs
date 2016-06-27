using System;
using System.Collections.Generic;
using System.Text;


namespace SpeedTest
{
    [Serializable]
    public class TestResult
    {
        public TestResult()
        {
            creationTime = 0;
            copyTime = 0;
            deleteTime = 0;
            testTime = DateTime.Now.ToString("G"); ;
            numFiles = 0;
            notes = "";

        }

        public long creationTime { get; set; }
        public long copyTime { get; set; }
        public long deleteTime { get; set; }
        public string testTime { get; set; }
        public int numFiles { get; set; }
        public string notes { get; set; }

        public long TotalTime
        {
            get { return creationTime + copyTime + deleteTime; }
        }
    }

    [Serializable]
    public class TestResultCollection
    {
        public TestResultCollection()
        {
            AllTestResults = new List<TestResult>();
        }

        public List<TestResult> AllTestResults { get; set; }
    }
}
