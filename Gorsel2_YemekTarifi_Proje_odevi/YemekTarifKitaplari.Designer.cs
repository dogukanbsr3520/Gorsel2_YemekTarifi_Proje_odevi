namespace Gorsel2_YemekTarifi_Proje_odevi
{
    partial class YemekTarifKitaplari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YemekTarifKitaplari));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_kitapAd = new System.Windows.Forms.TextBox();
            this.tx_kitapResimismi = new System.Windows.Forms.TextBox();
            this.tx_yazarAd = new System.Windows.Forms.TextBox();
            this.cbx_kategoriid = new System.Windows.Forms.ComboBox();
            this.btn_KitapResmiEkle = new System.Windows.Forms.Button();
            this.ofd_kitapResmiBul = new System.Windows.Forms.OpenFileDialog();
            this.pbx_yemekTarifKitap = new System.Windows.Forms.PictureBox();
            this.btn_kitapEkle = new System.Windows.Forms.Button();
            this.btn_kitapGuncelle = new System.Windows.Forms.Button();
            this.btn_kitapSil = new System.Windows.Forms.Button();
            this.btn_kitapCokluSil = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.dgv_kitapKayit = new System.Windows.Forms.DataGridView();
            this.tx_kitapid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_yemekTarifKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kitapKayit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarif Kitapid :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategoriid :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "kitapAd :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "YazarAd :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kitap Resim İsmi :";
            // 
            // tx_kitapAd
            // 
            this.tx_kitapAd.Location = new System.Drawing.Point(103, 254);
            this.tx_kitapAd.Name = "tx_kitapAd";
            this.tx_kitapAd.Size = new System.Drawing.Size(100, 20);
            this.tx_kitapAd.TabIndex = 7;
            // 
            // tx_kitapResimismi
            // 
            this.tx_kitapResimismi.Location = new System.Drawing.Point(103, 304);
            this.tx_kitapResimismi.Name = "tx_kitapResimismi";
            this.tx_kitapResimismi.Size = new System.Drawing.Size(100, 20);
            this.tx_kitapResimismi.TabIndex = 8;
            // 
            // tx_yazarAd
            // 
            this.tx_yazarAd.Location = new System.Drawing.Point(103, 277);
            this.tx_yazarAd.Name = "tx_yazarAd";
            this.tx_yazarAd.Size = new System.Drawing.Size(100, 20);
            this.tx_yazarAd.TabIndex = 9;
            // 
            // cbx_kategoriid
            // 
            this.cbx_kategoriid.FormattingEnabled = true;
            this.cbx_kategoriid.Location = new System.Drawing.Point(103, 232);
            this.cbx_kategoriid.Name = "cbx_kategoriid";
            this.cbx_kategoriid.Size = new System.Drawing.Size(121, 21);
            this.cbx_kategoriid.TabIndex = 11;
            // 
            // btn_KitapResmiEkle
            // 
            this.btn_KitapResmiEkle.Location = new System.Drawing.Point(175, 162);
            this.btn_KitapResmiEkle.Name = "btn_KitapResmiEkle";
            this.btn_KitapResmiEkle.Size = new System.Drawing.Size(141, 23);
            this.btn_KitapResmiEkle.TabIndex = 12;
            this.btn_KitapResmiEkle.Text = "Kitap Resmi Ekle";
            this.btn_KitapResmiEkle.UseVisualStyleBackColor = true;
            this.btn_KitapResmiEkle.Click += new System.EventHandler(this.btn_KitapResmiEkle_Click);
            // 
            // ofd_kitapResmiBul
            // 
            this.ofd_kitapResmiBul.FileName = "openFileDialog1";
            // 
            // pbx_yemekTarifKitap
            // 
            this.pbx_yemekTarifKitap.BackColor = System.Drawing.Color.DarkGray;
            this.pbx_yemekTarifKitap.Image = global::Gorsel2_YemekTarifi_Proje_odevi.Properties.Resources.KitapFoto;
            this.pbx_yemekTarifKitap.Location = new System.Drawing.Point(150, 12);
            this.pbx_yemekTarifKitap.Name = "pbx_yemekTarifKitap";
            this.pbx_yemekTarifKitap.Size = new System.Drawing.Size(196, 144);
            this.pbx_yemekTarifKitap.TabIndex = 1;
            this.pbx_yemekTarifKitap.TabStop = false;
            this.pbx_yemekTarifKitap.Click += new System.EventHandler(this.pbx_yemekTarifKitap_Click);
            // 
            // btn_kitapEkle
            // 
            this.btn_kitapEkle.Location = new System.Drawing.Point(271, 208);
            this.btn_kitapEkle.Name = "btn_kitapEkle";
            this.btn_kitapEkle.Size = new System.Drawing.Size(75, 37);
            this.btn_kitapEkle.TabIndex = 13;
            this.btn_kitapEkle.Text = "Yeni Kitap Ekle ";
            this.btn_kitapEkle.UseVisualStyleBackColor = true;
            this.btn_kitapEkle.Click += new System.EventHandler(this.btn_kitapEkle_Click);
            // 
            // btn_kitapGuncelle
            // 
            this.btn_kitapGuncelle.Location = new System.Drawing.Point(387, 208);
            this.btn_kitapGuncelle.Name = "btn_kitapGuncelle";
            this.btn_kitapGuncelle.Size = new System.Drawing.Size(75, 37);
            this.btn_kitapGuncelle.TabIndex = 14;
            this.btn_kitapGuncelle.Text = "Kitap Kaydı Güncelle";
            this.btn_kitapGuncelle.UseVisualStyleBackColor = true;
            this.btn_kitapGuncelle.Click += new System.EventHandler(this.btn_kitapGuncelle_Click);
            // 
            // btn_kitapSil
            // 
            this.btn_kitapSil.Location = new System.Drawing.Point(271, 284);
            this.btn_kitapSil.Name = "btn_kitapSil";
            this.btn_kitapSil.Size = new System.Drawing.Size(75, 38);
            this.btn_kitapSil.TabIndex = 15;
            this.btn_kitapSil.Text = "Kitap Kaydı Sil";
            this.btn_kitapSil.UseVisualStyleBackColor = true;
            this.btn_kitapSil.Click += new System.EventHandler(this.btn_kitapSil_Click);
            // 
            // btn_kitapCokluSil
            // 
            this.btn_kitapCokluSil.Location = new System.Drawing.Point(387, 284);
            this.btn_kitapCokluSil.Name = "btn_kitapCokluSil";
            this.btn_kitapCokluSil.Size = new System.Drawing.Size(75, 38);
            this.btn_kitapCokluSil.TabIndex = 16;
            this.btn_kitapCokluSil.Text = "Kitap Kaydı Çoklu Sil";
            this.btn_kitapCokluSil.UseVisualStyleBackColor = true;
            this.btn_kitapCokluSil.Click += new System.EventHandler(this.btn_kitapCokluSil_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(6, 334);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_Temizle.TabIndex = 17;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // dgv_kitapKayit
            // 
            this.dgv_kitapKayit.AllowUserToAddRows = false;
            this.dgv_kitapKayit.AllowUserToDeleteRows = false;
            this.dgv_kitapKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kitapKayit.Location = new System.Drawing.Point(15, 368);
            this.dgv_kitapKayit.Name = "dgv_kitapKayit";
            this.dgv_kitapKayit.ReadOnly = true;
            this.dgv_kitapKayit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_kitapKayit.Size = new System.Drawing.Size(447, 123);
            this.dgv_kitapKayit.TabIndex = 18;
            this.dgv_kitapKayit.SelectionChanged += new System.EventHandler(this.dgv_kitapKayit_SelectionChanged);
            // 
            // tx_kitapid
            // 
            this.tx_kitapid.Location = new System.Drawing.Point(103, 204);
            this.tx_kitapid.Name = "tx_kitapid";
            this.tx_kitapid.Size = new System.Drawing.Size(100, 20);
            this.tx_kitapid.TabIndex = 19;
            // 
            // YemekTarifKitaplari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(476, 503);
            this.Controls.Add(this.tx_kitapid);
            this.Controls.Add(this.dgv_kitapKayit);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_kitapCokluSil);
            this.Controls.Add(this.btn_kitapSil);
            this.Controls.Add(this.btn_kitapGuncelle);
            this.Controls.Add(this.btn_kitapEkle);
            this.Controls.Add(this.btn_KitapResmiEkle);
            this.Controls.Add(this.cbx_kategoriid);
            this.Controls.Add(this.tx_yazarAd);
            this.Controls.Add(this.tx_kitapResimismi);
            this.Controls.Add(this.tx_kitapAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbx_yemekTarifKitap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YemekTarifKitaplari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YemekTarifKitaplari";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YemekTarifKitaplari_FormClosing);
            this.Load += new System.EventHandler(this.YemekTarifKitaplari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_yemekTarifKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kitapKayit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_yemekTarifKitap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_kitapAd;
        private System.Windows.Forms.TextBox tx_kitapResimismi;
        private System.Windows.Forms.TextBox tx_yazarAd;
        private System.Windows.Forms.ComboBox cbx_kategoriid;
        private System.Windows.Forms.Button btn_KitapResmiEkle;
        private System.Windows.Forms.OpenFileDialog ofd_kitapResmiBul;
        private System.Windows.Forms.Button btn_kitapEkle;
        private System.Windows.Forms.Button btn_kitapGuncelle;
        private System.Windows.Forms.Button btn_kitapSil;
        private System.Windows.Forms.Button btn_kitapCokluSil;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.DataGridView dgv_kitapKayit;
        private System.Windows.Forms.TextBox tx_kitapid;
    }
}