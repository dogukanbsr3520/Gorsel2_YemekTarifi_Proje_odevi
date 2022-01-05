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
    public partial class Tarifler : Form
    {
        public Tarifler()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void Tarifler_Load(object sender, EventArgs e)
        {
            dgv_tarifKayit.DataSource = vt.Select("select tarif_id,tarifAd,tarificerik,yemek_id,eklenmeTarihi,kullanici_id from tbl_tarif");

            cbx_yemekid.DisplayMember = "yemek_id";
            cbx_yemekid.ValueMember = "yemek_id";
            cbx_yemekid.DataSource = vt.Select("select yemek_id,yemekAd,malzeme,yemekResim,yemekEklenmeTarihi,kategori_id from tbl_yemek");

            cbx_kullaniciid.DisplayMember = "kullanici_id";
            cbx_kullaniciid.ValueMember = "kullanici_id";
            cbx_kullaniciid.DataSource = vt.Select("select kullanici_id,kullaniciAd,kullaniciSoyad,Email,sifre,kullaniciTur_id from tbl_kullanici");
        }

        private void btn_yeniTarifEkle_Click(object sender, EventArgs e)
        {
            int kayitSay = vt.UpdateDelete("insert into tbl_tarif(tarif_id,tarifAd,tarificerik,yemek_id,eklenmeTarihi,kullanici_id)values('" + tx_tarifid.Text + "', '" + tx_tarifAd.Text + "', '" + tx_icerik.Text + "', '" + cbx_yemekid.SelectedValue + "', '" + dtp_eklenmeTarihi.Value.ToShortTimeString() + "', '" + cbx_kullaniciid.SelectedValue + "')");
            if (kayitSay > 0)
            {
                Tarifler_Load(null,null);
                MessageBox.Show("Yeni Tarif Başarılı Bir Şekilde Eklendi ! ");
            }
        }

        private void btn_tarifGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_tarifKayit.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Güncelleme İşleminin Yapılabilmesi İçin Öncelikle Satır Seçilmelidir !");
                return;
            }
            int kayitSay=vt.UpdateDelete(@"update tbl_tarif
                                            set tarif_id='"+tx_tarifid.Text+@"',
                                            tarifAd='"+tx_tarifAd.Text+@"',
                                            tarificerik='"+tx_icerik.Text+@"',
                                            yemek_id='"+cbx_yemekid.SelectedValue+@"',
                                            eklenmeTarihi='"+ dtp_eklenmeTarihi.Value.ToShortTimeString() + @"',
                                            kullanici_id='"+cbx_kullaniciid.SelectedValue+@"'
                                            where tarif_id=" + dgv_tarifKayit.SelectedRows[0].Cells["tarif_id"].Value);
            if (kayitSay > 0) 
            {
                Tarifler_Load(null,null);
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Güncellendi !");
            }
        }

        private void btn_tarifSil_Click(object sender, EventArgs e)
        {
            if (dgv_tarifKayit.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Silme İşlemi İçin Öncellikle Satır Seçilmelidir.");
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_tarif where tarif_id=" + dgv_tarifKayit.SelectedRows[0].Cells["tarif_id"].Value);
            if (kayitSay > 0) 
            {
                Tarifler_Load(null,null);
                MessageBox.Show("Seçilen Tarif Satırı Başarılı Bir Şekilde Silindi !");
            }
        }

        private void btn_tarifCokluSil_Click(object sender, EventArgs e)
        {
            if (dgv_tarifKayit.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Birden Fazla Kayıt Silmek İçin Öncellikle Satır Seçiniz !");
                return;
            }
            int kayitSay = 0;
            for (int i = 0; i < dgv_tarifKayit.SelectedRows.Count; i++) 
            {
                kayitSay += vt.UpdateDelete("delete from tbl_tarif where tarif_id=" + dgv_tarifKayit.SelectedRows[i].Cells["tarif_id"].Value);
            }
            if (kayitSay > 0) 
            {
                Tarifler_Load(null, null);
                MessageBox.Show(kayitSay + "  Kayıt Başarılı Bir Şekilde Silindi !");
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_tarifid.Text = "";
            tx_tarifAd.Text = "";
            tx_icerik.Text = "";
            cbx_yemekid.SelectedValue = -1;
            cbx_kullaniciid.SelectedValue = -1;

            foreach (DataGridViewRow item in dgv_tarifKayit.SelectedRows) 
            {
                item.Selected = false;
            }
        }

        private void dgv_tarifKayit_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_tarifKayit.SelectedRows.Count == 0) 
            {
                return;
            }
            tx_tarifid.Text = dgv_tarifKayit.SelectedRows[0].Cells["tarif_id"].Value.ToString();
            tx_tarifAd.Text = dgv_tarifKayit.SelectedRows[0].Cells["tarifAd"].Value.ToString();
            tx_icerik.Text = dgv_tarifKayit.SelectedRows[0].Cells["tarificerik"].Value.ToString();
            cbx_yemekid.SelectedValue = dgv_tarifKayit.SelectedRows[0].Cells["yemek_id"].Value.ToString();
            cbx_kullaniciid.SelectedValue = dgv_tarifKayit.SelectedRows[0].Cells["kullanici_id"].Value.ToString();

        }

        private void Tarifler_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiParent != null)
            {
                AnaForm afrm = (AnaForm)this.MdiParent;
                afrm.tsbtn_Tarifler.Enabled = true;
            }
        }

        private void dtp_eklenmeTarihi_ValueChanged(object sender, EventArgs e)
        {
            int kayitSay = vt.UpdateDelete(@"
                                            update tbl_tarif
                                            set eklenmeTarihi=GETDATE()
                                            where tarif_id=tarif_id");
        }
    }
}
