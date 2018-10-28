namespace DYEREntity.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_UserSendNotification
    {
        public int ID { get; set; }

        [Required]
        [StringLength(128)]
        public string UsersId { get; set; }

        [Required]
        public string TitleNotification { get; set; }

        [Required]
        public string ContentNotification { get; set; }

        public int HostID { get; set; }

        [StringLength(128)]
        public string LevelEmergency { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }

        [StringLength(128)]
        public string CreateByUserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UpdateDay { get; set; }

        [StringLength(128)]
        public string UpdateByUserID { get; set; }

        public bool Status { get; set; }

        public virtual tbl_Host tbl_Host { get; set; }

        public virtual tbl_Users tbl_Users { get; set; }
    }
}
