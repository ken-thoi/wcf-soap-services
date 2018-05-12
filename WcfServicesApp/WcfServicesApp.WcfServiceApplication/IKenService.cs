using System.ServiceModel;
using System.ServiceModel.Web;
using WcfServicesApp.DataLayer.DataContract;

/// <summary>
/// A new WCF service application
/// </summary>
namespace WcfServicesApp.WcfServiceApplication
{
    [ServiceContract]
    public interface IKenService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/Staffs", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        StaffDto[] GetAllStaffs();

        [OperationContract]
        [WebGet(UriTemplate = "/StaffsByJson", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        StaffDto[] GetAllStaffsByJson();
    }
}
