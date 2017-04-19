namespace HospitalManagement
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.metroStyleManagerLogin = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.btnAbout = new MetroFramework.Controls.MetroButton();
            this.lblTitle = new MetroFramework.Controls.MetroLabel();
            this.lblError = new MetroFramework.Controls.MetroLabel();
            this.ErrorCheckTextBox = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.lblErrorLoginFailed = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCheckTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManagerLogin
            // 
            this.metroStyleManagerLogin.Owner = null;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUsername.Location = new System.Drawing.Point(162, 90);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 19);
            this.lblUsername.Style = MetroFramework.MetroColorStyle.Black;
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(164, 261);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(204, 31);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPassword.Location = new System.Drawing.Point(160, 163);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 19);
            this.lblPassword.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(483, 318);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(50, 25);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About";
            this.btnAbout.UseSelectable = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTitle.Location = new System.Drawing.Point(149, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 25);
            this.lblTitle.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "HOSPITAL MANAGEMENT";
            this.lblTitle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblTitle.UseStyleColors = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(13, 304);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 19);
            this.lblError.Style = MetroFramework.MetroColorStyle.Red;
            this.lblError.TabIndex = 7;
            this.lblError.Text = "error";
            this.lblError.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblError.UseCustomForeColor = true;
            this.lblError.UseStyleColors = true;
            this.lblError.Visible = false;
            // 
            // ErrorCheckTextBox
            // 
            this.ErrorCheckTextBox.ContainerControl = this;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassword.Icon = global::HospitalManagement.Properties.Resources.edit;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(164, 194);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(204, 29);
            this.txtPassword.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.UseCustomBackColor = true;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseStyleColors = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.DisplayIcon = true;
            this.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUsername.Icon = global::HospitalManagement.Properties.Resources.edit;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(164, 120);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PromptText = "Username";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(204, 29);
            this.txtUsername.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.UseCustomBackColor = true;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.UseStyleColors = true;
            this.txtUsername.WaterMark = "Username";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblErrorLoginFailed
            // 
            this.lblErrorLoginFailed.AutoSize = true;
            this.lblErrorLoginFailed.ForeColor = System.Drawing.Color.Red;
            this.lblErrorLoginFailed.Location = new System.Drawing.Point(164, 236);
            this.lblErrorLoginFailed.Name = "lblErrorLoginFailed";
            this.lblErrorLoginFailed.Size = new System.Drawing.Size(39, 19);
            this.lblErrorLoginFailed.Style = MetroFramework.MetroColorStyle.Red;
            this.lblErrorLoginFailed.TabIndex = 8;
            this.lblErrorLoginFailed.Text = "error";
            this.lblErrorLoginFailed.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblErrorLoginFailed.UseCustomForeColor = true;
            this.lblErrorLoginFailed.UseStyleColors = true;
            this.lblErrorLoginFailed.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 343);
            this.Controls.Add(this.lblErrorLoginFailed);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(533, 343);
            this.MinimumSize = new System.Drawing.Size(533, 343);
            this.Name = "Login";
            this.Resizable = false;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCheckTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManagerLogin;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroButton btnAbout;
        private MetroFramework.Controls.MetroLabel lblTitle;
        private MetroFramework.Controls.MetroLabel lblError;
        private System.Windows.Forms.ErrorProvider ErrorCheckTextBox;
        private MetroFramework.Controls.MetroLabel lblErrorLoginFailed;
    }
}