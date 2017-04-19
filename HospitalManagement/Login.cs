using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace HospitalManagement
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }
        public static class  GlobalUname
        {
            private static string _activeUname;

            public static string GlobalVar
            {
                get { return _activeUname; }
                set { _activeUname = value; }
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == String.Empty)
            {
                ErrorCheckTextBox.SetError(txtUsername, "username field is required!!");
            }
            else if (txtPassword.Text == String.Empty)
            {
                ErrorCheckTextBox.SetError(txtPassword, "password field is required!!");
            }
            else
            {
                try
                {
                    var strcon = ConfigurationManager.ConnectionStrings["HMSConStr"].ToString();
                    var con = new SqlConnection();
                    con.ConnectionString = strcon;
                    
                    var qry = "select * from LoginTB where Username ='"+txtUsername.Text+"' and Password = '"+txtPassword.Text+"'";
                    var cmd = new SqlCommand(qry, con);
                    con.Open();

                    var dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        GlobalUname.GlobalVar = txtUsername.Text;
                        while (dr.Read())
                        {
                            ReadLogData(dr);
                        }
                       
                    }
                    else
                    {
                        lblErrorLoginFailed.Text = "Wrong username or Password!!";
                        lblErrorLoginFailed.Visible = true;
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    lblError.Text = ex.Message;
                    lblError.Visible = true;
                }
               
            }
        }

        private void ReadLogData(SqlDataReader dr)
        {
            
            if ((string)dr["Access_Level"] == "Admin")
            {

                var adm = new AdminPage();
                txtUsername.Text = String.Empty;
                txtPassword.Text = String.Empty;
                txtUsername.Focus();
                //GlobalUname.GlobalVar = (string) dr["Access_Level"];
                adm.Show();
                this.Hide();
            }
            else if ((string)dr["Access_Level"] == "Doctor")
            {
                var dp = new DoctorPage();
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtUsername.Focus();
                dp.Show();
                this.Hide();
            }
            else if ((string)dr["Access_Level"] == "Manager")
            {

            }
            else if ((string)dr["Access_Level"] == "Nurse")
            {

            }
            else if ((string)dr["Access_Level"] == "Assistant")
            {
                var hm = new Home();
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtUsername.Focus();
                hm.Show();
                this.Hide();
            }
        }

        //Admin
        //Manager
        //Doctor
        //Nurse
        //Assistant

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
           DialogResult dr = MessageBox.Show("Do you want to exist?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
            else if(dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var ab = new AboutApp();
            ab.ShowDialog();
        }
    }
}
