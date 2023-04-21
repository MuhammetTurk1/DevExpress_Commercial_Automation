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

namespace Ticari_Otamasyon2
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
            txt_MailAdresi.Text=mail;
        }

        private void btn_Gönder_Click(object sender, EventArgs e)
        {
            MailMessage mesajim = new MailMessage();
            SmtpClient istemci= new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("Mail", "Şifre");
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl= true;
            mesajim.To.Add(richbox_Mesaj.Text);
            mesajim.From = new MailAddress("Mail");
            mesajim.Subject = txt_Konu.Text;
            mesajim.Body = richbox_Mesaj.Text;
            istemci.Send(mesajim);
        }
    }
}
