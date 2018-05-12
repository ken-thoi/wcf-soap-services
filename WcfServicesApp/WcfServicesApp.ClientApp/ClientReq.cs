using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace WcfServicesApp.ClientApp
{
    public static class ClientReq
    {
        public static void CallWebService()
        {
            var _url = "http://dms-test.honda.com.vn/DMSSSA_Service.asmx?op=GUI_DON_HANG";
            var _action = "http://tempuri.org/GUI_DON_HANG";
            var _host = "dms-test.honda.com.vn";

            XmlDocument soapEnvelopeXml = CreateSoapEnvelope();
            HttpWebRequest webRequest = CreateWebRequest(_host, _url, _action);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            // begin async call to web request.
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            // suspend this thread until call is complete. You might want to
            // do something usefull here like update your UI.
            asyncResult.AsyncWaitHandle.WaitOne();

            // get the response from the completed web request.
            string soapResult;

            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (var rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }
                Console.WriteLine(XDocument.Parse(soapResult));
            }
        }

        /// <summary>
        /// Init web request
        /// </summary>
        /// <param name="url"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        private static HttpWebRequest CreateWebRequest(string host, string url, string action)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Host = host;
            webRequest.Headers.Add("SOAPAction", action);
            webRequest.ContentType = @"text/xml; charset=utf-8";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            webRequest.Accept = "*/*";
            return webRequest;
        }

        /// <summary>
        /// SOAP Envelope Document: body info
        /// </summary>
        /// <returns></returns>
        private static XmlDocument CreateSoapEnvelope()
        {
            // read from file
            string path = Path.Combine($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\XML\\EnvelopeBody.xml");
            // Read the file as one string.
            string xmlReader = File.ReadAllText(path);
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = File.ReadAllLines($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\XML\\EnvelopeBody.xml");

            // insert into XML Document
            var soapEnvelopeDocument = new XmlDocument();
            soapEnvelopeDocument.LoadXml(xmlReader.ToString());
            return soapEnvelopeDocument;
        }

        /// <summary>
        /// Insert SOAP Envelope into WebRequest
        /// </summary>
        /// <param name="soapEnvelopeXml"></param>
        /// <param name="webRequest"></param>
        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }
    }
}
