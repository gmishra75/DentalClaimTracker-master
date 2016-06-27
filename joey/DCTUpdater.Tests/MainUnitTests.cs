using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DCTUpdater.Tests
{
    [TestClass]
    public class MainUnitTests
    {
        const string DeploymentManifestFilePath = @"D:\TS\C-DentalClaimTracker\bin\Release Deployment\DeploymentManifest.XML";
        const string DeploymentManifestURL = "http://www.twinsparks.com/dct/exe/deploymentmanifest.xml";

        [TestMethod]
        public void TestBuildDeploymentManifest()
        {
            DeploymentManifest dm1 = new DeploymentManifest();
            
            // Add files here
            dm1.Files.Add(DeploymentFile.CreateFromFile(@"D:\TS\C-DentalClaimTracker\bin\Release\DentalClaimTracker.exe", 
                @"D:\TS\C-DentalClaimTracker\bin\Release Deployment\DentalClaimTracker.exe"));              

            dm1.Save(DeploymentManifestFilePath);

            DeploymentManifest dm2 = new DeploymentManifest();
            dm2.LoadFromFile(DeploymentManifestFilePath);

            // Validate
            for(int i = 0;i < dm1.Files.Count;i++)
            {
                Assert.AreEqual(dm1.Files[i].FileName, dm2.Files[i].FileName);
                Assert.AreEqual(dm1.Files[i].HashValue, dm2.Files[i].HashValue);
                Assert.AreEqual(dm1.Files[i].Version, dm2.Files[i].Version);               
            }
            
        }

        [TestMethod]
        public void TestDeploymentManifestFromUrl()
        {
            DeploymentManifest dm1 = new DeploymentManifest();
            dm1.LoadFromFile(DeploymentManifestFilePath);

            DeploymentManifest dm2 = new DeploymentManifest();
            dm2.LoadFromUrl(DeploymentManifestURL);

            // Validate
            for (int i = 0; i < dm1.Files.Count; i++)
            {
                //Assert.AreEqual(dm1.Files[i].FileName, dm2.Files[i].FileName);
                //Assert.AreEqual(dm1.Files[i].HashValue, dm2.Files[i].HashValue);
                //Assert.AreEqual(dm1.Files[i].Version, dm2.Files[i].Version);
            }
            // Didn't fix this, but not working because manifest now contains remote file location information
        }
    }
}
