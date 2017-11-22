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
    public partial class kullanıcıbilgileriadmin : Form
    {
        public kullanıcıbilgileriadmin()
        {
            InitializeComponent();
        }
        dbEnginee nesne = new dbEnginee();
        void Yukle()
        {
            dataGridView1.DataSource = nesne.TumKullanıcılar();
            dataGridView1.Columns[0].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[1].HeaderText = "Ad Soyad";
            dataGridView1.Columns[2].HeaderText = "Yetki Durumu";
            dataGridView1.Columns[3].HeaderText = "E-posta";
            dataGridView1.Columns[4].HeaderText = "Fotoğraf";
            dataGridView1.Columns[5].Visible = false;


        }
        void KullaniciKayit()
        {
            
                if (nesne.emailkontrol(txteposta.Text) == true)
                {
                    nesne.KullaniciKayitGuncelle(txtKullanıcıAdı.Text, txtAdSoyad.Text, cmbyetki.Text, txteposta.Text);
                    nesne.KullaniciKayitGuncelle2(txtKullanıcıAdı.Text,txtAdSoyad.Text);
                    MessageBox.Show("Kullanıcı bilgileri güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lütfen doğru mail formatı giriniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txteposta.Text = "";
                }
          

        }

        private void kullanıcıbilgileriadmin_Load(object sender, EventArgs e)
        {
            cmbyetki.DataSource = nesne.YetkiYukle();
            cmbyetki.DisplayMember = "YetkiDurum";
            Yukle();
            txtKullanıcıAdı.Enabled = false;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKullanıcıAdı.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmbyetki.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txteposta.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bilgileri güncellemek istediğinizden emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                KullaniciKayit();
                kullanıcıbilgileriadmin ac = new kullanıcıbilgileriadmin();
                ac.ShowDialog();
            }
        }

        private void cmbyetki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnkisisil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kullanıcıyı silmek istediğinizden emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                nesne.KullanıcıSil(txtKullanıcıAdı.Text);
                nesne.KullanıcıSil2(txtKullanıcıAdı.Text);
                nesne.KullanıcıSil3(txtKullanıcıAdı.Text);
                this.Hide();
                kullanıcıbilgileriadmin ac = new kullanıcıbilgileriadmin();
                ac.ShowDialog();
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
