namespace DYEREntity.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_StudentRespondNotification
    {
        public int ID { get; set; }

        public int StudentID { get; set; }

        [Column(TypeName = "date")]
        public DateTime TimeRequest { get; set; }

        [Required]
        [StringLength(1000)]
        public string Coordinate { get; set; }

        [Column(TypeName = "date")]
        public DateTime DateCreated { get; set; }

        public int? CreatedByUserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UpdateDay { get; set; }

        public int? UpdateByUserID { get; set; }

        public bool Status { get; set; }

        public virtual tlb_Student tlb_Student { get; set; }
    }
}
