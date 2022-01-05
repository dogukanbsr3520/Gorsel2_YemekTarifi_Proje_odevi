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
    public partial class Yorumlar : Form
    {
        public Yorumlar()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void Yorumlar_Load(object sender, EventArgs e)
        {
            dgv_yorumKayit.DataSource = vt.Select("select yorum_id,yorum,kullanici_id,eklenmeTarihi,icerik,yemek_id from tbl_yorumlar");

            cbx_yemekid.DisplayMember = "yemek_id";
            cbx_yemekid.ValueMember = "yemek_id";
            cbx_yemekid.DataSource = vt.Select("select yemek_id,yemekAd,malzeme,yemekResim,yemekEklenmeTarihi,kategori_id from tbl_yemek");
        }

        private void btn_yorumEkle_Click(object sender, EventArgs e)
        {
            int kayitSay = vt.UpdateDelete("insert into tbl_yorumlar(yorum_id,yorum,kullanici_id,eklenmeTarihi,icerik,yemek_id)values('" + tx_yorumid.Text + "', '" + tx_yorum.Text + "', '" + tx_kullaniciid.Text + "', '" + dtp_yorumEklenmeTarihi.Value.ToShortTimeString() + "', '" + tx_icerik.Text + "', '" + cbx_yemekid.SelectedValue + "')");
            if (kayitSay > 0) 
            {
                Yorumlar_Load(null,null);
                MessageBox.Show("Yeni Yorum Kaydı  Eklendi.");
            }
        }

        private void btn_yorumGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_yorumKayit.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Güncellemek İstediğiniz Yorum'un Üzerine Tıklayınız !");
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_yorumlar
                                            set yorum_id='"+tx_yorumid.Text+@"',
                                            yorum='"+tx_yorum.Text+@"',
                                            kullanici_id='"+tx_kullaniciid.Text+@"',
                                            eklenmeTarihi='"+ dtp_yorumEklenmeTarihi.Value.ToShortTimeString() + @"',
                                            icerik='"+tx_icerik.Text+@"',
                                            yemek_id='"+cbx_yemekid.SelectedValue+ @"'
                                             where yorum_id=" + dgv_yorumKayit.SelectedRows[0].Cells["yorum_id"].Value);
            if (kayitSay > 0) 
            {
                Yorumlar_Load(null, null);
                MessageBox.Show("Seçilen Yorum Güncellendi.");
            }
        }

        private void btn_yorumCokluSil_Click(object sender, EventArgs e)
        {
            if (dgv_yorumKayit.SelectedRows.Count == 0)
            {
                MessageBox.Show("Birden Fazla Yorum Silmek İçin Öncelikle Satır Seçmelisiniz !");
                return;
            }
            int kayitSay = 0;
            for (int i = 0; i < dgv_yorumKayit.SelectedRows.Count; i++) 
            {
                kayitSay += vt.UpdateDelete("delete from tbl_yorumlar where yorum_id=" + dgv_yorumKayit.SelectedRows[i].Cells["yorum_id"].Value);
            }
            if (kayitSay > 0)
            {
                Yorumlar_Load(null, null);
                MessageBox.Show(kayitSay+" Yorum Kaydını Sildiniz.");
            }
        }
        private void btn_yorumSil_Click(object sender, EventArgs e)
        {
            if (dgv_yorumKayit.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Silinecek Yorum'un Bulunduğu Satırı Seçiniz !");
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_yorumlar where yorum_id=" + dgv_yorumKayit.SelectedRows[0].Cells["yorum_id"].Value);
            if (kayitSay > 0)
            {
                Yorumlar_Load(null, null);
                MessageBox.Show("Yorum Kaydını Sildiniz.");
            }
        }
        private void dgv_yorumKayit_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_yorumKayit.SelectedRows.Count == 0) 
            {
                return;
            }
            tx_yorum.Text = dgv_yorumKayit.SelectedRows[0].Cells["yorum"].Value.ToString();
            tx_yorumid.Text = dgv_yorumKayit.SelectedRows[0].Cells["yorum_id"].Value.ToString();
            tx_kullaniciid.Text = dgv_yorumKayit.SelectedRows[0].Cells["kullanici_id"].Value.ToString();
            tx_icerik.Text=dgv_yorumKayit.SelectedRows[0].Cells["icerik"].Value.ToString();
            cbx_yemekid.SelectedValue= dgv_yorumKayit.SelectedRows[0].Cells["yemek_id"].Value.ToString();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_yorumid.Text = "";
            tx_yorum.Text = "";
            tx_kullaniciid.Text = "";
            tx_icerik.Text = "";
            cbx_yemekid.SelectedValue = -1;

            foreach (DataGridViewRow item in dgv_yorumKayit.SelectedRows)
            {
                item.Selected = false;
            }
        }

        private void Yorumlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiParent != null)
            {
                AnaForm afrm = (AnaForm)this.MdiParent;
                afrm.tsbtn_yorumlar.Enabled = true;
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
