using Newtonsoft.Json;
using System;
using System.ServiceModel.Activation;
using WcfServicesApp.DataLayer;
using WcfServicesApp.DataLayer.DataContext;
using WcfServicesApp.DataLayer.DataContract;
using WcfServicesApp.DataLayer.Helpers;

namespace WcfServicesApp.WcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "KenService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select KenService.svc or KenService.svc.cs at the Solution Explorer and start debugging.

    // The attribute AspNetCompabilityRequirements is used for specifying an ASP.NET compatible environment for WCF service execution.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class KenService : IKenService
    {
        public StaffDto[] GetAllStaffs()
        {
            var staffs = new StaffService().GetAllStaffs();
            Console.WriteLine($"Staffs all: {JsonConvert.SerializeObject(staffs)}");
            var result = MapperHelper.MapList<Staff, StaffDto>(staffs);
            return result.ToArray();
        }

        public StaffDto[] GetAllStaffsByJson()
        {
            var staffs = new StaffService().GetAllStaffs();
            Console.WriteLine($"Staffs all: {JsonConvert.SerializeObject(staffs)}");
            var result = MapperHelper.MapList<Staff, StaffDto>(staffs);
            return result.ToArray();
        }
    }
}