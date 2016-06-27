using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DCTUpdater
{
    public class DeploymentManifest
    {
        public DeploymentManifest()
        {
            Files = new List<DeploymentFile>();
        }

        public List<DeploymentFile> Files { get; set; }

        public void Save(string fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(DeploymentManifest));
            
            using (StreamWriter sw = File.CreateText(fileName))
            {
                xs.Serialize(sw, this);
            }
        }

        public void LoadFromUrl(string url)
        {
            XmlSerializer xs = new XmlSerializer(typeof(DeploymentManifest));

            XmlTextReader reader = new XmlTextReader(url);

            DeploymentManifest fileDM = (DeploymentManifest)xs.Deserialize(reader);
            this.Files = fileDM.Files;
        }
        
        public void LoadFromFile(string fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(DeploymentManifest));

            using (FileStream fs = File.Open(fileName, FileMode.Open))
            {
                DeploymentManifest fileDM = (DeploymentManifest)xs.Deserialize(fs);
                this.Files = fileDM.Files;
            }
        }
    }
}
