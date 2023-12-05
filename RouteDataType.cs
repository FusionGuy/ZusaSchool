namespace RiderLiNC.Azure.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RouteDataType")]
    public partial class RouteDataType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RouteDataType()
        {
            TourRoutes = new HashSet<TourRoute>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RouteDataTypeId { get; set; }

        [Required]
        [StringLength(3)]
        public string DataFormat { get; set; }

        [Required]
        [StringLength(50)]
        public string DataFormatDescription { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string Data { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TourRoute> TourRoutes { get; set; }
    }
}
