// Kopierrechte bei Sascha Lember 2023
// Erstellt 18.06.2023

namespace Lember.WerkMa.Allgemein.Email.SqlStrings
{
    public static class SqlEmailDataRead
    {
        #region Fields

        public const string SqlEmailDataString
                = @"SELECT * FROM Tbl_Email WHERE Anbieter = @anbieter";

        #endregion
    }
}