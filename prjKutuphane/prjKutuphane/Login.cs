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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            btngiris.Enabled = true;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            dbEnginee nesne = new dbEnginee();
            DataTable dt = nesne.Girisyap(txtKullaniciAd.Text, txtSifre.Text);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Hatalı Giriş Yaptınız!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            else
            {
                this.Hide();

                Anasayfa.AdSoyad = dt.Rows[0]["AdSoyad"].ToString();
                Anasayfa.YetkiDurum = dt.Rows[0]["YetkiDurum"].ToString();
                Anasayfa.pkKullaniciID = Convert.ToInt32(dt.Rows[0]["pkKullaniciID"]);
                kitaplar.YetkiDurum = dt.Rows[0]["YetkiDurum"].ToString();
                kullanicibilgileri.KullaniciAd = dt.Rows[0]["KullaniciAd"].ToString();
                kullanicibilgileri.AdSoyad = dt.Rows[0]["AdSoyad"].ToString();
                sifre.Sifre = dt.Rows[0]["Sifre"].ToString();
                Anasayfa ac = new Anasayfa();
                ac.ShowDialog();
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            guvenlik ac = new guvenlik();
            ac.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifreunuttum ac = new sifreunuttum();
            ac.ShowDialog();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Font = new Font("Comic Sans MS",9,FontStyle.Italic);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Font = new Font("Comic Sans MS",8);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Font = new Font("Comic Sans MS", 9, FontStyle.Italic);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Font = new Font("Comic Sans MS", 8);

        }

        private void btnkapat_MouseHover(object sender, EventArgs e)
        {
            btnkapat.Font = new Font("Comic Sans MS", 13);
        }

        private void btnkapat_MouseLeave(object sender, EventArgs e)
        {
            btnkapat.Font = new Font("Comic Sans MS", 12);
        }

        private void btngiris_MouseHover(object sender, EventArgs e)
        {
            btngiris.Font = new Font("Comic Sans MS", 13);
        }

        private void btngiris_MouseLeave(object sender, EventArgs e)
        {
            btngiris.Font = new Font("Comic Sans MS", 12);
        }

        private void txtKullaniciAd_TextChanged(object sender, EventArgs e)
        
           
        {
          

        }
    }
    }
   

