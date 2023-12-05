namespace RiderLiNC.Azure.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BroadcastType")]
    public partial class BroadcastType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BroadcastType()
        {
            Broadcasts = new HashSet<Broadcast>();
        }

        public int BroadcastTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public bool IsEmergency { get; set; }

        public bool FindNearestPolice { get; set; }

        public bool FindNearestHospital { get; set; }

        public bool FindGroupLead { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Broadcast> Broadcasts { get; set; }
    }
}
