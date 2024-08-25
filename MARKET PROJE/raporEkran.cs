using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MARKET_PROJE
{
    public partial class raporEkran : Form
    {
        public raporEkran()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xl = new Microsoft.Office.Interop.Excel.Application();
            var workbook = xl.Workbooks.Add();
            xl.Visible = true;

            Worksheet sht = ((Worksheet)workbook.ActiveSheet);
            Range target = (Range)sht.Range["A1"];

            string strCon = @"OLEDB;Provider=SQLNCLI11.0;server=.\SQLExpress;Trusted_Connection=yes;Database=MarketDB";

            string strSQL = "select distinct ÜrünAdi, sum(SatışMiktar) as 'Satış Adet', sum(SatışTutar) as 'Toplam Tutar' from Satış group by ÜrünAdi order by sum(SatışMiktar) desc;";

            sht.QueryTables.Add(strCon, target, strSQL).Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xl = new Microsoft.Office.Interop.Excel.Application();
            var workbook = xl.Workbooks.Add();
            xl.Visible = true;

            Worksheet sht = ((Worksheet)workbook.ActiveSheet);
            Range target = (Range)sht.Range["A1"];

            string strCon = @"OLEDB;Provider=SQLNCLI11.0;server=.\SQLExpress;Trusted_Connection=yes;Database=MarketDB";

            string strSQL = "select distinct ÜrünAdi, sum(SatışMiktar) as 'Satış Adet' from Satış group by ÜrünAdi order by sum(SatışMiktar) desc;";

            sht.QueryTables.Add(strCon, target, strSQL).Refresh();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
