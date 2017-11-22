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
    public partial class okuyuculiste : Form
    {
        public okuyuculiste()
        {
            InitializeComponent();
        }
        dbEnginee nesne = new dbEnginee();
        void OkuyucuYukle()
        {
            dataGridView1.DataSource = nesne.TumOkuyucular();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Tc Kimlik Numarası";
            dataGridView1.Columns[2].HeaderText = "Adı Soyadı";
            dataGridView1.Columns[3].HeaderText = "Öğrenci Numarası";
            dataGridView1.Columns[4].HeaderText = "Doğum Tarihi";
            dataGridView1.Columns[5].HeaderText = "Doğum Yeri";
            dataGridView1.Columns[6].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[7].HeaderText = "Eposta";
            dataGridView1.Columns[8].HeaderText = "Cinsiyet";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void okuyuculiste_Load(object sender, EventArgs e)
        {
            OkuyucuYukle();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nesne.OkuyucuAramaTc(txtTcKimlik.Text);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Tc Kimlik Numarası";
            dataGridView1.Columns[2].HeaderText = "Adı Soyadı";
            dataGridView1.Columns[3].HeaderText = "Öğrenci Numarası";
            dataGridView1.Columns[4].HeaderText = "Doğum Tarihi";
            dataGridView1.Columns[5].HeaderText = "Doğum Yeri";
            dataGridView1.Columns[6].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[7].HeaderText = "Eposta";
            dataGridView1.Columns[8].HeaderText = "Cinsiyet";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nesne.OkuyucuAramaAdSoyad(txtAdSoyad.Text);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Tc Kimlik Numarası";
            dataGridView1.Columns[2].HeaderText = "Adı Soyadı";
            dataGridView1.Columns[3].HeaderText = "Öğrenci Numarası";
            dataGridView1.Columns[4].HeaderText = "Doğum Tarihi";
            dataGridView1.Columns[5].HeaderText = "Doğum Yeri";
            dataGridView1.Columns[6].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[7].HeaderText = "Eposta";
            dataGridView1.Columns[8].HeaderText = "Cinsiyet";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nesne.OkuyucuAramaOkulNumarasi(txtOkulNumarasi.Text);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Tc Kimlik Numarası";
            dataGridView1.Columns[2].HeaderText = "Adı Soyadı";
            dataGridView1.Columns[3].HeaderText = "Öğrenci Numarası";
            dataGridView1.Columns[4].HeaderText = "Doğum Tarihi";
            dataGridView1.Columns[5].HeaderText = "Doğum Yeri";
            dataGridView1.Columns[6].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[7].HeaderText = "Eposta";
            dataGridView1.Columns[8].HeaderText = "Cinsiyet";

        }
        void radioButton2()//Ogrenci numarası sıralaması
        {
            dataGridView1.DataSource = nesne.TumOkuyucularradio2();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Tc Kimlik Numarası";
            dataGridView1.Columns[2].HeaderText = "Adı Soyadı";
            dataGridView1.Columns[3].HeaderText = "Öğrenci Numarası";
            dataGridView1.Columns[4].HeaderText = "Doğum Tarihi";
            dataGridView1.Columns[5].HeaderText = "Doğum Yeri";
            dataGridView1.Columns[6].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[7].HeaderText = "Eposta";
            dataGridView1.Columns[8].HeaderText = "Cinsiyet";
        }
        void radioButton3()//Ad soyad sıralaması
        {
            dataGridView1.DataSource = nesne.TumOkuyucularradio3();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Tc Kimlik Numarası";
            dataGridView1.Columns[2].HeaderText = "Adı Soyadı";
            dataGridView1.Columns[3].HeaderText = "Öğrenci Numarası";
            dataGridView1.Columns[4].HeaderText = "Doğum Tarihi";
            dataGridView1.Columns[5].HeaderText = "Doğum Yeri";
            dataGridView1.Columns[6].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[7].HeaderText = "Eposta";
            dataGridView1.Columns[8].HeaderText = "Cinsiyet";
        }

        private void radioButtonTc_CheckedChanged(object sender, EventArgs e)
        {
            OkuyucuYukle();

        }

        private void radioButtonOgrenciNumarasi_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonAdSoyad_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3();
        }
    }
}
