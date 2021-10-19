using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeWebAddInVerifier
{
    public class VerificationConfiguration
    {
        public string ManifestBase64 { get; set; } 
        public string ManifestPath { get; set; } // textBoxManifest.Text
        public List<string> Files { get; set; }
        public string Asmx { get; set; }
        public bool UseDefaultCredentials { get; set; }
        public string UserName { get; set; }
        public string Domain { get; set; }
        public void GetManifestAsBase64()
        {
            using (var client = new System.Net.WebClient())
            {
                // download the data so we can access it later
                byte[] LobjManifestData = client.DownloadData(ManifestPath);
                ManifestBase64 = Convert.ToBase64String(LobjManifestData);
            }
        }
    }
}
