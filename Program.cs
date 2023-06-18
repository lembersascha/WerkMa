// Kopierrechte bei Sascha Lember 2023
// Erstellt 17.06.2023

#region Verweise

using System;
using System.Windows.Forms;
using Lember.WerkMa.Allgemein.Database.DatabaseClass;
using Lember.WerkMa.Allgemein.Database.DatabaseForms;
using Lember.WerkMa.Allgemein.Variablen.VariablenClass;

#endregion

namespace Lember.WerkMa
{
    internal static class Program
    {
        #region Methods

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                var serverConnectionTest = new ServerConnectionTest();
                var connectionString
                        = new ConnectionStringReader().ReadAndDecryptConnectionString();
                if (serverConnectionTest.TestServerConnection(connectionString))
                {
                    ConnectionString.SetConnectionStringPath(connectionString);

                    Application.Run(new Hauptfenster());
                }
                else

                {
                    Application.Run(new Frm_DatabaseManager());
                }
            }
            catch (Exception e)
            {
                //TODO Email bei Fehler versenden
                Console.WriteLine(e);
                throw;
            }
        }

        #endregion
    }
}