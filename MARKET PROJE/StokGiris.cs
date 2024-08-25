using MARKET_PROJE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARKET_PROJE
{
    public partial class StokGiris : Form
    {
        private MarketDB db = new MarketDB();
        public decimal karMiktari;
        public StokGiris()
        {
            InitializeComponent();
        }


        private void btn_stok_girisi_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(txt_dosya_yolu.Text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] elemanlar = line.Split(';');
                    if (elemanlar.Length < 8) continue;

                    var irsaliye = new Irsaliye();
                    var urun = new Ürün();
                    var tedarikci = new Tedarikçi();
                    int i = 0;
                    
                    irsaliye.IrsaliyeID = Convert.ToInt32(elemanlar[i]);
                    irsaliye.ÜrünID = Convert.ToInt32(elemanlar[i + 1]);
                    irsaliye.GirişTarih = Convert.ToDateTime(elemanlar[i + 2]);
                    irsaliye.GirdiFiyat = Convert.ToDecimal(elemanlar[i + 3]);
                    irsaliye.Miktar = Convert.ToInt32(elemanlar[i + 4]);
                    irsaliye.TedarikçiID = Convert.ToInt32(elemanlar[i + 5]);
                    irsaliye.TedarikçiAdSoyad = Convert.ToString(elemanlar[i + 6]);
                    irsaliye.ÜrünAdı = Convert.ToString(elemanlar[i + 7]);
                    db.Irsaliye.Add(irsaliye);
                    var product = db.Ürün.FirstOrDefault(x => x.ÜrünAdı == irsaliye.ÜrünAdı);
                    if (product == null)
                    {
                        urun.ÜrünID = irsaliye.ÜrünID;
                        urun.BarkodNumarası = 855000000000 + irsaliye.ÜrünID;
                        urun.ÜrünAdı = irsaliye.ÜrünAdı;
                        urun.Miktar = irsaliye.Miktar;
                        decimal cevrim = irsaliye.GirdiFiyat + (karMiktari = Convert.ToDecimal(karPayi.Text));
                        cevrim = Math.Round(cevrim, 2);
                        urun.SatışFiyat = cevrim;
                        db.Ürün.Add(urun);
                        if (i % 8 == 0)
                        {
                            MessageBox.Show("Ürün kayıt edildi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        product.Miktar += irsaliye.Miktar;
                        product.SatışFiyat = Convert.ToDecimal(irsaliye.GirdiFiyat + (karMiktari = Convert.ToDecimal(karPayi.Text)));
                        if (i % 8 == 0)
                        {
                            MessageBox.Show("Ürün güncellendi", "Stok Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    var a = db.TedarikçiÖdeme.FirstOrDefault(x => x.TedarikçiID == irsaliye.TedarikçiID);
                    if (a == null)
                    {
                        tedarikci.TedarikçiID = irsaliye.TedarikçiID;
                        tedarikci.TedarikçiAdıSoyadı = irsaliye.TedarikçiAdSoyad;
                        tedarikci.GirişTarihi = DateTime.Now;
                        db.Tedarikçi.Add(tedarikci);

                        db.SaveChanges();


                    }
                    if (i % 8 == 0)
                    {
                        MessageBox.Show("Ürün kayıt edildi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    var tedarikciodeme1 = new TedarikçiÖdeme();
                    var tedarikciodeme = db.TedarikçiÖdeme.FirstOrDefault(x => x.TedarikçiID == irsaliye.TedarikçiID);
                    if (tedarikciodeme == null)
                    {
                        tedarikciodeme1.TedarikçiID = irsaliye.TedarikçiID;
                        tedarikciodeme1.ToplamBorc = Convert.ToDecimal(irsaliye.Miktar * irsaliye.GirdiFiyat);
                        tedarikciodeme1.ÖdenenMiktar = 0;
                        db.TedarikçiÖdeme.Add(tedarikciodeme1);
                        db.SaveChanges();
                    }
                    else
                    {
                        tedarikciodeme.ToplamBorc += Convert.ToDecimal(irsaliye.Miktar * irsaliye.GirdiFiyat);
                        db.SaveChanges();
                    }
                }
               
                StokGiris_Load(sender, e);
            }
        }


        private void StokGiris_Load(object sender, EventArgs e)
        {
            dgw_urunler.DataSource = db.Ürün.ToList();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgw_urunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
