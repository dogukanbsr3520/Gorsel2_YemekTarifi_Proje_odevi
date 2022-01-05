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
    public partial class GununYemegi : Form
    {
        public GununYemegi()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();

        private void GununYemegi_Load(object sender, EventArgs e)
        {
            dgv_gununYemegi.DataSource = vt.Select("select gununYemegi_id,yemek_id,tarif_id,gununYemegiPuan from tbl_gununYemegi");

            cbx_yemekid.DisplayMember = "yemek_id";
            cbx_yemekid.ValueMember = "yemek_id";
            cbx_yemekid.DataSource = vt.Select("select yemek_id,yemekAd,malzeme,yemekResim,yemekEklenmeTarihi,kategori_id from tbl_yemek");

            cbx_tarifid.DisplayMember = "tarif_id";
            cbx_tarifid.ValueMember = "tarif_id";
            cbx_tarifid.DataSource = vt.Select("select tarif_id,tarifAd,tarificerik,yemek_id,eklenmeTarihi,kullanici_id from tbl_tarif"); 
        }

        private void btn_gununYemegiEkle_Click(object sender, EventArgs e)
        {
            int kayitSay = vt.UpdateDelete("insert into tbl_gununYemegi(gununYemegi_id,yemek_id,tarif_id,gununYemegiPuan)values('" + tx_gununYemegiid.Text + "', '" + cbx_yemekid.SelectedValue + "', '" + cbx_tarifid.SelectedValue + "', '" + tx_gununYemegiPuan.Text + "')");
            if (kayitSay > 0)
            {
                GununYemegi_Load(null,null);
                MessageBox.Show("Günün Yemeği Başarılı Bir şekilde Eklendi");
            }
        }

        private void btn_gununYemeginiGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_gununYemegi.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Güncelleme İşlemi Yapılabilmesi İçin Satır Seçilmelidir ! ");
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_gununYemegi
                                            set yemek_id='"+cbx_yemekid.SelectedValue+@"',
                                            tarif_id='"+cbx_tarifid.SelectedValue+@"',
                                            gununYemegiPuan='"+tx_gununYemegiPuan.Text+ @"'
                                            where gununYemegi_id=" + dgv_gununYemegi.SelectedRows[0].Cells["gununYemegi_id"].Value);
            if (kayitSay > 0)
            {
                GununYemegi_Load(null,null);
                MessageBox.Show("Günün Yemeği Başarılı Bir Şekilde Güncellendi");
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_gununYemegiid.Text = "";
            cbx_yemekid.SelectedValue = -1;
            cbx_tarifid.SelectedValue = -1;
            tx_gununYemegiPuan.Text = "";

            foreach (DataGridViewRow item in dgv_gununYemegi.SelectedRows) 
            {
                item.Selected = false;
            }
        }

        private void btn_gününYemeginiSil_Click(object sender, EventArgs e)
        {
            if (dgv_gununYemegi.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Silme İşlemi için bir satır seçili olmalıdr !");
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_gununYemegi where gununYemegi_id=" + dgv_gununYemegi.SelectedRows[0].Cells["gununYemegi_id"].Value);
            if (kayitSay > 0) 
            {
                GununYemegi_Load(null, null);
                MessageBox.Show("Seçili Günün Yemeği Silindi.. Artık Günün Yemeği Değil :( ");
            }
        }

        private void btn_gununYemegiCokluSil_Click(object sender, EventArgs e)
        {
            if (dgv_gununYemegi.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Birden Fazla Yemek Kaydı Silmeniz için Öncelikle Satırlar Seçilmelidir ! ");
                return;
            }
            int kayitSay = 0;
            for(int i=0;i<dgv_gununYemegi.SelectedRows.Count;i++)
            {
                kayitSay += vt.UpdateDelete("delete from tbl_gununYemegi where gununYemegi_id=" + dgv_gununYemegi.SelectedRows[i].Cells["gununYemegi_id"].Value);
            }
            if (kayitSay > 0) 
            {
                GununYemegi_Load(null, null);
                MessageBox.Show(kayitSay+"  Günün Yemeği Silindi !");
            }
        }

        private void dgv_gununYemegi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_gununYemegi.SelectedRows.Count == 0) 
            {
                return;
            }
            tx_gununYemegiid.Text = dgv_gununYemegi.SelectedRows[0].Cells["gununYemegi_id"].Value.ToString();
            cbx_yemekid.SelectedValue = dgv_gununYemegi.SelectedRows[0].Cells["yemek_id"].Value.ToString();
            cbx_tarifid.SelectedValue = dgv_gununYemegi.SelectedRows[0].Cells["tarif_id"].Value.ToString();
            tx_gununYemegiPuan.Text = dgv_gununYemegi.SelectedRows[0].Cells["gununYemegiPuan"].Value.ToString();
        }

        private void GununYemegi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiParent != null)
            {
                AnaForm afrm = (AnaForm)this.MdiParent;
                afrm.tsbtn_gununYemegi.Enabled = true;
            }
        }
    }
}
