namespace DYEREntity.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tlb_Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tlb_Student()
        {
            tbl_StudentRespondNotification = new HashSet<tbl_StudentRespondNotification>();
        }

        public int Id { get; set; }

        public int FacultyId { get; set; }

        public int? NewPhoneNumber { get; set; }

        public int HostID { get; set; }

        [Required]
        [StringLength(250)]
        public string Semester { get; set; }

        [Required]
        [StringLength(1000)]
        public string TypeOfDY { get; set; }

        public bool Arrival { get; set; }

        [Column(TypeName = "date")]
        public DateTime TimeStart { get; set; }

        [Column(TypeName = "date")]
        public DateTime TimeFinish { get; set; }

        [StringLength(2000)]
        public string ContactPerson { get; set; }

        public int? ContactNumber { get; set; }

        [StringLength(2000)]
        public string NextOfKin { get; set; }

        public int? KinNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedDay { get; set; }

        public int? CreatedByUserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UpdateDay { get; set; }

        public int? UpdateByUserID { get; set; }

        public bool Status { get; set; }

        [Required]
        [StringLength(128)]
        public string UsersId { get; set; }

        public virtual tbl_Faculty tbl_Faculty { get; set; }

        public virtual tbl_Host tbl_Host { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_StudentRespondNotification> tbl_StudentRespondNotification { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }

    }
}
