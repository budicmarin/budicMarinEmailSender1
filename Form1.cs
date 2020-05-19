using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace budicMarinEmailSender1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPosalji_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                SmtpServer.Port = 587;

                string username = textBox1.Text.ToString();
                string pass = textBoxPass.Text.ToString();
                string primatelj = textBoxPrimatelj.Text.ToString();
                string predmet= textBoxPredmet.Text.ToString();
                string poruka= textBoxPoruka.Text.ToString();


                mail.From = new MailAddress(username);
                mail.To.Add(primatelj);
                mail.Subject = predmet;
                mail.Body = poruka;

               

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(username,pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
