namespace Gorsel2_YemekTarifi_Proje_odevi
{
    partial class Kullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanici));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_kullaniciAd = new System.Windows.Forms.TextBox();
            this.tx_kullaniciSoyad = new System.Windows.Forms.TextBox();
            this.tx_Email = new System.Windows.Forms.TextBox();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.btn_kullaniciEkle = new System.Windows.Forms.Button();
            this.btn_kullaniciGuncelle = new System.Windows.Forms.Button();
            this.btn_kullaniciSil = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.btn_kullaniciCokluSilme = new System.Windows.Forms.Button();
            this.dgv_Kullanici = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_kullaniciid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_kullaniciTurid = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Ad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(49, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(5, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(49, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre :";
            // 
            // tx_kullaniciAd
            // 
            this.tx_kullaniciAd.Location = new System.Drawing.Point(96, 222);
            this.tx_kullaniciAd.Name = "tx_kullaniciAd";
            this.tx_kullaniciAd.Size = new System.Drawing.Size(100, 20);
            this.tx_kullaniciAd.TabIndex = 4;
            this.tx_kullaniciAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kullanici_KeyPress);
            // 
            // tx_kullaniciSoyad
            // 
            this.tx_kullaniciSoyad.Location = new System.Drawing.Point(96, 252);
            this.tx_kullaniciSoyad.Name = "tx_kullaniciSoyad";
            this.tx_kullaniciSoyad.Size = new System.Drawing.Size(100, 20);
            this.tx_kullaniciSoyad.TabIndex = 5;
            this.tx_kullaniciSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kullanici_KeyPress);
            // 
            // tx_Email
            // 
            this.tx_Email.Location = new System.Drawing.Point(96, 278);
            this.tx_Email.MaxLength = 10;
            this.tx_Email.Name = "tx_Email";
            this.tx_Email.Size = new System.Drawing.Size(100, 20);
            this.tx_Email.TabIndex = 6;
            // 
            // tx_sifre
            // 
            this.tx_sifre.Location = new System.Drawing.Point(96, 309);
            this.tx_sifre.MaxLength = 8;
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.Size = new System.Drawing.Size(100, 20);
            this.tx_sifre.TabIndex = 7;
            this.tx_sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_sifre_KeyPress);
            // 
            // btn_kullaniciEkle
            // 
            this.btn_kullaniciEkle.Location = new System.Drawing.Point(258, 192);
            this.btn_kullaniciEkle.Name = "btn_kullaniciEkle";
            this.btn_kullaniciEkle.Size = new System.Drawing.Size(75, 46);
            this.btn_kullaniciEkle.TabIndex = 8;
            this.btn_kullaniciEkle.Text = "Kullanıcı Ekle";
            this.btn_kullaniciEkle.UseVisualStyleBackColor = true;
            this.btn_kullaniciEkle.Click += new System.EventHandler(this.btn_kullaniciEkle_Click);
            // 
            // btn_kullaniciGuncelle
            // 
            this.btn_kullaniciGuncelle.Location = new System.Drawing.Point(420, 192);
            this.btn_kullaniciGuncelle.Name = "btn_kullaniciGuncelle";
            this.btn_kullaniciGuncelle.Size = new System.Drawing.Size(75, 46);
            this.btn_kullaniciGuncelle.TabIndex = 9;
            this.btn_kullaniciGuncelle.Text = "Kullanıcı Güncelle";
            this.btn_kullaniciGuncelle.UseVisualStyleBackColor = true;
            this.btn_kullaniciGuncelle.Click += new System.EventHandler(this.btn_kullaniciGuncelle_Click);
            // 
            // btn_kullaniciSil
            // 
            this.btn_kullaniciSil.Location = new System.Drawing.Point(258, 313);
            this.btn_kullaniciSil.Name = "btn_kullaniciSil";
            this.btn_kullaniciSil.Size = new System.Drawing.Size(75, 44);
            this.btn_kullaniciSil.TabIndex = 10;
            this.btn_kullaniciSil.Text = "Kullanıcı Sil";
            this.btn_kullaniciSil.UseVisualStyleBackColor = true;
            this.btn_kullaniciSil.Click += new System.EventHandler(this.btn_kullaniciSil_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(342, 255);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(75, 46);
            this.btn_Temizle.TabIndex = 11;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_kullaniciCokluSilme
            // 
            this.btn_kullaniciCokluSilme.Location = new System.Drawing.Point(423, 315);
            this.btn_kullaniciCokluSilme.Name = "btn_kullaniciCokluSilme";
            this.btn_kullaniciCokluSilme.Size = new System.Drawing.Size(75, 42);
            this.btn_kullaniciCokluSilme.TabIndex = 12;
            this.btn_kullaniciCokluSilme.Text = "Çoklu Kullanıcı Sil";
            this.btn_kullaniciCokluSilme.UseVisualStyleBackColor = true;
            this.btn_kullaniciCokluSilme.Click += new System.EventHandler(this.btn_kullaniciCokluSilme_Click);
            // 
            // dgv_Kullanici
            // 
            this.dgv_Kullanici.AllowUserToAddRows = false;
            this.dgv_Kullanici.AllowUserToDeleteRows = false;
            this.dgv_Kullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kullanici.Location = new System.Drawing.Point(15, 36);
            this.dgv_Kullanici.Name = "dgv_Kullanici";
            this.dgv_Kullanici.ReadOnly = true;
            this.dgv_Kullanici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Kullanici.Size = new System.Drawing.Size(483, 150);
            this.dgv_Kullanici.TabIndex = 13;
            this.dgv_Kullanici.SelectionChanged += new System.EventHandler(this.dgv_Kullanici_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(147, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kullanıcı İşlemleri Sayfasına Hoşgeldiniz...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(15, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kullanıcı id :";
            // 
            // tx_kullaniciid
            // 
            this.tx_kullaniciid.Location = new System.Drawing.Point(96, 193);
            this.tx_kullaniciid.Name = "tx_kullaniciid";
            this.tx_kullaniciid.Size = new System.Drawing.Size(100, 20);
            this.tx_kullaniciid.TabIndex = 16;
            this.tx_kullaniciid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_kullaniciid_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(8, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "kullaniciTurid :";
            // 
            // cbx_kullaniciTurid
            // 
            this.cbx_kullaniciTurid.FormattingEnabled = true;
            this.cbx_kullaniciTurid.Location = new System.Drawing.Point(96, 341);
            this.cbx_kullaniciTurid.Name = "cbx_kullaniciTurid";
            this.cbx_kullaniciTurid.Size = new System.Drawing.Size(100, 21);
            this.cbx_kullaniciTurid.TabIndex = 18;
            // 
            // Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(507, 366);
            this.Controls.Add(this.cbx_kullaniciTurid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tx_kullaniciid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_Kullanici);
            this.Controls.Add(this.btn_kullaniciCokluSilme);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_kullaniciSil);
            this.Controls.Add(this.btn_kullaniciGuncelle);
            this.Controls.Add(this.btn_kullaniciEkle);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.tx_Email);
            this.Controls.Add(this.tx_kullaniciSoyad);
            this.Controls.Add(this.tx_kullaniciAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kullanici_FormClosing);
            this.Load += new System.EventHandler(this.Kullanici_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kullanici_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kullanici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_kullaniciAd;
        private System.Windows.Forms.TextBox tx_kullaniciSoyad;
        private System.Windows.Forms.TextBox tx_Email;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.Windows.Forms.Button btn_kullaniciEkle;
        private System.Windows.Forms.Button btn_kullaniciGuncelle;
        private System.Windows.Forms.Button btn_kullaniciSil;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Button btn_kullaniciCokluSilme;
        private System.Windows.Forms.DataGridView dgv_Kullanici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_kullaniciid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_kullaniciTurid;
    }
}