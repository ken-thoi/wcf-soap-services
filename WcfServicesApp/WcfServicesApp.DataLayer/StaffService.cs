using System.Collections.Generic;
using System.Linq;
using WcfServicesApp.DataLayer.DataContext;

namespace WcfServicesApp.DataLayer
{
    public class StaffService
    {
        public List<Staff> GetAllStaffs()
        {
            var context = new WCFServicesContext();
            var staffs = context.Staffs.ToList();
            context.Dispose();
            return staffs;
        }

        public Staff GetStaffById(int id)
        {
            var context = new WCFServicesContext();
            var staff = context.Staffs.SingleOrDefault(c => c.Id == id);
            context.Dispose();
            return staff;
        }

        public Staff AddStaff(Staff staff)
        {
            var context = new WCFServicesContext();
            context.Staffs.Add(staff);
            context.SaveChanges();
            context.Dispose();
            return staff;
        }
    }
}
