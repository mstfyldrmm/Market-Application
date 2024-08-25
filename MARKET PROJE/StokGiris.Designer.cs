namespace MARKET_PROJE
{
    partial class StokGiris
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
            this.txt_dosya_yolu = new System.Windows.Forms.TextBox();
            this.btn_stok_girisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgw_urunler = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.karPayi = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_urunler)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_dosya_yolu
            // 
            this.txt_dosya_yolu.Location = new System.Drawing.Point(223, 94);
            this.txt_dosya_yolu.Name = "txt_dosya_yolu";
            this.txt_dosya_yolu.Size = new System.Drawing.Size(331, 20);
            this.txt_dosya_yolu.TabIndex = 1;
            // 
            // btn_stok_girisi
            // 
            this.btn_stok_girisi.Location = new System.Drawing.Point(594, 90);
            this.btn_stok_girisi.Name = "btn_stok_girisi";
            this.btn_stok_girisi.Size = new System.Drawing.Size(146, 27);
            this.btn_stok_girisi.TabIndex = 2;
            this.btn_stok_girisi.Text = "STOK EKLE";
            this.btn_stok_girisi.UseVisualStyleBackColor = true;
            this.btn_stok_girisi.Click += new System.EventHandler(this.btn_stok_girisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DOSYA YOLUNU GİRİNİZ:";
            // 
            // dgw_urunler
            // 
            this.dgw_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_urunler.Location = new System.Drawing.Point(52, 185);
            this.dgw_urunler.Name = "dgw_urunler";
            this.dgw_urunler.Size = new System.Drawing.Size(690, 215);
            this.dgw_urunler.TabIndex = 4;
            this.dgw_urunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_urunler_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ÜRÜNLER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "KÂR MİKTARINI GİRİNİZ : ";
            // 
            // karPayi
            // 
            this.karPayi.Location = new System.Drawing.Point(192, 57);
            this.karPayi.Name = "karPayi";
            this.karPayi.Size = new System.Drawing.Size(100, 20);
            this.karPayi.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(315, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 20);
            this.button4.TabIndex = 12;
            this.button4.Text = "ONAYLA";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // StokGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.karPayi);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgw_urunler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_stok_girisi);
            this.Controls.Add(this.txt_dosya_yolu);
            this.Name = "StokGiris";
            this.Text = "StokGiris";
            this.Load += new System.EventHandler(this.StokGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_urunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_dosya_yolu;
        private System.Windows.Forms.Button btn_stok_girisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgw_urunler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox karPayi;
        private System.Windows.Forms.Button button4;
    }
}