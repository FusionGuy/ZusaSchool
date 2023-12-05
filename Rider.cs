using System.Collections;

namespace RiderLiNC.Azure.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rider")]
    public partial class Rider : IEnumerable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rider()
        {
            Broadcasts = new HashSet<Broadcast>();
            TourGroups = new HashSet<TourGroup>();
            TourRiders = new HashSet<TourRider>();
            Transports = new HashSet<Transport>();
        }

        public int RiderId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(15)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string DisplayName { get; set; }

        [StringLength(50)]
        public string PasswordHash { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? LastTourId { get; set; }

        public int NumTours { get; set; }

        [StringLength(10)]
        public string Culture { get; set; }

        [StringLength(50)]
        public string LanguageFile { get; set; }

        public int RankId { get; set; }

        [StringLength(25)]
        public string LastKnownCoordinates { get; set; }

        public int TimeZone { get; set; }

        public DateTime Joined { get; set; }

        public DateTime LastUpdated { get; set; }

        public DateTime? LastActivity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Broadcast> Broadcasts { get; set; }

        public virtual Rank Rank { get; set; }

        public virtual Tour Tour { get; set; }

        public virtual SocialMedia SocialMedia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TourGroup> TourGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TourRider> TourRiders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transport> Transports { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
