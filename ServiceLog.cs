namespace RiderLiNC.Azure.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceLog")]
    public partial class ServiceLog
    {
        public int ServiceLogId { get; set; }

        public int TransportId { get; set; }

        public int ServiceTypeId { get; set; }

        public DateTime DatePerformed { get; set; }

        [StringLength(100)]
        public string Source { get; set; }

        public string Description { get; set; }

        public int? Mileage { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        public virtual ServiceType ServiceType { get; set; }

        public virtual Transport Transport { get; set; }
    }
}
