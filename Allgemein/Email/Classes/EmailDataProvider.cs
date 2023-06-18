// Kopierrechte bei Sascha Lember 2023
// Erstellt 18.06.2023

#region Verweise

using System;
using System.Data.SqlClient;
using Lember.WerkMa.Allgemein.Email.SqlStrings;

#endregion

namespace Lember.WerkMa.Allgemein.Email.Classes
{
    public class EmailDataProvider
    {
        #region Construktors

        public EmailDataProvider(string connectionString)
        {
            this.connectionString = connectionString;
        }

        #endregion

        #region Fields

        private readonly string connectionString;

        #endregion

        #region Methods

        public EmailServerData GetEmailServerData(string provider)
        {
            var emailServerData = new EmailServerData();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(
                               SqlEmailDataRead.SqlEmailDataString,
                               connection))
                {
                    command.Parameters.AddWithValue("@anbieter", provider);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            emailServerData.SmtpServer = reader["SmtpServer"].ToString();
                            emailServerData.Port       = Convert.ToInt32(reader["Port"]);
                            emailServerData.EnableSsl  = Convert.ToBoolean(reader["Ssl"]);
                            emailServerData.User       = reader["User"].ToString();
                            emailServerData.Password   = reader["Password"].ToString();
                        }
                    }
                }
            }

            return emailServerData;
        }

        #endregion
    }
}