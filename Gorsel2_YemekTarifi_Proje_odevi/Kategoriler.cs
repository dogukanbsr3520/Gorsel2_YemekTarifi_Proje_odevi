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
    public partial class Kategoriler : Form
    {
        public Kategoriler()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void Kategoriler_Load(object sender, EventArgs e)
        {
            dgv_kategoriKayit.DataSource = vt.Select("select kategori_id,kategoriAd from tbl_kategori");
        }

        private void btn_kategoriEkle_Click(object sender, EventArgs e)
        {
            int kayitSay = vt.UpdateDelete("insert into tbl_kategori(kategori_id,kategoriAd)values('" + tx_kategoriid.Text + "', '" + tx_kategoriAd.Text + "')");
            if (kayitSay > 0) 
            {
                Kategoriler_Load(null,null);
                MessageBox.Show("Yemeğin Kategorisi Başarıyla Eklendi. ");
            }
        }

        private void btn_KategoriGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_kategoriKayit.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Güncellemek İşlemini Yapabilmek İçin Önce Satırı Seçmelisiniz ! ");
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_kategori
                                            set kategori_id='"+tx_kategoriid.Text+@"',
                                            kategoriAd='"+tx_kategoriAd.Text+@"'
                                            where kategori_id=" + dgv_kategoriKayit.SelectedRows[0].Cells["kategori_id"].Value);
            if (kayitSay > 0) 
            {
                Kategoriler_Load(null, null);
                MessageBox.Show("Seçilen Kategori Satırı Güncellendi !");
            }
        }

        private void btn_kategoriSil_Click(object sender, EventArgs e)
        {
            if (dgv_kategoriKayit.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Seçili Satır Başarılı Bir Şekilde Silindi ! ");
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_kategori where kategori_id=" + dgv_kategoriKayit.SelectedRows[0].Cells["kategori_id"].Value);
            if (kayitSay > 0) 
            {
                Kategoriler_Load(null, null);
                MessageBox.Show("Seçili Kategori kaydı Başarılı Bir Şekilde Silindi !  ");
            }
        }

        private void btn_kategoriCokluSil_Click(object sender, EventArgs e)
        {
            if (dgv_kategoriKayit.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Birden Fazla Silmek İşlemi İçin Öncellikle silinecek satırları seçmelsiniz !");
                return;
            }
            int kayitSay = 0;
            for(int i=0; i<dgv_kategoriKayit.SelectedRows.Count;i++)
            {
                kayitSay += vt.UpdateDelete("delete from tbl_kategori where kategori_id=" + dgv_kategoriKayit.SelectedRows[i].Cells["kategori_id"].Value);
            }
            if (kayitSay > 0) 
            {
                Kategoriler_Load(null,null);
                MessageBox.Show(kayitSay+"kategori Kaydını Sildiniz");
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_kategoriid.Text = "";
            tx_kategoriAd.Text = "";

            foreach (DataGridViewRow item in dgv_kategoriKayit.SelectedRows)
            {
                item.Selected = false;
            }
        }

        private void dgv_kategoriKayit_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_kategoriKayit.SelectedRows.Count == 0) 
            {
                return;
            }
            tx_kategoriid.Text = dgv_kategoriKayit.SelectedRows[0].Cells["kategori_id"].Value.ToString();
            tx_kategoriAd.Text = dgv_kategoriKayit.SelectedRows[0].Cells["kategoriAd"].Value.ToString();


        }

        private void Kategoriler_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiParent != null)
            {
                AnaForm afrm = (AnaForm)this.MdiParent;
                afrm.tsbtn_Kategori.Enabled = true;
            }
        }
    }
}
