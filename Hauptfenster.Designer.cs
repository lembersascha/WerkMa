namespace Lember.WerkMa
{
    partial class Hauptfenster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_OpenForm = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Lember.WerkMa.Allgemein.SplashScreens.SaveSuccess), true, true);
            this.SuspendLayout();
            // 
            // Btn_OpenForm
            // 
            this.Btn_OpenForm.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_OpenForm.Appearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_OpenForm.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_OpenForm.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Btn_OpenForm.Appearance.Options.UseBackColor = true;
            this.Btn_OpenForm.Appearance.Options.UseBorderColor = true;
            this.Btn_OpenForm.Appearance.Options.UseFont = true;
            this.Btn_OpenForm.Appearance.Options.UseForeColor = true;
            this.Btn_OpenForm.Appearance.Options.UseTextOptions = true;
            this.Btn_OpenForm.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_OpenForm.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_OpenForm.Location = new System.Drawing.Point(388, 178);
            this.Btn_OpenForm.Name = "Btn_OpenForm";
            this.Btn_OpenForm.Size = new System.Drawing.Size(120, 30);
            this.Btn_OpenForm.TabIndex = 0;
            this.Btn_OpenForm.Text = "Öffne Form";
            this.Btn_OpenForm.Click += new System.EventHandler(this.Btn_OpenForm_Click);
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 782);
            this.Controls.Add(this.Btn_OpenForm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hauptfenster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hauptfenster";
            this.Load += new System.EventHandler(this.Hauptfenster_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btn_OpenForm;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}

