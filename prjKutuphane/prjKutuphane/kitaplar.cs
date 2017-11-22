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
    public partial class kitaplar : Form
    {
       
        public kitaplar()
        {

            InitializeComponent();
         
        }
        dbEnginee nesne = new dbEnginee();
        void Yukle()
        {
            dataGridView1.DataSource = nesne.TumKitaplar();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Kitap Kod";
            dataGridView1.Columns[2].HeaderText = "Kitap Adı";
            dataGridView1.Columns[3].HeaderText = "Kategori";
            dataGridView1.Columns[4].HeaderText = "Yazar Adı";
            dataGridView1.Columns[5].HeaderText = "Raf Numarası";
            dataGridView1.Columns[6].HeaderText = "Kitap Bilgisi";
            dataGridView1.Columns[7].HeaderText = "Açıklama";
        }
        public static string YetkiDurum;
        private void kitaplar_Load(object sender, EventArgs e)
        {

            Yukle();

        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nesne.KitapArama(txtArama.Text);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Kitap Kod";
            dataGridView1.Columns[2].HeaderText = "Kitap Adı";
            dataGridView1.Columns[3].HeaderText = "Kategori";
            dataGridView1.Columns[4].HeaderText = "Yazar Adı";
            dataGridView1.Columns[5].HeaderText = "Raf Numarası";
            dataGridView1.Columns[6].HeaderText = "Kitap Bilgisi";
            dataGridView1.Columns[7].HeaderText = "Açıklama";
        }
        private void txtArama_TextChanged_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nesne.KitapArama(txtArama.Text);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Kitap Kod";
            dataGridView1.Columns[2].HeaderText = "Kitap Adı";
            dataGridView1.Columns[3].HeaderText = "Kategori";
            dataGridView1.Columns[4].HeaderText = "Yazar Adı";
            dataGridView1.Columns[5].HeaderText = "Raf Numarası";
            dataGridView1.Columns[6].HeaderText = "Kitap Bilgisi";
            dataGridView1.Columns[7].HeaderText = "Açıklama";

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
      
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        

       
        public static string KitapKod = "";
        
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (YetkiDurum == "Uzman Kütüphaneci" && YetkiDurum == "Kütüphane Başkanı")
            {
                DialogResult dr = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (dr == DialogResult.Yes)
                {
                    nesne.KitapSil(KitapKod);
                    Yukle();

                }
            }
            else
            {
                MessageBox.Show("Silmenize yetkiniz yoktur!", "",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            kitapkayit ac = new kitapkayit();
            ac.ShowDialog();
        }

        private void kitaplar_Activated(object sender, EventArgs e)
        {
            Yukle();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            int satir = e.RowIndex;
            if (satir != -1)
            {
                KitapKod = dataGridView1.Rows[satir].Cells["KitapKod"].Value.ToString() ;
                
                
            }
        }
        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

        private void görüntüleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            KitaplarDuzenle ac = new KitaplarDuzenle();
            ac.ShowDialog();


        }
    }
}
