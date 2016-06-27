using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace SpeedTest
{
    public partial class frmMain : Form
    {
        TestResultCollection trc;

        public frmMain()
        {
            InitializeComponent();
            if (File.Exists(Properties.Settings.Default.XMLPath))
            {
                try
                {
                    XmlSerializer mySerializer = new XmlSerializer(typeof(TestResultCollection));

                    FileStream myFileStream = new FileStream(Properties.Settings.Default.XMLPath, FileMode.Open);
                    trc = (TestResultCollection)mySerializer.Deserialize(myFileStream);
                    myFileStream.Close();
                }
                catch
                {
                    trc = new TestResultCollection();
                }
            }
            else
            {
                trc = new TestResultCollection();
            }
            testResultBindingSource.DataSource = trc;
        }

        private void btnRunTest_Click(object sender, EventArgs e)
        {
            TestResult tr = new TestResult();

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            List<string> allFiles = new List<string>();
            List<string> allCopies = new List<string>();

            tr.notes = txtNotes.Text;
            tr.testTime = DateTime.Now.ToString("G");
            tr.numFiles = Convert.ToInt32(nmbNumFiles.Value);

            // Create Files
            sw.Start();
            for (int i = 0; i <= nmbNumFiles.Value; i++)
                allFiles.Add(Path.GetTempFileName());
            sw.Stop();
            tr.creationTime = sw.ElapsedMilliseconds;

            // Copy Files
            sw.Reset();
            sw.Start();
            
            allFiles.ForEach(fileName => {  allCopies.Add(Path.GetTempFileName()); File.Copy(fileName, allCopies[allCopies.Count - 1], true); } );
            sw.Stop();
            tr.copyTime = sw.ElapsedMilliseconds;

            // Delete Files
            sw.Reset();
            sw.Start();
            allFiles.ForEach(fileName => File.Delete(fileName));
            allCopies.ForEach(fileName => File.Delete(fileName));
            sw.Stop();
            tr.deleteTime = sw.ElapsedMilliseconds;


            // Write to file
            trc.AllTestResults.Insert(0, tr);
            // Insert code to set properties and fields of the object.
            XmlSerializer mySerializer = new XmlSerializer(typeof(TestResultCollection));
            // To write to a file, create a StreamWriter object.
            File.Delete(Properties.Settings.Default.XMLPath);
            StreamWriter myWriter = new StreamWriter(Properties.Settings.Default.XMLPath);
            mySerializer.Serialize(myWriter, trc);
            myWriter.Close();

            txtNotes.Clear();

            testResultBindingSource.ResetBindings(false);
            
            
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
