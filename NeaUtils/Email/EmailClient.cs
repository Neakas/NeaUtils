using System;
using System.Net;
using System.Net.Mail;

namespace NeaUtils.Email
{
    public class EmailClient
    {
        private readonly EmailSettings _settings;

        public EmailClient(EmailSettings settings)
        {
            _settings = settings;
        }

        public bool Send(Email email)
        {
            try
            {
                var smtpClient = new SmtpClient();
                var basisCredential = new NetworkCredential(_settings.Benutzername, _settings.Passwort, _settings.Domain);
                var nachricht = new MailMessage();
                var absenderAdresse = new MailAddress(_settings.Absender);

                smtpClient.Host = _settings.SmtpServer;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = basisCredential;
                smtpClient.Timeout = 60 * 5 * 1000;
                smtpClient.EnableSsl = _settings.SslVerschlüsselung;

                nachricht.From = absenderAdresse;
                nachricht.Subject = email.Betreff;
                nachricht.IsBodyHtml = true;
                nachricht.Body = email.Mailtext.Replace("\r\n", "<br>");
                foreach (var empfänger in email.Empfänger)
                {
                    nachricht.To.Add(empfänger);
                }

                if (email.CcEmpfänger != null)
                {
                    foreach (var ccempfänger in email.CcEmpfänger)
                    {
                        nachricht.CC.Add(ccempfänger);
                    }
                }

                if (email.BccEmpfänger != null)
                {
                    foreach (var bccempfänger in email.BccEmpfänger)
                    {
                        nachricht.Bcc.Add(bccempfänger);
                    }
                }

                if (email.Anhänge != null)
                {
                    foreach (var attachment in email.Anhänge)
                    {
                        nachricht.Attachments.Add(new Attachment(attachment));
                    }
                }

                smtpClient.Send(nachricht);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
