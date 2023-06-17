namespace Lember.WerkMa.Allgemein.Database.DatabaseForms
{
    partial class Frm_DatabaseManager
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
            this.LblServer = new DevExpress.XtraEditors.LabelControl();
            this.LblPassword = new DevExpress.XtraEditors.LabelControl();
            this.LblBenutzer = new DevExpress.XtraEditors.LabelControl();
            this.LblDatabase = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.Te_DecryptetConnectionString = new DevExpress.XtraEditors.TextEdit();
            this.Te_ConnectionString = new DevExpress.XtraEditors.TextEdit();
            this.Btn_StringSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnTestConnection = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_StringRead = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Restart = new DevExpress.XtraEditors.SimpleButton();
            this.Te_ServerIp = new DevExpress.XtraEditors.TextEdit();
            this.Btn_Ping = new DevExpress.XtraEditors.SimpleButton();
            this.TeServer = new DevExpress.XtraEditors.TextEdit();
            this.BtnStringBuild = new DevExpress.XtraEditors.SimpleButton();
            this.Te_Username = new DevExpress.XtraEditors.TextEdit();
            this.TeDatabase = new DevExpress.XtraEditors.TextEdit();
            this.Te_Password = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Te_DecryptetConnectionString.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_ConnectionString.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_ServerIp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_Username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_Password.Properties)).BeginInit();
            this.SuspendLayout();
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
            // LblPassword
            // 
            this.LblPassword.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblPassword.Appearance.Options.UseFont = true;
            this.LblPassword.Location = new System.Drawing.Point(10, 132);
            this.LblPassword.MinimumSize = new System.Drawing.Size(0, 26);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(78, 26);
            this.LblPassword.TabIndex = 10;
            this.LblPassword.Text = "Passwort:";
            // 
            // LblBenutzer
            // 
            this.LblBenutzer.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblBenutzer.Appearance.Options.UseFont = true;
            this.LblBenutzer.Location = new System.Drawing.Point(10, 100);
            this.LblBenutzer.MinimumSize = new System.Drawing.Size(0, 26);
            this.LblBenutzer.Name = "LblBenutzer";
            this.LblBenutzer.Size = new System.Drawing.Size(76, 26);
            this.LblBenutzer.TabIndex = 11;
            this.LblBenutzer.Text = "Benutzer:";
            // 
            // LblDatabase
            // 
            this.LblDatabase.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.LblDatabase.Appearance.Options.UseFont = true;
            this.LblDatabase.Location = new System.Drawing.Point(10, 68);
            this.LblDatabase.MinimumSize = new System.Drawing.Size(0, 26);
            this.LblDatabase.Name = "LblDatabase";
            this.LblDatabase.Size = new System.Drawing.Size(89, 26);
            this.LblDatabase.TabIndex = 12;
            this.LblDatabase.Text = "Datenbank:";
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
            this.groupControl1.Controls.Add(this.TeServer);
            this.groupControl1.Controls.Add(this.BtnStringBuild);
            this.groupControl1.Controls.Add(this.Te_Username);
            this.groupControl1.Controls.Add(this.LblDatabase);
            this.groupControl1.Controls.Add(this.TeDatabase);
            this.groupControl1.Controls.Add(this.LblBenutzer);
            this.groupControl1.Controls.Add(this.Te_Password);
            this.groupControl1.Controls.Add(this.LblPassword);
            this.groupControl1.Controls.Add(this.LblServer);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(320, 196);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Server String Erstellen";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupControl2.Appearance.BorderColor = System.Drawing.Color.White;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.Appearance.Options.UseBorderColor = true;
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.AutoSize = true;
            this.groupControl2.Controls.Add(this.Te_ServerIp);
            this.groupControl2.Controls.Add(this.Btn_Ping);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(370, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(412, 62);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Server IP Testen";
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupControl3.Appearance.BorderColor = System.Drawing.Color.White;
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.Appearance.Options.UseBorderColor = true;
            this.groupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupControl3.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl3.Controls.Add(this.Btn_Close);
            this.groupControl3.Controls.Add(this.Btn_Restart);
            this.groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl3.Location = new System.Drawing.Point(370, 83);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(412, 125);
            this.groupControl3.TabIndex = 19;
            this.groupControl3.Text = "System";
            // 
            // groupControl4
            // 
            this.groupControl4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupControl4.Appearance.BorderColor = System.Drawing.Color.White;
            this.groupControl4.Appearance.Options.UseBackColor = true;
            this.groupControl4.Appearance.Options.UseBorderColor = true;
            this.groupControl4.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupControl4.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl4.Controls.Add(this.Te_DecryptetConnectionString);
            this.groupControl4.Controls.Add(this.Te_ConnectionString);
            this.groupControl4.Controls.Add(this.Btn_StringSave);
            this.groupControl4.Controls.Add(this.BtnTestConnection);
            this.groupControl4.Controls.Add(this.Btn_StringRead);
            this.groupControl4.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl4.Location = new System.Drawing.Point(12, 235);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(770, 108);
            this.groupControl4.TabIndex = 20;
            this.groupControl4.Text = "Konfogurationsdatei Schreiben / Lesen";
            // 
            // Te_DecryptetConnectionString
            // 
            this.Te_DecryptetConnectionString.Location = new System.Drawing.Point(10, 26);
            this.Te_DecryptetConnectionString.Name = "Te_DecryptetConnectionString";
            this.Te_DecryptetConnectionString.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.Te_DecryptetConnectionString.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_DecryptetConnectionString.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Te_DecryptetConnectionString.Properties.Appearance.Options.UseBackColor = true;
            this.Te_DecryptetConnectionString.Properties.Appearance.Options.UseFont = true;
            this.Te_DecryptetConnectionString.Properties.Appearance.Options.UseForeColor = true;
            this.Te_DecryptetConnectionString.Properties.Appearance.Options.UseTextOptions = true;
            this.Te_DecryptetConnectionString.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_DecryptetConnectionString.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_DecryptetConnectionString.Properties.AppearanceFocused.Options.UseFont = true;
            this.Te_DecryptetConnectionString.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.Te_DecryptetConnectionString.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_DecryptetConnectionString.Size = new System.Drawing.Size(400, 26);
            this.Te_DecryptetConnectionString.TabIndex = 0;
            // 
            // Te_ConnectionString
            // 
            this.Te_ConnectionString.Location = new System.Drawing.Point(10, 71);
            this.Te_ConnectionString.Name = "Te_ConnectionString";
            this.Te_ConnectionString.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.Te_ConnectionString.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_ConnectionString.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Te_ConnectionString.Properties.Appearance.Options.UseBackColor = true;
            this.Te_ConnectionString.Properties.Appearance.Options.UseFont = true;
            this.Te_ConnectionString.Properties.Appearance.Options.UseForeColor = true;
            this.Te_ConnectionString.Properties.Appearance.Options.UseTextOptions = true;
            this.Te_ConnectionString.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_ConnectionString.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_ConnectionString.Properties.AppearanceFocused.Options.UseFont = true;
            this.Te_ConnectionString.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.Te_ConnectionString.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_ConnectionString.Size = new System.Drawing.Size(400, 26);
            this.Te_ConnectionString.TabIndex = 3;
            // 
            // Btn_StringSave
            // 
            this.Btn_StringSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_StringSave.Appearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_StringSave.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_StringSave.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Btn_StringSave.Appearance.Options.UseBackColor = true;
            this.Btn_StringSave.Appearance.Options.UseBorderColor = true;
            this.Btn_StringSave.Appearance.Options.UseFont = true;
            this.Btn_StringSave.Appearance.Options.UseForeColor = true;
            this.Btn_StringSave.Appearance.Options.UseTextOptions = true;
            this.Btn_StringSave.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_StringSave.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_StringSave.ImageOptions.Image = global::Lember.WerkMa.Properties.Resources.exportfile_16x16;
            this.Btn_StringSave.Location = new System.Drawing.Point(416, 71);
            this.Btn_StringSave.Name = "Btn_StringSave";
            this.Btn_StringSave.Size = new System.Drawing.Size(160, 26);
            this.Btn_StringSave.TabIndex = 4;
            this.Btn_StringSave.Text = "Speichern";
            this.Btn_StringSave.Click += new System.EventHandler(this.Btn_StringSave_Click);
            // 
            // BtnTestConnection
            // 
            this.BtnTestConnection.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnTestConnection.Appearance.BorderColor = System.Drawing.Color.Black;
            this.BtnTestConnection.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BtnTestConnection.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnTestConnection.Appearance.Options.UseBackColor = true;
            this.BtnTestConnection.Appearance.Options.UseBorderColor = true;
            this.BtnTestConnection.Appearance.Options.UseFont = true;
            this.BtnTestConnection.Appearance.Options.UseForeColor = true;
            this.BtnTestConnection.Appearance.Options.UseTextOptions = true;
            this.BtnTestConnection.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BtnTestConnection.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.BtnTestConnection.ImageOptions.Image = global::Lember.WerkMa.Properties.Resources.refresh_16x161;
            this.BtnTestConnection.Location = new System.Drawing.Point(582, 25);
            this.BtnTestConnection.Name = "BtnTestConnection";
            this.BtnTestConnection.Size = new System.Drawing.Size(180, 26);
            this.BtnTestConnection.TabIndex = 2;
            this.BtnTestConnection.Text = "Verbindung Testen";
            this.BtnTestConnection.Click += new System.EventHandler(this.BtnTestConnection_Click);
            // 
            // Btn_StringRead
            // 
            this.Btn_StringRead.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_StringRead.Appearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_StringRead.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_StringRead.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Btn_StringRead.Appearance.Options.UseBackColor = true;
            this.Btn_StringRead.Appearance.Options.UseBorderColor = true;
            this.Btn_StringRead.Appearance.Options.UseFont = true;
            this.Btn_StringRead.Appearance.Options.UseForeColor = true;
            this.Btn_StringRead.Appearance.Options.UseTextOptions = true;
            this.Btn_StringRead.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_StringRead.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_StringRead.ImageOptions.Image = global::Lember.WerkMa.Properties.Resources.previous_16x16;
            this.Btn_StringRead.Location = new System.Drawing.Point(416, 25);
            this.Btn_StringRead.Name = "Btn_StringRead";
            this.Btn_StringRead.Size = new System.Drawing.Size(160, 26);
            this.Btn_StringRead.TabIndex = 1;
            this.Btn_StringRead.Text = "Lesen";
            this.Btn_StringRead.Click += new System.EventHandler(this.Btn_StringRead_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Appearance.BackColor = System.Drawing.Color.GreenYellow;
            this.Btn_Close.Appearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Close.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Close.Appearance.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Appearance.Options.UseBackColor = true;
            this.Btn_Close.Appearance.Options.UseBorderColor = true;
            this.Btn_Close.Appearance.Options.UseFont = true;
            this.Btn_Close.Appearance.Options.UseForeColor = true;
            this.Btn_Close.Appearance.Options.UseTextOptions = true;
            this.Btn_Close.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_Close.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_Close.ImageOptions.Image = global::Lember.WerkMa.Properties.Resources.close_16x16;
            this.Btn_Close.Location = new System.Drawing.Point(5, 58);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(160, 26);
            this.Btn_Close.TabIndex = 1;
            this.Btn_Close.Text = "Beenden";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Restart
            // 
            this.Btn_Restart.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Restart.Appearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Restart.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Restart.Appearance.ForeColor = System.Drawing.Color.White;
            this.Btn_Restart.Appearance.Options.UseBackColor = true;
            this.Btn_Restart.Appearance.Options.UseBorderColor = true;
            this.Btn_Restart.Appearance.Options.UseFont = true;
            this.Btn_Restart.Appearance.Options.UseForeColor = true;
            this.Btn_Restart.Appearance.Options.UseTextOptions = true;
            this.Btn_Restart.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_Restart.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_Restart.ImageOptions.Image = global::Lember.WerkMa.Properties.Resources.refresh_16x162;
            this.Btn_Restart.Location = new System.Drawing.Point(5, 26);
            this.Btn_Restart.Name = "Btn_Restart";
            this.Btn_Restart.Size = new System.Drawing.Size(160, 26);
            this.Btn_Restart.TabIndex = 0;
            this.Btn_Restart.Text = "Neu Starten";
            this.Btn_Restart.Click += new System.EventHandler(this.Btn_Restart_Click);
            // 
            // Te_ServerIp
            // 
            this.Te_ServerIp.Location = new System.Drawing.Point(5, 26);
            this.Te_ServerIp.Name = "Te_ServerIp";
            this.Te_ServerIp.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.Te_ServerIp.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_ServerIp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Te_ServerIp.Properties.Appearance.Options.UseBackColor = true;
            this.Te_ServerIp.Properties.Appearance.Options.UseFont = true;
            this.Te_ServerIp.Properties.Appearance.Options.UseForeColor = true;
            this.Te_ServerIp.Properties.Appearance.Options.UseTextOptions = true;
            this.Te_ServerIp.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_ServerIp.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_ServerIp.Properties.AppearanceFocused.Options.UseFont = true;
            this.Te_ServerIp.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.Te_ServerIp.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_ServerIp.Size = new System.Drawing.Size(229, 26);
            this.Te_ServerIp.TabIndex = 0;
            // 
            // Btn_Ping
            // 
            this.Btn_Ping.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_Ping.Appearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Ping.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Ping.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Btn_Ping.Appearance.Options.UseBackColor = true;
            this.Btn_Ping.Appearance.Options.UseBorderColor = true;
            this.Btn_Ping.Appearance.Options.UseFont = true;
            this.Btn_Ping.Appearance.Options.UseForeColor = true;
            this.Btn_Ping.Appearance.Options.UseTextOptions = true;
            this.Btn_Ping.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_Ping.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_Ping.ImageOptions.Image = global::Lember.WerkMa.Properties.Resources.stretch_16x161;
            this.Btn_Ping.Location = new System.Drawing.Point(240, 26);
            this.Btn_Ping.Name = "Btn_Ping";
            this.Btn_Ping.Size = new System.Drawing.Size(160, 26);
            this.Btn_Ping.TabIndex = 1;
            this.Btn_Ping.Text = "Ping";
            this.Btn_Ping.Click += new System.EventHandler(this.Btn_Ping_Click);
            // 
            // TeServer
            // 
            this.TeServer.Location = new System.Drawing.Point(114, 36);
            this.TeServer.MinimumSize = new System.Drawing.Size(0, 26);
            this.TeServer.Name = "TeServer";
            this.TeServer.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.TeServer.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TeServer.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TeServer.Properties.Appearance.Options.UseBackColor = true;
            this.TeServer.Properties.Appearance.Options.UseFont = true;
            this.TeServer.Properties.Appearance.Options.UseForeColor = true;
            this.TeServer.Properties.Appearance.Options.UseTextOptions = true;
            this.TeServer.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TeServer.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TeServer.Properties.AppearanceFocused.Options.UseFont = true;
            this.TeServer.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.TeServer.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TeServer.Size = new System.Drawing.Size(194, 26);
            this.TeServer.TabIndex = 0;
            // 
            // BtnStringBuild
            // 
            this.BtnStringBuild.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnStringBuild.Appearance.BorderColor = System.Drawing.Color.Black;
            this.BtnStringBuild.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.BtnStringBuild.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnStringBuild.Appearance.Options.UseBackColor = true;
            this.BtnStringBuild.Appearance.Options.UseBorderColor = true;
            this.BtnStringBuild.Appearance.Options.UseFont = true;
            this.BtnStringBuild.Appearance.Options.UseForeColor = true;
            this.BtnStringBuild.Appearance.Options.UseTextOptions = true;
            this.BtnStringBuild.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BtnStringBuild.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.BtnStringBuild.ImageOptions.Image = global::Lember.WerkMa.Properties.Resources.addnewdatasource_16x161;
            this.BtnStringBuild.Location = new System.Drawing.Point(114, 164);
            this.BtnStringBuild.Name = "BtnStringBuild";
            this.BtnStringBuild.Size = new System.Drawing.Size(194, 26);
            this.BtnStringBuild.TabIndex = 4;
            this.BtnStringBuild.Text = "String Erstellen";
            this.BtnStringBuild.Click += new System.EventHandler(this.BtnStringBuild_Click);
            // 
            // Te_Username
            // 
            this.Te_Username.Location = new System.Drawing.Point(114, 100);
            this.Te_Username.MinimumSize = new System.Drawing.Size(0, 26);
            this.Te_Username.Name = "Te_Username";
            this.Te_Username.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.Te_Username.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_Username.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Te_Username.Properties.Appearance.Options.UseBackColor = true;
            this.Te_Username.Properties.Appearance.Options.UseFont = true;
            this.Te_Username.Properties.Appearance.Options.UseForeColor = true;
            this.Te_Username.Properties.Appearance.Options.UseTextOptions = true;
            this.Te_Username.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_Username.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Te_Username.Properties.AppearanceFocused.Options.UseFont = true;
            this.Te_Username.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.Te_Username.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Te_Username.Size = new System.Drawing.Size(194, 26);
            this.Te_Username.TabIndex = 2;
            // 
            // TeDatabase
            // 
            this.TeDatabase.Location = new System.Drawing.Point(114, 68);
            this.TeDatabase.MinimumSize = new System.Drawing.Size(0, 26);
            this.TeDatabase.Name = "TeDatabase";
            this.TeDatabase.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.TeDatabase.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TeDatabase.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TeDatabase.Properties.Appearance.Options.UseBackColor = true;
            this.TeDatabase.Properties.Appearance.Options.UseFont = true;
            this.TeDatabase.Properties.Appearance.Options.UseForeColor = true;
            this.TeDatabase.Properties.Appearance.Options.UseTextOptions = true;
            this.TeDatabase.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TeDatabase.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TeDatabase.Properties.AppearanceFocused.Options.UseFont = true;
            this.TeDatabase.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.TeDatabase.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TeDatabase.Size = new System.Drawing.Size(194, 26);
            this.TeDatabase.TabIndex = 1;
            // 
            // Te_Password
            // 
            this.Te_Password.Location = new System.Drawing.Point(114, 132);
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
            // Frm_DatabaseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 615);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "Frm_DatabaseManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datenbank Manager";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Te_DecryptetConnectionString.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_ConnectionString.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_ServerIp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_Username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Te_Password.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit Te_ConnectionString;
        private DevExpress.XtraEditors.SimpleButton Btn_StringSave;
        private DevExpress.XtraEditors.SimpleButton Btn_StringRead;
        private DevExpress.XtraEditors.TextEdit Te_DecryptetConnectionString;
        private DevExpress.XtraEditors.TextEdit Te_Username;
        private DevExpress.XtraEditors.TextEdit TeDatabase;
        private DevExpress.XtraEditors.TextEdit TeServer;
        private DevExpress.XtraEditors.TextEdit Te_Password;
        private DevExpress.XtraEditors.LabelControl LblServer;
        private DevExpress.XtraEditors.LabelControl LblPassword;
        private DevExpress.XtraEditors.LabelControl LblBenutzer;
        private DevExpress.XtraEditors.LabelControl LblDatabase;
        private DevExpress.XtraEditors.SimpleButton BtnStringBuild;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnTestConnection;
        private DevExpress.XtraEditors.TextEdit Te_ServerIp;
        private DevExpress.XtraEditors.SimpleButton Btn_Ping;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton Btn_Restart;
        private DevExpress.XtraEditors.SimpleButton Btn_Close;
    }
}