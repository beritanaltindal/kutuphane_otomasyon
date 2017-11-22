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
using System.IO;

namespace prjKutuphane
{
    public partial class kullanicibilgileri : Form
    {
        public kullanicibilgileri()
        {
            InitializeComponent();
        }

        private void btnsifre_Click(object sender, EventArgs e)
        {
            sifre ac = new sifre();
            ac.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public static int pkKullaniciID;
        public static string KullaniciAd;
        public static string YetkiDurum;
        public static string AdSoyad;
        public static string FotografYolu;

        private void kullanicibilgileri_Load(object sender, EventArgs e)
        {
            txtkullaniciadi.Text = KullaniciAd;
            txtkullaniciadi.Enabled = false;
            cmbgorev.DataSource = nesne.GorevYukle();
            cmbgorev.DisplayMember = "Gorev";
            txtadsoyad.Text = AdSoyad;

            //KullaniciBilgileri Doldurma
            DataTable dtKullanici = nesne.KullaniciBilgileriBul(txtkullaniciadi.Text);
            if (dtKullanici.Rows.Count == 0)
            {
                MessageBox.Show("Kaydınız bulunamadı.Lütfen bilgilerinizi sisteme kaydediniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                txtkullaniciadi.Text = dtKullanici.Rows[0]["KullaniciAdi"].ToString();
                cmbgorev.Text = dtKullanici.Rows[0]["Gorevi"].ToString();
                txtadsoyad.Text = dtKullanici.Rows[0]["AdSoyad"].ToString();
                dtpdogumtarihi.Text = dtKullanici.Rows[0]["DogumTarihi"].ToString();
                dtpgiristarihi.Text = dtKullanici.Rows[0]["GirisTarihi"].ToString();
                btntamam.Text = "Güncelle";
                sifre.KullaniciAd = txtkullaniciadi.Text;

            }
            DataTable dtFotograf = nesne.FotografBul(txtkullaniciadi.Text);
            if (dtFotograf.Rows.Count == 0)
            {
                btnkaydet.Text = "Kaydet";
            }
            else
            {
                FotografYolu = dtFotograf.Rows[0]["FotografYolu"].ToString();
                pictureBox1.ImageLocation = FotografYolu;
                btnkaydet.Text = "Değiştir";
            }    
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
           
        }

        private void txtkullaniciadi_TextChanged(object sender, EventArgs e)
        {

        }
        dbEnginee nesne = new dbEnginee();

        private void btntamam_Click(object sender, EventArgs e)
        {
            try
            {
                if (btntamam.Text == "Güncelle")
                {
                    DialogResult dr = MessageBox.Show("Güncellemek istediğinizden emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        nesne.KullaniciBilgileriGuncelle1(txtkullaniciadi.Text, cmbgorev.Text, txtadsoyad.Text, dtpdogumtarihi.Value, dtpgiristarihi.Value);
                        nesne.KullaniciBilgileriGuncelle2(txtkullaniciadi.Text , txtadsoyad.Text);
                        MessageBox.Show("Güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }

                }
                else {
                    DialogResult dr = MessageBox.Show("Kaydetmek istediğinizden emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        nesne.KullaniciBilgileri(txtkullaniciadi.Text, cmbgorev.Text, txtadsoyad.Text, dtpdogumtarihi.Value, dtpgiristarihi.Value);
                        MessageBox.Show("Sisteme kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btntamam.Text = "Güncelle";
                        
                    }
                    
                }
            }
            catch
            {
                MessageBox.Show("Kayıt Yapılamadı.Yeniden deneyiniz..", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnsifre_MouseHover(object sender, EventArgs e)
        {
            btnsifre.Font = new Font("Comic Sans MS", 10, FontStyle.Italic);
            
        }

        private void btnsifre_MouseLeave(object sender, EventArgs e)
        {
            btnsifre.Font = new Font("Comic Sans MS", 9);

        }

        private void txtadsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
       //Resim ekleme
       
        private void btnekle_Click_1(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            openFileDialog1.Title = "www.WiseLib.com";
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                FotografYolu = openFileDialog1.ToString();
                pictureBox1.ImageLocation = FotografYolu;
              
            }
            
        }
        
        private void btnkaydet_Click_1(object sender, EventArgs e)
        {
            if (btnkaydet.Text == "Kaydet")
            {
                try
                {
                  nesne.FotografKaydet(txtkullaniciadi.Text, FotografYolu);
                  MessageBox.Show("Başarılı");
                }
                catch(Exception hata)
                {
                  MessageBox.Show(hata.Message);
                }
                
            }
            else
            {
                try
                {
                    nesne.FotografGuncelle(txtkullaniciadi.Text, FotografYolu);
                    MessageBox.Show("Başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                { }
               
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmbgorev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbgorev_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
    }
    }

