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
    public partial class kitapkayit : Form
    {
        public kitapkayit()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        dbEnginee nesne = new dbEnginee();

        private void kitapkayit_Load(object sender, EventArgs e)
        {
            
            cbKategoriAd.DataSource = nesne.KategoriYukle();
            cbKategoriAd.DisplayMember="Kategori";
        }

        private void cbKAtegoriAd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void Kayit()
        {
            if (nesne.KitapKontrol(txtKitapKod.Text) == true)
            {

                nesne.KitapKayit(txtKitapKod.Text, txtKitapAd.Text, cbKategoriAd.Text, txtYazarAd.Text, txtRafNo.Text, cbKitapDurum.Text, txtAciklama.Text);
                MessageBox.Show("Kayıt tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kitap kodu daha önceden tanımlanmıştır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
       
      

        private void btnKaydet_Click(object sender, EventArgs e)
        { // Yeni Kayıt sağlar
            if (btnKaydet.Text == "Kaydet")
            {
                if (txtKitapKod.Text.Length == 0 || txtKitapAd.Text.Length == 0 || txtRafNo.Text.Length == 0 || cbKategoriAd.Text.Length == 0)
                {
                    MessageBox.Show("Alanlar boş geçilemez!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Kayit();
                }
            }
            //Kayıt günceller
            else
            {
                nesne.KitapGuncelle(txtKitapKod.Text, txtKitapAd.Text, cbKategoriAd.Text, txtYazarAd.Text, txtRafNo.Text, cbKitapDurum.Text, txtAciklama.Text);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtKitap = nesne.KitapBul(txtKitapKod.Text);
            if (dtKitap.Rows.Count == 0)
            {
                MessageBox.Show("Kitap bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                txtAciklama.Text = dtKitap.Rows[0]["Aciklama"].ToString();
                txtKitapAd.Text = dtKitap.Rows[0]["KitapAd"].ToString();
                txtRafNo.Text = dtKitap.Rows[0]["RafNo"].ToString();
                txtYazarAd.Text = dtKitap.Rows[0]["YazarAd"].ToString();
                cbKategoriAd.Text = dtKitap.Rows[0]["KategoriAd"].ToString();
                cbKitapDurum.Text = dtKitap.Rows[0]["KitapDurum"].ToString();
                btnKaydet.Text = "Düzelt";
                txtKitapKod.Enabled = false;
                btnSil.Visible = true;
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            kitapkayit ac = new kitapkayit();
            ac.Show();
            btnKaydet.Text = "Kaydet";
            txtKitapKod.Enabled = true;
            txtAciklama.Text = "";
            txtKitapAd.Text = "";
            txtRafNo.Text = "";
            txtYazarAd.Text = "";
            txtKitapKod.Text = "";
            cbKategoriAd.SelectedIndex = 0;
            cbKitapDurum.SelectedIndex =0;
            txtKitapKod.Focus();
            
       }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Silmek istediğinizden emin misiniz?","Kayıt Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr==DialogResult.Yes) {
                nesne.KitapSil(txtKitapKod.Text);
                btnYeni.PerformClick();
                btnSil.Visible = false;
            }
        }

        private void cbKitapDurum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtKitapKod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

        }
    }
        



    }

