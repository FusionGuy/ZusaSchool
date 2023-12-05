namespace RiderLiNC.Azure.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Device")]
    public partial class Device
    {
        public int DeviceId { get; set; }

        [Required]
        [StringLength(50)]
        public string DisplayName { get; set; }

        [StringLength(50)]
        public string DeviceModel { get; set; }

        public int? DeviceOSTypeId { get; set; }

        [StringLength(15)]
        public string DeviceOSVersion { get; set; }

        [StringLength(15)]
        public string DevicePhoneNum { get; set; }

        [StringLength(25)]
        public string DeviceNetwork { get; set; }

        public int DeviceTypeId { get; set; }

        public int RiderId { get; set; }

        public bool IsVisible { get; set; }

        public bool IsEnabled { get; set; }

        public bool IsSupported { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual DeviceOSType DeviceOSType { get; set; }

        public virtual DeviceType DeviceType { get; set; }
    }
}
