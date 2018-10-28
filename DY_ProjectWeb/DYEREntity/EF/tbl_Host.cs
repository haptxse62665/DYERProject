namespace DYEREntity.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Host
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Host()
        {
            tlb_Student = new HashSet<tlb_Student>();
            tbl_UserSendNotification = new HashSet<tbl_UserSendNotification>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(2000)]
        public string HostName { get; set; }

        [Required]
        [StringLength(3000)]
        public string Location { get; set; }

        public int CountryID { get; set; }

        [Required]
        [StringLength(1000)]
        public string Email { get; set; }

        [Required]
        public string ContactNumber { get; set; }

        [StringLength(2100)]
        public string Image { get; set; }

        [Required]
        [StringLength(2000)]
        public string Type { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; }

        public int? CreatedByUserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UpdateDay { get; set; }

        public int? UpdateByUserID { get; set; }

        public bool Status { get; set; }

        public virtual tbl_Country tbl_Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tlb_Student> tlb_Student { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_UserSendNotification> tbl_UserSendNotification { get; set; }
    }
}
