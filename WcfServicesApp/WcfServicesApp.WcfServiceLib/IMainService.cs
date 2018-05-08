using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using WcfServicesApp.DataLayer.DataContract;

/// <summary>
/// a new WCF service library
/// </summary>
namespace WcfServicesApp.WcfServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change 
    // the interface name "IMainService" in both code and config file together.
    [ServiceContract]
    public interface IMainService
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/staffs", Method = "GET")]
        List<StaffDto> GetAllStaffs();

        [OperationContract]
        [WebInvoke(UriTemplate = "/staffs/{id}", Method = "GET")]
        StaffDto GetStaffById(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/staffs/add", Method = "POST")]
        StaffDto AddStaff(StaffDto staffDto);
    }
}
