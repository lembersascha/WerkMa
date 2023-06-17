// Kopierrechte bei Sascha Lember 2023
// Erstellt 17.06.2023

namespace Lember.WerkMa.Allgemein.Database.DatabaseClass
{
    public class ServerStringBuild
    {
        #region Construktors

        // Konstruktor
        public ServerStringBuild(string server, string database, string username,
                                 string password)
        {
            Server   = server;
            Database = database;
            Username = username;
            Password = password;
        }

        #endregion

        #region Fields

        // Eigenschaften
        private string Server   { get; }
        private string Database { get; }
        private string Username { get; }
        private string Password { get; }

        #endregion

        #region Methods

        // Methode zur Erstellung des Connection Strings
        public string BuildServerString()
        {
            return
                    $"Data Source={Server};Initial Catalog={Database};User ID={Username};Password={Password}";
        }

        #endregion
    }
}