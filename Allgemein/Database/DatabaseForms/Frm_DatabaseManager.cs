// Kopierrechte bei Sascha Lember 2023
// Erstellt 17.06.2023

#region Verweise

using System;
using System.Drawing;
using DevExpress.XtraEditors;
using Lember.WerkMa.Allgemein.Database.DatabaseClass;

#endregion

namespace Lember.WerkMa.Allgemein.Database.DatabaseForms
{
    public partial class Frm_DatabaseManager : XtraForm
    {
        #region Construktors

        public Frm_DatabaseManager()
        {
            InitializeComponent();
        }

        #endregion

        #region Fields

        public string ConnectionString { get; set; }

        #endregion

        #region Methods

        private void Btn_StringSave_Click(object sender, EventArgs e)
        {
            var connectionStringWriter = new ConnectionStringWriter();
            connectionStringWriter.WriteEncryptedConnectionStringToFile(
                    Te_ConnectionString.Text);
        }

        private void Btn_StringRead_Click(object sender, EventArgs e)
        {
            var connectionStringReader = new ConnectionStringReader();
            Te_DecryptetConnectionString.Text
                    = connectionStringReader.ReadAndDecryptConnectionString();
        }

        private void BtnStringBuild_Click(object sender, EventArgs e)
        {
            Te_ConnectionString.Text = new ServerStringBuild(TeServer.Text,
                    TeDatabase.Text, Te_Username.Text,
                    Te_Password.Text).BuildServerString();
        }

        private void BtnTestConnection_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Te_DecryptetConnectionString.Text))
            {
                XtraMessageBox.Show("Bitte geben Sie einen Connection String ein.");
                return;
            }

            var tester  = new ServerConnectionTest();
            var success = tester.TestServerConnection(Te_DecryptetConnectionString.Text);

            XtraMessageBox.Show(!success
                    ? "Verbindung konnte nicht hergestellt werden."
                    : "Verbindung erfolgreich hergestellt!");
        }

        private void Btn_Ping_Click(object sender, EventArgs e)
        {
            var validator = new IpAddressValidator();
            var isValid   = validator.IsValidIpAddress(Te_ServerIp.Text);

            if (!isValid)
            {
                XtraMessageBox.Show("Das ist keine gültige IP-Adresse.");
            }
            else
            {
                var pinger  = new ServerPinger();
                var success = pinger.PingServer(Te_ServerIp.Text);

                if (success)
                    Te_ServerIp.BackColor = Color.Green;
                else
                    Te_ServerIp.BackColor = Color.Red;
            }
        }

        #endregion
    }
}