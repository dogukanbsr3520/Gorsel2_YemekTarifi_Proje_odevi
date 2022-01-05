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
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void Kullanici_Load(object sender, EventArgs e)
        {
            dgv_Kullanici.DataSource = vt.Select("select kullanici_id,kullaniciAd,kullaniciSoyad,Email,sifre,kullaniciTur_id from tbl_kullanici");

            cbx_kullaniciTurid.DisplayMember = "kullaniciTur";
            cbx_kullaniciTurid.ValueMember = "kullaniciTur_id";
            cbx_kullaniciTurid.DataSource = vt.Select("select kullaniciTur_id,kullaniciTur from tbl_kullaniciTur");
        }

        private void btn_kullaniciEkle_Click(object sender, EventArgs e)
        {
            if (tx_kullaniciAd.Text.Trim().Length<2)
            {
                MessageBox.Show("Girilen Kullanıcı Adı en az 2 karakter olmalıdır ! ");
                return;
            }
            if (tx_kullaniciSoyad.Text.Trim().Length < 2)
            {
                MessageBox.Show("Girilen Kullanıcı Soyadı en az 2 karakter olmalıdır ! ");
                return;
            }
            if (tx_Email.Text.Trim().Length > 10)
            {
                MessageBox.Show("Girilen Email adresi en fazla 10 karakter olmalıdır ! ");
                return;
            }
            if (tx_sifre.Text.Trim().Length > 8)
            {
                MessageBox.Show("Girilen Şifre en fazla 8 karakter olmalıdır ! ");
                return;
            }

            int kayitSay = vt.UpdateDelete("insert into tbl_kullanici(kullanici_id,kullaniciAd,kullaniciSoyad,Email,sifre,kullaniciTur_id)values('" + tx_kullaniciid.Text + "','" + tx_kullaniciAd.Text+"','"+tx_kullaniciSoyad.Text+"', '"+tx_Email.Text+"', '"+tx_sifre.Text+ "', '" + cbx_kullaniciTurid.SelectedValue + "')");
            if (kayitSay > 0)
            {
                Kullanici_Load(null, null);
                MessageBox.Show("Kullanıcı Eklendi...");
            }
        }

        private void btn_kullaniciGuncelle_Click(object sender, EventArgs e)
        {
            if(dgv_Kullanici.SelectedRows.Count==0)
            {
                MessageBox.Show("Güncelleme işlemini yapabilmek için bir satır seçmelisiniz !");
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_kullanici
                                            set kullaniciAd='"+tx_kullaniciAd.Text+@"',
                                            kullaniciSoyad='"+tx_kullaniciSoyad.Text+@"',
                                            Email='"+tx_Email.Text+@"',
                                            sifre='"+tx_sifre.Text+@"',
                                            kullaniciTur_id='"+cbx_kullaniciTurid.SelectedValue+ @"'
                                            where kullanici_id=" + dgv_Kullanici.SelectedRows[0].Cells["kullanici_id"].Value);
            if (kayitSay>0)
            {
                Kullanici_Load(null, null);
                MessageBox.Show("Kullanıcı Güncellendi.");
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            tx_kullaniciid.Text = "";
            tx_kullaniciAd.Text = "";
            tx_kullaniciSoyad.Text = "";
            tx_Email.Text = "";
            tx_sifre.Text = "";
            cbx_kullaniciTurid.SelectedValue = -1; 
            foreach (DataGridViewRow item in dgv_Kullanici.SelectedRows)
            {
                item.Selected = false;
            }
        }

        private void btn_kullaniciSil_Click(object sender, EventArgs e)
        {
            if (dgv_Kullanici.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Silme İşleminin Gerçekleşebilmesi İçin Satır Seçilmelidir !");
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_kullanici where kullanici_id =" + dgv_Kullanici.SelectedRows[0].Cells["kullanici_id"].Value);
            if (kayitSay > 0) 
            {
                Kullanici_Load(null, null);
                MessageBox.Show("Seçilen Kullanıcı Silindi.");
            }
        }

        private void btn_kullaniciCokluSilme_Click(object sender, EventArgs e)
        {
            if (dgv_Kullanici.SelectedRows.Count == 0) 
            {
                MessageBox.Show("İşlem Yapılacak Satırı Seçiniz.");
                return;
            }
            int kayitSay = 0;
            for (int i = 0; i < dgv_Kullanici.SelectedRows.Count; i++) 
            {
                kayitSay += vt.UpdateDelete("delete from tbl_kullanici where kullanici_id =" + dgv_Kullanici.SelectedRows[i].Cells["kullanici_id"].Value);
            }
            if (kayitSay > 0) 
            {
                Kullanici_Load(null, null);
                MessageBox.Show(kayitSay + " kullanıcı silindi.");
            }
        }

        private void Kullanici_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != '\b'&& e.KeyChar!=' ')
                e.Handled = true;
        }

        private void tx_kullaniciid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void tx_sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void dgv_Kullanici_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Kullanici.SelectedRows.Count == 0)
            {
                return;
            }
            tx_kullaniciid.Text = dgv_Kullanici.SelectedRows[0].Cells["kullanici_id"].Value.ToString();
            tx_kullaniciAd.Text = dgv_Kullanici.SelectedRows[0].Cells["kullaniciAd"].Value.ToString();
            tx_kullaniciSoyad.Text = dgv_Kullanici.SelectedRows[0].Cells["kullaniciSoyad"].Value.ToString();
            tx_Email.Text = dgv_Kullanici.SelectedRows[0].Cells["Email"].Value.ToString();
            tx_sifre.Text = dgv_Kullanici.SelectedRows[0].Cells["sifre"].Value.ToString();
            cbx_kullaniciTurid.SelectedValue = dgv_Kullanici.SelectedRows[0].Cells["kullaniciTur_id"].Value.ToString();
        }

        private void Kullanici_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaForm afrm = (AnaForm)this.MdiParent;
            afrm.tsbtn_Kullanici.Enabled = true; 
        }
    }
}
