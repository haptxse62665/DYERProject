namespace DYEREntity.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_DYC
    {
        public int Id { get; set; }

        public int FacultyId { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; }

        public int? CreatedByUserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UpdateDay { get; set; }

        public int? UpdateByUserID { get; set; }

        public bool Status { get; set; }

        [Required]
        [StringLength(128)]
        public string UsersId { get; set; }

        public virtual tbl_Faculty tbl_Faculty { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
