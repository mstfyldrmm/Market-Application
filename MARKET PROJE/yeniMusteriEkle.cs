using MARKET_PROJE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARKET_PROJE
{
    public partial class yeniMusteriEkle : Form
    {
        private MarketDB db = new MarketDB();
        public yeniMusteriEkle()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string tarih = kayittarihi.Value.ToShortDateString();
            müşteri Müşteri = new müşteri
            Müşteri.musteriId = 0;
            Müşteri.musteriAdi = musteriadi.Text;
            Müşteri.musteriSoyadi = musterisoyad.Text;
            Müşteri.musteriGSM = telno.Text;
            Müşteri.kayitTarihi = tarih;
            Müşteri.musteriBorc = 0;
            db.Müşteri.Add(Müşteri);
            db.SaveChanges();
            MessageBox.Show("Müşteri Eklendi. Numarası : " + musteri.musteriId + "", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void yeniMusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
