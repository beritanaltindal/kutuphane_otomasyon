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
    public partial class okuyucuekle : Form
    {
        public okuyucuekle()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        dbEnginee nesne = new dbEnginee();
        void okuyucukayit()
        {
            if (nesne.TcKontrol(tctextbox.Text) == true)
            {
             if(nesne.OkuyucuTcKontrol(tctextbox.Text) == true)
                { 
                if (nesne.emailkontrol(epostatxt.Text) == true)
                {
                    nesne.OkuyucuKayit(tctextbox.Text, adsoyadtextbox.Text, numaratextbox.Text, dogumdtp.Value, dogumyericmb.Text, iletisimtextbox.Text, epostatxt.Text, cinsiyetcmb.Text);
                    MessageBox.Show("Kayıt tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lütfen doğru mail formatı giriniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    epostatxt.Text = "";
                }
                }
             else {
                    MessageBox.Show("Aynı Tc Kimlik Numarası ile başka bir öğrenci kaydı bulunmaktadır! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    epostatxt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Sistemde kayıtlı bir öğrenci bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tctextbox.Text = "";
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (tctextbox.Text.Length == 0 || adsoyadtextbox.Text.Length == 0 || numaratextbox.Text.Length == 0 || iletisimtextbox.Text.Length == 0)
            {
                MessageBox.Show("Alanlar boş geçilemez!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                 okuyucukayit();
            }
        }

        private void tctextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void numaratextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void iletisimtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

        }
    }
}
