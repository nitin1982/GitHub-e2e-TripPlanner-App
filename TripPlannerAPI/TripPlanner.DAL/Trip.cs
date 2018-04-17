namespace TripPlanner.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trip")]
    public partial class Trip: BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trip()
        {
            Documents = new HashSet<Document>();
            Pictures = new HashSet<Picture>();
            Stays = new HashSet<Stay>();
            TripImportantDates = new HashSet<TripImportantDate>();
            WebLinks = new HashSet<WebLink>();
        }
        
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(1000)]
        public string Detail { get; set; }

        [StringLength(30)]
        public string Place { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? TripTypeID { get; set; }

        public int? TripGroupID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Document> Documents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Picture> Pictures { get; set; }

        public virtual Reference TripType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stay> Stays { get; set; }

        public virtual TripGroup TripGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TripImportantDate> TripImportantDates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WebLink> WebLinks { get; set; }
    }
}
