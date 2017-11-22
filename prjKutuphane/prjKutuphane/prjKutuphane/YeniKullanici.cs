using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjKutuphane
{
    public partial class 
        YeniKullanici : Form
    {
        public YeniKullanici()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        dbEnginee nesne = new dbEnginee();

        private void YeniKullanici_Load(object sender, EventArgs e)
        {
            cmbyetki.DataSource = nesne.YetkiYukle();
            cmbyetki.DisplayMember = "YetkiDurum";
        }
        void KullaniciKayit()
        {
            if (nesne.KullaniciKontrol(txtkullaniciadi.Text) == true)
            {

                nesne.KullaniciKayit(txtkullaniciadi.Text, txtsifre.Text, txtadsoyad.Text, cmbyetki.Text);
                MessageBox.Show("Kayıt tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı daha önceden alınmıştır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtkullaniciadi.Text = "";
            }

        }

        private void btntamam_Click(object sender, EventArgs e)
        {
            if (txtadsoyad.Text.Length == 0 || txtkullaniciadi.Text.Length == 0 || txtsifre.Text.Length == 0 || txtsifretekrar.Text.Length == 0)
            {
                MessageBox.Show("Alanlar boş geçilemez!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtsifre.Text == txtsifretekrar.Text)
                {
                    KullaniciKayit();
          
                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btntamam_MouseHover(object sender, EventArgs e)
        {
            //btntamam.Font = new Font("Comic Sans MS",11);
        }
    }
}
