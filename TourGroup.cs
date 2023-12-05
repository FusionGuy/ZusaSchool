namespace RiderLiNC.Azure.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TourGroup")]
    public partial class TourGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TourGroup()
        {
            Broadcasts = new HashSet<Broadcast>();
            TourGroupWaypoints = new HashSet<TourGroupWaypoint>();
            TourRiders = new HashSet<TourRider>();
        }

        public int TourGroupId { get; set; }

        public int TourId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int AttendeeLimit { get; set; }

        public int? LeadRiderId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Broadcast> Broadcasts { get; set; }

        public virtual Rider Rider { get; set; }

        public virtual Tour Tour { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TourGroupWaypoint> TourGroupWaypoints { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TourRider> TourRiders { get; set; }
    }
}
