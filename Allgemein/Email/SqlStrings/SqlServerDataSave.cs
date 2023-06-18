// Kopierrechte bei Sascha Lember 2023
// Erstellt 18.06.2023

namespace Lember.WerkMa.Allgemein.Email.SqlStrings
{
    public static class SqlServerDataSave
    {
        #region Fields

        public const string SqlEmailDataSaveString = @"
        INSERT INTO
	        WerMa.dbo.Tbl_Email
	        (
		        SmtpServer,
		        [Port],
		        [Ssl],
		        [User],
		        [Password],
		        Anbieter
	        )
        VALUES
	        (
		        @smtpServer,
		        @port,
		        @ssl,
		        @user,
		        @password,
		        @anbieter
	        );";

        #endregion
    }
}