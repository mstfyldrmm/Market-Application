using MARKET_PROJE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARKET_PROJE
{
    public partial class satisEkrani : Form
    {
        public double totalPrice = 0;
        private MarketDB db = new MarketDB();
        public int stsmusteriID;
        public satisEkrani()
        {
            InitializeComponent();
        }
        private void addID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Regex.IsMatch(addID.Text, "[^0-9\b]+");
            if (e.Handled == true)
            {
                MessageBox.Show("Sadece sayı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void showIDText_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void addProductButton_Click_1(object sender, EventArgs e)
        {
            if (urunMiktar1.Text != null)
            {

                long newAddmiktar = Convert.ToInt64(urunMiktar1.Text);
                long newAddId = Convert.ToInt64(addID.Text);
                var product = db.Ürün.SingleOrDefault(x => x.BarkodNumarası == newAddId);
                if (product == null)
                {
                    MessageBox.Show("Girilen barkod no'ya ait ürün bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (product.Miktar < newAddmiktar)
                    {
                        MessageBox.Show("Stok miktarından fazla ürün ekleyemezsiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string urunAdi = product.ÜrünAdı;
                        string gecis = urunAdi + " x " + urunMiktar1.Text;
                        totalPrice += Convert.ToDouble(product.SatışFiyat) * Convert.ToDouble(urunMiktar1.Text);
                        listBox1.Items.Add(gecis);
                        MessageBox.Show("Ürün sepete eklendi", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label3.Text = "Tutar toplamı : " + totalPrice + "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Ürün miktarı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            urunMiktar1.Clear();
            addID.Clear();
        }
        private void deleteProductButton_Click(object sender, EventArgs e)
        {
        }


        private void satisEkrani_Load(object sender, EventArgs e)
        {
            sifreText.PasswordChar = '*';
        }

        private void addID_TextChanged(object sender, EventArgs e)
        {

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void debtButton_Click_1(object sender, EventArgs e)
        {

            stsmusteriID = Convert.ToInt32(musArama.Text);
            var satis = new Satış();
            var musterii = db.Müşteri.FirstOrDefault(x => x.MüşteriID == stsmusteriID);
            
                for (int i = 2; i < listBox1.Items.Count; i++)
                {
                    string itemSelected = listBox1.Items[i].ToString();
                    string[] selected = itemSelected.Split(' ');
                    string selected1 = selected[0];
                    int selected2 = Convert.ToInt32(selected[2]);
                    var urunMiktari12 = db.Ürün.FirstOrDefault(x => x.ÜrünAdı == selected1);
                    if (urunMiktari12 != null)
                    {
                        urunMiktari12.Miktar -= selected2;
                    if (urunMiktari12.Miktar < 10)
                    {
                        MessageBox.Show("Ürün stokunu azalmak üzere. Lütfen stoklarınızı güncelleyin.", "Stok Düşük", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    satis.SatışTutar = Convert.ToDecimal(urunMiktari12.SatışFiyat * selected2);
                        satis.MüşteriID = Convert.ToInt32(musArama.Text);
                        satis.ÜrünAdi = urunMiktari12.ÜrünAdı;
                        satis.SatışMiktar = selected2;
                        satis.SatışTarihi = DateTime.Now;
                        db.Satış.Add(satis);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Hata");
                    }
                }
                    var musteri = db.Borc.FirstOrDefault(x => x.MüşteriID == stsmusteriID);
                    if (musteri == null)
                    {

                        var borc = new Borc();
                        borc.MüşteriID = musterii.MüşteriID;
                        borc.BorcMiktar = Convert.ToDecimal(totalPrice);
                        borc.ÖdenenMiktar = 0;
                        borc.BorcTarihi = DateTime.Now;
                        db.Borc.Add(borc);
                
                    }
                    else
                    {
                        musteri.BorcMiktar += Convert.ToDecimal(totalPrice);
                    }
                    db.SaveChanges();
                    listBox1.Items.Clear();
                totalPrice = 0;
                listBox1.Items.Clear();
                listBox1.Items.Add("Sepet");
                listBox1.Items.Add("----------");
                totalPrice = 0;
                label3.Text = "Tutar toplamı : " + totalPrice;
                MessageBox.Show("Satış Tamamlandı", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                musArama.Clear();
            
        }

        private void cashButton_Click_1(object sender, EventArgs e)
        {
            var satis = new Satış();
            for (int i = 2; i < listBox1.Items.Count; i++)
            {
                string itemSelected = listBox1.Items[i].ToString();
                string[] selected = itemSelected.Split(' ');
                string selected1 = selected[0];
                int selected2 = Convert.ToInt32(selected[2]);
                var urunMiktari12 = db.Ürün.FirstOrDefault(x => x.ÜrünAdı == selected1);
                if (urunMiktari12 != null)
                {
                    urunMiktari12.Miktar -= selected2;
                    if (urunMiktari12.Miktar < 10)
                    {
                        MessageBox.Show("Ürün stokunu azalmak üzere. Lütfen stoklarınızı güncelleyin.", "Stok Düşük", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    satis.SatışTutar = Convert.ToDecimal(urunMiktari12.SatışFiyat * selected2);
                    satis.ÜrünAdi = urunMiktari12.ÜrünAdı;
                    satis.SatışMiktar = selected2;
                    satis.SatışTarihi = DateTime.Now;
                    db.Satış.Add(satis);
                    db.SaveChanges();

                }
                else
                {
                    MessageBox.Show("Hata");
                }
            }
            db.SaveChanges();
            listBox1.Items.Clear();
            listBox1.Items.Add("Sepet");
            listBox1.Items.Add("----------");
            totalPrice = 0;
            label3.Text = "Tutar toplamı : " + totalPrice;
            MessageBox.Show("Satış Tamamlandı", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteriekleme yme = new musteriekleme();
            yme.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void sifreText_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                sifreText.PasswordChar = '\0';
            }
            else
            {
                sifreText.PasswordChar = '*';
            }
        }

        private void satisEkrani_Load_1(object sender, EventArgs e)
        {

        }

        private void deleteProductButton_Click_1(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                string itemSelected = listBox1.SelectedItem.ToString();
                string[] selected = itemSelected.Split(' ');
                string selected1 = selected[0];
                int selected2 = Convert.ToInt32(selected[2]);
                var product = db.Ürün.SingleOrDefault(x => x.ÜrünAdı == selected1);

                if (sifreText.Text != "123")
                {
                    MessageBox.Show("Hatalı şifre girdiniz. Ürün silinemedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double al = Convert.ToDouble(product.SatışFiyat);
                    totalPrice -= Convert.ToSingle(al * selected2);
                    label3.Text = "Tutar toplamı : " + totalPrice + "";
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir ürün seçin!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
