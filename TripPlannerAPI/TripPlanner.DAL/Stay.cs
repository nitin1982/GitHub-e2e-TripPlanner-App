namespace TripPlanner.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stay")]
    public partial class Stay: BaseEntity
    {
        [StringLength(50)]
        public string HotelName { get; set; }

        [StringLength(50)]
        public string Street1 { get; set; }

        [StringLength(50)]
        public string Street2 { get; set; }

        [StringLength(15)]
        public string City { get; set; }

        [StringLength(10)]
        public string State { get; set; }

        [StringLength(5)]
        public string Zip { get; set; }

        [StringLength(10)]
        public string ContactNo1 { get; set; }

        [StringLength(10)]
        public string ContactNo2 { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(20)]
        public string ContactPersonFirstName { get; set; }

        [StringLength(20)]
        public string ContactPersonMiddleName { get; set; }

        [StringLength(20)]
        public string ContactPersonLastName { get; set; }

        [StringLength(80)]
        public string Website { get; set; }

        public int? TripID { get; set; }

        public virtual Trip Trip { get; set; }
    }
}
