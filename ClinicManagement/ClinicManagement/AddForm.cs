using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ClinicManagement
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (txtName.Text == "" || txtAddress.Text == "" || txtSalary.Text == "" || txtPass.Text == "" || cmbDept.SelectedItem.ToString().Equals("") || txtDate.Text == "")
            {
                MessageBox.Show("Please fill up the full form");
            }
            else
            {
                string sql = "begin addemployee(employee_id.nextval, '" + this.txtName.Text + "', '" + this.cmbDept.Text + "', '" + this.txtAddress.Text + "', " + this.txtSalary.Text + ", '" + this.txtDate.Text + "', '" + this.txtPass.Text + "'); end; ";
                int row = da.UpdateExecuteQuery(sql);


                MessageBox.Show("inserted");

            }
        }
    }
}
    


