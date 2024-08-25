namespace MARKET_PROJE.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Irsaliye")]
    public partial class Irsaliye
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IrsaliyeID { get; set; }

        public int ÜrünID { get; set; }

        [Column(TypeName = "date")]
        public DateTime GirişTarih { get; set; }

        public decimal GirdiFiyat { get; set; }

        public int Miktar { get; set; }

        public int TedarikçiID { get; set; }

        [StringLength(50)]
        public string TedarikçiAdSoyad { get; set; }

        [Required]
        [StringLength(50)]
        public string ÜrünAdı { get; set; }

        public virtual Tedarikçi Tedarikçi { get; set; }

        public virtual Ürün Ürün { get; set; }
    }
}
