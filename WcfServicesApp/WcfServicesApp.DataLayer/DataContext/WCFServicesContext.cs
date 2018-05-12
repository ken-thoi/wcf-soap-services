namespace WcfServicesApp.DataLayer.DataContext
{
    using System.Data.Entity;

    public partial class WCFServicesContext : DbContext
    {
        public WCFServicesContext()
            : base("name=WCFServicesContext")
        {
        }

        public virtual DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
