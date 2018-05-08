using System;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Linq;

namespace WcfServicesApp.ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Output";

            CallRestfulService();
            ClientReq.CallWebService();

            Console.ReadKey();
            Console.ReadLine();
        }

        static void CallTcpEndPoint()
        {
            //ServiceClient client = new ServiceClient();
            //var staffs = client.GetAllStaffs();
        }

        /// <summary>
        /// Call rest soap service
        /// </summary>
        static void CallRestfulService()
        {
            WebRequest request = WebRequest.Create("http://localhost:8787/WcfServicesApp.WcfServiceLib/MainService/rest/staffs/4");
            WebResponse ws = request.GetResponse();
            Encoding enc = Encoding.GetEncoding(1252);
            StreamReader responseStream = new StreamReader(ws.GetResponseStream());
            string response = responseStream.ReadToEnd();
            responseStream.Close();
            
            Console.WriteLine(XDocument.Parse(response));
        }
    }
}
