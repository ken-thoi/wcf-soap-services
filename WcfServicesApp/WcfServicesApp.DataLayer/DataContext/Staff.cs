namespace WcfServicesApp.DataLayer.DataContext
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

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

        [StringLength(50)]
        public string ExternalLink { get; set; }

        public DateTime? Modified { get; set; }

        public DateTime? Created { get; set; }
    }
}
