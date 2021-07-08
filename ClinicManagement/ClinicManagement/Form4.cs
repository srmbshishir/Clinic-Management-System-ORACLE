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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Visible = false;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddForm a1 = new AddForm();
            a1.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            if (this.txtId.Text == "" || this.txtNam.Text == "" || this.txtAddress.Text == "" || this.txtSal.Text == "" || this.txtPas.Text == "" || this.cmbDept.Text=="" || this.txtHrdate.Text == "")
            {
                MessageBox.Show("Please fill up the full form");
            }
            else
            {
                string sql = "begin editemployee(" + this.txtId.Text + ", '" + this.txtNam.Text + "', '" + this.cmbDept.Text + "', '" + this.txtAddress.Text + "', " + this.txtSal.Text + ", '" + this.txtHrdate.Text + "', '" + this.txtPas.Text + "'); end; "; 
                int row = da.UpdateExecuteQuery(sql);


                MessageBox.Show("edited");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            string sql = "select * from employee";
            DataSet ds = da.ExecuteQuery(sql);
            this.dgvShow.AutoGenerateColumns = false;
            this.dgvShow.DataSource = ds.Tables[0];


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.dataSet1.EMPLOYEE);

        }

        private void dgvShow_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = this.dgvShow.CurrentRow.Cells[0].Value.ToString();
            this.txtNam.Text = this.dgvShow.CurrentRow.Cells[1].Value.ToString();
            this.txtAddress.Text = this.dgvShow.CurrentRow.Cells[3].Value.ToString();
            this.txtSal.Text = this.dgvShow.CurrentRow.Cells[4].Value.ToString();
            this.txtHrdate.Text = this.dgvShow.CurrentRow.Cells[5].Value.ToString();
            this.cmbDept.Text = this.dgvShow.CurrentRow.Cells[2].Value.ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            string id = this.dgvShow.CurrentRow.Cells[0].Value.ToString();
            string name = this.dgvShow.CurrentRow.Cells[1].Value.ToString();
            string sql = "begin deleteemployee("+id+"); end; ";
            int row = da.UpdateExecuteQuery(sql);

            MessageBox.Show("Employee " + name + " has been deleted");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            string sql = "select * from employee where id ="+this.txtSearch.Text+"";
            DataSet ds = da.ExecuteQuery(sql);
            this.dgvShow.AutoGenerateColumns = false;
            this.dgvShow.DataSource = ds.Tables[0];
        }
    }
}
