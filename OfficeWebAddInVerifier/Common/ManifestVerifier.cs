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
        public string ManifestPath { get; private set; }
        public string ManifestXml { get; private set; }
        public List<string> Files { get; private set; }
        private XmlDocument MobjManifestDoc;

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="PobjFilePath"></param>
        public ManifestVerifier(string PstrManifest, List<string> PobjFiles)
        {
            if (System.IO.File.Exists(PstrManifest))
            {
                ManifestPath = PstrManifest;
                LoadManifestFromFile();
            }
            else
            {
                ManifestXml = PstrManifest;
                LoadManifestFromXml();
            }
            Files = PobjFiles;
        }

        /// <summary>
        /// Loads the manifest from the raw XML
        /// </summary>
        public void LoadManifestFromXml()
        {
            MobjManifestDoc = new XmlDocument();
            MobjManifestDoc.LoadXml(ManifestXml);
        }

        /// <summary>
        /// Loads the manifest from the file path
        /// </summary>
        public void LoadManifestFromFile()
        {
            MobjManifestDoc = new XmlDocument();
            MobjManifestDoc.Load(ManifestPath);
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

                ManifestCheckType("Manifest loaded, reading header...",
                                  new ManifestHeader(MobjManifestDoc));
                ManifestCheckType("Confirming IconUrl...",
                                  new ManifestUrl(MobjManifestDoc, "IconUrl", ManifestUrl.UrlType.Image));
                ManifestCheckType("Confirming HighResolutionIconUrl...",
                                  new ManifestUrl(MobjManifestDoc, "HighResolutionIconUrl", ManifestUrl.UrlType.Image));
                ManifestCheckType("Confirming SupportUrl...",
                                  new ManifestUrl(MobjManifestDoc, "SupportUrl", ManifestUrl.UrlType.Html));
                ManifestUrl LobjManifestBaseUrl = new ManifestUrl(MobjManifestDoc, "SourceLocation", ManifestUrl.UrlType.TaskPane);
                ManifestCheckType("Confirming SourceLocation...", LobjManifestBaseUrl);
                ManifestCheckType("Confirming all Resource Images...",
                                  new ManifestResources(MobjManifestDoc, "//bt:Images/bt:Image", "Images"));
                ManifestCheckType("Confirming all Resource Urls...",
                                  new ManifestResources(MobjManifestDoc, "//bt:Urls/bt:Url", "Url"));
                ManifestCheckType("Confirming all files in solution...", 
                                  new ManifestFiles(MobjManifestDoc, LobjManifestBaseUrl.BaseUrl, Files));
                ///ManifestCheckType("Confirming Exchange.asmx connection...", new ...);
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
