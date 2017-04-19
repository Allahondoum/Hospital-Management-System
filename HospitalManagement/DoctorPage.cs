using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace HospitalManagement
{
    public partial class DoctorPage : MetroForm
    {
        private readonly string constr = ConfigurationManager.ConnectionStrings["HMSConStr"].ToString();
        private SqlConnection conn;
        string uname = Login.GlobalUname.GlobalVar;
        GlobalFunctions gf = new GlobalFunctions();

        public DoctorPage()
        {
            InitializeComponent();

        }

        private void DoctorPage_Load(object sender, EventArgs e)
        {
            try
            {
                gf.GetActiveUser(lblActiveUser);
                gf.GetUserInfo(lblDocFname,lblDocFname,lblDocAddress,lblDocDOB,lblDocPhone,lblDocEmail,lblDocTitle,lblDocDepartement);
                GetDocPatient();

            }
            catch (Exception ex)
            {
                lblErrorMess.Text = ex.Message;
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exist?", "Information", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
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

        private void GetDocPatient()
        {
            conn = new SqlConnection {ConnectionString = constr};

            conn.Open();

            var qry = "select * from InPatientReg where AssignedDoc = '" + lblActiveUser.Text + "'";



            var sda = new SqlDataAdapter(qry, conn);

            var dt = new DataTable();


            sda.Fill(dt);
            // bs.DataSource = ds;
            docPatGridView.DataSource = dt;
            docPatGridView.Visible = true;
            //ViewPatientGridView.DataBindings

            conn.Close();
        }

        private void DoctorPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exist?", "Information", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
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

        private void txtSearchPat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchInPat.Text == String.Empty)
                {
                    errorProvider1.SetError(txtSearchInPat, "Requierd field. Cannot be left blank");
                }
                else
                {
                    conn = new SqlConnection {ConnectionString = constr};

                    conn.Open();

                    var qry = "select * from InPatientReg where Fname like '%" + txtSearchInPat.Text + "%' or Lname like'%" +
                              txtSearchInPat.Text + "%'";


                    var sda = new SqlDataAdapter(qry, conn);

                    var dt = new DataTable();


                    sda.Fill(dt);
                    docPatGridView.DataSource = dt;
                    docPatGridView.Visible = true;

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                lblErrorMess.Text = ex.Message;

            }
        }

        private void docPatGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            GetActiveRow(docPatGridView, e);
        }

        private void docPatGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetActiveRow(docPatGridView, e);
        }

        private void docPatGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GetActiveRow(docPatGridView, e);
        }

        private void GetActiveRow(DataGridView gr1, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;

            var dgr = gr1.Rows[row];

            lblPatFname.Text = dgr.Cells[1].Value.ToString();
            lblPatLname.Text = dgr.Cells[2].Value.ToString();
            lblPatGender.Text = dgr.Cells[4].Value.ToString();
            lblPatOccup.Text = dgr.Cells[7].Value.ToString();
            lblPatAge.Text = dgr.Cells[9].Value.ToString();
            lblPatStatus.Text = dgr.Cells[10].Value.ToString();
            richPatTxtSymptoms.Text = dgr.Cells[12].Value.ToString();
            //return gr1;
        }



        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            
            
            txtDocFname.Text = lblDocFname.Text;
            txtDocLname.Text = lblDocLname.Text;
            txtDocDOB.Text = lblDocDOB.Text;
            txtDocAddress.Text = lblDocAddress.Text;
            txtDocPhone.Text = lblDocPhone.Text;
            txtDocEmail.Text = lblDocEmail.Text;
            txtDocTitle.Text = lblDocTitle.Text;
            txtDocDept.Text = lblDocDepartement.Text;


            EnableTextBoxes(this,true);
            //txtDocFname.Enabled = true;
            //txtDocLname.Enabled = true;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
        }
        public void EnableTextBoxes(Control ctrls, bool chk)
        {
            foreach (Control control in ctrls.Controls)
            {
                var box = control as TextBox;
                if (box != null)
                {
                    box.Enabled = chk;
                }
                if (control.HasChildren)
                {
                  EnableTextBoxes(control,chk);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var am = new AdminPage();
            am.ClearAllTextBoxes(this);
            EnableTextBoxes(this,false);
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            gf.ShowAccount();
        }
    }
}
