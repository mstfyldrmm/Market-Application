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
    public partial class Satıcıgirişi : Form
    {
        private MarketDB db = new MarketDB();

        public Satıcıgirişi()
        {
            InitializeComponent();
        }

        private void btn_giriş_Click(object sender, EventArgs e)
        {
            using (var context = new MarketDB())
            {
                var satıcı = context.Satıcı
                    .Where(s => s.SatıcıAdıSoyadı == txt_adsoyad.Text && s.Şifre == txt_sifre.Text)
                    .FirstOrDefault();

                if (satıcı != null)
                {
                    MessageBox.Show("Giriş başarılı!");
                    var satisEkrani = new satisEkrani();
                    satisEkrani.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı ad soyad veya şifre!");
                }
            }

        }

        private void txt_adsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
