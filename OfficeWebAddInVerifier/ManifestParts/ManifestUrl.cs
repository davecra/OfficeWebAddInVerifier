using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using OfficeWebAddInVerifier.Validators;

namespace OfficeWebAddInVerifier.ManifestParts
{
    public class ManifestUrl : ManifestBase
    {
        public enum UrlType { Image, TaskPane, Dialog, Html, JS, Unknown };
        private string MstrUrl = "";
        private string MstrName = "";
        private UrlType MobjType = UrlType.Unknown;
        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="PobjDoc"></param>
        /// <param name="PstrUrlName"></param>
        public ManifestUrl(XmlDocument PobjDoc, string PstrUrlName, UrlType PobjType) : base(PobjDoc) 
        {
            MstrName = PstrUrlName;
            MstrUrl = ReadManifestProp(MstrName, "DefaultValue", NamespaceSelected.none);
            MobjType = PobjType;
        }
        /// <summary>
        /// Output the result
        /// </summary>
        /// <returns></returns>
        public override void Run()
        {
            try
            {
                if (string.IsNullOrEmpty(MstrUrl))
                {
                    SendMessage("INVALID URL VALUE: " + MstrName, false);
                }
                // test to see if we can access
                if (AccessUrl(MstrUrl))
                {
                    SendMessage("SUCCESS accessing " + MstrName + " at " + MstrUrl, true);
                    bool LbolValidatedType = false;
                    switch(MobjType)
                    {
                        case UrlType.TaskPane:
                        case UrlType.Dialog:
                            // check for taskpane information
                            LbolValidatedType = new ValidateOfficeJS(Encoding.Default.GetString(MobjDownloadedData)).Check();
                            break;
                        case UrlType.Html:
                            // check to make sure it is valid HTMNL
                            LbolValidatedType = new ValidateHtml(Encoding.Default.GetString(MobjDownloadedData)).Check();
                            break;
                        case UrlType.JS:
                            // check to make sure it is valid javascript
                            LbolValidatedType = new ValidateJS(Encoding.Default.GetString(MobjDownloadedData)).Check();
                            break;
                        case UrlType.Image:
                            LbolValidatedType = new ValidateImage(MobjDownloadedData).Check();
                            break;
                        case UrlType.Unknown:
                            LbolValidatedType = true;
                            // unknown - so we just return truel
                            break;
                    }

                    if (LbolValidatedType)
                    {
                        SendMessage("SUCCESS validating " + MstrName + ". Is valid " + MobjType.ToString() + ".", true);
                    }
                    else
                    {
                        SendMessage("FAILED validating " + MstrName + ". Not valid " + MobjType.ToString() + " type.", false);
                    }
                }
                else
                {
                    SendMessage("FAILED accessing " + MstrName + " at " + MstrUrl,false);
                }
            }
            catch(Exception PobjEx)
            {
                PobjEx.Log("Unable to verify URL.");
            }
        }
    }
}
