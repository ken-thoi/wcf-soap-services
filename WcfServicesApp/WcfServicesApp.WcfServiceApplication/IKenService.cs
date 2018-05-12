using System.ServiceModel;
using System.ServiceModel.Web;
using WcfServicesApp.DataLayer.DataContract;
using System;

/// <summary>
/// A new WCF service application
/// </summary>
namespace WcfServicesApp.WcfServiceApplication
{
    [ServiceContract]
    public interface IKenService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/Employees", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        StaffDto[] GetAllStaffs();
    }
}
