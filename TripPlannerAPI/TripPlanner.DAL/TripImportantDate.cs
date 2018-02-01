namespace TripPlanner.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TripImportantDate")]
    public partial class TripImportantDate:BaseEntity
    {
        

        public int? TripID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ImpDate { get; set; }

        [StringLength(500)]
        public string Detail { get; set; }

        public bool? SetScreenRemider { get; set; }

        public virtual Trip Trip { get; set; }
    }
}
