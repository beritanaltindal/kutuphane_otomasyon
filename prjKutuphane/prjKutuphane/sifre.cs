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
    public partial class sifre : Form
    {
        public sifre()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txteskisifre.PasswordChar = '\0';
                txtyenisifre.PasswordChar = '\0';
                txtyenisifretekrar.PasswordChar = '\0';
            }
            else
            {
                txteskisifre.PasswordChar = '*';
                txtyenisifre.PasswordChar = '*';
                txtyenisifretekrar.PasswordChar = '*';
            }
        }

        private void sifre_Load(object sender, EventArgs e)
        {

        }
        public static string Sifre;
        public static string KullaniciAd;
        dbEnginee nesne = new dbEnginee();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txteskisifre.Text==Sifre)
            {
                if (txtyenisifre.Text == txtyenisifretekrar.Text)
                {
                    try
                    {
                        nesne.sifreguncelle(KullaniciAd, txtyenisifre.Text);
                        MessageBox.Show("Şifreniz değiştirildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txteskisifre.Text = "";
                        txtyenisifre.Text = "";
                        txtyenisifretekrar.Text = "";
                        this.Hide();

                    }
                    catch
                    {
                        MessageBox.Show("HATA", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler aynı olmalıdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Eski şifreniz doğrulanamadı!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
    }
}
