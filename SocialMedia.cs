namespace RiderLiNC.Azure.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SocialMedia")]
    public partial class SocialMedia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RiderId { get; set; }

        [StringLength(50)]
        public string FacebookProfileId { get; set; }

        [StringLength(50)]
        public string TwitterLoginName { get; set; }

        [StringLength(50)]
        public string GooglePlusId { get; set; }

        public virtual Rider Rider { get; set; }

        public virtual SocialMedia SocialMedia1 { get; set; }

        public virtual SocialMedia SocialMedia2 { get; set; }
    }
}
