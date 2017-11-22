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
            DialogResult cevap = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        public static int pkKullaniciID;
        public static string AdSoyad;
        public static string YetkiDurum;


        private void Anasayfa_Load(object sender, EventArgs e)
        {
            lblBilgi.Text = AdSoyad + "(" + YetkiDurum + ")" + "olarak giriş yaptınız.";
            if (YetkiDurum != "Admin")
            {
                kitapekle.Enabled = false;

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
    }
}
