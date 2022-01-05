namespace Gorsel2_YemekTarifi_Proje_odevi
{
    partial class Tarifler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarifler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_yemekid = new System.Windows.Forms.ComboBox();
            this.cbx_kullaniciid = new System.Windows.Forms.ComboBox();
            this.tx_tarifid = new System.Windows.Forms.TextBox();
            this.tx_icerik = new System.Windows.Forms.TextBox();
            this.tx_tarifAd = new System.Windows.Forms.TextBox();
            this.dtp_eklenmeTarihi = new System.Windows.Forms.DateTimePicker();
            this.dgv_tarifKayit = new System.Windows.Forms.DataGridView();
            this.btn_yeniTarifEkle = new System.Windows.Forms.Button();
            this.btn_tarifGuncelle = new System.Windows.Forms.Button();
            this.btn_tarifSil = new System.Windows.Forms.Button();
            this.btn_tarifCokluSil = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tarifKayit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarifid :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarif Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarif İçerik :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yemekid :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Eklenme Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "kullaniciid :";
            // 
            // cbx_yemekid
            // 
            this.cbx_yemekid.FormattingEnabled = true;
            this.cbx_yemekid.Location = new System.Drawing.Point(87, 214);
            this.cbx_yemekid.Name = "cbx_yemekid";
            this.cbx_yemekid.Size = new System.Drawing.Size(121, 21);
            this.cbx_yemekid.TabIndex = 6;
            // 
            // cbx_kullaniciid
            // 
            this.cbx_kullaniciid.FormattingEnabled = true;
            this.cbx_kullaniciid.Location = new System.Drawing.Point(87, 282);
            this.cbx_kullaniciid.Name = "cbx_kullaniciid";
            this.cbx_kullaniciid.Size = new System.Drawing.Size(121, 21);
            this.cbx_kullaniciid.TabIndex = 7;
            // 
            // tx_tarifid
            // 
            this.tx_tarifid.Location = new System.Drawing.Point(86, 9);
            this.tx_tarifid.Name = "tx_tarifid";
            this.tx_tarifid.Size = new System.Drawing.Size(100, 20);
            this.tx_tarifid.TabIndex = 8;
            // 
            // tx_icerik
            // 
            this.tx_icerik.Location = new System.Drawing.Point(86, 78);
            this.tx_icerik.Multiline = true;
            this.tx_icerik.Name = "tx_icerik";
            this.tx_icerik.Size = new System.Drawing.Size(300, 124);
            this.tx_icerik.TabIndex = 10;
            // 
            // tx_tarifAd
            // 
            this.tx_tarifAd.Location = new System.Drawing.Point(86, 44);
            this.tx_tarifAd.Name = "tx_tarifAd";
            this.tx_tarifAd.Size = new System.Drawing.Size(100, 20);
            this.tx_tarifAd.TabIndex = 11;
            // 
            // dtp_eklenmeTarihi
            // 
            this.dtp_eklenmeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_eklenmeTarihi.Location = new System.Drawing.Point(87, 248);
            this.dtp_eklenmeTarihi.MinDate = new System.DateTime(2020, 12, 26, 0, 0, 0, 0);
            this.dtp_eklenmeTarihi.Name = "dtp_eklenmeTarihi";
            this.dtp_eklenmeTarihi.Size = new System.Drawing.Size(121, 20);
            this.dtp_eklenmeTarihi.TabIndex = 12;
            this.dtp_eklenmeTarihi.Value = new System.DateTime(2020, 12, 26, 20, 28, 0, 0);
            this.dtp_eklenmeTarihi.ValueChanged += new System.EventHandler(this.dtp_eklenmeTarihi_ValueChanged);
            // 
            // dgv_tarifKayit
            // 
            this.dgv_tarifKayit.AllowUserToAddRows = false;
            this.dgv_tarifKayit.AllowUserToDeleteRows = false;
            this.dgv_tarifKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tarifKayit.Location = new System.Drawing.Point(233, 230);
            this.dgv_tarifKayit.Name = "dgv_tarifKayit";
            this.dgv_tarifKayit.ReadOnly = true;
            this.dgv_tarifKayit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tarifKayit.Size = new System.Drawing.Size(428, 150);
            this.dgv_tarifKayit.TabIndex = 14;
            this.dgv_tarifKayit.SelectionChanged += new System.EventHandler(this.dgv_tarifKayit_SelectionChanged);
            // 
            // btn_yeniTarifEkle
            // 
            this.btn_yeniTarifEkle.Location = new System.Drawing.Point(25, 341);
            this.btn_yeniTarifEkle.Name = "btn_yeniTarifEkle";
            this.btn_yeniTarifEkle.Size = new System.Drawing.Size(75, 39);
            this.btn_yeniTarifEkle.TabIndex = 15;
            this.btn_yeniTarifEkle.Text = "Yeni Tarif Ekle";
            this.btn_yeniTarifEkle.UseVisualStyleBackColor = true;
            this.btn_yeniTarifEkle.Click += new System.EventHandler(this.btn_yeniTarifEkle_Click);
            // 
            // btn_tarifGuncelle
            // 
            this.btn_tarifGuncelle.Location = new System.Drawing.Point(133, 341);
            this.btn_tarifGuncelle.Name = "btn_tarifGuncelle";
            this.btn_tarifGuncelle.Size = new System.Drawing.Size(75, 39);
            this.btn_tarifGuncelle.TabIndex = 16;
            this.btn_tarifGuncelle.Text = "Tarif Güncelle";
            this.btn_tarifGuncelle.UseVisualStyleBackColor = true;
            this.btn_tarifGuncelle.Click += new System.EventHandler(this.btn_tarifGuncelle_Click);
            // 
            // btn_tarifSil
            // 
            this.btn_tarifSil.Location = new System.Drawing.Point(25, 386);
            this.btn_tarifSil.Name = "btn_tarifSil";
            this.btn_tarifSil.Size = new System.Drawing.Size(75, 23);
            this.btn_tarifSil.TabIndex = 17;
            this.btn_tarifSil.Text = "Tarif Sil";
            this.btn_tarifSil.UseVisualStyleBackColor = true;
            this.btn_tarifSil.Click += new System.EventHandler(this.btn_tarifSil_Click);
            // 
            // btn_tarifCokluSil
            // 
            this.btn_tarifCokluSil.Location = new System.Drawing.Point(133, 386);
            this.btn_tarifCokluSil.Name = "btn_tarifCokluSil";
            this.btn_tarifCokluSil.Size = new System.Drawing.Size(94, 23);
            this.btn_tarifCokluSil.TabIndex = 18;
            this.btn_tarifCokluSil.Text = "Tarif Çoklu Sil";
            this.btn_tarifCokluSil.UseVisualStyleBackColor = true;
            this.btn_tarifCokluSil.Click += new System.EventHandler(this.btn_tarifCokluSil_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(176, 309);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(51, 23);
            this.btn_temizle.TabIndex = 19;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Gorsel2_YemekTarifi_Proje_odevi.Properties.Resources.tariflerFoto;
            this.pictureBox1.Image = global::Gorsel2_YemekTarifi_Proje_odevi.Properties.Resources.tariflerFoto;
            this.pictureBox1.Location = new System.Drawing.Point(403, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 190);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Tarifler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(673, 412);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_tarifCokluSil);
            this.Controls.Add(this.btn_tarifSil);
            this.Controls.Add(this.btn_tarifGuncelle);
            this.Controls.Add(this.btn_yeniTarifEkle);
            this.Controls.Add(this.dgv_tarifKayit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtp_eklenmeTarihi);
            this.Controls.Add(this.tx_tarifAd);
            this.Controls.Add(this.tx_icerik);
            this.Controls.Add(this.tx_tarifid);
            this.Controls.Add(this.cbx_kullaniciid);
            this.Controls.Add(this.cbx_yemekid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tarifler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarifler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tarifler_FormClosing);
            this.Load += new System.EventHandler(this.Tarifler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tarifKayit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_yemekid;
        private System.Windows.Forms.ComboBox cbx_kullaniciid;
        private System.Windows.Forms.TextBox tx_tarifid;
        private System.Windows.Forms.TextBox tx_icerik;
        private System.Windows.Forms.TextBox tx_tarifAd;
        private System.Windows.Forms.DateTimePicker dtp_eklenmeTarihi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_tarifKayit;
        private System.Windows.Forms.Button btn_yeniTarifEkle;
        private System.Windows.Forms.Button btn_tarifGuncelle;
        private System.Windows.Forms.Button btn_tarifSil;
        private System.Windows.Forms.Button btn_tarifCokluSil;
        private System.Windows.Forms.Button btn_temizle;
    }
}