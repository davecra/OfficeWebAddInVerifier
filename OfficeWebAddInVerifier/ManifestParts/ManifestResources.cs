using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using OfficeWebAddInVerifier.Validators;

namespace OfficeWebAddInVerifier.ManifestParts
{
    public class ManifestResources : ManifestBase
    {
        private string MstrXPath = "";
        private string MstrName = "";
        public ManifestResources(XmlDocument PobjDoc, string PstrXPath, string PstrName) : base(PobjDoc) 
        {
            MstrXPath = PstrXPath;
            MstrName = PstrName;
        }
        public override void Run()
        {
            try
            {
                XmlNodeList LobjNodes = MobjDoc.SelectNodes(MstrXPath, MobjNSMgr);
                foreach(XmlNode LobjNode in LobjNodes)
                {
                    string LstrId = LobjNode.Attributes.GetNamedItem("id").Value;
                    string LstrValue = LobjNode.Attributes.GetNamedItem("DefaultValue").Value;
                    bool LbolVerified = AccessUrl(LstrValue);
                    bool LbolValidated = false;
                    // load the proper validator
                    if (LstrValue.EndsWith(".html") || LstrValue.EndsWith(".htm"))
                        LbolValidated = new ValidateOfficeJS(Encoding.Default.GetString(MobjDownloadedData)).Check();

                    string LstrReturnValue = string.Format("{0}: Resource {1} file - {2} @ {3}\n", 
                                                     (LbolVerified ? "SUCCESS" : "FAILED"),
                                                     MstrName, LstrId, LstrValue);
                    SendMessage(LstrReturnValue, LbolVerified);
                }
            }
            catch(Exception PobjEx)
            {
                PobjEx.Log("Unable to read resources section.");
            }
        }
    }
}
