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
    public partial class EmanetListe : Form
    {
        public EmanetListe()
        {
            InitializeComponent();
        }
        dbEnginee nesne = new dbEnginee();
        void Yukle()
        {
            dataGridView1.DataSource = nesne.EmanetKitaplar();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "TC Kimlik";
            dataGridView1.Columns[2].HeaderText = "Ad Soyad";
            dataGridView1.Columns[3].HeaderText = "Öğrenci Numarası";
            dataGridView1.Columns[4].HeaderText = "İletişim";
            dataGridView1.Columns[5].HeaderText = "Kitap Kod";
            dataGridView1.Columns[6].HeaderText = "Kitap Adı";
            dataGridView1.Columns[7].HeaderText = "Kitap Yazarı";
            dataGridView1.Columns[8].HeaderText = "Başlangıç Tarihi";
            dataGridView1.Columns[9].HeaderText = "Bitiş Tarihi";
            dataGridView1.Columns[10].HeaderText = "Teslim Tarihi";
            dataGridView1.Columns[11].HeaderText = "Hasar Durumu";
            dataGridView1.Columns[12].HeaderText = "Teslim Durumu";
        }

        private void EmanetListe_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Teslim.TCKimlik = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Teslim.AdSoyad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Teslim.KitapKodu = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Teslim.KitapAdı = dataGridView1.CurrentRow.Cells[6].Value.ToString();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teslim ac = new Teslim();
            ac.ShowDialog();
        }
    }
}
