namespace prjKutuphane
{
    partial class Anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblBilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kitap = new System.Windows.Forms.ToolStripButton();
            this.kitapekle = new System.Windows.Forms.ToolStripButton();
            this.kullanicibilgileri = new System.Windows.Forms.ToolStripButton();
            this.cikis = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitap,
            this.toolStripSeparator1,
            this.kitapekle,
            this.toolStripSeparator2,
            this.kullanicibilgileri,
            this.toolStripSeparator3,
            this.cikis});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(871, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBilgi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(871, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblBilgi
            // 
            this.lblBilgi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(79, 17);
            this.lblBilgi.Text = "........................";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::prjKutuphane.Properties.Resources.lib;
            this.pictureBox1.Location = new System.Drawing.Point(0, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(871, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // kitap
            // 
            this.kitap.Image = global::prjKutuphane.Properties.Resources.book;
            this.kitap.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kitap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kitap.Name = "kitap";
            this.kitap.Size = new System.Drawing.Size(83, 36);
            this.kitap.Text = "Kitaplar";
            this.kitap.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // kitapekle
            // 
            this.kitapekle.Image = global::prjKutuphane.Properties.Resources.add;
            this.kitapekle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kitapekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kitapekle.Name = "kitapekle";
            this.kitapekle.Size = new System.Drawing.Size(94, 36);
            this.kitapekle.Text = "Kitap Ekle";
            this.kitapekle.Click += new System.EventHandler(this.kitapekle_Click);
            // 
            // kullanicibilgileri
            // 
            this.kullanicibilgileri.Image = global::prjKutuphane.Properties.Resources.kisisel;
            this.kullanicibilgileri.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kullanicibilgileri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kullanicibilgileri.Name = "kullanicibilgileri";
            this.kullanicibilgileri.Size = new System.Drawing.Size(122, 36);
            this.kullanicibilgileri.Text = "Kullanıcı Bilgileri";
            // 
            // cikis
            // 
            this.cikis.Image = global::prjKutuphane.Properties.Resources.kapat1;
            this.cikis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(75, 36);
            this.cikis.Text = "Çıkış Yap";
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(871, 522);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WiseLib";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton kitap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton kitapekle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton kullanicibilgileri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton cikis;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblBilgi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}