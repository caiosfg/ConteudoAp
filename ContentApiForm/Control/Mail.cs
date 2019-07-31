using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Windows.Forms;

namespace ContentApiForm.Control
{
    class Mail
    {
        //Configure os atributos de sua conta de email
        string from = "ingresso@ingresso.com";
        string fromNome = "Noc Report";
        string to = "ingresso@ingresso.com";
        string smtpclient = "";
        string password = "";
        string host = "mail.ingresso.dev";
        int port = 1025;
        string subject = "Report - Emissão de Relatório";
        string body = System.IO.File.ReadAllText(Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory), @"mail.html"));

        public void Envia(string anexo)
        {
            MailMessage message = new MailMessage();
            
            //Cria e Compila a referencia do Mail Message
            message.From = new MailAddress(from, fromNome);
            message.To.Add(new MailAddress(to));
            message.Subject = subject;
            Attachment anexar = new Attachment(anexo);
            message.Attachments.Add(anexar);
            message.Body = body;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            message.Priority = MailPriority.High;

            using (var client = new System.Net.Mail.SmtpClient(host, port))
            {
                // Passando SMTP credentials
                client.Credentials =
                    new NetworkCredential(smtpclient, password);

                // habilitando SSL encryption
                client.EnableSsl = true;

                // Enviando email e seu status
                try
                {
                    MessageBox.Show("Enviando email.......");
                    client.Send(message);
                    MessageBox.Show("Email Enviado !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problema ao enviar.");
                    MessageBox.Show("Error message: " + ex.Message);
                }

            }
        }
    }
}
