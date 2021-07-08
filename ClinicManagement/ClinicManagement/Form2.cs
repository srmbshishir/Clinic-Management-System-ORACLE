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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShowPatient_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            string sql = "select * from patient where doctorid="+this.label2.Text+" ";
            DataSet ds = da.ExecuteQuery(sql);
            this.dgvDocForm.AutoGenerateColumns = false;
            this.dgvDocForm.DataSource = ds.Tables[0];
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label2.Text = Form1.SetValue;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Visible = false;
        }
    }
}
