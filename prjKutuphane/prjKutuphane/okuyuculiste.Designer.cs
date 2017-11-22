namespace prjKutuphane
{
    partial class okuyuculiste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(okuyuculiste));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTcKimlik = new System.Windows.Forms.TextBox();
            this.txtOkulNumarasi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonTc = new System.Windows.Forms.RadioButton();
            this.radioButtonOgrenciNumarasi = new System.Windows.Forms.RadioButton();
            this.radioButtonAdSoyad = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tc Kimlik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Okul Numarası";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(186, 23);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(137, 20);
            this.txtAdSoyad.TabIndex = 1;
            this.txtAdSoyad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(348, 23);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(137, 20);
            this.txtTcKimlik.TabIndex = 2;
            this.txtTcKimlik.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtOkulNumarasi
            // 
            this.txtOkulNumarasi.Location = new System.Drawing.Point(505, 23);
            this.txtOkulNumarasi.Name = "txtOkulNumarasi";
            this.txtOkulNumarasi.Size = new System.Drawing.Size(137, 20);
            this.txtOkulNumarasi.TabIndex = 3;
            this.txtOkulNumarasi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjKutuphane.Properties.Resources.find;
            this.pictureBox1.Location = new System.Drawing.Point(133, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 36);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(771, 237);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtAdSoyad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTcKimlik);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtOkulNumarasi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 50);
            this.panel1.TabIndex = 20;
            // 
            // radioButtonTc
            // 
            this.radioButtonTc.AutoSize = true;
            this.radioButtonTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonTc.Location = new System.Drawing.Point(42, 32);
            this.radioButtonTc.Name = "radioButtonTc";
            this.radioButtonTc.Size = new System.Drawing.Size(75, 19);
            this.radioButtonTc.TabIndex = 21;
            this.radioButtonTc.TabStop = true;
            this.radioButtonTc.Text = "Tc Kimlik";
            this.radioButtonTc.UseVisualStyleBackColor = true;
            this.radioButtonTc.CheckedChanged += new System.EventHandler(this.radioButtonTc_CheckedChanged);
            // 
            // radioButtonOgrenciNumarasi
            // 
            this.radioButtonOgrenciNumarasi.AutoSize = true;
            this.radioButtonOgrenciNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonOgrenciNumarasi.Location = new System.Drawing.Point(42, 57);
            this.radioButtonOgrenciNumarasi.Name = "radioButtonOgrenciNumarasi";
            this.radioButtonOgrenciNumarasi.Size = new System.Drawing.Size(125, 19);
            this.radioButtonOgrenciNumarasi.TabIndex = 22;
            this.radioButtonOgrenciNumarasi.TabStop = true;
            this.radioButtonOgrenciNumarasi.Text = "Öğrenci Numarası";
            this.radioButtonOgrenciNumarasi.UseVisualStyleBackColor = true;
            this.radioButtonOgrenciNumarasi.CheckedChanged += new System.EventHandler(this.radioButtonOgrenciNumarasi_CheckedChanged);
            // 
            // radioButtonAdSoyad
            // 
            this.radioButtonAdSoyad.AutoSize = true;
            this.radioButtonAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonAdSoyad.Location = new System.Drawing.Point(41, 82);
            this.radioButtonAdSoyad.Name = "radioButtonAdSoyad";
            this.radioButtonAdSoyad.Size = new System.Drawing.Size(76, 19);
            this.radioButtonAdSoyad.TabIndex = 23;
            this.radioButtonAdSoyad.TabStop = true;
            this.radioButtonAdSoyad.Text = "Ad Soyad";
            this.radioButtonAdSoyad.UseVisualStyleBackColor = true;
            this.radioButtonAdSoyad.CheckedChanged += new System.EventHandler(this.radioButtonAdSoyad_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTc);
            this.groupBox1.Controls.Add(this.radioButtonAdSoyad);
            this.groupBox1.Controls.Add(this.radioButtonOgrenciNumarasi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(33, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 115);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sıralama Türünü Seçiniz:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // okuyuculiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 437);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "okuyuculiste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OKUYUCU LİSTESİ";
            this.Load += new System.EventHandler(this.okuyuculiste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTcKimlik;
        private System.Windows.Forms.TextBox txtOkulNumarasi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonTc;
        private System.Windows.Forms.RadioButton radioButtonOgrenciNumarasi;
        private System.Windows.Forms.RadioButton radioButtonAdSoyad;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}