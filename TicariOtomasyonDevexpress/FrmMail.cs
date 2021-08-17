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

namespace TicariOtomasyonDevexpress
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        public string mail;
        private void FrmMail_Load(object sender, EventArgs e)
        {
            txtMail.Text = mail;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential(txtGonderenMail.Text,txtSifre.Text);
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesaj.To.Add(txtMail.Text);
            mesaj.From = new MailAddress(txtGonderenMail.Text);
            mesaj.Subject = txtMesaj.Text;
            mesaj.Body = richTextBox1.Text;
            istemci.Send(mesaj);
            MessageBox.Show("Mesaj Gönderilmiştir","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
