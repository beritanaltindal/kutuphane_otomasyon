using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace prjKutuphane
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            kitaplar ac = new kitaplar();
            ac.Show();

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Oturumu kapatmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Restart(); //Oturumu kapatır uygulamayı yeniden başlatır.
            }

        }

        public static int pkKullaniciID;
        public static string AdSoyad;
        public static string YetkiDurum;

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            lblBilgi.Text = AdSoyad + "(" + YetkiDurum + ")" + "olarak giriş yaptınız.";

            if (YetkiDurum != "Uzman Kütüphaneci")
            {
                kitapekle.Enabled = false;

            }
            if (YetkiDurum =="Kütüphane Başkanı")
            {
                kitapekle.Enabled = true;
            }
            else
            {
                kitapekle.Enabled = true;
            }

        }

        private void kitapekle_Click(object sender, EventArgs e)
        {
            kitapkayit ac = new kitapkayit();
            ac.ShowDialog();
        }
         

        private void kullanicibilgileri_Click(object sender, EventArgs e)
        {
            if (YetkiDurum != "Kütüphane Başkanı")
            {
                kullanicibilgileri ac = new kullanicibilgileri();
                ac.ShowDialog();
             
            }
            else
            {
                kullanıcıbilgileriadmin ac = new kullanıcıbilgileriadmin();
                ac.ShowDialog();
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            emanetkitapislemleri ac = new emanetkitapislemleri();
            ac.ShowDialog();
        }

        private void okuyucukayit_Click(object sender, EventArgs e)
        {
            okuyucuekle ac = new okuyucuekle();
            ac.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            okuyuculiste okuyuculiste = new okuyuculiste();
            okuyuculiste.ShowDialog();
        }

        private void lblBilgi_Click(object sender, EventArgs e)
        {

        }
    }
}
