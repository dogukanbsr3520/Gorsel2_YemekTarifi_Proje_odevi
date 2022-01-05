using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTI;

namespace Gorsel2_YemekTarifi_Proje_odevi
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (tx_kullaniciAd.Text == "" || tx_sifre.Text == "")
            {
                MessageBox.Show("İlgili Alanlar Boş Bırakılamaz ! ");
                return;
            }
            DataTable dtSonuc = vt.Select("select * from tbl_kullanici where kullanici_id = '" + tx_kullaniciAd.Text + "' and sifre = '" + vt.MD5Sifrele(tx_sifre.Text) + "'");
            if (dtSonuc.Rows.Count == 0)
            {
                MessageBox.Show("Kullanıcı ad veya Şifreniz Hatalı !");
                return;
            }
                this.Hide();
                AnaForm afrm = new AnaForm();

            int kullaniciTur_id = Convert.ToInt32(dtSonuc.Rows[0]["kullaniciTur_id"]);
            if (kullaniciTur_id != 1) 
            {
                afrm.tsbtn_Kullanici.Visible = false;
                afrm.tsbtn_kullaniciTurleri.Visible = false;
                afrm.tsbtn_yemekEkleme.Visible = false;
                afrm.tsbtn_yemekTarifKitaplari.Visible = false;
            }

                afrm.Show();
                return;
            
           
        }
    }
}
