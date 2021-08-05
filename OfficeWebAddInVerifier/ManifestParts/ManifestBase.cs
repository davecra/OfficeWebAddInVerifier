using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OfficeWebAddInVerifier.ManifestParts
{
    public abstract class ManifestBase : IManifestInterface
    {
        public delegate void OutputHandler(object PobjSender, OutputHandlerArgs PobjArgs);
        public event OutputHandler OutputMessage;
        protected enum NamespaceSelected { xsi, bt, none };
        protected XmlDocument MobjDoc;
        protected XmlNamespaceManager MobjNSMgr;
        protected List<string> MobjOutput = new List<string>();
        protected byte[] MobjDownloadedData;
        /// <summary>
        /// BASE CTOR
        /// Defines the namespaces being used
        /// </summary>
        /// <param name="PobjDoc"></param>
        public ManifestBase(XmlDocument PobjDoc)
        {
            MobjDoc = PobjDoc;
            MobjNSMgr = new XmlNamespaceManager(MobjDoc.NameTable);
            MobjNSMgr.AddNamespace("", "http://schemas.microsoft.com/office/appforoffice/1.1");
            MobjNSMgr.AddNamespace("mailappor", "http://schemas.microsoft.com/office/mailappversionoverrides/1.0");
            MobjNSMgr.AddNamespace("bt", "http://schemas.microsoft.com/office/officeappbasictypes/1.0");
            MobjNSMgr.AddNamespace("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            MobjNSMgr.AddNamespace("ns", "http://schemas.microsoft.com/office/mailappversionoverrides");
        }
        /// <summary>
        /// Global message handler for raising generic message events
        /// </summary>
        /// <param name="PstrMessage"></param>
        protected void SendMessage(string PstrMessage, bool PbolIsSuccess)
        {
            if (OutputMessage != null) OutputMessage(this, new OutputHandlerArgs(PstrMessage, PbolIsSuccess));
        }
        public virtual void Run() { }
        //public List<string> Output() { return MobjOutput; }
        /// <summary>
        /// Returns the namespace based on the selected enum value
        /// </summary>
        /// <param name="PobjNs"></param>
        /// <returns></returns>
        private string GetNamespace(NamespaceSelected PobjNs)
        {
            switch(PobjNs)
            {
                case NamespaceSelected.xsi: return "http://www.w3.org/2001/XMLSchema-instance";
                case NamespaceSelected.bt: return "http://schemas.microsoft.com/office/officeappbasictypes/1.0";
                case NamespaceSelected.none: return "";
                default: return "";
            }
        }
        /// <summary>
        /// Accesses the URL given, returns true if it can be accessed
        /// </summary>
        /// <param name="PstrUrl"></param>
        /// <returns></returns>
        protected bool AccessUrl(string PstrUrl)
        {
            try
            {
                string LstrLocalTemp = Path.GetTempFileName();
                using (var client = new WebClient())
                {
                    // download the data so we can access it later
                    MobjDownloadedData = client.DownloadData(PstrUrl);
                    return true;
                }
            }
            catch
            {
                return false; // failed
            }
        }
        /// <summary>
        /// OVERRIDE: Reads the property from the manifest file 
        /// </summary>
        /// <param name="PstrField"></param>
        /// <returns></returns>
        protected string ReadManifestProp(string PstrField)
        {
            return MobjDoc.GetElementsByTagName(PstrField)
                          .Item(0).InnerText;
        }
        /// <summary>
        /// OVERRIDE: Reads a property/attribute from the manifest file
        /// </summary>
        /// <param name="PstrField"></param>
        /// <param name="PstrAttribute"></param>
        /// <param name="PobjNs"></param>
        /// <returns></returns>
        protected string ReadManifestProp(string PstrField, string PstrAttribute, NamespaceSelected PobjNs)
        {
            try
            {
                if (PobjNs != NamespaceSelected.none)
                {
                    return MobjDoc.GetElementsByTagName(PstrField)
                                  .Item(0)
                                  .Attributes
                                  .GetNamedItem(PstrAttribute, GetNamespace(PobjNs)).Value;
                } 
                else
                {
                    return MobjDoc.GetElementsByTagName(PstrField)
                                  .Item(0)
                                  .Attributes
                                  .GetNamedItem(PstrAttribute).Value;
                }
            }
            catch
            {
                return "";
            }
        }
    }
}
