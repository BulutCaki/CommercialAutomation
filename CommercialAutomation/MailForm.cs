using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace CommercialAutomation
{
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
        }

        public string mail;

        private void MailForm_Load(object sender, EventArgs e)
        {
            textMail.Text = mail;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MailForm_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("Mail", "Sifre");
            client.Port = 587;
            client.Host = "smpt.live.com";
            client.EnableSsl = true;
            message.To.Add(richTextContent.Text);
            message.From = new MailAddress("Mail");
            message.Subject = textSubject.Text;
            message.Body = richTextContent.Text;
            client.Send(message);
        }
    }
}
