namespace prjKutuphane
{
    partial class sifreunuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sifreunuttum));
            this.lblkullaniciadi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkullanici = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btngonder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.AutoSize = true;
            this.lblkullaniciadi.Location = new System.Drawing.Point(206, 65);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(85, 18);
            this.lblkullaniciadi.TabIndex = 0;
            this.lblkullaniciadi.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mail Adresi";
            // 
            // txtkullanici
            // 
            this.txtkullanici.Location = new System.Drawing.Point(297, 62);
            this.txtkullanici.Name = "txtkullanici";
            this.txtkullanici.Size = new System.Drawing.Size(236, 26);
            this.txtkullanici.TabIndex = 2;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(297, 105);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(236, 26);
            this.txtmail.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjKutuphane.Properties.Resources.send_icon;
            this.pictureBox1.Location = new System.Drawing.Point(72, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btngonder
            // 
            this.btngonder.Image = global::prjKutuphane.Properties.Resources.send1;
            this.btngonder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngonder.Location = new System.Drawing.Point(340, 152);
            this.btngonder.Name = "btngonder";
            this.btngonder.Size = new System.Drawing.Size(129, 61);
            this.btngonder.TabIndex = 5;
            this.btngonder.Text = "GÖNDER";
            this.btngonder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btngonder.UseVisualStyleBackColor = true;
            this.btngonder.Click += new System.EventHandler(this.btngonder_Click);
            // 
            // sifreunuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btngonder);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtkullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblkullaniciadi);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sifreunuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Hatırlatma";
            this.Load += new System.EventHandler(this.sifreunuttum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkullaniciadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkullanici;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Button btngonder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}