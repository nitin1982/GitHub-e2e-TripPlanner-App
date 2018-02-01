namespace TripPlanner.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Document")]
    public partial class Document: BaseEntity
    {               

        [StringLength(50)]
        public string DocName { get; set; }

        [StringLength(500)]
        public string DocDesc { get; set; }

        [StringLength(500)]
        public string DocUrl { get; set; }

        public int? DocTypeID { get; set; }

        public int? TripID { get; set; }

        public virtual Reference DocType { get; set; }

        public virtual Trip Trip { get; set; }
    }
}
