namespace MARKET_PROJE
{
    partial class musteriekleme
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
            this.dgw_kayıtlımüşteri = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.kayittarihi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kayıtlımüşteri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_kayıtlımüşteri
            // 
            this.dgw_kayıtlımüşteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_kayıtlımüşteri.Location = new System.Drawing.Point(436, 70);
            this.dgw_kayıtlımüşteri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgw_kayıtlımüşteri.Name = "dgw_kayıtlımüşteri";
            this.dgw_kayıtlımüşteri.RowHeadersWidth = 51;
            this.dgw_kayıtlımüşteri.Size = new System.Drawing.Size(599, 452);
            this.dgw_kayıtlımüşteri.TabIndex = 0;
            this.dgw_kayıtlımüşteri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_kayıtlımüşteri_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(641, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "KAYITLI MÜŞTERİLER";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(35, 70);
            this.lbl_ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(26, 16);
            this.lbl_ad.TabIndex = 2;
            this.lbl_ad.Text = "AD";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Location = new System.Drawing.Point(35, 158);
            this.lbl_telefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(69, 16);
            this.lbl_telefon.TabIndex = 4;
            this.lbl_telefon.Text = "TELEFON";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(35, 112);
            this.lbl_soyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(54, 16);
            this.lbl_soyad.TabIndex = 5;
            this.lbl_soyad.Text = "SOYAD";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(117, 66);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(269, 22);
            this.txt_ad.TabIndex = 7;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(117, 108);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(269, 22);
            this.txt_soyad.TabIndex = 8;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(117, 154);
            this.txt_telefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(269, 22);
            this.txt_telefon.TabIndex = 9;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(119, 250);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(271, 62);
            this.btn_ekle.TabIndex = 11;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(119, 347);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(272, 59);
            this.btn_sil.TabIndex = 12;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(121, 442);
            this.btn_güncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(269, 62);
            this.btn_güncelle.TabIndex = 13;
            this.btn_güncelle.Text = "GÜNCELLE";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(35, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 34);
            this.label5.TabIndex = 15;
            this.label5.Text = "MÜŞTERİ KAYIT \r\nTARİHİ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // kayittarihi
            // 
            this.kayittarihi.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.kayittarihi.Location = new System.Drawing.Point(157, 194);
            this.kayittarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kayittarihi.Name = "kayittarihi";
            this.kayittarihi.Size = new System.Drawing.Size(229, 22);
            this.kayittarihi.TabIndex = 14;
            this.kayittarihi.Value = new System.DateTime(2023, 1, 20, 2, 44, 0, 0);
            // 
            // musteriekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kayittarihi);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_telefon);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgw_kayıtlımüşteri);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "musteriekleme";
            this.Text = "MÜŞTERİ SAYFASI";
            this.Load += new System.EventHandler(this.musteriekleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_kayıtlımüşteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_kayıtlımüşteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker kayittarihi;
    }
}