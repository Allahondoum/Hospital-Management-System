namespace HospitalManagement
{
    partial class Laboratory
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
            this.LabTabs = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.lblActiveUser = new MetroFramework.Controls.MetroLabel();
            this.lblWelcome = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.lblDateTime = new MetroFramework.Controls.MetroLabel();
            this.lblErrorMess = new MetroFramework.Controls.MetroLabel();
            this.LabTabs.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabTabs
            // 
            this.LabTabs.Controls.Add(this.metroTabPage1);
            this.LabTabs.Controls.Add(this.metroTabPage2);
            this.LabTabs.Controls.Add(this.metroTabPage3);
            this.LabTabs.Controls.Add(this.metroTabPage4);
            this.LabTabs.Location = new System.Drawing.Point(24, 61);
            this.LabTabs.Name = "LabTabs";
            this.LabTabs.SelectedIndex = 0;
            this.LabTabs.Size = new System.Drawing.Size(1127, 532);
            this.LabTabs.TabIndex = 0;
            this.LabTabs.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroPanel3);
            this.metroTabPage1.Controls.Add(this.metroPanel2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1119, 490);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Profile";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1119, 484);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Patient";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1119, 484);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Medical Test";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(1119, 484);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Operation";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLogout.Highlight = true;
            this.btnLogout.Location = new System.Drawing.Point(1072, 35);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.Style = MetroFramework.MetroColorStyle.Red;
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.UseStyleColors = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblActiveUser
            // 
            this.lblActiveUser.AutoSize = true;
            this.lblActiveUser.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblActiveUser.Location = new System.Drawing.Point(886, 39);
            this.lblActiveUser.Name = "lblActiveUser";
            this.lblActiveUser.Size = new System.Drawing.Size(71, 19);
            this.lblActiveUser.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblActiveUser.TabIndex = 13;
            this.lblActiveUser.Text = "Username";
            this.lblActiveUser.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblActiveUser.UseStyleColors = true;
            this.lblActiveUser.Visible = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblWelcome.Location = new System.Drawing.Point(816, 39);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(64, 19);
            this.lblWelcome.TabIndex = 12;
            this.lblWelcome.Text = "Welcome";
            // 
            // metroPanel3
            // 
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(573, 8);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(542, 479);
            this.metroPanel3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroPanel3.TabIndex = 5;
            this.metroPanel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.UseStyleColors = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 8);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(557, 479);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroPanel2.TabIndex = 4;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseStyleColors = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDateTime.Location = new System.Drawing.Point(979, 596);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(67, 19);
            this.lblDateTime.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDateTime.TabIndex = 16;
            this.lblDateTime.Text = "DateTime";
            this.lblDateTime.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDateTime.UseStyleColors = true;
            // 
            // lblErrorMess
            // 
            this.lblErrorMess.AutoSize = true;
            this.lblErrorMess.Location = new System.Drawing.Point(28, 596);
            this.lblErrorMess.Name = "lblErrorMess";
            this.lblErrorMess.Size = new System.Drawing.Size(60, 19);
            this.lblErrorMess.Style = MetroFramework.MetroColorStyle.Red;
            this.lblErrorMess.TabIndex = 15;
            this.lblErrorMess.Text = "Message";
            this.lblErrorMess.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblErrorMess.UseStyleColors = true;
            // 
            // Laboratory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 630);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblErrorMess);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblActiveUser);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.LabTabs);
            this.Name = "Laboratory";
            this.Text = "Laboratory";
            this.LabTabs.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl LabTabs;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroLabel lblActiveUser;
        private MetroFramework.Controls.MetroLabel lblWelcome;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel lblDateTime;
        private MetroFramework.Controls.MetroLabel lblErrorMess;
    }
}