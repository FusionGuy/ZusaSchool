namespace RiderLiNC.Azure.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transport")]
    public partial class Transport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transport()
        {
            ServiceLogs = new HashSet<ServiceLog>();
        }

        public int TransportId { get; set; }

        public int TransportTypeId { get; set; }

        public int RiderId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Make { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [StringLength(4)]
        public string Year { get; set; }

        [StringLength(50)]
        public string DisplayName { get; set; }

        public int? IndividualMilesLogged { get; set; }

        public int? GroupMilesLogged { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastUpdated { get; set; }

        public virtual Rider Rider { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceLog> ServiceLogs { get; set; }
    }
}
