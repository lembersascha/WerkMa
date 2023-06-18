// Kopierrechte bei Sascha Lember 2023
// Erstellt 18.06.2023

#region Verweise

using System;
using DevExpress.XtraEditors;
using Lember.WerkMa.Allgemein.Email.Classes;

#endregion

namespace Lember.WerkMa.Allgemein.Email.Forms
{
    public partial class Frm_EmailDaten : XtraForm
    {
        #region Construktors

        public Frm_EmailDaten()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void Btn_ProviderSave_Click(object sender, EventArgs e)
        {
            var emailDataWriter = new EmailDataWriter();
            emailDataWriter.WriteEmailServerDataToDb(Te_Server.Text,
                    Convert.ToInt32(Te_Port.Text),
                    Ce_Ssl.Checked,
                    Te_User.Text,
                    Te_Password.Text,
                    Te_Anbieter.Text);
        }

        #endregion
    }
}