using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace HospitalManagement
{
    public partial class Cashier : MetroForm
    {
        public Cashier()
        {
            InitializeComponent();
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
    }
}
