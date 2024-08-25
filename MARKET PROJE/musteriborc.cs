using MARKET_PROJE.Entity;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace MARKET_PROJE
{
    public partial class musteriborc : Form
    {
        private MarketDB db = new MarketDB();
        public musteriborc()
        {
            InitializeComponent();
        }

        private void btn_borc_ödeme_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ödenecek_tutar.Text))
            {
                MessageBox.Show("Ödenecek tutar alanı boş bırakılamaz!");
                return;
            }

            decimal ödenecekTutar = decimal.Parse(txt_ödenecek_tutar.Text);
            decimal güncelBorc = decimal.Parse(txt_güncel_borc.Text);

            if (ödenecekTutar > güncelBorc)
            {
                MessageBox.Show("Ödenecek tutar, müşterinin borcundan fazla olamaz!");
                return;
            }

            var müşteri = db.Müşteri.Where(m => m.MüşteriAdı == txt_ad.Text && m.MüşteriSoyadı == txt_soyad.Text && m.MüşteriTelefonNumarası == txt_telefon.Text).FirstOrDefault();
            if (müşteri == null)
            {
                MessageBox.Show("Müşteri bulunamadı!");
                return;
            }
            var borç = db.Borc.Where(b => b.MüşteriID == müşteri.MüşteriID).FirstOrDefault();
            if (borç != null)
            {
                borç.BorcMiktar -= ödenecekTutar;
                borç.ÖdenenMiktar += ödenecekTutar;
            }
            

            db.SaveChanges();

            MessageBox.Show("Borç ödemesi başarılı");
            musteriborc_Load(sender, e);
            txt_ad.Text = "";
            txt_soyad.Text = "";
            txt_telefon.Text = "";
            txt_güncel_borc.Text = "";
        }


        private void dgwborclular_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int müşteriID = Convert.ToInt32(dgwborclular.Rows[e.RowIndex].Cells["MüşteriID"].Value);
            Müşteri müşteri = db.Müşteri.Find(müşteriID);
            txt_ad.Text = müşteri.MüşteriAdı;
            txt_soyad.Text = müşteri.MüşteriSoyadı;
            txt_telefon.Text = müşteri.MüşteriTelefonNumarası;
            decimal? toplamBorc = db.Borc.Where(b => b.MüşteriID == müşteriID).Sum(b => b.BorcMiktar);
            if (toplamBorc.HasValue)
            {
                txt_güncel_borc.Text = Convert.ToString(toplamBorc.Value);
            }
            else
            {
                txt_güncel_borc.Text = "0";
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_güncel_borc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ödenecek_tutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void musteriborc_Load(object sender, EventArgs e)
        {
            dgwborclular.DataSource = db.Borc.ToList();
        }

        private void btn_arama_Click(object sender, EventArgs e)
        {
            int customerId;
            if (int.TryParse(txt_arama.Text, out customerId))
            {
                var customer = db.Müşteri.Where(m => m.MüşteriID == customerId).FirstOrDefault();
                if (customer != null)
                {
                    txt_ad.Text = customer.MüşteriAdı;
                    txt_soyad.Text = customer.MüşteriSoyadı;
                    txt_telefon.Text = customer.MüşteriTelefonNumarası;
                    decimal? toplamBorc = db.Borc.Where(b => b.MüşteriID == customer.MüşteriID).Sum(b => b.BorcMiktar);
                    if (toplamBorc.HasValue)
                    {
                        txt_güncel_borc.Text = Convert.ToString(toplamBorc.Value);
                    }
                    else
                    {
                        txt_güncel_borc.Text = "0";
                    }
                    dgwborclular.DataSource = db.Satış.Where(b => b.MüşteriID == customer.MüşteriID).ToList();
                   
                }
                else
                {
                    MessageBox.Show("Müşteri bulunamadı.");
                }

            }
        }

        private void dgwurunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application xl = new Microsoft.Office.Interop.Excel.Application();
            var workbook = xl.Workbooks.Add();
            xl.Visible = true;

            Worksheet sht = ((Worksheet)workbook.ActiveSheet);
            Range target = (Range)sht.Range["A1"];

            string strCon = @"OLEDB;Provider=SQLNCLI11.0;server=.\SQLExpress;Trusted_Connection=yes;Database=MarketDB";

            string strSQL = "Select distinct MüşteriAdı + '  '+ MüşteriSoyadı as 'Müşteri', ToplamSatis, BorcMiktar, ÖdenenMiktar from Borc inner join Müşteri on Borc.MüşteriID=Müşteri.MüşteriID inner join Satış on Borc.MüşteriID=Satış.MüşteriID;";

            sht.QueryTables.Add(strCon, target, strSQL).Refresh();

        }
    }
}
