using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_DentalClaimTracker.Appointment_Auditing
{
    public partial class frmImportAppointmentAudit : Form
    {
        DateTime lastWrite;
        DateTime importStart;
        BackgroundWorker WorkerThread = new BackgroundWorker();
        delegate void ProgressDelegate(int increment, string text);
        delegate void StatusDelegate(string text);
        delegate void EmptyDelegate();
        int totalRows = 0;
        public static bool THREADINGON = false;

        public frmImportAppointmentAudit()
        {
            InitializeComponent();
            WorkerThread.DoWork += WorkerThread_DoWork;
            WorkerThread.RunWorkerCompleted += WorkerThread_RunWorkerCompleted;
        }

        void WorkerThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            if (e.Cancelled)
            {
                CancelImport();
            }
            else
            {
                pbarProgress.Value = pbarProgress.Maximum;
                lblStatus.Text = "Operation complete!";
                system_options.SetLastAppointmentAuditImportDate(importStart);
                UpdateStatusBox("Import completed successfully!");
                system_options.SetLastImportDate(DateTime.Now);
                ShowLastImportDate();
            }
        }

        void WorkerThread_DoWork(object sender, DoWorkEventArgs e)
        {
            claim workingClaim = new claim();
            DataTable importData = new DataTable();
            DataTable importDataSecondaries = new DataTable();
            DataTable importDataPredeterms = new DataTable();
            OleDbConnection oConnect;
            appointment_audit aa;

            UpdateProgressBar(0, "Starting Import");


            #region Initiate Connection, Get Data
            try
            {
                oConnect = new OleDbConnection(data_mapping_schema.GetDefaultSchema.GetConnectionString(true));
            }
            catch (Exception err)
            {
                LoggingHelper.Log("An error occurred getting the connection string for a new connection in frmImportData.Import", LogSeverity.Error, err, false);
                e.Cancel = true;
                return;
            }



            OleDbDataAdapter oAdapter;
            // Use Connection object for the DataAdapter to retrieve all tables from selected Database
            try
            {
                oConnect.Open();
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Could not connect to the database in frmImportAppointmentAuditdata.Import", LogSeverity.Error, err, false);
                e.Cancel = true;
                return;
            }

            DateTime lastImport = system_options.GetLastAppointmentAuditImportDate();
            importStart = DateTime.Now;
            

            

            try
            {
                

                string sql;

                // ************* Start import
                if (chkMergeData.Checked)
                {
                    sql = string.Format("SELECT * FROM AUDIT_DDB_APPT_BASE" +
                        " WHERE DATE_CHANGED > '{0}'", CommonFunctions.ToSQLServerDateTime(lastImport));
                }
                else
                {
                    UpdateStatusBox("Clearing existing appointment audit information for full import...");
                    UpdateProgressBar(0, "Clearing existing appointments audit data...");
                    aa = new appointment_audit();
                    aa.Zap();

                    sql = string.Format("SELECT * FROM AUDIT_DDB_APPT_BASE" +
                        " WHERE DATE_CHANGED > '{0}'",
                        DateTime.Now.AddDays(Convert.ToInt32(nmbFullImportDuration.Value * -1)).ToShortDateString());
                }
                UpdateStatusBox("Starting the following query: \r\n" + sql);
                UpdateProgressBar(50, "Querying remote database...");
                oAdapter = new OleDbDataAdapter(sql, oConnect);
                oAdapter.SelectCommand.CommandTimeout = System.Convert.ToInt32(nmbTimeout.Value);
                oAdapter.Fill(importData);

            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error with SQL statement or connection in frmImportData.Import", LogSeverity.Error, err);
                e.Cancel = true;
                CancelImport();
                return;
            }

            UpdateProgressBar(200, "Importing data...");

            // **** Data retrieved, put it into our local table
            
            totalRows = importData.Rows.Count;
            decimal exactIncrementAmount;
            decimal incrementCounter = 0;
            int increment;

            if (totalRows > 0)
                exactIncrementAmount = 500m / totalRows;
            else
                exactIncrementAmount = 500m;


            if (exactIncrementAmount < 1)
                increment = 1;
            else
                increment = Convert.ToInt32(Math.Truncate(exactIncrementAmount));

            UpdateStatusBox("Starting import process for " + importData.Rows.Count + " rows.");

            int i = 0;
            int insertedRows = 0;
            aa = new appointment_audit();
            string colList = "";
            string valueList = "";
            string sqlText = "INSERT INTO APPOINTMENT_AUDIT ({0}) VALUES {1}";
            foreach (DataColumn aColumn in importData.Columns)
            {
                colList += aColumn.ColumnName + ",";
            }
            colList = colList.Substring(0, colList.Length - 1);


            // Have data at this point, need to tie them to the internal mapping schema data
            foreach (DataRow anImportRow in importData.Rows)
            {
                i++;
                insertedRows++;
                // need new data object for this table type
                /*aa = new appointment_audit();

                foreach (DataColumn aColumn in importData.Columns)
                {
                    aa[aColumn.ColumnName] = anImportRow[aColumn.ColumnName];
                }
                
                aa.change_type = aa.DiscoverChangeType();
                aa.Save();

                incrementCounter += exactIncrementAmount;

                 * */

                

                if (insertedRows > 500) // Can't go over 1000, no reason to cut it close
                {
                    valueList = valueList.Substring(0, valueList.Length - 1);
                    sqlText = string.Format(sqlText, colList, valueList);
                    /* if (!THREADINGON)
                        Clipboard.SetText(sqlText); */
                    aa.ExecuteNonQuery(sqlText);
                    
                    valueList = "";
                    sqlText = "INSERT INTO APPOINTMENT_AUDIT ({0}) VALUES {1}";
                }

                valueList += "(";

                foreach (DataColumn aColumn in importData.Columns)
                {
                    string newValue = anImportRow[aColumn.ColumnName].ToString().Trim().Replace("'", "''");

                    if (!aColumn.DataType.ToString().Contains("int"))
                        newValue = "'" + newValue + "'";

                    valueList += newValue + ",";
                }

                valueList = valueList.Substring(0, valueList.Length - 1);
                valueList += "),";

                if (incrementCounter >= increment)
                {
                    UpdateProgressBar(increment, string.Format("Importing changes {0}/{1}", i, totalRows));
                    incrementCounter -= increment;
                }

            }

            valueList = valueList.Substring(0, valueList.Length - 1);
            
            sqlText = string.Format(sqlText, colList, valueList);
            // Clipboard.SetText(sqlText);
            aa.ExecuteNonQuery(sqlText);

            #endregion

            if (!THREADINGON)
                WorkerThread_RunWorkerCompleted(null, new RunWorkerCompletedEventArgs(null, null, false));
        }


        private void chkMergeData_CheckedChanged(object sender, EventArgs e)
        {
            nmbFullImportDuration.Enabled = !chkMergeData.Checked;
        }

        private void frmImportAppointmentAudit_Load(object sender, EventArgs e)
        {
            ShowLastImportDate();
        }

        private void ShowLastImportDate()
        {
            try
            {
                lastWrite = system_options.GetLastAppointmentAuditImportDate();
                lblLastImport.Text = "Last Import: " + lastWrite.ToShortDateString() + " " + lastWrite.ToShortTimeString();
            }
            catch
            {
                lblLastImport.Text = "Last Import: Unknown";
            }
        }

        private void cmdImport_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            rtbStatus.Text = "";
            if (THREADINGON)
                WorkerThread.RunWorkerAsync();
            else
                WorkerThread_DoWork(this, null);
        }

        private void UpdateProgressBar(int increment, string text)
        {
            if (pbarProgress.InvokeRequired)
            {
                this.Invoke(new ProgressDelegate(UpdateProgressBar), new object[] { increment, text });
            }
            else
            {
                pbarProgress.Increment(increment);
                lblStatus.Text = text;
            }
        }

        private void UpdateStatusBox(string text)
        {
            if (rtbStatus.InvokeRequired)
            {
                this.Invoke(new StatusDelegate(UpdateStatusBox), new object[] { text });
            }
            else
            {
                if (rtbStatus.Text != "")
                    rtbStatus.AppendText(Environment.NewLine);

                string timeStamp = DateTime.Now.ToString("h:mm:ss tt") + ": ";

                rtbStatus.SelectionStart = rtbStatus.TextLength;
                rtbStatus.SelectionLength = 0;
                rtbStatus.SelectionColor = Color.CadetBlue;
                rtbStatus.AppendText(timeStamp);


                rtbStatus.SelectionStart = rtbStatus.TextLength;
                rtbStatus.SelectionLength = 0;
                rtbStatus.SelectionColor = Color.Black;
                rtbStatus.AppendText(text);
                
                rtbStatus.Refresh();
            }
        }

        private void CancelImport()
        {
            if (lblStatus.InvokeRequired)
            {
                this.Invoke(new EmptyDelegate(CancelImport));
            }
            else
            {
                lblStatus.Text = "Import Cancelled...";
                UpdateStatusBox("Import Cancelled.");
                pbarProgress.Value = 0;
                Cursor = Cursors.Default;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateStatusBox("test 1");
            UpdateStatusBox("test 2");
            UpdateStatusBox("test 3");
        }

        private void btnChangeType_Click(object sender, EventArgs e)
        {
            appointment_audit aa = new appointment_audit();

            DataTable matches = aa.Search("SELECT * FROM appointment_audit WHERE change_type is null");

            foreach (DataRow aRow in matches.Rows)
            {
                aa = new appointment_audit();
                aa.Load(aRow);

                aa.change_type = aa.DiscoverChangeType();

                aa.Save();
            }

            MessageBox.Show(this, "Action Complete. " + matches.Rows.Count + " rows updated.");

        }

        private void btnImportDentrixProviders_Click(object sender, EventArgs e)
        {
            claim workingClaim = new claim();
            DataTable importData = new DataTable();
            DataTable importDataSecondaries = new DataTable();
            DataTable importDataPredeterms = new DataTable();
            OleDbConnection oConnect;
            dentrix_providers dp;

            try
            {
                oConnect = new OleDbConnection(data_mapping_schema.GetDefaultSchema.GetConnectionString(true));
            }
            catch (Exception err)
            {
                LoggingHelper.Log("An error occurred getting the connection string for a new connection in frmImportData.Import", LogSeverity.Error, err, false);
                return;
            }

            OleDbDataAdapter oAdapter;
            // Use Connection object for the DataAdapter to retrieve all tables from selected Database
            try
            {
                oConnect.Open();
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Could not connect to the database in frmImportAppointmentAuditdata.Import", LogSeverity.Error, err, false);
                return;
            }

            try
            {


                string sql;

                sql = "SELECT * FROM DDB_RSC_BASE WHERE RSCTYPE = 1 ORDER BY URSCID";

                oAdapter = new OleDbDataAdapter(sql, oConnect);
                oAdapter.SelectCommand.CommandTimeout = 300;
                oAdapter.Fill(importData);

            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error with SQL statement or connection in frmImportData.Import", LogSeverity.Error, err);
                return;
            }

            // **** Data retrieved, put it into our local table

            dp = new dentrix_providers();
            dp.Zap();
            string colList = "";
            string valueList = "";
            string sqlText = "INSERT INTO dentrix_providers ({0}) VALUES {1}";
            foreach (DataColumn aColumn in importData.Columns)
            {
                colList += aColumn.ColumnName + ",";
            }
            colList = colList.Substring(0, colList.Length - 1);


            // Have data at this point, need to tie them to the internal mapping schema data
            foreach (DataRow anImportRow in importData.Rows)
            {
                valueList += "(";

                foreach (DataColumn aColumn in importData.Columns)
                {
                    string newValue = anImportRow[aColumn.ColumnName].ToString().Trim().Replace("'", "''");

                    if (!aColumn.DataType.ToString().Contains("int"))
                        newValue = "'" + newValue + "'";

                    valueList += newValue + ",";
                }

                valueList = valueList.Substring(0, valueList.Length - 1);
                valueList += "),";
            }

            valueList = valueList.Substring(0, valueList.Length - 1);

            sqlText = string.Format(sqlText, colList, valueList);
            dp.ExecuteNonQuery(sqlText);

            MessageBox.Show("Import Successful! " + importData.Rows.Count + " providers in the system.");

        }

    }
}
