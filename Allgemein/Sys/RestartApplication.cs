// Kopierrechte bei Sascha Lember 2023
// Erstellt 18.06.2023

#region Verweise

using System.Diagnostics;
using System.Windows.Forms;

#endregion

namespace Lember.WerkMa.Allgemein.Sys
{
    internal class RestartApplication
    {
        #region Methods

        public static void Restart()
        {
            var processModule = Process.GetCurrentProcess().MainModule;
            if (processModule != null)
            {
                var exeName = processModule.FileName;
                Process.Start(exeName);
            }

            Application.Exit();
        }

        #endregion
    }
}