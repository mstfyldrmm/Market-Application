namespace MARKET_PROJE.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ürün
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ürün()
        {
            Irsaliye = new HashSet<Irsaliye>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ÜrünID { get; set; }

        public long? BarkodNumarası { get; set; }

        [Required]
        [StringLength(50)]
        public string ÜrünAdı { get; set; }

        public decimal? SatışFiyat { get; set; }

        public int Miktar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Irsaliye> Irsaliye { get; set; }
    }
}
