namespace HospitalManagement
{
    partial class Pharmacy
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.lblActiveUser = new MetroFramework.Controls.MetroLabel();
            this.lblWelcome = new MetroFramework.Controls.MetroLabel();
            this.lblDateTime = new MetroFramework.Controls.MetroLabel();
            this.lblErrorMess = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(24, 64);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(1127, 531);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1119, 489);
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
            this.metroTabPage2.Size = new System.Drawing.Size(1119, 489);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Buy Medecine";
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
            this.metroTabPage3.Size = new System.Drawing.Size(1119, 489);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "View Medecines";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLogout.Highlight = true;
            this.btnLogout.Location = new System.Drawing.Point(1072, 38);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.Style = MetroFramework.MetroColorStyle.Red;
            this.btnLogout.TabIndex = 17;
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
            this.lblActiveUser.Location = new System.Drawing.Point(884, 42);
            this.lblActiveUser.Name = "lblActiveUser";
            this.lblActiveUser.Size = new System.Drawing.Size(71, 19);
            this.lblActiveUser.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblActiveUser.TabIndex = 16;
            this.lblActiveUser.Text = "Username";
            this.lblActiveUser.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblActiveUser.UseStyleColors = true;
            this.lblActiveUser.Visible = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblWelcome.Location = new System.Drawing.Point(814, 42);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(64, 19);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDateTime.Location = new System.Drawing.Point(995, 598);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(67, 19);
            this.lblDateTime.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDateTime.TabIndex = 19;
            this.lblDateTime.Text = "DateTime";
            this.lblDateTime.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDateTime.UseStyleColors = true;
            // 
            // lblErrorMess
            // 
            this.lblErrorMess.AutoSize = true;
            this.lblErrorMess.Location = new System.Drawing.Point(28, 598);
            this.lblErrorMess.Name = "lblErrorMess";
            this.lblErrorMess.Size = new System.Drawing.Size(60, 19);
            this.lblErrorMess.Style = MetroFramework.MetroColorStyle.Red;
            this.lblErrorMess.TabIndex = 18;
            this.lblErrorMess.Text = "Message";
            this.lblErrorMess.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblErrorMess.UseStyleColors = true;
            // 
            // Pharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 630);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblErrorMess);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblActiveUser);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Pharmacy";
            this.Text = "Pharmacy";
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroLabel lblActiveUser;
        private MetroFramework.Controls.MetroLabel lblWelcome;
        private MetroFramework.Controls.MetroLabel lblDateTime;
        private MetroFramework.Controls.MetroLabel lblErrorMess;
    }
}