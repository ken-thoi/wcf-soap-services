using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Syndication;
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

        [WebInvoke(Method = "GET", UriTemplate = "/search?format={format}")]
        [ServiceKnownType(typeof(Atom10FeedFormatter))]
        [ServiceKnownType(typeof(List<StaffDto>))]
        Atom10FeedFormatter Search(string format);
    }
}
