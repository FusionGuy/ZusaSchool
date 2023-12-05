namespace RiderLiNC.Azure.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TourGroupWaypoint")]
    public partial class TourGroupWaypoint
    {
        public int TourGroupWaypointId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int TourGroupId { get; set; }

        public int TourRouteId { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public virtual TourGroup TourGroup { get; set; }

        public virtual TourRoute TourRoute { get; set; }
    }
}
