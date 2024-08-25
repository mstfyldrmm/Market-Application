namespace MARKET_PROJE.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Müşteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Müşteri()
        {
            Borc = new HashSet<Borc>();
            Satış = new HashSet<Satış>();
        }

        public int MüşteriID { get; set; }

        [Required]
        [StringLength(50)]
        public string MüşteriAdı { get; set; }

        [Required]
        [StringLength(50)]
        public string MüşteriSoyadı { get; set; }

        [Required]
        [StringLength(50)]
        public string MüşteriTelefonNumarası { get; set; }

        [Column(TypeName = "date")]
        public DateTime KayıtTarihi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Borc> Borc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satış> Satış { get; set; }
    }
}
