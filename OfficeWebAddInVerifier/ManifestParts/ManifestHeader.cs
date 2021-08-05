using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OfficeWebAddInVerifier.ManifestParts
{
    public class ManifestHeader : ManifestBase
    {
        public ManifestHeader(XmlDocument PobjDoc) : base(PobjDoc) { }

        /// <summary>
        /// Output the header information
        /// </summary>
        /// <returns></returns>
        public override void Run()
        {
            try
            {
                // OfficeApp/type & Id & Version & ProviderName & DisplayName & Description
                string LstrResult = string.Format("SUCCESS: Header information: {0} {1} | {2} | {3} | {4}",
                                                  ReadManifestProp("DisplayName", "DefaultValue", NamespaceSelected.none),
                                                  ReadManifestProp("Version"),
                                                  ReadManifestProp("OfficeApp", "type", NamespaceSelected.xsi),
                                                  ReadManifestProp("ProviderName"),
                                                  ReadManifestProp("Description", "DefaultValue", NamespaceSelected.none));
                SendMessage(LstrResult, true);
            }
            catch(Exception PobjEx)
            {
                PobjEx.Log("Unable to read manifest header.");
            }
        }
    }
}
