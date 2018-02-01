namespace TripPlanner.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Picture")]
    public partial class Picture:BaseEntity
    {
        [StringLength(50)]
        public string PicName { get; set; }

        [StringLength(500)]
        public string PicDesc { get; set; }

        [StringLength(500)]
        public string PicUrl { get; set; }

        public int? TripID { get; set; }

        public virtual Trip Trip { get; set; }
    }
}
