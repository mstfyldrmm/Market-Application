using MARKET_PROJE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARKET_PROJE
{
    public partial class musteriekleme : Form
    {
        private MarketDB db = new MarketDB();

        public musteriekleme()
        {
            InitializeComponent();
        }

        private void musteriekleme_Load(object sender, EventArgs e)
        {

            dgw_kayıtlımüşteri.DataSource = db.Müşteri.ToList();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            DateTime tarih = kayittarihi.Value;
            Müşteri müşteri = new Müşteri
            {
                MüşteriAdı = txt_ad.Text,
                MüşteriSoyadı = txt_soyad.Text,
                MüşteriTelefonNumarası = txt_telefon.Text,
                KayıtTarihi = tarih,
                
        };

            
            db.Müşteri.Add(müşteri);
            db.SaveChanges();

            
            dgw_kayıtlımüşteri.DataSource = db.Müşteri.ToList();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            
            Müşteri müşteri = (Müşteri)dgw_kayıtlımüşteri.CurrentRow.DataBoundItem;

            
            db.Müşteri.Remove(müşteri);
            db.SaveChanges();

            
            dgw_kayıtlımüşteri.DataSource = db.Müşteri.ToList();
        }
        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            
            Müşteri müşteri = (Müşteri)dgw_kayıtlımüşteri.CurrentRow.DataBoundItem;

            müşteri.MüşteriAdı = txt_ad.Text;
            müşteri.MüşteriSoyadı = txt_soyad.Text;
            müşteri.MüşteriTelefonNumarası = txt_telefon.Text;

            
            db.SaveChanges();

            
            dgw_kayıtlımüşteri.DataSource = db.Müşteri.ToList();
        }
        private void dgw_kayıtlımüşteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Müşteri müşteri = (Müşteri)dgw_kayıtlımüşteri.CurrentRow.DataBoundItem;

            
            txt_ad.Text = müşteri.MüşteriAdı;
            txt_soyad.Text = müşteri.MüşteriSoyadı;
            txt_telefon.Text = müşteri.MüşteriTelefonNumarası;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

