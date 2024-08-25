namespace MARKET_PROJE.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TedarikçiÖdeme
    {
        [Key]
        public int ÖdemeID { get; set; }

        public int TedarikçiID { get; set; }

        public decimal? ToplamBorc { get; set; }

        public decimal? ÖdenenMiktar { get; set; }

        public virtual Tedarikçi Tedarikçi { get; set; }
    }
}
