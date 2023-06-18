// Kopierrechte bei Sascha Lember 2023
// Erstellt 18.06.2023

#region Verweise

using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

#endregion

namespace Lember.WerkMa.Allgemein.SplashScreens
{
    public class ShowResultForm
    {
        #region Methods

        public void WaitFormSave()
        {
            SplashScreenManager.ShowForm(null, typeof(SaveSuccess), true, true, false);

            var timer = new Timer();
            timer.Interval = 2000; // Setzen Sie den Timer auf 2 Sekunden.
            timer.Tick += (sender, e) =>
            {
                timer.Stop(); // Stoppen Sie den Timer.
                if (SplashScreenManager.Default !=
                    null) // Prüfen Sie, ob ein SplashScreen geöffnet ist.
                    SplashScreenManager.CloseForm(); // Schließen Sie den Splash-Screen.
            };
            timer.Start(); // Starten Sie den Timer.
        }

        #endregion
    }
}