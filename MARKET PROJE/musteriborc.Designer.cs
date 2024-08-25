namespace MARKET_PROJE
{
    partial class musteriborc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwborclular = new System.Windows.Forms.DataGridView();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.lbl_borc_ödeme = new System.Windows.Forms.Label();
            this.txt_ödenecek_tutar = new System.Windows.Forms.TextBox();
            this.lbl_müşteri_borc = new System.Windows.Forms.Label();
            this.txt_güncel_borc = new System.Windows.Forms.TextBox();
            this.btn_borc_ödeme = new System.Windows.Forms.Button();
            this.txt_arama = new System.Windows.Forms.TextBox();
            this.btn_arama = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwborclular)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwborclular
            // 
            this.dgwborclular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwborclular.Location = new System.Drawing.Point(399, 115);
            this.dgwborclular.Margin = new System.Windows.Forms.Padding(4);
            this.dgwborclular.Name = "dgwborclular";
            this.dgwborclular.RowHeadersWidth = 51;
            this.dgwborclular.Size = new System.Drawing.Size(643, 347);
            this.dgwborclular.TabIndex = 0;
            this.dgwborclular.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwborclular_CellContentClick);
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(75, 59);
            this.lbl_ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(26, 16);
            this.lbl_ad.TabIndex = 2;
            this.lbl_ad.Text = "AD";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(148, 55);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(152, 22);
            this.txt_ad.TabIndex = 3;
            this.txt_ad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(75, 114);
            this.lbl_soyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(54, 16);
            this.lbl_soyad.TabIndex = 4;
            this.lbl_soyad.Text = "SOYAD";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(148, 111);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(152, 22);
            this.txt_soyad.TabIndex = 5;
            this.txt_soyad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(75, 186);
            this.lbl_telefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(69, 16);
            this.lbl_telefon.TabIndex = 6;
            this.lbl_telefon.Text = "TELEFON";
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(148, 182);
            this.txt_telefon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(152, 22);
            this.txt_telefon.TabIndex = 7;
            // 
            // lbl_borc_ödeme
            // 
            this.lbl_borc_ödeme.AutoSize = true;
            this.lbl_borc_ödeme.Location = new System.Drawing.Point(75, 330);
            this.lbl_borc_ödeme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_borc_ödeme.Name = "lbl_borc_ödeme";
            this.lbl_borc_ödeme.Size = new System.Drawing.Size(186, 16);
            this.lbl_borc_ödeme.TabIndex = 8;
            this.lbl_borc_ödeme.Text = "ÖDENMEK İSTENEN TUTAR";
            // 
            // txt_ödenecek_tutar
            // 
            this.txt_ödenecek_tutar.Location = new System.Drawing.Point(79, 366);
            this.txt_ödenecek_tutar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ödenecek_tutar.Name = "txt_ödenecek_tutar";
            this.txt_ödenecek_tutar.Size = new System.Drawing.Size(221, 22);
            this.txt_ödenecek_tutar.TabIndex = 9;
            this.txt_ödenecek_tutar.TextChanged += new System.EventHandler(this.txt_ödenecek_tutar_TextChanged);
            // 
            // lbl_müşteri_borc
            // 
            this.lbl_müşteri_borc.AutoSize = true;
            this.lbl_müşteri_borc.Location = new System.Drawing.Point(75, 252);
            this.lbl_müşteri_borc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_müşteri_borc.Name = "lbl_müşteri_borc";
            this.lbl_müşteri_borc.Size = new System.Drawing.Size(103, 16);
            this.lbl_müşteri_borc.TabIndex = 10;
            this.lbl_müşteri_borc.Text = "GÜNCEL BORC";
            // 
            // txt_güncel_borc
            // 
            this.txt_güncel_borc.Location = new System.Drawing.Point(195, 249);
            this.txt_güncel_borc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_güncel_borc.Name = "txt_güncel_borc";
            this.txt_güncel_borc.Size = new System.Drawing.Size(105, 22);
            this.txt_güncel_borc.TabIndex = 11;
            this.txt_güncel_borc.TextChanged += new System.EventHandler(this.txt_güncel_borc_TextChanged);
            // 
            // btn_borc_ödeme
            // 
            this.btn_borc_ödeme.Location = new System.Drawing.Point(79, 433);
            this.btn_borc_ödeme.Margin = new System.Windows.Forms.Padding(4);
            this.btn_borc_ödeme.Name = "btn_borc_ödeme";
            this.btn_borc_ödeme.Size = new System.Drawing.Size(223, 81);
            this.btn_borc_ödeme.TabIndex = 12;
            this.btn_borc_ödeme.Text = "BORC ÖDEME";
            this.btn_borc_ödeme.UseVisualStyleBackColor = true;
            this.btn_borc_ödeme.Click += new System.EventHandler(this.btn_borc_ödeme_Click);
            // 
            // txt_arama
            // 
            this.txt_arama.Location = new System.Drawing.Point(715, 49);
            this.txt_arama.Margin = new System.Windows.Forms.Padding(4);
            this.txt_arama.Name = "txt_arama";
            this.txt_arama.Size = new System.Drawing.Size(301, 22);
            this.txt_arama.TabIndex = 15;
            // 
            // btn_arama
            // 
            this.btn_arama.Location = new System.Drawing.Point(715, 79);
            this.btn_arama.Margin = new System.Windows.Forms.Padding(4);
            this.btn_arama.Name = "btn_arama";
            this.btn_arama.Size = new System.Drawing.Size(303, 28);
            this.btn_arama.TabIndex = 16;
            this.btn_arama.Text = "SORGULA";
            this.btn_arama.UseVisualStyleBackColor = true;
            this.btn_arama.Click += new System.EventHandler(this.btn_arama_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "SORGULANACAK KİŞİ BİLGİSİ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(574, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 74);
            this.button1.TabIndex = 18;
            this.button1.Text = "EXCELE AKTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // musteriborc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_arama);
            this.Controls.Add(this.txt_arama);
            this.Controls.Add(this.btn_borc_ödeme);
            this.Controls.Add(this.txt_güncel_borc);
            this.Controls.Add(this.lbl_müşteri_borc);
            this.Controls.Add(this.txt_ödenecek_tutar);
            this.Controls.Add(this.lbl_borc_ödeme);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.dgwborclular);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "musteriborc";
            this.Text = "BORC İŞLEMLERİ";
            this.Load += new System.EventHandler(this.musteriborc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwborclular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwborclular;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.Label lbl_borc_ödeme;
        private System.Windows.Forms.TextBox txt_ödenecek_tutar;
        private System.Windows.Forms.Label lbl_müşteri_borc;
        private System.Windows.Forms.TextBox txt_güncel_borc;
        private System.Windows.Forms.Button btn_borc_ödeme;
        private System.Windows.Forms.TextBox txt_arama;
        private System.Windows.Forms.Button btn_arama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}