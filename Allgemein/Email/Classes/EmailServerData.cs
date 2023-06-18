// Kopierrechte bei Sascha Lember 2023
// Erstellt 18.06.2023

namespace Lember.WerkMa.Allgemein.Email.Classes
{
    public class EmailServerData
    {
        #region Fields

        public string SmtpServer { get; set; }
        public int    Port       { get; set; }
        public bool   EnableSsl  { get; set; }
        public string User       { get; set; }
        public string Password   { get; set; }

        #endregion
    }
}