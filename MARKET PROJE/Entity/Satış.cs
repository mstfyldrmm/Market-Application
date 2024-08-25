namespace MARKET_PROJE.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Satış
    {
        public int SatışID { get; set; }

        public int? MüşteriID { get; set; }

        [Column(TypeName = "date")]
        public DateTime SatışTarihi { get; set; }

        [Required]
        [StringLength(50)]
        public string ÜrünAdi { get; set; }

        public int SatışMiktar { get; set; }

        public decimal SatışTutar { get; set; }

        public virtual Müşteri Müşteri { get; set; }
    }
}
