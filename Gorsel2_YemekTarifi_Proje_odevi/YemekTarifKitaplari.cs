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
    public partial class YemekTarifKitaplari : Form
    {
        public YemekTarifKitaplari()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void btn_KitapResmiEkle_Click(object sender, EventArgs e)
        {
            pbx_yemekTarifKitap.SizeMode = PictureBoxSizeMode.StretchImage;
            ofd_kitapResmiBul.ShowDialog();
            pbx_yemekTarifKitap.ImageLocation = ofd_kitapResmiBul.FileName;
        }

        private void YemekTarifKitaplari_Load(object sender, EventArgs e)
        {
            dgv_kitapKayit.DataSource = vt.Select("select tarifKitap_id,kategori_id,kitapAd,yazarAd,KitapResim from tbl_yemekTarifiKitap");

            cbx_kategoriid.DisplayMember = "kategori_id";
            cbx_kategoriid.ValueMember = "kategori_id";
            cbx_kategoriid.DataSource = vt.Select("select kategori_id,kategoriAd from tbl_kategori");
        }

        private void btn_kitapEkle_Click(object sender, EventArgs e)
        {
            int kayitSay = vt.UpdateDelete("insert into tbl_yemekTarifiKitap(tarifKitap_id,kategori_id,kitapAd,yazarAd,KitapResim)values('" + tx_kitapid.Text + "', '" + cbx_kategoriid.SelectedValue + "', '" + tx_kitapAd.Text + "', '" + tx_yazarAd.Text + "', '" + tx_kitapResimismi.Text + "')");
            if (kayitSay > 0) 
            {
                YemekTarifKitaplari_Load(null, null);
                MessageBox.Show("Yeni Kitap Kaydı Oluşturuldu !");
            }
        }

        private void btn_kitapGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_kitapKayit.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Güncellenecek Kitap Satırını Seçiniz !");
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_yemekTarifiKitap
                                            set tarifKitap_id='"+tx_kitapid.Text+@"',
                                            kategori_id='"+cbx_kategoriid.SelectedValue+@"',
                                            kitapAd='"+tx_kitapAd.Text+@"',
                                            yazarAd='"+tx_yazarAd.Text+@"',
                                            KitapResim='"+tx_kitapResimismi.Text+ @"'
                                            where tarifKitap_id=" +dgv_kitapKayit.SelectedRows[0].Cells["tarifKitap_id"].Value);
            if (kayitSay > 0) 
            {
                YemekTarifKitaplari_Load(null,null);
                MessageBox.Show("Seçilen Kitap Kaydı Başarılı Bir Şekilde Güncellendi !");
            }
        }

        private void btn_kitapSil_Click(object sender, EventArgs e)
        {
            if(dgv_kitapKayit.SelectedRows.Count==0)
            {
                MessageBox.Show("Silinecek Kitap Kaydını Seçiniz !");
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_yemekTarifiKitap where tarifKitap_id=" + dgv_kitapKayit.SelectedRows[0].Cells["tarifKitap_id"].Value);
            if (kayitSay > 0)
            {
                YemekTarifKitaplari_Load(null, null);
                MessageBox.Show("Seçili Kitap Kaydı Silindi.");
            }
        }
        private void btn_kitapCokluSil_Click(object sender, EventArgs e)
        {
            if (dgv_kitapKayit.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Birden Fazla Kayıt Silmek İçin Öncelikle Satır Seçiniz !");
                return;
            }
            int kayitSay = 0;
            for(int i=0;i<dgv_kitapKayit.SelectedRows.Count;i++)
            {
                kayitSay += vt.UpdateDelete("delete from tbl_yemekTarifiKitap where tarifKitap_id=" + dgv_kitapKayit.SelectedRows[i].Cells["tarifKitap_id"].Value);
            }
            if (kayitSay > 0) 
            {
                YemekTarifKitaplari_Load(null,null);
                MessageBox.Show(kayitSay+" Kitap Kaydı Silindi !");
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_kitapid.Text = "";
            cbx_kategoriid.SelectedValue = -1;
            tx_kitapAd.Text = "";
            tx_yazarAd.Text = "";
            tx_kitapResimismi.Text = "";

            foreach (DataGridViewRow item in dgv_kitapKayit.SelectedRows) 
            {
                item.Selected = false;
            }
        }

        private void dgv_kitapKayit_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_kitapKayit.SelectedRows.Count == 0) 
            {
                return;
            }
            tx_kitapid.Text = dgv_kitapKayit.SelectedRows[0].Cells["tarifKitap_id"].Value.ToString();
            cbx_kategoriid.SelectedValue = dgv_kitapKayit.SelectedRows[0].Cells["kategori_id"].Value.ToString();
            tx_kitapAd.Text = dgv_kitapKayit.SelectedRows[0].Cells["kitapAd"].Value.ToString();
            tx_yazarAd.Text = dgv_kitapKayit.SelectedRows[0].Cells["yazarAd"].Value.ToString();
            tx_kitapResimismi.Text = dgv_kitapKayit.SelectedRows[0].Cells["KitapResim"].Value.ToString();

        }

        private void YemekTarifKitaplari_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiParent != null)
            {
                AnaForm afrm = (AnaForm)this.MdiParent;
                afrm.tsbtn_yemekTarifKitaplari.Enabled = true;
            }
        }

        private void pbx_yemekTarifKitap_Click(object sender, EventArgs e)
        {

        }
    }
}
