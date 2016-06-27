using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCTUpdater
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        const string DeploymentManifestFilePath = @"D:\TS\C-DentalClaimTracker\bin\Release\Deployment\DeploymentManifest.XML";
        const string DeploymentManifestURL = "http://www.twinsparks.com/dct/exe/deploymentmanifest.xml";
        string baseExe = @"D:\TS\C-DentalClaimTracker\bin\Release\DentalClaimTracker.exe";
        string deploymentFolderExe = @"D:\TS\C-DentalClaimTracker\bin\Release\Deployment\DentalClaimTracker.exe";
        public void TestBuildDeploymentManifest(string deploymentPath)
        {
            DeploymentManifest dm1 = new DeploymentManifest();

            // Add files here
            // Second part needs to be remote file name

            dm1.Files.Add(DeploymentFile.CreateFromFile(@"D:\TS\C-DentalClaimTracker\bin\Release\DentalClaimTracker.exe",
                deploymentPath));

            dm1.Save(DeploymentManifestFilePath);

            DeploymentManifest dm2 = new DeploymentManifest();
            dm2.LoadFromFile(DeploymentManifestFilePath);
        }

        private void cmdOpenFolder_Click(object sender, EventArgs e)
        {
            TestBuildDeploymentManifest(@"C:\Temp\");
            System.Diagnostics.Process.Start(System.IO.Path.GetDirectoryName(DeploymentManifestFilePath));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestBuildDeploymentManifest("");

            if (System.IO.File.Exists(baseExe))
                System.IO.File.Copy(baseExe, deploymentFolderExe, true);
            System.Diagnostics.Process.Start(System.IO.Path.GetDirectoryName(DeploymentManifestFilePath));
        }
    }
}
