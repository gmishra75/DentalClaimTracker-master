using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Linq;

namespace C_DentalClaimTracker.E_Claims
{
    public partial class frmEditApexSchema : Form
    {
        XDocument xDoc;

        public frmEditApexSchema()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (xDoc != null)
            {
                try
                {
                    xDoc.Root.Elements("Fields").Elements("Field").Remove();

                    foreach (ApexField f in (BindingList<ApexField>) bsApexSchema.DataSource)
                    {
                        XElement toAdd = new XElement("Field");

                        toAdd.Add(new XElement("Name", f.Name),
                            new XElement("Line", f.Line), new XElement("StartColumn", f.StartColumn), new XElement("EndColumn", f.EndColumn));

                        xDoc.Root.Element("Fields").Add(toAdd) ;
                    }

                    xDoc.Save(Properties.Settings.Default.ApexEDIConfigLocation); // @"C:\NHDG\config\apexedi.config
                    MessageBox.Show(this, "Changes saved successfully!");
                }
                catch (Exception err)
                {
                    LoggingHelper.Log("Could not write to Apex config file in frmProcessor.cmdSave_click.", LogSeverity.Error, err, false);
                    MessageBox.Show(this, "An unexpected error occurred writing to the config file.\n\n" + err.Message);
                }
            }
            else
            {
                LoggingHelper.Log("Could not save changes to Apex Schema. Unknown error in Save.", LogSeverity.Critical);
                MessageBox.Show("Could not save changes to Apex Schema.");
            }
        }

        private void lnkOpenFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                CommonFunctions.OpenDirectory(Path.GetDirectoryName(Properties.Settings.Default.ApexEDIConfigLocation));
            }
            catch (Exception err)
            {
                LoggingHelper.Log("Could not open the path: '" + Path.GetDirectoryName(Properties.Settings.Default.ApexEDIConfigLocation) +
                    "'.", LogSeverity.Error, err, false);
                MessageBox.Show("Could not open the path: '" + Path.GetDirectoryName(Properties.Settings.Default.ApexEDIConfigLocation) +
                    "'. Error message was:\n\n" + err.Message);
            }
        }

        private void InitializeSchemaXMLData()
        {
            try
            {
                 xDoc = NHDG.ApexEDI.ApexEDI.Schema;
            }
            catch(Exception e)
            {
                MessageBox.Show(this,
                    "An unexpected error occurred loading the schema data. Please pass this error along to an administrator:\n\n" + e.Message,
                    "Error loading XML Schema Data");
                return;
            }

            try
            {
                var sorted = from c in xDoc.Root.Elements("Fields").Elements("Field")
                             select new ApexField
                             {
                                 Name = (string)c.Element("Name"),
                                 Line = (int)c.Element("Line"),
                                 StartColumn = (int)c.Element("StartColumn"),
                                 EndColumn = (int)c.Element("EndColumn")
                             };

                sorted = sorted.OrderBy(l => l.Line).ThenBy(s => s.StartColumn);

                var queryAsList = new BindingList<ApexField>(sorted.ToList());
                bsApexSchema.DataSource = queryAsList;
                dgvSchemaData.DataSource = bsApexSchema;

            }
            catch (Exception err)
            {
                LoggingHelper.Log("Error displaying XML data in frmProcessor.InitializeSchemaXMLData", LogSeverity.Error, err, false);
                MessageBox.Show("Error displaying XML data.\n\n" + err.Message);
            }
        }

        private void frmEditApexSchema_Load(object sender, EventArgs e)
        {
            InitializeSchemaXMLData();
        }
    }

    public class ApexField
    {
        public string Name { get; set; }
        public int Line { get; set; }
        public int StartColumn { get; set; }
        public int EndColumn { get; set; }
    }
}
