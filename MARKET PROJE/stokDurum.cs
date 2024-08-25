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
    public partial class stokDurum : Form
    {
        private MarketDB db = new MarketDB();
        public stokDurum()
        {
            InitializeComponent();
        }

        private void stokDurum_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = db.Ürün.ToList();
        }
    }
}
