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
    public partial class YemekEkleme : Form
    {
        public YemekEkleme()
        {
            InitializeComponent();
        }

        private void btn_resimEkle_Click(object sender, EventArgs e)
        {
            pbx_yemekResim.SizeMode = PictureBoxSizeMode.StretchImage;
            ofd_DosyaAçma.ShowDialog();
            pbx_yemekResim.ImageLocation = ofd_DosyaAçma.FileName;
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void YemekEkleme_Load(object sender, EventArgs e)
        {
            dgv_yemekEkleme.DataSource = vt.Select("select yemek_id,yemekAd,malzeme,yemekResim,yemekEklenmeTarihi,kategori_id from tbl_yemek");
        }

        private void btn_yemekEkle_Click(object sender, EventArgs e)
        {
            int kayitsay = vt.UpdateDelete("insert into tbl_yemek(yemek_id,yemekAd,malzeme,yemekResim,yemekEklenmeTarihi,kategori_id)values('" + tx_yemekid.Text + "', '" + tx_yemekAd.Text + "', '" + tx_malzeme.Text + "', '" + tx_yemekResimismi.Text + "', '" + dtp_eklenmeTarihi.Value.ToShortTimeString() + "', '" + tx_kategoriid.Text + "')");
            if (kayitsay > 0) 
            {
                YemekEkleme_Load(null, null);
                MessageBox.Show("Yeni Yemek Eklendi,Yeni Çıktı Fırından :)");
            }
        }

        private void btn_yemekGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_yemekEkleme.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Güncellemek İstediğiniz yemeğin bulunduğu satıra tıklayınız !");
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_yemek
                                            set yemekAd = '"+tx_yemekAd.Text+@"',
                                            malzeme = '"+tx_malzeme.Text+@"',
                                            yemekResim = '"+tx_yemekResimismi.Text+@"',
                                            yemekEklenmeTarihi = '"+ dtp_eklenmeTarihi.Value.ToShortTimeString()+ @"',
                                            kategori_id = '"+tx_kategoriid.Text+ @"'
                                            where yemek_id = " + dgv_yemekEkleme.SelectedRows[0].Cells["yemek_id"].Value);
            if (kayitSay > 0) 
            {
                YemekEkleme_Load(null,null);
                MessageBox.Show("Seçilen Yemek Kaydı Güncellendi.");
            }
        }
        private void btn_yemekKayitSil_Click(object sender, EventArgs e)
        {
            if (dgv_yemekEkleme.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Yemek Kaydı Silmek İçin Öncelikle Satır Seçili Olmalı !");
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_yemek where yemek_id=" + dgv_yemekEkleme.SelectedRows[0].Cells["yemek_id"].Value);
            if (kayitSay > 0) 
            {
                YemekEkleme_Load(null,null);
                MessageBox.Show("Seçilen Yemek Kaydı Silindi.");
            }
        }


        private void btn_yemekCokluSil_Click(object sender, EventArgs e)
        {
            if (dgv_yemekEkleme.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Birden Fazla Satır Silmek İçin Öncelikle Rastgele Satır Seçiniz.");
                return;
            }
            int kayitSay = 0;
            for (int i = 0; i < dgv_yemekEkleme.SelectedRows.Count; i++) 
            {
                kayitSay+=vt.UpdateDelete("delete from tbl_yemek where yemek_id=" + dgv_yemekEkleme.SelectedRows[i].Cells["yemek_id"].Value);
            }
            if(kayitSay>0)
            {
                YemekEkleme_Load(null, null);
                MessageBox.Show(kayitSay+" Yemek Kaydı Silindi.");
            }
        }

        private void btn_yemekTemizle_Click(object sender, EventArgs e)
        {
            tx_yemekid.Text = "";
            tx_yemekAd.Text = "";
            tx_malzeme.Text = "";
            tx_yemekResimismi.Text = "";
            tx_kategoriid.Text = "";

            foreach (DataGridViewRow item in dgv_yemekEkleme.SelectedRows)
            {
                item.Selected = true;
            }
        }

        private void dgv_yemekEkleme_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_yemekEkleme.SelectedRows.Count == 0) 
            {
                return;
            }
            tx_yemekid.Text = dgv_yemekEkleme.SelectedRows[0].Cells["yemek_id"].Value.ToString();
            tx_yemekAd.Text = dgv_yemekEkleme.SelectedRows[0].Cells["yemekAd"].Value.ToString();
            tx_malzeme.Text = dgv_yemekEkleme.SelectedRows[0].Cells["malzeme"].Value.ToString();
            tx_yemekResimismi.Text = dgv_yemekEkleme.SelectedRows[0].Cells["yemekResim"].Value.ToString();
            tx_kategoriid.Text = dgv_yemekEkleme.SelectedRows[0].Cells["kategori_id"].Value.ToString();


        }

        private void YemekEkleme_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiParent != null) 
            {
                AnaForm afrm = (AnaForm)this.MdiParent;
                afrm.tsbtn_yemekEkleme.Enabled = true;
            }
        }
    }
}
