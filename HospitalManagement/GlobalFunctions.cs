using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace HospitalManagement
{
    public class GlobalFunctions
    {
        private readonly string constr = ConfigurationManager.ConnectionStrings["HMSConStr"].ToString();
        private SqlConnection conn;


        string uname = Login.GlobalUname.GlobalVar;

        public void ShowAccount()
        {
            var ac = new AccountSettings { lblUname = { Text = uname } };
            ac.ShowDialog();
        }
        public void GetActiveUser(Label actuname)
        {

            conn = new SqlConnection { ConnectionString = constr };

            var qry = "select FirstName, Lastname from UserProfile where Username ='" + uname +
                      "'";
            conn.Open();
            var cmd = new SqlCommand(qry, conn);

            var dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {


                    actuname.Text = (string)dr["FirstName"] + " " + (string)dr["LastName"];
                    actuname.Visible = true;

                }

            }
            conn.Close();
        }

        //Get user informations from the DB
        public void GetUserInfo(Control txt1,Control txt2, Control txt3, Control txt4, Control txt5, Control txt6,Control txt7,Control txt8)
        {
            

            conn = new SqlConnection { ConnectionString = constr };

            conn.Open();

            var qry = "select * from UserProfile where Username = '" + uname + "'";



            var cmd = new SqlCommand(qry, conn);
            var dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {


                    txt1.Text = (string)dr["FirstName"];
                    txt2.Text = (string)dr["LastName"];
                    txt3.Text = (string)dr["Address"];
                    txt4.Text = (string)dr["DOB"];
                    txt5.Text = (string)dr["PhoneNumber"];
                    txt6.Text = (string)dr["Email"];
                    txt7.Text = (string)dr["Title"];
                    txt8.Text = (string)dr["Department"];


                }
            }

        }

    }
}
