namespace RiderLiNC.Azure.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    // ReSharper disable once InconsistentNaming
    public partial class RiderLiNCAzure : DbContext
    {
        public RiderLiNCAzure()
            : base("name=RiderLiNC_Azure_Model")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Broadcast> Broadcasts { get; set; }
        public virtual DbSet<BroadcastType> BroadcastTypes { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<DeviceOSType> DeviceOSTypes { get; set; }
        public virtual DbSet<DeviceType> DeviceTypes { get; set; }
        public virtual DbSet<Rank> Ranks { get; set; }
        public virtual DbSet<Rider> Riders { get; set; }
        public virtual DbSet<RouteDataType> RouteDataTypes { get; set; }
        public virtual DbSet<ServiceLog> ServiceLogs { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        public virtual DbSet<SocialMedia> SocialMedias { get; set; }
        //public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<TourGroup> TourGroups { get; set; }
        public virtual DbSet<TourGroupWaypoint> TourGroupWaypoints { get; set; }
        public virtual DbSet<TourRider> TourRiders { get; set; }
        public virtual DbSet<TourRoute> TourRoutes { get; set; }
        public virtual DbSet<Transport> Transports { get; set; }
        public virtual DbSet<TransportType> TransportTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BroadcastType>()
                .HasMany(e => e.Broadcasts)
                .WithRequired(e => e.BroadcastType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DeviceType>()
                .HasMany(e => e.Devices)
                .WithRequired(e => e.DeviceType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DeviceType>()
                .HasOptional(e => e.DeviceType1)
                .WithRequired(e => e.DeviceType2);

            modelBuilder.Entity<Rank>()
                .HasMany(e => e.Riders)
                .WithRequired(e => e.Rank)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rider>()
                .Property(e => e.Culture)
                .IsUnicode(false);

            modelBuilder.Entity<Rider>()
                .HasMany(e => e.Broadcasts)
                .WithRequired(e => e.Rider)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rider>()
                .HasMany(e => e.TourGroups)
                .WithOptional(e => e.Rider)
                .HasForeignKey(e => e.LeadRiderId);

            modelBuilder.Entity<Rider>()
                .HasMany(e => e.TourRiders)
                .WithRequired(e => e.Rider)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rider>()
                .HasMany(e => e.Transports)
                .WithRequired(e => e.Rider)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RouteDataType>()
                .Property(e => e.DataFormat)
                .IsFixedLength();

            modelBuilder.Entity<RouteDataType>()
                .HasMany(e => e.TourRoutes)
                .WithRequired(e => e.RouteDataType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceLog>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ServiceType>()
                .HasMany(e => e.ServiceLogs)
                .WithRequired(e => e.ServiceType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SocialMedia>()
                .HasOptional(e => e.Rider)
                .WithRequired(e => e.SocialMedia);

            modelBuilder.Entity<SocialMedia>()
                .HasOptional(e => e.SocialMedia1)
                .WithRequired(e => e.SocialMedia2);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.Riders)
                .WithOptional(e => e.Tour)
                .HasForeignKey(e => e.LastTourId);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.TourGroups)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.TourRiders)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TourGroup>()
                .HasMany(e => e.Broadcasts)
                .WithRequired(e => e.TourGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TourGroup>()
                .HasMany(e => e.TourGroupWaypoints)
                .WithRequired(e => e.TourGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TourGroup>()
                .HasMany(e => e.TourRiders)
                .WithRequired(e => e.TourGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TourRoute>()
                .HasMany(e => e.Tours)
                .WithRequired(e => e.TourRoute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TourRoute>()
                .HasMany(e => e.TourGroupWaypoints)
                .WithRequired(e => e.TourRoute)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transport>()
                .Property(e => e.Year)
                .IsFixedLength();

            modelBuilder.Entity<Transport>()
                .HasMany(e => e.ServiceLogs)
                .WithRequired(e => e.Transport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransportType>()
                .Property(e => e.Code)
                .IsFixedLength();
        }
    }
}
