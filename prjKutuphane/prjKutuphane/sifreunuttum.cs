using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail; //Mail gönderme kütüphanesi
using System.Net;
using System.Data.OleDb;

namespace prjKutuphane
{
    public partial class sifreunuttum : Form
    {
        public sifreunuttum()
        {
            InitializeComponent();
        }
        //Mail gönderme
        public static string Sifre;
        
       

        private void btngonder_Click(object sender, EventArgs e)
        {
            if (txtkullanici.Text==""||txtmail.Text=="")
            {
                MessageBox.Show("Gerekli alanları doldurunuz!","Mesaj",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                dbEnginee nesne = new dbEnginee();
                if (nesne.emailkontrol(txtmail.Text)==true)
                {
                    DataTable dtemail = nesne.SifreBul(txtkullanici.Text,txtmail.Text);
                    if (dtemail.Rows.Count == 0) 
                    {
                        MessageBox.Show("Sistemdeki kullanıcı adınız ve epostanız eşleşmiyor!", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        sifreunuttum.Sifre = dtemail.Rows[0]["Sifre"].ToString();
                        ////şifre gönderme
                         try
                            {
                                int _port = 587;
                                string _host = "smtp.live.com";
                                string _clientUserName = "Wiselib@hotmail.com";
                                string _fromMail = "Wiselib@hotmail.com";
                                string _clientUserPassword = "Welcome1234";
                                bool _enableSsl = true;

                                MailMessage mailMessage = new MailMessage();

                                mailMessage.To.Add(txtmail.Text);
                                mailMessage.IsBodyHtml = true;
                                mailMessage.Body = @"Şifreniz:" + Sifre;
                                mailMessage.Subject = @"Şifre Hatırlatma";
                                mailMessage.From = new MailAddress(_fromMail);

                                SmtpClient smtp = new SmtpClient(_host, _port);
                                smtp.Credentials = new System.Net.NetworkCredential(_clientUserName, _clientUserPassword);
                                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                                smtp.EnableSsl = _enableSsl;
                                smtp.Send(mailMessage);
                                MessageBox.Show("Mail başarıyla gönderildi.", "MAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch(Exception hata)
                            {
                                MessageBox.Show(hata.Message);
                            }

                        

                    }
                      
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir mail adresi giriniz", "Geçersiz Mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            


        }

        private void sifreunuttum_Load(object sender, EventArgs e)
        {

        }
    }
}
