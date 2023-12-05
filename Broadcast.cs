namespace RiderLiNC.Azure.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Broadcast")]
    public partial class Broadcast
    {
        public int BroadcastId { get; set; }

        public int BroadcastTypeId { get; set; }

        public int RiderId { get; set; }

        public int TourGroupId { get; set; }

        [StringLength(255)]
        public string Message { get; set; }

        public bool IsInjury { get; set; }

        public bool IsSpam { get; set; }

        public virtual BroadcastType BroadcastType { get; set; }

        public virtual Rider Rider { get; set; }

        public virtual TourGroup TourGroup { get; set; }
    }
}
