namespace MARKET_PROJE.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Borc")]
    public partial class Borc
    {
        public int BorcID { get; set; }

        public int MüşteriID { get; set; }

        [Column(TypeName = "date")]
        public DateTime BorcTarihi { get; set; }

        public decimal BorcMiktar { get; set; }

        public decimal? ÖdenenMiktar { get; set; }

        public virtual Müşteri Müşteri { get; set; }
    }
}
