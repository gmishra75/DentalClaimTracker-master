using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DCTUpdater
{
    public struct DeploymentFile
    {
        public string FileName { get; set; }
        public string HashValue { get; set; }
        public string Version { get; set; }

        public DeploymentFile(string fileName, string hashValue, string version)
            : this()
        {
            FileName = fileName;
            HashValue = hashValue;
            Version = version;
        }

        public override bool Equals(object o) 
        {
            return o is DeploymentFile && Equals((DeploymentFile)o);
        }

        public static bool operator ==(DeploymentFile a, DeploymentFile b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(DeploymentFile a, DeploymentFile b)
        {
            return !(a == b);
        }

        private bool Equals(DeploymentFile df)
        {
            return Path.GetFileName(FileName) == Path.GetFileName(df.FileName) && HashValue == df.HashValue && Version == df.Version;
        }

        static public DeploymentFile CreateFromFile(string fileName)
        {
            return CreateFromFile(fileName, fileName); // Use the same path for actual and deployment
        }

        static public DeploymentFile CreateFromFile(string fileName, string deployPath)
        {
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException("File not found.", fileName);
            }

            DeploymentFile df = new DeploymentFile();

            if (Path.GetFileName(deployPath) != String.Empty)
            {
                // Use full deploy path because it specifies a file
                df.FileName = deployPath;
            }
            else if (deployPath == string.Empty)
            {
                df.FileName = Path.GetFileName(fileName);
            }
            else
            {
                df.FileName = Path.GetDirectoryName(deployPath) + "\\" + Path.GetFileName(fileName);
            }

            df.HashValue = GetMD5HashFromFile(fileName);
            df.Version = FileVersionInfo.GetVersionInfo(fileName).FileVersion;

            return df;
        }

        static public string GetMD5HashFromFile(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Open);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(file);
            file.Close();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
