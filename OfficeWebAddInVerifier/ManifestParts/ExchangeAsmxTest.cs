using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Reflection;

namespace OfficeWebAddInVerifier.ManifestParts
{
    public class ExchangeAsmxTest : ManifestBase
    {
        private string MstrUrl = String.Empty;
        private string MstrError = String.Empty;
        private NetworkCredential MobjCreds = null;
        public ExchangeAsmxTest(XmlDocument PobjDoc, string PstrUrl, NetworkCredential PobjCreds) : base(PobjDoc) 
        {
            MstrUrl = PstrUrl;
            MobjCreds = PobjCreds;
        }
        /// <summary>
        /// This function will attempt to access the URL
        /// 1) Verify we can ping it
        /// 2) Download the ASMX contents and verify that they are valid
        /// 3) Try a call to the server with SOAP
        /// </summary>
        public override void Run()
        {
            try
            {
                bool LbolVerified = false;
                LbolVerified = PingServer();
                // FIRST - connect to the website
                string LstrReturnValue = string.Format("{0}: Ping website {1}. {2}\n",
                                            (LbolVerified ? "SUCCESS" : "FAILED"),
                                             MstrUrl, 
                                            (!LbolVerified ? MstrError : ""));
                SendMessage(LstrReturnValue, LbolVerified);

                // NEXT - verify the contents of the website is an ASMX page
                LbolVerified = AccessAsmxPage();
                LstrReturnValue = string.Format("{0}: Access to ASMX page. {1}\n",
                                    (LbolVerified ? "SUCCESS" : "FAILED"), 
                                    (!LbolVerified ? MstrError : ""));
                SendMessage(LstrReturnValue, LbolVerified);

                // FINALLY - verify a connection with SOAP
                LbolVerified = IssueEwsCall();
                LstrReturnValue = string.Format("{0}: Verify EWS Connection to {1}. {2}\n",
                                    (LbolVerified ? "SUCCESS" : "FAILED"),
                                    MstrUrl,
                                    (!LbolVerified ? MstrError : ""));
                SendMessage(LstrReturnValue, LbolVerified);
                // all done
            }
            catch(Exception PobjEx)
            {
                PobjEx.Log("Unable to verify Exchange connection.");
            }
        }
        /// <summary>
        /// Contacts the server to verify it is online
        /// </summary>
        /// <returns></returns>
        private bool PingServer()
        {
            bool LbolSuccess = false;
            Ping LobjPinger = null;

            try
            {
                // strip the servername from the url
                Uri LobjUri = new Uri(MstrUrl);
                LobjPinger = new Ping();
                PingReply reply = LobjPinger.Send(LobjUri.Host);
                LbolSuccess = reply.Status == IPStatus.Success;
            }
            catch (PingException) { }
            catch(Exception PobjEx)
            {
                MstrError = PobjEx.Message;
            }
            finally
            {
                if (LobjPinger != null)
                {
                    LobjPinger.Dispose();
                }
            }

            return LbolSuccess;
        }

        /// <summary>
        /// Connects the the server ASMX page
        /// </summary>
        private bool AccessAsmxPage()
        {
            try
            {
                WebClient LobjClient = new WebClient();
                LobjClient.Credentials = MobjCreds;
                string LstrHtmlPage = LobjClient.DownloadString(MstrUrl);
                XmlDocument LobjDoc = new XmlDocument();
                LobjDoc.LoadXml(LstrHtmlPage);
                XmlNodeList LobjElems = LobjDoc.GetElementsByTagName("PRE");
                if (LobjElems != null && LobjElems.Count > 0 &&
                    LobjElems[0].InnerText.StartsWith("svcutil.exe https://")) 
                {
                    return true;
                } 
                else
                {
                    return false;
                }
            }
            catch(Exception PobjEx)
            {
                MstrError = PobjEx.Message;
                return false;
            }
        }
        /// <summary>
        /// Sends an ews request to the server to get the total number of
        /// items in the mailbox, it will use the current users credentials
        /// or it will use the credentials provided
        /// </summary>
        /// <returns></returns>
        private bool IssueEwsCall()
        {
            /// This is the XML request that is sent to the Exchange server.
            string LstrGetFolderSOAPRequest = OfficeWebAddInVerifier.Properties.Resources.getFolder;
            // Write the get folder operation request to the console and log file.
            HttpWebRequest LobjGetFolderRequest = WebRequest.CreateHttp(MstrUrl);
            LobjGetFolderRequest.AllowAutoRedirect = false;
            LobjGetFolderRequest.Credentials = MobjCreds;
            LobjGetFolderRequest.Method = "POST";
            LobjGetFolderRequest.ContentType = "text/xml";
            StreamWriter LobjRequestWriter = new StreamWriter(LobjGetFolderRequest.GetRequestStream());
            LobjRequestWriter.Write(LstrGetFolderSOAPRequest);
            LobjRequestWriter.Close();
            try
            {
                HttpWebResponse LstrGetFolderResponse = (HttpWebResponse)(LobjGetFolderRequest.GetResponse());
                if (LstrGetFolderResponse.StatusCode == HttpStatusCode.OK)
                {
                    StreamReader LobjStream = new StreamReader(LstrGetFolderResponse.GetResponseStream());
                    XmlDocument LobjDoc = new XmlDocument();
                    LobjDoc.LoadXml(LobjStream.ReadToEnd());
                    if (LobjDoc != null)
                    {
                        XmlNodeList LobjElems = LobjDoc.GetElementsByTagName("m:ResponseCode");
                        if(LobjElems == null || LobjElems.Count == 0) throw new Exception("Invalid response details.");
                        if(LobjElems[0].InnerText != "NoError") throw new Exception("Error response details.");
                        // if we are here - all good
                        return true;
                    }
                    else
                    {
                        throw new Exception("Invalid server response.");
                    }
                }
                else
                {
                    throw new Exception("Server responded with invalid code: " + LstrGetFolderResponse.StatusCode);
                }
            }
            catch (WebException ex)
            {
                MstrError = "Web exception: " + ex.Message;
                return false;
            }
            catch (ApplicationException ex)
            {
                MstrError = "Application exception: " + ex.Message;
                return false;
            }
            catch(Exception ex)
            {
                MstrError = ex.Message;
                return false;
            }
        }
    }
}
