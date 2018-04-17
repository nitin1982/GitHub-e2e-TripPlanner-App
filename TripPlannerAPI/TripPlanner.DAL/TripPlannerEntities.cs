namespace TripPlanner.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TripPlannerEntities : DbContext
    {
        public TripPlannerEntities(string connString)
            : base(connString)
        {
        }

        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Reference> References { get; set; }
        public virtual DbSet<ReferenceCategory> ReferenceCategories { get; set; }
        public virtual DbSet<Stay> Stays { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<TripGroup> TripGroups { get; set; }
        public virtual DbSet<TripImportantDate> TripImportantDates { get; set; }
        public virtual DbSet<WebLink> WebLinks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>()
                .Property(e => e.DocName)
                .IsUnicode(false);

            modelBuilder.Entity<Document>()
                .Property(e => e.ID).HasColumnName("DocumentID");
            
            modelBuilder.Entity<Document>()
                .Property(e => e.DocDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Document>()
                .Property(e => e.DocUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Picture>()
                .Property(e => e.PicName)
                .IsUnicode(false);

            modelBuilder.Entity<Picture>()
                .Property(e => e.ID).HasColumnName("PictureID");
            
            modelBuilder.Entity<Picture>()
                .Property(e => e.PicDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Picture>()
                .Property(e => e.PicUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Reference>()
                .Property(e => e.RefName)
                .IsUnicode(false);

            modelBuilder.Entity<Reference>()
                .Property(e => e.ID).HasColumnName("ReferenceID");
            
            modelBuilder.Entity<Reference>()
                .Property(e => e.RefDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Reference>()
                .Property(e => e.RefCode)
                .IsUnicode(false);

            modelBuilder.Entity<Reference>()
                .HasMany(e => e.Documents)
                .WithOptional(e => e.DocType)
                .HasForeignKey(e => e.DocTypeID);

            modelBuilder.Entity<Reference>()
                .HasMany(e => e.Trips)
                .WithOptional(e => e.TripType)
                .HasForeignKey(e => e.TripTypeID);

            modelBuilder.Entity<Reference>()
                .HasMany(e => e.WebLinks)
                .WithOptional(e => e.WebLinkType)
                .HasForeignKey(e => e.WebLinkTypeID);

            modelBuilder.Entity<ReferenceCategory>()
                .Property(e => e.RefCatName)
                .IsUnicode(false);

            modelBuilder.Entity<ReferenceCategory>()
                .Property(e => e.RefCatDesc)
                .IsUnicode(false);

            modelBuilder.Entity<ReferenceCategory>()
                .Property(e => e.RefCatCode)
                .IsUnicode(false);

            modelBuilder.Entity<ReferenceCategory>()
                .Property(e => e.ID).HasColumnName("ReferenceCategoryID");


            modelBuilder.Entity<Trip>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Trip>()
                .Property(e => e.Detail)
                .IsUnicode(false);

            modelBuilder.Entity<Trip>()
                .Property(e => e.Place)
                .IsUnicode(false);

            modelBuilder.Entity<Trip>()
                .Property(e => e.ID).HasColumnName("TripID");

            modelBuilder.Entity<TripImportantDate>()
                .Property(e => e.Detail)
                .IsUnicode(false);

            modelBuilder.Entity<TripImportantDate>()
               .Property(e => e.ID).HasColumnName("TripImportantDateID");

            modelBuilder.Entity<WebLink>()
                .Property(e => e.WebLinkName)
                .IsUnicode(false);
            
            modelBuilder.Entity<WebLink>()
                .Property(e => e.WebURL)
                .IsUnicode(false);

            modelBuilder.Entity<WebLink>()
                .Property(e => e.ID).HasColumnName("WebLinkID");

            modelBuilder.Entity<TripGroup>()
                .Property(e => e.GroupTitle)
                .IsUnicode(false);

            modelBuilder.Entity<TripGroup>()
                .Property(e => e.GroupDetail)
                .IsUnicode(false);

            modelBuilder.Entity<TripGroup>()
                .Property(e => e.ID).HasColumnName("TripGroupID");

            modelBuilder.Entity<Stay>()
               .Property(e => e.HotelName)
               .IsUnicode(false);

            modelBuilder.Entity<Stay>()
               .Property(e => e.ID).HasColumnName("StayID");

            modelBuilder.Entity<Trip>()
                .Property(e => e.Place)
                .IsUnicode(false);

            modelBuilder.Entity<Stay>()
                .Property(e => e.HotelName)
                .IsUnicode(false);

            modelBuilder.Entity<Stay>()
                .Property(e => e.Street1)
                .IsUnicode(false);

            modelBuilder.Entity<Stay>()
                .Property(e => e.Street2)
                .IsUnicode(false);

            modelBuilder.Entity<Stay>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Stay>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Stay>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<Stay>()
                .Property(e => e.ContactNo1)
                .IsUnicode(false);

            modelBuilder.Entity<Stay>()
                .Property(e => e.ContactNo2)
                .IsUnicode(false);

            modelBuilder.Entity<Stay>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Stay>()
                .Property(e => e.ContactPersonFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Stay>()
                .Property(e => e.ContactPersonMiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Stay>()
                .Property(e => e.ContactPersonLastName)
                .IsUnicode(false);

            modelBuilder.Entity<Stay>()
                .Property(e => e.Website)
                .IsUnicode(false);
        }
    }
}
