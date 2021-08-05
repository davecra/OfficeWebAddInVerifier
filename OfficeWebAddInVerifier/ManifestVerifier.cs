using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using OfficeWebAddInVerifier.ManifestParts;

namespace OfficeWebAddInVerifier
{
    public class ManifestVerifier
    {
        public delegate void LogEventDelegate(object PobjSender, OutputHandlerArgs PobjEvent);
        public event LogEventDelegate LogEvent;
        public delegate void NotificationDelegate(object PobjSender, NotifyEventArgs PobjEvent);
        public event NotificationDelegate NotificationEvent;
        public string FailDescription { get; private set; }
        public string Manifest { get; private set; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="PobjFilePath"></param>
        public ManifestVerifier(string PstrFilePath)
        {
            Manifest = PstrFilePath;
        }

        /// <summary>
        /// Checks the manifest file
        /// </summary>
        /// <returns></returns>
        public bool Check()
        {
            try
            {
                // open the manifest and get the URL's from it...
                XmlDocument LobjDoc = new XmlDocument();
                LobjDoc.Load(Manifest);
                ManifestCheckType("Manifest loaded, reading header...",
                                  new ManifestHeader(LobjDoc));
                ManifestCheckType("Confirming IconUrl...",
                                  new ManifestUrl(LobjDoc, "IconUrl", ManifestUrl.UrlType.Image));
                ManifestCheckType("Confirming HighResolutionIconUrl...",
                                  new ManifestUrl(LobjDoc, "HighResolutionIconUrl", ManifestUrl.UrlType.Image));
                ManifestCheckType("Confirming SupportUrl...",
                                  new ManifestUrl(LobjDoc, "SupportUrl", ManifestUrl.UrlType.Html));
                ManifestCheckType("Confirming SourceLocation...",
                                  new ManifestUrl(LobjDoc, "SourceLocation", ManifestUrl.UrlType.TaskPane));
                ManifestCheckType("Confirming all Resource Images...",
                                  new ManifestResources(LobjDoc, "//bt:Images/bt:Image", "Images"));
                ManifestCheckType("Confirming all Resource Urls...",
                                  new ManifestResources(LobjDoc, "//bt:Urls/bt:Url", "Url"));
                //ManifestCheckType("Confirming all files in solution...", new ...);
                ///ManifestCheckType("Confirming Exchange.asmx connection...", new ...);
                //ManifestCheckType("...", new ...); // done - reset
                return true; // success
            }
            catch(Exception PobjEx)
            {
                FailDescription = "General unknown failure. " + PobjEx.Message;
                return false;
            }
        }

        /// <summary>
        /// Primary generic handler for all checks
        /// </summary>
        /// <param name="PobjManifestCheck"></param>
        private void ManifestCheckType(string PstrNotification, ManifestBase PobjManifestCheck)
        {
            // send notification
            if (NotificationEvent != null) NotificationEvent(this, new NotifyEventArgs(PstrNotification));
            // connect to sub-class output event
            PobjManifestCheck.OutputMessage += (o, e) =>
            {
                // and then log messages from the sub-class to the caller
                if (LogEvent != null) LogEvent(this, e);
            };
            // now run the check
            PobjManifestCheck.Run();
        }
    }
}
