// Kopierrechte bei Sascha Lember 2023
// Erstellt 17.06.2023

#region Verweise

using System;
using DevExpress.XtraEditors;
using Lember.WerkMa.Allgemein.Database.DatabaseForms;

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
        }

        private void Btn_OpenForm_Click(object sender, EventArgs e)
        {
            var frmDatabaseManager = new Frm_DatabaseManager();
            frmDatabaseManager.Show();
        }

        #endregion
    }
}