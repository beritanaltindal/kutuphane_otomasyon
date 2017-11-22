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
    public partial class Teslim : Form
    {
        public Teslim()
        {
            InitializeComponent();
        }

        private void tctextbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        public static string TCKimlik;
        public static string AdSoyad;
        public static string KitapAdı;
        public static string KitapKodu;
      
        private void Teslim_Load(object sender, EventArgs e)
        {
            tctextbox.SelectedText = TCKimlik;
            adsoyadtextbox.Text = AdSoyad;
            txtKitapKod.Text = KitapKodu;
            txtKitapAd.Text = KitapAdı;
            cmbHasar.DataSource = nesne.HasarYukle();
            cmbHasar.DisplayMember = "HasarDurumu";



        }
        dbEnginee nesne = new dbEnginee();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Teslim almak istediğinizden emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr==DialogResult.Yes)
            {
                if (cmbHasar.Text == "Kayıp")
                {

                    nesne.EmanetKitapGuncelle(cmbHasar.Text, tctextbox.Text, txtKitapKod.Text);
                    nesne.EmanetKitapGuncelle2(textBox2.Text, tctextbox.Text, txtKitapKod.Text);
                    MessageBox.Show("Kitap bilgileri güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if (cmbHasar.Text != "Kayıp")

                    nesne.EmanetKitapGuncelle(cmbHasar.Text, tctextbox.Text, txtKitapKod.Text);
                    nesne.EmanetKitapGuncelle2(textBox1.Text, tctextbox.Text, txtKitapKod.Text);
                    MessageBox.Show("Kitap bilgileri güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
         //Teslim alma formu kapat
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

        }
    }
}
