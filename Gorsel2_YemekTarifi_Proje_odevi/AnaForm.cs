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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tsbtn_Kullanici_Click(object sender, EventArgs e)
        {
            tsbtn_Kullanici.BackColor = Color.Blue;
            if (tsbtn_Kullanici.Enabled == false)
                return;
            Kullanici kfrm = new Kullanici();
            kfrm.MdiParent = this;
            tsbtn_Kullanici.Enabled = false;
            kfrm.Show();
        }

        private void tsbtn_kullaniciTurleri_Click(object sender, EventArgs e)
        {
            tsbtn_kullaniciTurleri.BackColor = Color.Gainsboro;
            if (tsbtn_kullaniciTurleri.Enabled == false)
                return;
            KullanıcıTürKayıtları ktkfrm = new KullanıcıTürKayıtları();
            ktkfrm.MdiParent = this;
            tsbtn_kullaniciTurleri.Enabled = false;
            ktkfrm.Show();
        }

        private void tsbtn_yemekEkleme_Click(object sender, EventArgs e)
        {
            tsbtn_yemekEkleme.BackColor = Color.Orange;
            if (tsbtn_yemekEkleme.Enabled == false)
                return;
            YemekEkleme yefrm = new YemekEkleme();
            yefrm.MdiParent = this;
            tsbtn_yemekEkleme.Enabled = false;
            yefrm.Show();
        }

        private void tsbtn_gununYemegi_Click(object sender, EventArgs e)
        {
            tsbtn_gununYemegi.BackColor = Color.Green;
            if (tsbtn_gununYemegi.Enabled == false)
                return;
            GununYemegi gununYemegi_frm = new GununYemegi();
            gununYemegi_frm.MdiParent = this;
            tsbtn_gununYemegi.Enabled = false;
            gununYemegi_frm.Show();
        }

        private void tsbtn_yorumlar_Click(object sender, EventArgs e)
        {
            tsbtn_yorumlar.BackColor = Color.Purple;
            if (tsbtn_yorumlar.Enabled == false)
                return;
            Yorumlar yfrm = new Yorumlar();
            yfrm.MdiParent = this;
            tsbtn_yorumlar.Enabled = false;
            yfrm.Show();
        }

        private void tsbtn_yemekTarifKitaplari_Click(object sender, EventArgs e)
        {
            tsbtn_yemekTarifKitaplari.BackColor = Color.Yellow;
            if (tsbtn_yemekTarifKitaplari.Enabled == false)
                return;
            YemekTarifKitaplari ytkfrm = new YemekTarifKitaplari();
            ytkfrm.MdiParent = this;
            tsbtn_yemekTarifKitaplari.Enabled = false;
            ytkfrm.Show();
        }

        private void tsbtn_Kategori_Click(object sender, EventArgs e)
        {
            tsbtn_Kategori.BackColor = Color.Gray;
            if (tsbtn_Kategori.Enabled == false)
                return;
            Kategoriler ktgfrm = new Kategoriler();
            ktgfrm.MdiParent = this;
            tsbtn_Kategori.Enabled = false;
            ktgfrm.Show();
        }

        private void tsbtn_yemekBolge_Click(object sender, EventArgs e)
        {
            tsbtn_yemekBolge.BackColor = Color.Olive;
            if (tsbtn_yemekBolge.Enabled == false)
                return;
            Bölgelere_Göre_Yemekler bgyfrm = new Bölgelere_Göre_Yemekler();
            bgyfrm.MdiParent = this;
            tsbtn_yemekBolge.Enabled = false;
            bgyfrm.Show();
        }

        private void tsbtn_Tarifler_Click(object sender, EventArgs e)
        {
            tsbtn_Tarifler.BackColor = Color.DarkCyan;
            if (tsbtn_Tarifler.Enabled == false)
                return;
            Tarifler trffrm = new Tarifler();
            trffrm.MdiParent = this;
            tsbtn_Tarifler.Enabled = false;
            trffrm.Show();
        }

        private void UygulamaAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void uygulamaCikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void notifyIconTaskBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
