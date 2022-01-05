namespace Gorsel2_YemekTarifi_Proje_odevi
{
    partial class Bölgelere_Göre_Yemekler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bölgelere_Göre_Yemekler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_kategoriid = new System.Windows.Forms.ComboBox();
            this.tx_yemekBolgeid = new System.Windows.Forms.TextBox();
            this.tx_yemekAd = new System.Windows.Forms.TextBox();
            this.tx_bolgeAd = new System.Windows.Forms.TextBox();
            this.btn_bolgeEkle = new System.Windows.Forms.Button();
            this.btn_bolgeGuncelle = new System.Windows.Forms.Button();
            this.btn_bolgeSil = new System.Windows.Forms.Button();
            this.btn_bolgeCokluSil = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.dgv_yemekBolgeKayitlar = new System.Windows.Forms.DataGridView();
            this.pbx_bolgeResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yemekBolgeKayitlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_bolgeResim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "YemekBolgeid :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategoriid :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yemek Ad (Türü) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bölge Ad :";
            // 
            // cbx_kategoriid
            // 
            this.cbx_kategoriid.FormattingEnabled = true;
            this.cbx_kategoriid.Location = new System.Drawing.Point(311, 57);
            this.cbx_kategoriid.Name = "cbx_kategoriid";
            this.cbx_kategoriid.Size = new System.Drawing.Size(121, 21);
            this.cbx_kategoriid.TabIndex = 4;
            // 
            // tx_yemekBolgeid
            // 
            this.tx_yemekBolgeid.Location = new System.Drawing.Point(311, 29);
            this.tx_yemekBolgeid.Name = "tx_yemekBolgeid";
            this.tx_yemekBolgeid.Size = new System.Drawing.Size(100, 20);
            this.tx_yemekBolgeid.TabIndex = 5;
            // 
            // tx_yemekAd
            // 
            this.tx_yemekAd.Location = new System.Drawing.Point(311, 87);
            this.tx_yemekAd.Name = "tx_yemekAd";
            this.tx_yemekAd.Size = new System.Drawing.Size(100, 20);
            this.tx_yemekAd.TabIndex = 6;
            // 
            // tx_bolgeAd
            // 
            this.tx_bolgeAd.Location = new System.Drawing.Point(311, 122);
            this.tx_bolgeAd.Name = "tx_bolgeAd";
            this.tx_bolgeAd.Size = new System.Drawing.Size(100, 20);
            this.tx_bolgeAd.TabIndex = 7;
            // 
            // btn_bolgeEkle
            // 
            this.btn_bolgeEkle.Location = new System.Drawing.Point(233, 159);
            this.btn_bolgeEkle.Name = "btn_bolgeEkle";
            this.btn_bolgeEkle.Size = new System.Drawing.Size(75, 37);
            this.btn_bolgeEkle.TabIndex = 9;
            this.btn_bolgeEkle.Text = "Yemek Bölge Ekle";
            this.btn_bolgeEkle.UseVisualStyleBackColor = true;
            this.btn_bolgeEkle.Click += new System.EventHandler(this.btn_bolgeEkle_Click);
            // 
            // btn_bolgeGuncelle
            // 
            this.btn_bolgeGuncelle.Location = new System.Drawing.Point(233, 202);
            this.btn_bolgeGuncelle.Name = "btn_bolgeGuncelle";
            this.btn_bolgeGuncelle.Size = new System.Drawing.Size(75, 47);
            this.btn_bolgeGuncelle.TabIndex = 10;
            this.btn_bolgeGuncelle.Text = "Yemek Bölge Güncelle";
            this.btn_bolgeGuncelle.UseVisualStyleBackColor = true;
            this.btn_bolgeGuncelle.Click += new System.EventHandler(this.btn_bolgeGuncelle_Click);
            // 
            // btn_bolgeSil
            // 
            this.btn_bolgeSil.Location = new System.Drawing.Point(375, 159);
            this.btn_bolgeSil.Name = "btn_bolgeSil";
            this.btn_bolgeSil.Size = new System.Drawing.Size(75, 37);
            this.btn_bolgeSil.TabIndex = 11;
            this.btn_bolgeSil.Text = "Yemek Bölge Sil";
            this.btn_bolgeSil.UseVisualStyleBackColor = true;
            this.btn_bolgeSil.Click += new System.EventHandler(this.btn_bolgeSil_Click);
            // 
            // btn_bolgeCokluSil
            // 
            this.btn_bolgeCokluSil.Location = new System.Drawing.Point(375, 202);
            this.btn_bolgeCokluSil.Name = "btn_bolgeCokluSil";
            this.btn_bolgeCokluSil.Size = new System.Drawing.Size(75, 47);
            this.btn_bolgeCokluSil.TabIndex = 12;
            this.btn_bolgeCokluSil.Text = "Yemek Bölge Çoklu Sil";
            this.btn_bolgeCokluSil.UseVisualStyleBackColor = true;
            this.btn_bolgeCokluSil.Click += new System.EventHandler(this.btn_bolgeCokluSil_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(417, 29);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(51, 23);
            this.btn_Temizle.TabIndex = 13;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // dgv_yemekBolgeKayitlar
            // 
            this.dgv_yemekBolgeKayitlar.AllowUserToAddRows = false;
            this.dgv_yemekBolgeKayitlar.AllowUserToDeleteRows = false;
            this.dgv_yemekBolgeKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_yemekBolgeKayitlar.Location = new System.Drawing.Point(470, 29);
            this.dgv_yemekBolgeKayitlar.Name = "dgv_yemekBolgeKayitlar";
            this.dgv_yemekBolgeKayitlar.ReadOnly = true;
            this.dgv_yemekBolgeKayitlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_yemekBolgeKayitlar.Size = new System.Drawing.Size(294, 205);
            this.dgv_yemekBolgeKayitlar.TabIndex = 14;
            this.dgv_yemekBolgeKayitlar.SelectionChanged += new System.EventHandler(this.dgv_yemekBolgeKayitlar_SelectionChanged);
            // 
            // pbx_bolgeResim
            // 
            this.pbx_bolgeResim.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbx_bolgeResim.ErrorImage")));
            this.pbx_bolgeResim.Image = ((System.Drawing.Image)(resources.GetObject("pbx_bolgeResim.Image")));
            this.pbx_bolgeResim.Location = new System.Drawing.Point(12, 29);
            this.pbx_bolgeResim.Name = "pbx_bolgeResim";
            this.pbx_bolgeResim.Size = new System.Drawing.Size(197, 205);
            this.pbx_bolgeResim.TabIndex = 8;
            this.pbx_bolgeResim.TabStop = false;
            // 
            // Bölgelere_Göre_Yemekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(767, 259);
            this.Controls.Add(this.dgv_yemekBolgeKayitlar);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_bolgeCokluSil);
            this.Controls.Add(this.btn_bolgeSil);
            this.Controls.Add(this.btn_bolgeGuncelle);
            this.Controls.Add(this.btn_bolgeEkle);
            this.Controls.Add(this.pbx_bolgeResim);
            this.Controls.Add(this.tx_bolgeAd);
            this.Controls.Add(this.tx_yemekAd);
            this.Controls.Add(this.tx_yemekBolgeid);
            this.Controls.Add(this.cbx_kategoriid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bölgelere_Göre_Yemekler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bölgelere_Göre_Yemekler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bölgelere_Göre_Yemekler_FormClosing);
            this.Load += new System.EventHandler(this.Bölgelere_Göre_Yemekler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yemekBolgeKayitlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_bolgeResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_kategoriid;
        private System.Windows.Forms.TextBox tx_yemekBolgeid;
        private System.Windows.Forms.TextBox tx_yemekAd;
        private System.Windows.Forms.TextBox tx_bolgeAd;
        private System.Windows.Forms.PictureBox pbx_bolgeResim;
        private System.Windows.Forms.Button btn_bolgeEkle;
        private System.Windows.Forms.Button btn_bolgeGuncelle;
        private System.Windows.Forms.Button btn_bolgeSil;
        private System.Windows.Forms.Button btn_bolgeCokluSil;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.DataGridView dgv_yemekBolgeKayitlar;
    }
}