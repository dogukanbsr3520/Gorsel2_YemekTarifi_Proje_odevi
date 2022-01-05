namespace Gorsel2_YemekTarifi_Proje_odevi
{
    partial class KullaniciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGiris));
            this.btn_Giris = new System.Windows.Forms.Button();
            this.tx_kullaniciAd = new System.Windows.Forms.TextBox();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Giris
            // 
            this.btn_Giris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Giris.Image = ((System.Drawing.Image)(resources.GetObject("btn_Giris.Image")));
            this.btn_Giris.Location = new System.Drawing.Point(205, 192);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(48, 28);
            this.btn_Giris.TabIndex = 2;
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // tx_kullaniciAd
            // 
            this.tx_kullaniciAd.Location = new System.Drawing.Point(68, 81);
            this.tx_kullaniciAd.Name = "tx_kullaniciAd";
            this.tx_kullaniciAd.Size = new System.Drawing.Size(168, 20);
            this.tx_kullaniciAd.TabIndex = 3;
            // 
            // tx_sifre
            // 
            this.tx_sifre.Location = new System.Drawing.Point(68, 121);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.PasswordChar = '*';
            this.tx_sifre.Size = new System.Drawing.Size(168, 20);
            this.tx_sifre.TabIndex = 4;
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(299, 298);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.tx_kullaniciAd);
            this.Controls.Add(this.btn_Giris);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_=Kullanıcı Giriş=_";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.TextBox tx_kullaniciAd;
        private System.Windows.Forms.TextBox tx_sifre;
    }
}

