﻿using System;
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
    public partial class guvenlik : Form
    {
        public guvenlik()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (txtKullanıcıAdı.Text == "beritan" && txtSifre.Text == "123")
            {
                YeniKullanici ac = new YeniKullanici();
                ac.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yetki bilgileri yanlıştır!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
