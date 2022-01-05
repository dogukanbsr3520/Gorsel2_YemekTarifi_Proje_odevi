using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel2_YemekTarifi_Proje_odevi
{
    public partial class KullanıcıTürKayıtları : Form
    {
        public KullanıcıTürKayıtları()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void KullanıcıTürKayıtları_Load(object sender, EventArgs e)
        {
            dgv_kullaniciTurKayitlar.DataSource = vt.Select("select kullaniciTur_id,kullaniciTur from tbl_kullaniciTur");
        }

        private void btn_kullaniciTurEkle_Click(object sender, EventArgs e)
        {
            int kayitSay = vt.UpdateDelete("insert into tbl_kullaniciTur(kullaniciTur_id,kullaniciTur)values('" + tx_kullaniciTurid.Text + "', '" + tx_kullaniciTurAd.Text + "')");
            if (kayitSay > 0) 
            {
                KullanıcıTürKayıtları_Load(null, null);
                MessageBox.Show("Yeni Kullanıcı Türü Başarılı Bir Şekilde Eklendi !");
            }
        }

        private void btn_kullaniciTurGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_kullaniciTurKayitlar.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Öncelikle Güncellenecek Satır Seçilmelidir !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_kullaniciTur
                                            set kullaniciTur_id='"+tx_kullaniciTurid.Text+@"',
                                            kullaniciTur='"+tx_kullaniciTurAd.Text+ @"'
                                            where kullaniciTur_id=" + dgv_kullaniciTurKayitlar.SelectedRows[0].Cells["kullaniciTur_id"].Value);
            if (kayitSay > 0)
            {
                KullanıcıTürKayıtları_Load(null,null);
                MessageBox.Show("Seçili Kullanıcı Tür Kaydı Başarılı Bir Şekilde Güncellendi !");
            }
        }

        private void btn_kullaniciTurSil_Click(object sender, EventArgs e)
        {
            if (dgv_kullaniciTurKayitlar.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Silinecek Satır Seçilmelidir !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_kullaniciTur where kullaniciTur_id=" + dgv_kullaniciTurKayitlar.SelectedRows[0].Cells["kullaniciTur_id"].Value);
            if (kayitSay > 0) 
            {
                KullanıcıTürKayıtları_Load(null,null);
                MessageBox.Show("Seçili Satır Kaydı Silindi !");
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_kullaniciTurid.Text = "";
            tx_kullaniciTurAd.Text = "";

            foreach (DataGridViewRow item in dgv_kullaniciTurKayitlar.SelectedRows) 
            {
                item.Selected = false;
            }
        }

        private void dgv_kullaniciTurKayitlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_kullaniciTurKayitlar.SelectedRows.Count == 0) 
            {
                return;
            }
            tx_kullaniciTurid.Text = dgv_kullaniciTurKayitlar.SelectedRows[0].Cells["kullaniciTur_id"].Value.ToString();
            tx_kullaniciTurAd.Text = dgv_kullaniciTurKayitlar.SelectedRows[0].Cells["kullaniciTur"].Value.ToString();

        }

        private void KullanıcıTürKayıtları_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (this.MdiParent != null)
            //{
            //    AnaForm afrm = (AnaForm)this.MdiParent;
            //    afrm.tsbtn_kullaniciTurleri.Enabled = true;
            //}
        }
    }
}
