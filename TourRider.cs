namespace RiderLiNC.Azure.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TourRider")]
    public partial class TourRider
    {
        public int TourRiderId { get; set; }

        public int TourId { get; set; }

        public int RiderId { get; set; }

        public bool IsTourLead { get; set; }

        public int TourGroupId { get; set; }

        public virtual Rider Rider { get; set; }

        public virtual Tour Tour { get; set; }

        public virtual TourGroup TourGroup { get; set; }
    }
}
