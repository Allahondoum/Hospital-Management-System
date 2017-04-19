namespace HospitalManagement
{
    partial class Cashier
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
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.lblActiveUser = new MetroFramework.Controls.MetroLabel();
            this.lblWelcome = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(24, 64);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
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
            this.metroTabPage2.Text = "Make Payment";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLogout.Highlight = true;
            this.btnLogout.Location = new System.Drawing.Point(1076, 38);
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
            this.lblActiveUser.Location = new System.Drawing.Point(889, 42);
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
            this.lblWelcome.Location = new System.Drawing.Point(819, 42);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(64, 19);
            this.lblWelcome.TabIndex = 12;
            this.lblWelcome.Text = "Welcome";
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 632);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblActiveUser);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroLabel lblActiveUser;
        private MetroFramework.Controls.MetroLabel lblWelcome;
    }
}