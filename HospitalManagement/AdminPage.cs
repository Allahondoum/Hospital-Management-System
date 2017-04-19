using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using  System.Configuration;

namespace HospitalManagement
{
    public partial class AdminPage : MetroForm
    {
        private readonly string strcon = ConfigurationManager.ConnectionStrings["HMSConStr"].ToString();
        SqlConnection con = new SqlConnection();
        GlobalFunctions gf = new GlobalFunctions();
        
        public AdminPage()
        {
            InitializeComponent();
            AdminTimer.Start();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                
                con.ConnectionString = strcon;

                var cnn = new SqlConnection();
                cnn.ConnectionString = strcon;

                con.Open();
                cnn.Open();
                string insrtlg = "INSERT INTO LoginTB(Username,Password,Access_Level) VALUES(@usr,@pass,@role)";
                string insrtGenInfo = "INSERT INTO UserProfile(FirstName,LastName,DOB,Gender,Username,PhoneNumber,Email,Address,Title,AccessLevel,Department) VALUES(@FirstName,@LastName,@DOB,@Gender,@Username,@PhoneNumber,@Email,@Address,@Title,@AccessLevel,@Department)";


                SqlCommand cmd = new SqlCommand(insrtlg, con);
                SqlCommand cmd1 = new SqlCommand(insrtGenInfo, con);

                //Adding Login Infos
                cmd.Parameters.AddWithValue("@usr", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                cmd.Parameters.AddWithValue("@role", txtAccessLevel.SelectedItem);

                //Adding Registration Infos

                cmd1.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd1.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd1.Parameters.AddWithValue("@DOB", txtDateOfBirth.Text);
                cmd1.Parameters.AddWithValue("@Gender", txtGender.SelectedItem);
                cmd1.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd1.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                cmd1.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd1.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd1.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd1.Parameters.AddWithValue("@AccessLevel", txtAccessLevel.SelectedItem);
                cmd1.Parameters.AddWithValue("@Department", txtDepartment.SelectedItem);

                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                con.Close();
                cnn.Close();
                MessageBox.Show(this, "User successfully inserted into database. ", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAllTextBoxes(this);
                ClearAllComboBox(this);

            }
            catch (Exception ex)
            {
                lblExcep.Text = ex.Message;
            }



        }
        public void ClearAllTextBoxes(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    ClearAllTextBoxes(control);
                }
            }
        }
        public void ClearAllComboBox(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                //if (control == txtAccessLevel)
                //{
                //    continue;
                //}
                //else
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control.HasChildren)
                {
                    ClearAllComboBox(control);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this);
            ClearAllComboBox(this);
        }

        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            var lg = new Login();
            lg.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exist?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr == DialogResult.Yes)
            {
                this.Dispose();
                var lg = new Login();
                lg.Show();
            }
            else if (dr == DialogResult.No)
            {
               // dr == DialogResult.Cancel.Equals("Cancel");
            }
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalManagementDBDataSet.UserProfile' table. You can move, or remove it, as needed.
            this.userProfileTableAdapter.Fill(this.hospitalManagementDBDataSet.UserProfile);

            try
            {
                gf.GetActiveUser(lblActiveUser);
                gf.GetUserInfo(lblAdminFname, lblAdminFname, lblAdminAddress, lblAdminDOB, lblAdminPhone, lblAdminEmail, lblAdminTitle, lblAdminDepartement);
            }
            catch (Exception ex)
            {
                lblExcep.Text = ex.Message;
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = strcon;
                con.Open();
                var qry = "select * from UserProfile where FirstName like '%" + txtSearch.Text + "%' or LastName like '%" + txtSearch.Text + "%'";

                //var cmd = new SqlCommand(qry, conn);

                var sda = new SqlDataAdapter(qry, con);

                var dt = new DataTable();
                //var dr = cmd.ExecuteReader();

                sda.Fill(dt);
                // bs.DataSource = ds;
                userGridView.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                lblExcep.Text = ex.Message;
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //userGridView.DataSource = null;
            this.userProfileTableAdapter.Fill(this.hospitalManagementDBDataSet.UserProfile);
            //userGridView.Refresh();
            txtSearch.Text = String.Empty;
        }

        private void AdminTimer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblDateTime.Text = dt.ToString();
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            gf.ShowAccount();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
