using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using WcfServicesApp.DataLayer;
using WcfServicesApp.DataLayer.DataContext;
using WcfServicesApp.WcfServiceLib.DataContract;
using WcfServicesApp.WcfServiceLib.Helpers;

namespace WcfServicesApp.WcfServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IMainService" in both code and config file together.
    public class MainService : IMainService
    {
        public List<StaffDto> GetAllStaffs()
        {
            var staffs = new StaffService().GetAllStaffs();
            Console.WriteLine($"Staffs all: {JsonConvert.SerializeObject(staffs)}");
            return MapperHelper.MapList<Staff, StaffDto>(staffs);
        }

        public StaffDto GetStaffById(string id)
        {
            var staff = new StaffService().GetStaffById(Convert.ToInt32(id));
            Console.WriteLine($"Staff by id = {id}: {JsonConvert.SerializeObject(staff)}");
            return MapperHelper.Map<Staff, StaffDto>(staff);
        }
        
        public StaffDto AddStaff(StaffDto staffDto)
        {
            var staff = MapperHelper.Map<StaffDto, Staff>(staffDto);
            staff = new StaffService().AddStaff(staff);
            Console.WriteLine($"Add new staff success: {JsonConvert.SerializeObject(staff)}");
            return MapperHelper.Map<Staff, StaffDto>(staff);
        }

    }
}
