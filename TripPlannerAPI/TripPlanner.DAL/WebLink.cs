namespace TripPlanner.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebLink")]
    public partial class WebLink:BaseEntity
    {
        [StringLength(150)]
        public string WebLinkName { get; set; }

        [StringLength(150)]
        public string WebURL { get; set; }

        public int? WebLinkTypeID { get; set; }

        public int? TripID { get; set; }

        public virtual Reference WebLinkType { get; set; }

        public virtual Trip Trip { get; set; }
    }
}
