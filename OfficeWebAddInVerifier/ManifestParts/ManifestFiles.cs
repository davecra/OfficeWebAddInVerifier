using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OfficeWebAddInVerifier.ManifestParts
{
    public class ManifestFiles : ManifestBase
    {
        private readonly string MstrBaseUrl = "";
        public Dictionary<string, bool> FilesFound { get; private set; }
        public ManifestFiles(XmlDocument PobjDoc, string PstrBaseUrl, List<string> PobjFiles) : base(PobjDoc) 
        {
            FilesFound = new Dictionary<string, bool>();
            PobjFiles.ForEach((o) => {
                FilesFound.Add(o, false);
            });
            MstrBaseUrl = PstrBaseUrl;
        }

        /// <summary>
        /// Runs through the file list and verifies they are present
        /// </summary>
        public override void Run()
        {
            try
            {
                foreach(KeyValuePair<string,bool> LobjFile in FilesFound)
                {
                    string LstrCompleteUrl = MstrBaseUrl + LobjFile.Key.Replace("\\","/");
                    bool LbolFound = AccessUrl(LstrCompleteUrl);
                    if(LbolFound)
                    {
                        SendMessage("SUCCESS accessing " + LstrCompleteUrl, true);
                    }
                    else
                    {
                        SendMessage("FAILED accessing " + LstrCompleteUrl, false);
                    }
                }
            }
            catch (Exception PobjEx)
            {
                PobjEx.Log("Unable to verify files.");
            }
        }
    }
}
