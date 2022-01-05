namespace Gorsel2_YemekTarifi_Proje_odevi
{
    partial class YemekEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YemekEkleme));
            this.ofd_DosyaAçma = new System.Windows.Forms.OpenFileDialog();
            this.btn_resimEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_yemekid = new System.Windows.Forms.TextBox();
            this.tx_yemekAd = new System.Windows.Forms.TextBox();
            this.tx_malzeme = new System.Windows.Forms.TextBox();
            this.tx_yemekResimismi = new System.Windows.Forms.TextBox();
            this.tx_kategoriid = new System.Windows.Forms.TextBox();
            this.dtp_eklenmeTarihi = new System.Windows.Forms.DateTimePicker();
            this.dgv_yemekEkleme = new System.Windows.Forms.DataGridView();
            this.pbx_yemekResim = new System.Windows.Forms.PictureBox();
            this.btn_yemekEkle = new System.Windows.Forms.Button();
            this.btn_yemekGuncelle = new System.Windows.Forms.Button();
            this.btn_yemekKayitSil = new System.Windows.Forms.Button();
            this.btn_yemekCokluSil = new System.Windows.Forms.Button();
            this.btn_yemekTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yemekEkleme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_yemekResim)).BeginInit();
            this.SuspendLayout();
            // 
            // ofd_DosyaAçma
            // 
            this.ofd_DosyaAçma.FileName = "openFileDialog1";
            // 
            // btn_resimEkle
            // 
            this.btn_resimEkle.Location = new System.Drawing.Point(31, 155);
            this.btn_resimEkle.Name = "btn_resimEkle";
            this.btn_resimEkle.Size = new System.Drawing.Size(161, 23);
            this.btn_resimEkle.TabIndex = 1;
            this.btn_resimEkle.Text = "Yemek Resim Ekle";
            this.btn_resimEkle.UseVisualStyleBackColor = true;
            this.btn_resimEkle.Click += new System.EventHandler(this.btn_resimEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yemekid :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "YemekAd :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Malzeme :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yemek Resim İsmi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Eklenme Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "kategoriId :";
            // 
            // tx_yemekid
            // 
            this.tx_yemekid.Location = new System.Drawing.Point(108, 195);
            this.tx_yemekid.Name = "tx_yemekid";
            this.tx_yemekid.Size = new System.Drawing.Size(100, 20);
            this.tx_yemekid.TabIndex = 8;
            // 
            // tx_yemekAd
            // 
            this.tx_yemekAd.Location = new System.Drawing.Point(108, 221);
            this.tx_yemekAd.Name = "tx_yemekAd";
            this.tx_yemekAd.Size = new System.Drawing.Size(100, 20);
            this.tx_yemekAd.TabIndex = 9;
            // 
            // tx_malzeme
            // 
            this.tx_malzeme.Location = new System.Drawing.Point(108, 252);
            this.tx_malzeme.Name = "tx_malzeme";
            this.tx_malzeme.Size = new System.Drawing.Size(100, 20);
            this.tx_malzeme.TabIndex = 10;
            // 
            // tx_yemekResimismi
            // 
            this.tx_yemekResimismi.Location = new System.Drawing.Point(108, 284);
            this.tx_yemekResimismi.Name = "tx_yemekResimismi";
            this.tx_yemekResimismi.Size = new System.Drawing.Size(100, 20);
            this.tx_yemekResimismi.TabIndex = 11;
            // 
            // tx_kategoriid
            // 
            this.tx_kategoriid.Location = new System.Drawing.Point(108, 348);
            this.tx_kategoriid.Name = "tx_kategoriid";
            this.tx_kategoriid.Size = new System.Drawing.Size(100, 20);
            this.tx_kategoriid.TabIndex = 13;
            // 
            // dtp_eklenmeTarihi
            // 
            this.dtp_eklenmeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_eklenmeTarihi.Location = new System.Drawing.Point(108, 318);
            this.dtp_eklenmeTarihi.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_eklenmeTarihi.Name = "dtp_eklenmeTarihi";
            this.dtp_eklenmeTarihi.Size = new System.Drawing.Size(107, 20);
            this.dtp_eklenmeTarihi.TabIndex = 14;
            // 
            // dgv_yemekEkleme
            // 
            this.dgv_yemekEkleme.AllowUserToAddRows = false;
            this.dgv_yemekEkleme.AllowUserToDeleteRows = false;
            this.dgv_yemekEkleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_yemekEkleme.Location = new System.Drawing.Point(332, 34);
            this.dgv_yemekEkleme.Name = "dgv_yemekEkleme";
            this.dgv_yemekEkleme.ReadOnly = true;
            this.dgv_yemekEkleme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_yemekEkleme.Size = new System.Drawing.Size(364, 331);
            this.dgv_yemekEkleme.TabIndex = 15;
            this.dgv_yemekEkleme.SelectionChanged += new System.EventHandler(this.dgv_yemekEkleme_SelectionChanged);
            // 
            // pbx_yemekResim
            // 
            this.pbx_yemekResim.BackColor = System.Drawing.Color.DarkGray;
            this.pbx_yemekResim.Location = new System.Drawing.Point(12, 5);
            this.pbx_yemekResim.Name = "pbx_yemekResim";
            this.pbx_yemekResim.Size = new System.Drawing.Size(196, 144);
            this.pbx_yemekResim.TabIndex = 0;
            this.pbx_yemekResim.TabStop = false;
            // 
            // btn_yemekEkle
            // 
            this.btn_yemekEkle.Location = new System.Drawing.Point(236, 12);
            this.btn_yemekEkle.Name = "btn_yemekEkle";
            this.btn_yemekEkle.Size = new System.Drawing.Size(75, 55);
            this.btn_yemekEkle.TabIndex = 16;
            this.btn_yemekEkle.Text = "Yeni Yemek Ekle";
            this.btn_yemekEkle.UseVisualStyleBackColor = true;
            this.btn_yemekEkle.Click += new System.EventHandler(this.btn_yemekEkle_Click);
            // 
            // btn_yemekGuncelle
            // 
            this.btn_yemekGuncelle.Location = new System.Drawing.Point(236, 77);
            this.btn_yemekGuncelle.Name = "btn_yemekGuncelle";
            this.btn_yemekGuncelle.Size = new System.Drawing.Size(75, 61);
            this.btn_yemekGuncelle.TabIndex = 17;
            this.btn_yemekGuncelle.Text = "Yemek Güncelle";
            this.btn_yemekGuncelle.UseVisualStyleBackColor = true;
            this.btn_yemekGuncelle.Click += new System.EventHandler(this.btn_yemekGuncelle_Click);
            // 
            // btn_yemekKayitSil
            // 
            this.btn_yemekKayitSil.Location = new System.Drawing.Point(236, 154);
            this.btn_yemekKayitSil.Name = "btn_yemekKayitSil";
            this.btn_yemekKayitSil.Size = new System.Drawing.Size(75, 61);
            this.btn_yemekKayitSil.TabIndex = 18;
            this.btn_yemekKayitSil.Text = "Yemek Kayıt Sil";
            this.btn_yemekKayitSil.UseVisualStyleBackColor = true;
            this.btn_yemekKayitSil.Click += new System.EventHandler(this.btn_yemekKayitSil_Click);
            // 
            // btn_yemekCokluSil
            // 
            this.btn_yemekCokluSil.Location = new System.Drawing.Point(236, 233);
            this.btn_yemekCokluSil.Name = "btn_yemekCokluSil";
            this.btn_yemekCokluSil.Size = new System.Drawing.Size(75, 57);
            this.btn_yemekCokluSil.TabIndex = 19;
            this.btn_yemekCokluSil.Text = "Yemek Çoklu Kayıt Sil";
            this.btn_yemekCokluSil.UseVisualStyleBackColor = true;
            this.btn_yemekCokluSil.Click += new System.EventHandler(this.btn_yemekCokluSil_Click);
            // 
            // btn_yemekTemizle
            // 
            this.btn_yemekTemizle.Location = new System.Drawing.Point(236, 307);
            this.btn_yemekTemizle.Name = "btn_yemekTemizle";
            this.btn_yemekTemizle.Size = new System.Drawing.Size(75, 61);
            this.btn_yemekTemizle.TabIndex = 20;
            this.btn_yemekTemizle.Text = "Temizle";
            this.btn_yemekTemizle.UseVisualStyleBackColor = true;
            this.btn_yemekTemizle.Click += new System.EventHandler(this.btn_yemekTemizle_Click);
            // 
            // YemekEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(708, 377);
            this.Controls.Add(this.btn_yemekTemizle);
            this.Controls.Add(this.btn_yemekCokluSil);
            this.Controls.Add(this.btn_yemekKayitSil);
            this.Controls.Add(this.btn_yemekGuncelle);
            this.Controls.Add(this.btn_yemekEkle);
            this.Controls.Add(this.dgv_yemekEkleme);
            this.Controls.Add(this.dtp_eklenmeTarihi);
            this.Controls.Add(this.tx_kategoriid);
            this.Controls.Add(this.tx_yemekResimismi);
            this.Controls.Add(this.tx_malzeme);
            this.Controls.Add(this.tx_yemekAd);
            this.Controls.Add(this.tx_yemekid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_resimEkle);
            this.Controls.Add(this.pbx_yemekResim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YemekEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YemekEkleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YemekEkleme_FormClosing);
            this.Load += new System.EventHandler(this.YemekEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_yemekEkleme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_yemekResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_yemekResim;
        private System.Windows.Forms.OpenFileDialog ofd_DosyaAçma;
        private System.Windows.Forms.Button btn_resimEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_yemekid;
        private System.Windows.Forms.TextBox tx_yemekAd;
        private System.Windows.Forms.TextBox tx_malzeme;
        private System.Windows.Forms.TextBox tx_yemekResimismi;
        private System.Windows.Forms.TextBox tx_kategoriid;
        private System.Windows.Forms.DateTimePicker dtp_eklenmeTarihi;
        private System.Windows.Forms.DataGridView dgv_yemekEkleme;
        private System.Windows.Forms.Button btn_yemekEkle;
        private System.Windows.Forms.Button btn_yemekGuncelle;
        private System.Windows.Forms.Button btn_yemekKayitSil;
        private System.Windows.Forms.Button btn_yemekCokluSil;
        private System.Windows.Forms.Button btn_yemekTemizle;
    }
}