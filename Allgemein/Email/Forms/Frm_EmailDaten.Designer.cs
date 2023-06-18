namespace Lember.WerkMa.Allgemein.Email.Forms
{
    partial class Frm_EmailDaten
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LblDatabase = new DevExpress.XtraEditors.LabelControl();
            this.LblBenutzer = new DevExpress.XtraEditors.LabelControl();
            this.LblPassword = new DevExpress.XtraEditors.LabelControl();
            this.LblServer = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Te_Port = new DevExpress.XtraEditors.TextEdit();
            this.Ce_Ssl = new DevExpress.XtraEditors.CheckEdit();
            this.Te_Anbieter = new DevExpress.XtraEditors.TextEdit();
            this.Te_Server = new DevExpress.XtraEditors.TextEdit();
            this.Btn_ProviderSave = new DevExpress.XtraEditors.SimpleButton();
            this.Te_User = new DevExpress.XtraEditors.TextEdit();
            this.Te_Password = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Te_Port.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ce_Ssl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_Anbieter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_Server.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_User.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_Password.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.Te_Port);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.Ce_Ssl);
            this.groupControl1.Controls.Add(this.Te_Anbieter);
            this.groupControl1.Controls.Add(this.Te_Server);
            this.groupControl1.Controls.Add(this.Btn_ProviderSave);
            this.groupControl1.Controls.Add(this.Te_User);
            this.groupControl1.Controls.Add(this.LblDatabase);
            this.groupControl1.Controls.Add(this.LblBenutzer);
            this.groupControl1.Controls.Add(this.Te_Password);
            this.groupControl1.Controls.Add(this.LblPassword);
            this.groupControl1.Controls.Add(this.LblServer);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(12, 233);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(320, 314);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Emaildaten Server Neu";
            // 
            // LblDatabase
            // 
            this.LblDatabase.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblDatabase.Appearance.Options.UseFont = true;
            this.LblDatabase.Location = new System.Drawing.Point(10, 68);
            this.LblDatabase.MinimumSize = new System.Drawing.Size(0, 26);
            this.LblDatabase.Name = "LblDatabase";
            this.LblDatabase.Size = new System.Drawing.Size(38, 26);
            this.LblDatabase.TabIndex = 12;
            this.LblDatabase.Text = "SSL:";
            // 
            // LblBenutzer
            // 
            this.LblBenutzer.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblBenutzer.Appearance.Options.UseFont = true;
            this.LblBenutzer.Location = new System.Drawing.Point(10, 132);
            this.LblBenutzer.MinimumSize = new System.Drawing.Size(0, 26);
            this.LblBenutzer.Name = "LblBenutzer";
            this.LblBenutzer.Size = new System.Drawing.Size(76, 26);
            this.LblBenutzer.TabIndex = 11;
            this.LblBenutzer.Text = "Benutzer:";
            // 
            // LblPassword
            // 
            this.LblPassword.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblPassword.Appearance.Options.UseFont = true;
            this.LblPassword.Location = new System.Drawing.Point(10, 164);
            this.LblPassword.MinimumSize = new System.Drawing.Size(0, 26);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(78, 26);
            this.LblPassword.TabIndex = 10;
            this.LblPassword.Text = "Passwort:";
            // 
            // LblServer
            // 
            this.LblServer.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblServer.Appearance.Options.UseFont = true;
            this.LblServer.Location = new System.Drawing.Point(10, 36);
            this.LblServer.MinimumSize = new System.Drawing.Size(0, 26);
            this.LblServer.Name = "LblServer";
            this.LblServer.Size = new System.Drawing.Size(56, 26);
            this.LblServer.TabIndex = 8;
            this.LblServer.Text = "Server:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 199);
            this.labelControl1.MinimumSize = new System.Drawing.Size(0, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 26);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Anbieter:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 100);
            this.labelControl2.MinimumSize = new System.Drawing.Size(0, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 26);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Port:";
            // 
            // Te_Port
            // 
            this.Te_Port.Location = new System.Drawing.Point(114, 100);
            this.Te_Port.MinimumSize = new System.Drawing.Size(0, 26);
            this.Te_Port.Name = "Te_Port";
            this.Te_Port.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.Te_Port.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_Port.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Te_Port.Properties.Appearance.Options.UseBackColor = true;
            this.Te_Port.Properties.Appearance.Options.UseFont = true;
            this.Te_Port.Properties.Appearance.Options.UseForeColor = true;
            this.Te_Port.Properties.Appearance.Options.UseTextOptions = true;
            this.Te_Port.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_Port.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_Port.Properties.AppearanceFocused.Options.UseFont = true;
            this.Te_Port.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.Te_Port.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_Port.Size = new System.Drawing.Size(194, 26);
            this.Te_Port.TabIndex = 16;
            // 
            // Ce_Ssl
            // 
            this.Ce_Ssl.EditValue = true;
            this.Ce_Ssl.Location = new System.Drawing.Point(99, 71);
            this.Ce_Ssl.Name = "Ce_Ssl";
            this.Ce_Ssl.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Ce_Ssl.Properties.Appearance.Options.UseFont = true;
            this.Ce_Ssl.Properties.Caption = "";
            this.Ce_Ssl.Properties.ContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Ce_Ssl.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.Ce_Ssl.Size = new System.Drawing.Size(52, 20);
            this.Ce_Ssl.TabIndex = 16;
            // 
            // Te_Anbieter
            // 
            this.Te_Anbieter.Location = new System.Drawing.Point(114, 196);
            this.Te_Anbieter.MinimumSize = new System.Drawing.Size(0, 26);
            this.Te_Anbieter.Name = "Te_Anbieter";
            this.Te_Anbieter.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.Te_Anbieter.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_Anbieter.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Te_Anbieter.Properties.Appearance.Options.UseBackColor = true;
            this.Te_Anbieter.Properties.Appearance.Options.UseFont = true;
            this.Te_Anbieter.Properties.Appearance.Options.UseForeColor = true;
            this.Te_Anbieter.Properties.Appearance.Options.UseTextOptions = true;
            this.Te_Anbieter.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_Anbieter.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_Anbieter.Properties.AppearanceFocused.Options.UseFont = true;
            this.Te_Anbieter.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.Te_Anbieter.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_Anbieter.Size = new System.Drawing.Size(194, 26);
            this.Te_Anbieter.TabIndex = 13;
            // 
            // Te_Server
            // 
            this.Te_Server.Location = new System.Drawing.Point(114, 36);
            this.Te_Server.MinimumSize = new System.Drawing.Size(0, 26);
            this.Te_Server.Name = "Te_Server";
            this.Te_Server.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.Te_Server.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_Server.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Te_Server.Properties.Appearance.Options.UseBackColor = true;
            this.Te_Server.Properties.Appearance.Options.UseFont = true;
            this.Te_Server.Properties.Appearance.Options.UseForeColor = true;
            this.Te_Server.Properties.Appearance.Options.UseTextOptions = true;
            this.Te_Server.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_Server.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_Server.Properties.AppearanceFocused.Options.UseFont = true;
            this.Te_Server.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.Te_Server.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_Server.Size = new System.Drawing.Size(194, 26);
            this.Te_Server.TabIndex = 0;
            // 
            // Btn_ProviderSave
            // 
            this.Btn_ProviderSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_ProviderSave.Appearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_ProviderSave.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_ProviderSave.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Btn_ProviderSave.Appearance.Options.UseBackColor = true;
            this.Btn_ProviderSave.Appearance.Options.UseBorderColor = true;
            this.Btn_ProviderSave.Appearance.Options.UseFont = true;
            this.Btn_ProviderSave.Appearance.Options.UseForeColor = true;
            this.Btn_ProviderSave.Appearance.Options.UseTextOptions = true;
            this.Btn_ProviderSave.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_ProviderSave.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_ProviderSave.ImageOptions.Image = global::Lember.WerkMa.Properties.Resources.addnewdatasource_16x161;
            this.Btn_ProviderSave.Location = new System.Drawing.Point(114, 242);
            this.Btn_ProviderSave.Name = "Btn_ProviderSave";
            this.Btn_ProviderSave.Size = new System.Drawing.Size(194, 26);
            this.Btn_ProviderSave.TabIndex = 4;
            this.Btn_ProviderSave.Text = "Anbieter Speichern";
            this.Btn_ProviderSave.Click += new System.EventHandler(this.Btn_ProviderSave_Click);
            // 
            // Te_User
            // 
            this.Te_User.Location = new System.Drawing.Point(114, 132);
            this.Te_User.MinimumSize = new System.Drawing.Size(0, 26);
            this.Te_User.Name = "Te_User";
            this.Te_User.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.Te_User.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_User.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Te_User.Properties.Appearance.Options.UseBackColor = true;
            this.Te_User.Properties.Appearance.Options.UseFont = true;
            this.Te_User.Properties.Appearance.Options.UseForeColor = true;
            this.Te_User.Properties.Appearance.Options.UseTextOptions = true;
            this.Te_User.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_User.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_User.Properties.AppearanceFocused.Options.UseFont = true;
            this.Te_User.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.Te_User.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_User.Size = new System.Drawing.Size(194, 26);
            this.Te_User.TabIndex = 2;
            // 
            // Te_Password
            // 
            this.Te_Password.Location = new System.Drawing.Point(114, 164);
            this.Te_Password.MinimumSize = new System.Drawing.Size(0, 26);
            this.Te_Password.Name = "Te_Password";
            this.Te_Password.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.Te_Password.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_Password.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Te_Password.Properties.Appearance.Options.UseBackColor = true;
            this.Te_Password.Properties.Appearance.Options.UseFont = true;
            this.Te_Password.Properties.Appearance.Options.UseForeColor = true;
            this.Te_Password.Properties.Appearance.Options.UseTextOptions = true;
            this.Te_Password.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_Password.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_Password.Properties.AppearanceFocused.Options.UseFont = true;
            this.Te_Password.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.Te_Password.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_Password.Size = new System.Drawing.Size(194, 26);
            this.Te_Password.TabIndex = 3;
            // 
            // Frm_EmailDaten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 559);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Name = "Frm_EmailDaten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emaildaten in Datenbank Schreiben";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Te_Port.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ce_Ssl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_Anbieter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_Server.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_User.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_Password.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit Te_Server;
        private DevExpress.XtraEditors.SimpleButton Btn_ProviderSave;
        private DevExpress.XtraEditors.TextEdit Te_User;
        private DevExpress.XtraEditors.LabelControl LblDatabase;
        private DevExpress.XtraEditors.LabelControl LblBenutzer;
        private DevExpress.XtraEditors.TextEdit Te_Password;
        private DevExpress.XtraEditors.LabelControl LblPassword;
        private DevExpress.XtraEditors.LabelControl LblServer;
        private DevExpress.XtraEditors.TextEdit Te_Anbieter;
        private DevExpress.XtraEditors.CheckEdit Ce_Ssl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit Te_Port;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}