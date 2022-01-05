namespace Gorsel2_YemekTarifi_Proje_odevi
{
    partial class KullanıcıTürKayıtları
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıTürKayıtları));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_kullaniciTurid = new System.Windows.Forms.TextBox();
            this.tx_kullaniciTurAd = new System.Windows.Forms.TextBox();
            this.btn_kullaniciTurEkle = new System.Windows.Forms.Button();
            this.btn_kullaniciTurGuncelle = new System.Windows.Forms.Button();
            this.btn_kullaniciTurSil = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.dgv_kullaniciTurKayitlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kullaniciTurKayitlar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "kullanıcı Türid :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Tür Ad :";
            // 
            // tx_kullaniciTurid
            // 
            this.tx_kullaniciTurid.Location = new System.Drawing.Point(87, 87);
            this.tx_kullaniciTurid.Name = "tx_kullaniciTurid";
            this.tx_kullaniciTurid.Size = new System.Drawing.Size(100, 20);
            this.tx_kullaniciTurid.TabIndex = 2;
            // 
            // tx_kullaniciTurAd
            // 
            this.tx_kullaniciTurAd.Location = new System.Drawing.Point(87, 149);
            this.tx_kullaniciTurAd.Name = "tx_kullaniciTurAd";
            this.tx_kullaniciTurAd.Size = new System.Drawing.Size(100, 20);
            this.tx_kullaniciTurAd.TabIndex = 3;
            // 
            // btn_kullaniciTurEkle
            // 
            this.btn_kullaniciTurEkle.Location = new System.Drawing.Point(212, 26);
            this.btn_kullaniciTurEkle.Name = "btn_kullaniciTurEkle";
            this.btn_kullaniciTurEkle.Size = new System.Drawing.Size(65, 34);
            this.btn_kullaniciTurEkle.TabIndex = 4;
            this.btn_kullaniciTurEkle.Text = "Kullanıcı Türü Ekle";
            this.btn_kullaniciTurEkle.UseVisualStyleBackColor = true;
            this.btn_kullaniciTurEkle.Click += new System.EventHandler(this.btn_kullaniciTurEkle_Click);
            // 
            // btn_kullaniciTurGuncelle
            // 
            this.btn_kullaniciTurGuncelle.Location = new System.Drawing.Point(295, 12);
            this.btn_kullaniciTurGuncelle.Name = "btn_kullaniciTurGuncelle";
            this.btn_kullaniciTurGuncelle.Size = new System.Drawing.Size(75, 47);
            this.btn_kullaniciTurGuncelle.TabIndex = 5;
            this.btn_kullaniciTurGuncelle.Text = "Kullanıcı Türü Güncelle";
            this.btn_kullaniciTurGuncelle.UseVisualStyleBackColor = true;
            this.btn_kullaniciTurGuncelle.Click += new System.EventHandler(this.btn_kullaniciTurGuncelle_Click);
            // 
            // btn_kullaniciTurSil
            // 
            this.btn_kullaniciTurSil.Location = new System.Drawing.Point(386, 6);
            this.btn_kullaniciTurSil.Name = "btn_kullaniciTurSil";
            this.btn_kullaniciTurSil.Size = new System.Drawing.Size(75, 53);
            this.btn_kullaniciTurSil.TabIndex = 6;
            this.btn_kullaniciTurSil.Text = "Kullanıcı Türü Sil";
            this.btn_kullaniciTurSil.UseVisualStyleBackColor = true;
            this.btn_kullaniciTurSil.Click += new System.EventHandler(this.btn_kullaniciTurSil_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(145, 193);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(51, 23);
            this.btn_Temizle.TabIndex = 7;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // dgv_kullaniciTurKayitlar
            // 
            this.dgv_kullaniciTurKayitlar.AllowUserToAddRows = false;
            this.dgv_kullaniciTurKayitlar.AllowUserToDeleteRows = false;
            this.dgv_kullaniciTurKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kullaniciTurKayitlar.Location = new System.Drawing.Point(220, 87);
            this.dgv_kullaniciTurKayitlar.Name = "dgv_kullaniciTurKayitlar";
            this.dgv_kullaniciTurKayitlar.ReadOnly = true;
            this.dgv_kullaniciTurKayitlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_kullaniciTurKayitlar.Size = new System.Drawing.Size(240, 150);
            this.dgv_kullaniciTurKayitlar.TabIndex = 8;
            this.dgv_kullaniciTurKayitlar.SelectionChanged += new System.EventHandler(this.dgv_kullaniciTurKayitlar_SelectionChanged);
            // 
            // KullanıcıTürKayıtları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(472, 261);
            this.Controls.Add(this.dgv_kullaniciTurKayitlar);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_kullaniciTurSil);
            this.Controls.Add(this.btn_kullaniciTurGuncelle);
            this.Controls.Add(this.btn_kullaniciTurEkle);
            this.Controls.Add(this.tx_kullaniciTurAd);
            this.Controls.Add(this.tx_kullaniciTurid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullanıcıTürKayıtları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullanıcıTürKayıtları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KullanıcıTürKayıtları_FormClosing);
            this.Load += new System.EventHandler(this.KullanıcıTürKayıtları_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kullaniciTurKayitlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_kullaniciTurid;
        private System.Windows.Forms.TextBox tx_kullaniciTurAd;
        private System.Windows.Forms.Button btn_kullaniciTurEkle;
        private System.Windows.Forms.Button btn_kullaniciTurGuncelle;
        private System.Windows.Forms.Button btn_kullaniciTurSil;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.DataGridView dgv_kullaniciTurKayitlar;
    }
}