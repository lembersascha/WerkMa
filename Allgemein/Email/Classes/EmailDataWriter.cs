// Kopierrechte bei Sascha Lember 2023
// Erstellt 18.06.2023

#region Verweise

using System;
using System.Data.SqlClient;
using Lember.WerkMa.Allgemein.Email.SqlStrings;
using Lember.WerkMa.Allgemein.SplashScreens;
using Lember.WerkMa.Allgemein.Variablen.VariablenClass;

#endregion

namespace Lember.WerkMa.Allgemein.Email.Classes
{
    public class EmailDataWriter
    {
        #region Methods

        public void WriteEmailServerDataToDb(string emailServer, int    port, bool ssl,
                                             string user,        string password,
                                             string anbieter)

        {
            try
            {
                using (var connection
                       = new SqlConnection(ConnectionString.ConnectionStringPath))
                {
                    connection.Open();

                    using (var command = new SqlCommand(
                                   SqlServerDataSave.SqlEmailDataSaveString,
                                   connection))
                    {
                        command.Parameters.AddWithValue("@smtpServer", emailServer);
                        command.Parameters.AddWithValue("@port", port);
                        command.Parameters.AddWithValue("@ssl", ssl);
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@anbieter", anbieter);
                        command.ExecuteNonQuery();
                    }

                    var showResultForm = new ShowResultForm();
                    showResultForm.WaitFormSave();
                }
            }
            catch (Exception fehler)
            {
                Console.WriteLine(fehler.Message);
                throw;
            }
        }

        #endregion
    }
}