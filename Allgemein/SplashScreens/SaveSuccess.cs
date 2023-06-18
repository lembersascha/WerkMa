// Kopierrechte bei Sascha Lember 2023
// Erstellt 18.06.2023

#region Verweise

using System;
using DevExpress.XtraWaitForm;

#endregion

namespace Lember.WerkMa.Allgemein.SplashScreens
{
    public partial class SaveSuccess : WaitForm
    {
        #region Construktors

        public SaveSuccess()
        {
            InitializeComponent();
            progressPanel1.AutoHeight = true;
        }

        #endregion

        #region WaitFormCommand enum

        public enum WaitFormCommand
        {
        }

        #endregion

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            progressPanel1.Caption = caption;
        }

        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            progressPanel1.Description = description;
        }

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
    }
}