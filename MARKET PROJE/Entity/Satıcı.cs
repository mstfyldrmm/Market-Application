namespace MARKET_PROJE.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Satıcı
    {
        public int SatıcıID { get; set; }

        [Required]
        [StringLength(50)]
        public string SatıcıAdıSoyadı { get; set; }

        [Required]
        [StringLength(50)]
        public string Şifre { get; set; }
    }
}
