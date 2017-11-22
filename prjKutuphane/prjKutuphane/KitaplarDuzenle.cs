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
    public partial class KitaplarDuzenle : Form
    {
        public KitaplarDuzenle()
        {
            InitializeComponent();
        }
        
       dbEnginee nesne = new dbEnginee();

        public static string FotografYolu;
        private void KitaplarDuzenle_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtkitap = nesne.KitapGoruntuleme(kitaplar.KitapKod);
                txtKitapAd.Text = dtkitap.Rows[0]["KitapAd"].ToString();
                cbKategoriAd.Text = dtkitap.Rows[0]["KategoriAd"].ToString();
                txtYazarAd.Text = dtkitap.Rows[0]["YazarAd"].ToString();
                txtAciklama.Text = dtkitap.Rows[0]["Aciklama"].ToString();


                //Fotoğraf Gösterme
                DataTable dtFotograf = nesne.KapakFotografıBul(txtKitapAd.Text);
                if (dtFotograf.Rows.Count == 0)
                {
                   btnekle.Text = "Fotoğraf Ekle";
                }
                else
                {
                    FotografYolu = dtFotograf.Rows[0]["FotografYolu"].ToString();
                    pictureBox1.ImageLocation = FotografYolu;
                    btnekle.Text = "Değiştir";
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            
           
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            KitaplarDuzenle kapat = new KitaplarDuzenle();
            this.Hide();
        }

        private void cbKategoriAd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            openFileDialog1.Title = "www.WiseLib.com";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                FotografYolu = openFileDialog1.ToString();
                pictureBox1.ImageLocation = FotografYolu;


                if (btnekle.Text == "Fotoğraf Ekle")
                {
                    try
                    {
                        nesne.KapakFotografKaydet(txtKitapAd.Text, FotografYolu);
                        MessageBox.Show("Başarılı","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }

                }
                else
                {
                    try
                    {
                        nesne.KapakFotografGuncelle(txtKitapAd.Text, FotografYolu);
                        MessageBox.Show("Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    { }

                }

            }
        }
    }
}
