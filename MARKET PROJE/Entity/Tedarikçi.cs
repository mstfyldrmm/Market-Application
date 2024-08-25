namespace MARKET_PROJE.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tedarikçi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tedarikçi()
        {
            Irsaliye = new HashSet<Irsaliye>();
            TedarikçiÖdeme = new HashSet<TedarikçiÖdeme>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TedarikçiID { get; set; }

        [StringLength(50)]
        public string TedarikçiAdıSoyadı { get; set; }

        [Column(TypeName = "date")]
        public DateTime GirişTarihi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Irsaliye> Irsaliye { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TedarikçiÖdeme> TedarikçiÖdeme { get; set; }
    }
}
