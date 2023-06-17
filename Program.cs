// Kopierrechte bei Sascha Lember 2023
// Erstellt 17.06.2023

#region Verweise

using System;
using System.Windows.Forms;

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
            Application.Run(new Hauptfenster());
        }

        #endregion
    }
}