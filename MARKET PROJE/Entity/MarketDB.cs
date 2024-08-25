using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MARKET_PROJE.Entity
{
    public partial class MarketDB : DbContext
    {
        public MarketDB()
            : base("name=MarketDB")
        {
        }

        public virtual DbSet<Borc> Borc { get; set; }
        public virtual DbSet<Irsaliye> Irsaliye { get; set; }
        public virtual DbSet<Müşteri> Müşteri { get; set; }
        public virtual DbSet<Satıcı> Satıcı { get; set; }
        public virtual DbSet<Satış> Satış { get; set; }
        public virtual DbSet<Tedarikçi> Tedarikçi { get; set; }
        public virtual DbSet<TedarikçiÖdeme> TedarikçiÖdeme { get; set; }
        public virtual DbSet<Ürün> Ürün { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Borc>()
                .Property(e => e.BorcMiktar)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Borc>()
                .Property(e => e.ÖdenenMiktar)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Irsaliye>()
                .Property(e => e.GirdiFiyat)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Müşteri>()
                .HasMany(e => e.Borc)
                .WithRequired(e => e.Müşteri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Satış>()
                .Property(e => e.SatışTutar)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Tedarikçi>()
                .HasMany(e => e.Irsaliye)
                .WithRequired(e => e.Tedarikçi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tedarikçi>()
                .HasMany(e => e.TedarikçiÖdeme)
                .WithRequired(e => e.Tedarikçi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TedarikçiÖdeme>()
                .Property(e => e.ToplamBorc)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TedarikçiÖdeme>()
                .Property(e => e.ÖdenenMiktar)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Ürün>()
                .Property(e => e.SatışFiyat)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Ürün>()
                .HasMany(e => e.Irsaliye)
                .WithRequired(e => e.Ürün)
                .WillCascadeOnDelete(false);
        }
    }
}
