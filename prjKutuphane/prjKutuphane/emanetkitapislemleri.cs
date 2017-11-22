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
    public partial class emanetkitapislemleri : Form
    {
        public emanetkitapislemleri()
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
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderText = "Telefon Numarası";
            dataGridView1.Columns[7].HeaderText = "Eposta";
            dataGridView1.Columns[8].HeaderText = "Cinsiyet";
        }
        void KitapYukle()
        {
            dataGridView2.DataSource = nesne.TumKitaplar();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "Kitap Kod";
            dataGridView2.Columns[2].HeaderText = "Kitap Adı";
            dataGridView2.Columns[3].HeaderText = "Kategori";
            dataGridView2.Columns[4].HeaderText = "Yazar Adı";
            dataGridView2.Columns[5].HeaderText = "Raf Numarası";
            dataGridView2.Columns[6].HeaderText = "Kitap Bilgisi";
            dataGridView2.Columns[7].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void emanetkitapislemleri_Load(object sender, EventArgs e)
        {
            OkuyucuYukle();
            KitapYukle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tctextbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            adsoyadtextbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            numaratextbox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            iletisimtextbox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            epostatxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cinsiyetcmb.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKitapKod.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtKitapAd.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            cbKategoriAd.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtYazarAd.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            cbKitapDurum.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        void EmanetiKaydet()
        {
           
                    nesne.EmanetKayit(tctextbox.Text, adsoyadtextbox.Text, numaratextbox.Text, iletisimtextbox.Text, txtKitapKod.Text, txtKitapAd.Text, txtYazarAd.Text, dtpbaslangıc.Value, textBox2.Text);
                    MessageBox.Show("Kayıt tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EmanetListe ac = new EmanetListe();
                  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tctextbox.Text.Length == 0 || txtKitapKod.Text.Length == 0 )
            {
                MessageBox.Show("Lütfen listeden kişi ve kitap seçiniz..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                
            }
            else
            {
                EmanetiKaydet();
            }
            

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            EmanetListe ac = new EmanetListe();
            ac.ShowDialog();
        }

        private void cinsiyetcmb_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbKategoriAd_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbKitapDurum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbKitapDurum_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cinsiyetcmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            emanetkitapislemleri kapat = new emanetkitapislemleri();
            kapat.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            okuyucuekle ac = new okuyucuekle();
            ac.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kitapkayit ac = new kitapkayit();
            ac.ShowDialog();
        }
    }
}
