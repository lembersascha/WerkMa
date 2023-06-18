// Kopierrechte bei Sascha Lember 2023
// Erstellt 18.06.2023

#region Verweise

using System.Net;
using System.Net.Mail;
using Lember.WerkMa.Allgemein.Variablen.VariablenClass;

#endregion

namespace Lember.WerkMa.Allgemein.Email.Classes
{
    public class EmailSender
    {
        #region Construktors

        public EmailSender(string provider)
        {
            var dataProvider
                    = new EmailDataProvider(ConnectionString.ConnectionStringPath);
            serverData = dataProvider.GetEmailServerData(provider);
        }

        #endregion

        #region Fields

        private readonly EmailServerData serverData;

        #endregion

        #region Methods

        public void SendEmail(string recipient, string subject, string body)
        {
            using (var client = new SmtpClient(serverData.SmtpServer, serverData.Port))
            {
                client.Credentials
                        = new NetworkCredential(serverData.User, serverData.Password);
                client.EnableSsl = serverData.EnableSsl;

                var mailMessage = new MailMessage
                {
                        From    = new MailAddress(serverData.User),
                        Subject = subject,
                        Body    = body
                };
                mailMessage.To.Add(recipient);

                client.Send(mailMessage);
            }
        }

        #endregion
    }
}