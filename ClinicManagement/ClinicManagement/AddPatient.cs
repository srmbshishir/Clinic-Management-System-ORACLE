using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (txtPname.Text == "" || txtPage.Text == "" || txtSex.Text == "" || txtDoctorId.Text == "" || txtDate.Text == "" || txtOldpat.Text == "" || txtPaid.Text == "")
            {
                MessageBox.Show("Please fill up the full form");
            }
            else
            {
                string sql = "begin addpatient(PATIENT_ID.nextval, '" + this.txtPname.Text + "', '" + this.txtPage.Text + "', '" + this.txtSex.Text + "', " + this.txtDoctorId.Text + ", '" + this.txtDate.Text + "', '" + this.txtOldpat.Text + "','" + this.txtPaid.Text + "'); end; ";
                int row = da.UpdateExecuteQuery(sql);


                MessageBox.Show("inserted");
            }
        }
    }
}
