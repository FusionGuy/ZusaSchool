namespace RiderLiNC.Azure.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeviceOSType")]
    public partial class DeviceOSType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeviceOSType()
        {
            Devices = new HashSet<Device>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeviceOSTypeId { get; set; }

        [Required]
        [StringLength(25)]
        public string Description { get; set; }

        [Required]
        [StringLength(15)]
        public string Vendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Device> Devices { get; set; }
    }
}
