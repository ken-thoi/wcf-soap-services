using CallSoapVb6.HVNServiceReference;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using WcfServicesApp.ClientApp;

namespace CallSoapVb6
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();
            DataTable dt1 = DataTableHelper.ToDataTable<Order>(new List<Order> { new Order() }, "Table1");
            DataTable dt2 = DataTableHelper.ToDataTable<OrderDetails>(new List<OrderDetails> { new OrderDetails() }, "Table2");
            ds.Tables.Add(dt1);
            ds.Tables.Add(dt2);
            string schemaString = ds.GetXmlSchema();
            StreamWriter xmlSW = new StreamWriter("ds.order1.xml", true, Encoding.UTF8);
            ds.WriteXml(xmlSW, XmlWriteMode.WriteSchema);
            xmlSW.Close();

            var xmlString = XMLSerializer.ToXmlData(ds);

            string err = "";
            bool showScreen = false;

            var client = new DMSSSA_ServiceSoapClient().GUI_DON_HANG(ref ds, "HUELOC1", "HVNL1069", "frmDMSC01", "22004", "Honda@2018", "22004", ref err, ref showScreen);
        }
    }
}
