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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPatient a2 = new AddPatient();
            a2.Visible = true;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            string sql = "select * from patient";
            DataSet ds = da.ExecuteQuery(sql);
            this.dgvPatient.AutoGenerateColumns = false;
            this.dgvPatient.DataSource = ds.Tables[0];
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (txtId.Text == "" || txtName.Text == "" || txtGender.Text == "" || txtAge.Text == "" || txtDocId.Text == "" || txtCheckdate.Text == "" || txtOldpat.Text == "" || txtPaid.Text == "")
            {
                MessageBox.Show("Please fill up the full form");
            }
            else
            {
                string sql = "begin editpatient(" + this.txtId.Text + ", '" + this.txtName.Text + "', '" + this.txtAge.Text + "', '" + this.txtGender.Text + "', " + this.txtDocId.Text + ", '" + this.txtCheckdate.Text + "', '" + this.txtOldpat.Text + "','" + this.txtPaid.Text + "'); end; ";
                int row = da.UpdateExecuteQuery(sql);


                MessageBox.Show("edited");
            }
        }

        private void dgvPatient_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = this.dgvPatient.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dgvPatient.CurrentRow.Cells[1].Value.ToString();
            this.txtAge.Text = this.dgvPatient.CurrentRow.Cells[2].Value.ToString();
            this.txtGender.Text = this.dgvPatient.CurrentRow.Cells[3].Value.ToString();
            this.txtDocId.Text = this.dgvPatient.CurrentRow.Cells[7].Value.ToString();
            this.txtCheckdate.Text = this.dgvPatient.CurrentRow.Cells[4].Value.ToString();
            this.txtOldpat.Text = this.dgvPatient.CurrentRow.Cells[5].Value.ToString();
            this.txtPaid.Text = this.dgvPatient.CurrentRow.Cells[6].Value.ToString();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Visible = false;
        }

        private void btnSearchPat_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = "select * from patient where pid =" + this.txtSeachPat.Text + " ";
                DataSet ds = da.ExecuteQuery(sql);
                this.dgvPatient.AutoGenerateColumns = false;
                this.dgvPatient.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("No Patient found");
            }
        }

        private void btndoclist_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            string sql = "select * from doctor";
            DataSet ds = da.ExecuteQuery(sql);
            this.dgvDoctor.AutoGenerateColumns = false;
            this.dgvDoctor.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = "select * from doctor where " + this.txtdocavailable.Text + " is not null and speciality like '"+this.txtSpeciality.Text+"%' ";
                DataSet ds = da.ExecuteQuery(sql);
                this.dgvDoctor.AutoGenerateColumns = false;
                this.dgvDoctor.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("No doctor found or you didn't enter all fields");
            }
        }

        private void btnEditPatient_Click_1(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (txtId.Text == "" || txtName.Text == "" || txtGender.Text == "" || txtAge.Text == "" || txtDocId.Text == "" || txtCheckdate.Text == "" || txtOldpat.Text == "" || txtPaid.Text == "")
            {
                MessageBox.Show("Please fill up the full form");
            }
            else
            {
                string sql = "begin editpatient(" + this.txtId.Text + ", '" + this.txtName.Text + "', '" + this.txtAge.Text + "', '" + this.txtGender.Text + "', " + this.txtDocId.Text + ", '" + this.txtCheckdate.Text + "', '" + this.txtOldpat.Text + "','" + this.txtPaid.Text + "'); end; ";
                int row = da.UpdateExecuteQuery(sql);


                MessageBox.Show("edited");
            }
        }
    }
}
