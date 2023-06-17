// Kopierrechte bei Sascha Lember 2023
// Erstellt 17.06.2023

#region Verweise

using System.Data.SqlClient;

#endregion

namespace Lember.WerkMa.Allgemein.Database.DatabaseClass
{
    public class ServerConnectionTest
    {
        #region Methods

        public bool TestServerConnection(string connectionString)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        #endregion
    }
}