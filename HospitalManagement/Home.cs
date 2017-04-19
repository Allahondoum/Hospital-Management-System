using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace HospitalManagement
{
    public partial class Home : MetroForm
    {
        private readonly string constr = ConfigurationManager.ConnectionStrings["HMSConStr"].ToString();
        private SqlConnection conn;
        GlobalFunctions gf = new GlobalFunctions();

        public Home()
        {
            InitializeComponent();
            MyTimer.Start();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var lg = new Login();
            lg.Show();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            var lg = new Login();
            lg.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                
                conn = new SqlConnection();

                conn.ConnectionString = constr;
                conn.Open();
               
                var qry = "select * from InPatientReg where Fname like '%" + txtSearch.Text + "%' or Lname ='%" + txtSearch.Text + "%'";

               
                
                var sda = new SqlDataAdapter(qry,conn);

                var dt = new DataTable();
                

                sda.Fill(dt);
               // bs.DataSource = ds;
                ViewPatientGridView.DataSource = dt;
                ViewPatientGridView.Visible = true;
                //ViewPatientGridView.DataBindings
             
                conn.Close();


            }
            catch (Exception ex)
            {
                lblErrorMess.Text = ex.Message;
               
            }


        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalManagementDBDataSetSearch.UserProfile' table. You can move, or remove it, as needed.
            this.userProfileTableAdapter.Fill(this.hospitalManagementDBDataSetSearch.UserProfile);
            // TODO: This line of code loads data into the 'hospitalManagementDBDataSetSearch.UserProfile' table. You can move, or remove it, as needed.
            this.userProfileTableAdapter.Fill(this.hospitalManagementDBDataSetSearch.UserProfile);
            //lblActiveUser.Text = Login.GlobalUname.GlobalVar;
            HomeTabPage1.Focus();
            try
            {
                gf.GetActiveUser(lblActiveUser);
                gf.GetUserInfo(lblAssistFname, lblAssistLname, lblAssistAddress, lblAssistDOB, lblAssistPhone, lblAssistEmail, lblAssistTitle, lblAssistDepartement);
            }
            catch (Exception ex)
            {
                lblErrorMess.Text = ex.Message;
            }

            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection {ConnectionString = constr};



                conn.Open();
               // string insrtlg = "INSERT INTO LoginTB(Username,Password,Access_Level) VALUES(@usr,@pass,@role)";
                string insrtInPat = "INSERT INTO InPatientReg(Fname,Lname,Birth,Gender,Phone,Address,Occupation,MaritalStatus,Age,Status,AdmissionDate,Symptoms,Departement,AssignedDoc,WardNo,BedNo) VALUES(@FirstName,@LastName,@DOB,@Gender,@PhoneNumber,@Address,@Occupation,@Mstatus,@Age,@Status,@AdminDate,@Sympt,@Dept,@Doc,@WNo,@BNo)";


                SqlCommand cmd1 = new SqlCommand(insrtInPat, conn);

                //Adding Registration Infos

                cmd1.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd1.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd1.Parameters.AddWithValue("@DOB", txtDateOfBirth.Text);
                cmd1.Parameters.AddWithValue("@Gender", txtGender.SelectedItem);
                cmd1.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                cmd1.Parameters.AddWithValue("@Address", txtAddress.Text);
                
                cmd1.Parameters.AddWithValue("@Occupation", txtOccupation.Text);
                cmd1.Parameters.AddWithValue("@Mstatus", txtMaritalStatus.SelectedItem);
                cmd1.Parameters.AddWithValue("@Age", txtAge.Text);
                cmd1.Parameters.AddWithValue("@Status", txtStatus.SelectedItem);
                cmd1.Parameters.AddWithValue("@AdminDate", lblCurrentDateTime.Text);
                cmd1.Parameters.AddWithValue("@Sympt", txtSymptoms.Text);
                cmd1.Parameters.AddWithValue("@Dept", txtDepartment.SelectedItem);
                cmd1.Parameters.AddWithValue("@Doc", txtAssignDoctor.Text);
                cmd1.Parameters.AddWithValue("@WNo", txtWardNo.SelectedItem);
                cmd1.Parameters.AddWithValue("@BNo", txtBedNumber.Value);

                cmd1.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(this, "User successfully inserted into database. ", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
               var am = new AdminPage();
                am.ClearAllTextBoxes(this);

            }
            catch (Exception ex)
            {
                lblErrorMess.Text = ex.Message;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblCurrentDateTime.Text = dt.ToString();
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userProfileTableAdapter.FillBy(this.hospitalManagementDBDataSetSearch.UserProfile);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userProfileTableAdapter.Fill(this.hospitalManagementDBDataSetSearch.UserProfile);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            var us = new GlobalFunctions();
            us.ShowAccount();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            txtAssistFname.Text = lblAssistFname.Text;
            txtAssistLname.Text = lblAssistLname.Text;
            txtAssistDOB.Text = lblAssistDOB.Text;
            txtAssistAddress.Text = lblAssistAddress.Text;
            txtAssistPhone.Text = lblAssistPhone.Text;
            txtAssistEmail.Text = lblAssistEmail.Text;
            txtAssistTitle.Text = lblAssistTitle.Text;
            txtAssistDept.Text = lblAssistDepartement.Text;


            //EnableTextBoxes(this, true);
            //txtAssistFname.Enabled = true;
            //txtAssistLname.Enabled = true;
            btnUpdate.Enabled = true;
            btnCancelUpdate.Enabled = true;
        }
    }
}
