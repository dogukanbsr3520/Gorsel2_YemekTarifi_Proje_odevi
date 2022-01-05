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
    public partial class Bölgelere_Göre_Yemekler : Form
    {
        public Bölgelere_Göre_Yemekler()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void Bölgelere_Göre_Yemekler_Load(object sender, EventArgs e)
        {
            dgv_yemekBolgeKayitlar.DataSource = vt.Select("select yemekBolge_id,kategori_id,yemekTurleri,bolgeAd from tbl_yemekBolge");
            cbx_kategoriid.DisplayMember = "kategori_id";
            cbx_kategoriid.ValueMember = "kategori_id";
            cbx_kategoriid.DataSource = vt.Select("select kategori_id,kategoriAd from tbl_kategori");
        }

        private void btn_bolgeEkle_Click(object sender, EventArgs e)
        {
            int kayitSay = vt.UpdateDelete("insert into tbl_yemekBolge(yemekBolge_id,kategori_id,yemekTurleri,bolgeAd)values('" + tx_yemekBolgeid.Text + "', '" + cbx_kategoriid.SelectedValue+ "', '" + tx_yemekAd.Text + "', '" + tx_bolgeAd.Text + "')");
            if (kayitSay > 0)
            {
                Bölgelere_Göre_Yemekler_Load(null,null);
                MessageBox.Show("İstenilen Yemek Bölge Verileri Başarılı Bir Şekilde Eklendi !");
            }
        }

        private void btn_bolgeGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_yemekBolgeKayitlar.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Öncellikle Güncellenecek Kaydı Seçmelisiniz !");
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_yemekBolge
                                            set yemekBolge_id='"+tx_yemekBolgeid.Text+@"',
                                            kategori_id='"+cbx_kategoriid.SelectedValue+@"',
                                            yemekTurleri='"+tx_yemekAd.Text+@"',
                                            bolgeAd='"+tx_bolgeAd.Text+ @"'
                                             where yemekBolge_id = " + dgv_yemekBolgeKayitlar.SelectedRows[0].Cells["yemekBolge_id"].Value);
            if (kayitSay > 0) 
            {
                Bölgelere_Göre_Yemekler_Load(null, null);
                MessageBox.Show("Seçili Satır Başarılı Bir Şekilde Güncellendi ! ");
            }
        }

        private void btn_bolgeSil_Click(object sender, EventArgs e)
        {
            if (dgv_yemekBolgeKayitlar.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Öncelikle Silenecek Satırı Seçmelisiniz !");
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_yemekBolge where yemekBolge_id=" + dgv_yemekBolgeKayitlar.SelectedRows[0].Cells["yemekBolge_id"].Value);
            if (kayitSay > 0) 
            {
                Bölgelere_Göre_Yemekler_Load(null, null);
                MessageBox.Show("Seçilen Satırda Buluan Kayıt Başarılı Bir Şekilde Silindi !");
            }
        }

        private void btn_bolgeCokluSil_Click(object sender, EventArgs e)
        {
            if (dgv_yemekBolgeKayitlar.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Birden Fazla Kayıt Silmeniz İçin Öncelike Silinecek Satırları Seçmelisiniz !");
                return;
            }
            int kayitSay = 0;
            for (int i = 0; i < dgv_yemekBolgeKayitlar.SelectedRows.Count; i++) 
            {
                kayitSay += vt.UpdateDelete("delete from tbl_yemekBolge where yemekBolge_id=" + dgv_yemekBolgeKayitlar.SelectedRows[i].Cells["yemekBolge_id"].Value);
            }
            if (kayitSay > 0) 
            {
                Bölgelere_Göre_Yemekler_Load(null, null);
                MessageBox.Show(kayitSay+"  yemek Bölge Kaydı Silindi !");
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_yemekBolgeid.Text = "";
            cbx_kategoriid.SelectedValue = -1;
            tx_yemekAd.Text = "";
            tx_bolgeAd.Text = "";
            foreach (DataGridViewRow item in dgv_yemekBolgeKayitlar.SelectedRows) 
            {
                item.Selected = false;
            }
        }

        private void dgv_yemekBolgeKayitlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_yemekBolgeKayitlar.SelectedRows.Count == 0) 
            {
                return;
            }
            tx_yemekBolgeid.Text = dgv_yemekBolgeKayitlar.SelectedRows[0].Cells["yemekBolge_id"].Value.ToString();
            cbx_kategoriid.SelectedValue = dgv_yemekBolgeKayitlar.SelectedRows[0].Cells["kategori_id"].Value.ToString();
            tx_yemekAd.Text = dgv_yemekBolgeKayitlar.SelectedRows[0].Cells["yemekTurleri"].Value.ToString();
            tx_bolgeAd.Text = dgv_yemekBolgeKayitlar.SelectedRows[0].Cells["bolgeAd"].Value.ToString();
        }

        private void Bölgelere_Göre_Yemekler_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiParent != null)
            {
                AnaForm afrm = (AnaForm)this.MdiParent;
                afrm.tsbtn_yemekBolge.Enabled = true;
            }
        }
    }
}
