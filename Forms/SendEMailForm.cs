using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeApps.Forms
{
    public partial class SendEMailForm : Form
    {
        string attachFolder;
        public SendEMailForm()
        {
            InitializeComponent();
        }
        void Clear()
        {
            txtReciever.Clear();
            txtSubject.Clear();
            lsbFolder.Items.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int eMailCount = Regex.Matches(txtReciever.Text, ";").Count + 1;
            SmtpClient client = new SmtpClient("smtp.yandex.com.tr", 587);
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("kurtulusocal@yandex.com", "Kurtuluş Öcal");
            mail.Priority = MailPriority.High;
            mail.Subject = txtSubject.Text;
            if (eMailCount > 1)
            {
                string[] aliciPostaAdresleri = txtReciever.Text.Split(';');
                for (int i = 0; i < eMailCount; i++)
                {
                    string aliciPostaAdresi = aliciPostaAdresleri[i];
                    mail.To.Add(new MailAddress(aliciPostaAdresi, ""));
                }
            }
            else
            {
                mail.To.Add(new MailAddress(txtReciever.Text, ""));
            }
            mail.Body = rTextEMail.Text;
            mail.IsBodyHtml = true;

            if (attachFolder != null)
            {
                mail.Attachments.Add(new Attachment(attachFolder));
                NetworkCredential credential = new NetworkCredential("kurtulusocal@yandex.com", "password"); //use yandex mail. go to yadex mail and create a new code for access to smpt protocl of another e-mail auth.
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = credential;
                client.Send(mail);
            }
            else
            {
                NetworkCredential credential = new NetworkCredential("kurtulusocal@yandex.com", "password");
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = credential;
                client.Send(mail);
            }

            DialogResult sonuc = new DialogResult();

            sonuc = MessageBox.Show("Mailiniz Başarılı Bir Şekilde Gönderildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (sonuc == DialogResult.OK)
            {
                Clear();

                if (attachFolder != null)
                {
                    attachFolder.Remove(0, 2);
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Mailiniz Başarılı Bir Şekilde Gönderilemedi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSec = new OpenFileDialog();
            dosyaSec.Title = "";
            dosyaSec.ShowDialog();
            attachFolder = dosyaSec.FileName;
            lsbFolder.Items.Add(dosyaSec.SafeFileName);
        }
    }
}
