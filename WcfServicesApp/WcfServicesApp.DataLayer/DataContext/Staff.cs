namespace WcfServicesApp.DataLayer.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Staff")]
    public partial class Staff
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        public DateTime? BirthOfDay { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Descriptions { get; set; }
    }
}
