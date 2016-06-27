using C_DentalClaimTracker.E_Claims.Mercury;
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
using PdfSharp;
using PdfSharp.Drawing;
using System.Diagnostics;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Pdf.IO;


namespace C_DentalClaimTracker
{
    public partial class DebugForm : Form
    {
        public DebugForm()
        {
            InitializeComponent();
        }

        XMLClaimData helper = new XMLClaimData();

        private void cmdXMLTest_Click(object sender, EventArgs e)
        {
            try
            {
                helper.InsertValue(txtValue1.Text, txtValue2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message);
            }

            txtAllData.Text = helper.MainDocAsString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = "";
            XmlReader rdr = XmlReader.Create(new System.IO.StringReader(helper.MainDocAsString));
            while (rdr.Read())
            {
                if (rdr.NodeType == XmlNodeType.Element)
                {
                    output += "xh.LOCALNAME = \"\";\n".Replace("LOCALNAME", rdr.LocalName);
                }
            }

            txtAllData.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFindMercuryPayer mp = new frmFindMercuryPayer("Plan");

            mp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string output = "";
                string baseXML =
    @"<TRANS_ID></TRANS_ID>
<PRIORITY></PRIORITY>
<PayerName></PayerName>
<PayerID></PayerID>
<PAYER_ADDRESS1></PAYER_ADDRESS1>
<PAYER_ADDRESS2></PAYER_ADDRESS2>
<PAYER_CITY></PAYER_CITY>
<PAYER_STATE></PAYER_STATE>
<PAYER_ZIP></PAYER_ZIP>
<EligibilityDate></EligibilityDate>
<AppointmentDate></AppointmentDate>
<AppointmentTime></AppointmentTime>
<EligibilityType></EligibilityType>
<ProviderLastName></ProviderLastName>
<ProviderFirstName></ProviderFirstName>
<ProviderNPI></ProviderNPI>
<ProviderLicenceNo></ProviderLicenceNo>
<ProviderLicenseState></ProviderLicenseState>
<ProviderAdditionalID></ProviderAdditionalID>
<SubscriberTraceNo></SubscriberTraceNo>
<SubscriberID></SubscriberID>
<SubscriberLastName></SubscriberLastName>
<SubscriberFirstName></SubscriberFirstName>
<SubscriberGender></SubscriberGender>
<SubscriberDOB></SubscriberDOB>
<SubscriberGroupNo></SubscriberGroupNo>
<SubscriberDependentID></SubscriberDependentID>
<PatientRelation></PatientRelation>
<DependentTraceNo></DependentTraceNo>
<DependentID></DependentID>
<DependentLastName></DependentLastName>
<DependentFirstName></DependentFirstName>
<DependentGender></DependentGender>
<DependentDOB></DependentDOB>";

                StringReader sr = new StringReader(baseXML);
                string line = string.Empty;
                do
                {
                    line = sr.ReadLine();

                    if (line != null)
                        output += "\npublic string {0} { set { InsertValue(\"{0}\", value); } }".Replace("{0}", line.Substring(1, line.IndexOf(">") - 1));

                } while (line != null);

                txtAllData.Text = output;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            PdfDocument inputDocument1 = PdfReader.Open(@"D:\TS\C-DentalClaimTracker\C-DentalClaimTracker\bin\Debug\ada-form\sample\ADA2006.pdf", PdfDocumentOpenMode.Modify);
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            PdfPage page = inputDocument1.Pages[0];

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            // Draw the text
            gfx.DrawString("Hello, World!", font, XBrushes.Black,
              new XRect(0, 0, page.Width, page.Height),
              XStringFormats.Center);

            // Save the document...
            const string filename = "HelloWorld.pdf";
            document.Pages.Add(page);
            document.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);
        }
    }
}

 
