using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MARKET_PROJE.Entity;
using Microsoft.Office.Interop.Excel;
using excel = Microsoft.Office.Interop.Excel;

namespace MARKET_PROJE
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            satısgecmisi f2 = new satısgecmisi();
            f2.Show();
        }

        private void satisButon_Click(object sender, EventArgs e)
        {
            Satıcıgirişi f3 = new Satıcıgirişi();
            f3.Show();
        }

        private void musteributon_Click(object sender, EventArgs e)
        {
            musteriekleme f4 = new musteriekleme();
            f4.Show();
        }

        private void stokbuton_Click(object sender, EventArgs e)
        {
            stokDurum f5 = new stokDurum();
            f5.Show();
        }

        private void borcButon_Click(object sender, EventArgs e)
        {
            tedarikciBorc f6 = new tedarikciBorc();
            f6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteriborc f7 = new musteriborc();
            f7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StokGiris f8= new StokGiris();
            f8.Show();
        }

        private void raporbuton_Click(object sender, EventArgs e)
        {
            raporEkran f9 = new raporEkran();
            f9.Show();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
