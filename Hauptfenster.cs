// Kopierrechte bei Sascha Lember 2023
// Erstellt 17.06.2023

#region Verweise

using System;
using DevExpress.XtraEditors;
using Lember.WerkMa.Allgemein.Email.Classes;

#endregion

namespace Lember.WerkMa
{
    public partial class Hauptfenster : XtraForm
    {
        #region Construktors

        public Hauptfenster()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void Hauptfenster_Load(object sender, EventArgs e)
        {
            // MessageBox.Show(DbCon);
        }

        private void Btn_OpenForm_Click(object sender, EventArgs e)
        {
            //   var frmDatabaseManager = new Frm_DatabaseManager();
            //   frmDatabaseManager.Show();

            //TODO Email bei Fehler versenden Konfigurieren

            var emailSender = new EmailSender("dogado");
            emailSender.SendEmail("sascha@lember.net", "Testmail",
                    "mal schauen ob das geht");

            // var frm_EmailDaten = new Frm_EmailDaten();
            // frm_EmailDaten.Show();
        }

        #endregion
    }
}