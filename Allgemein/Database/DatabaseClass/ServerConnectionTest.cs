// Kopierrechte bei Sascha Lember 2023
// Erstellt 17.06.2023

#region Verweise

using System;
using System.Data.SqlClient;
using System.Diagnostics;

#endregion

namespace Lember.WerkMa.Allgemein.Database.DatabaseClass
{
    public class ServerConnectionTest
    {
        #region Methods

        public bool TestServerConnection(string connectionString,
                                         int    connectionTimeout = 5)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.ConnectionString
                            += $";Connection Timeout={connectionTimeout}";
                    connection.Open();

                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        #endregion
    }
}