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
using System.Data.Sql;
using System.Data.SqlClient;
namespace ClinicManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
/*
        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection oracon = new OracleConnection(@"DATA SOURCE = localhost:1521 / orcl; USER ID =C##SCOTT; PASSWORD =tiger;");
            oracon.Open();
            OracleCommand oracom = new OracleCommand("select * from emp", oracon);
            OracleDataAdapter oda = new OracleDataAdapter(oracom);
            DataSet ds = new DataSet();
            oda.Fill(ds);

            this.lblinfo.Text = ds.Tables[0].Rows[0][0].ToString();
            oracon.Close();
                
        }
*/
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            string sql = "select * from employee where id=" + this.txtUsername.Text + " and password='" + this.txtPassword.Text + "'";
            DataSet ds = da.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Login Valid");
            }
            else
            {
                MessageBox.Show("Invalid");
            }




            /* OracleConnection oracon = new OracleConnection(@"DATA SOURCE = localhost:1521 / orcl; USER ID =C##SCOTT; PASSWORD =tiger;");
            oracon.Open();
            OracleCommand oracom = new OracleCommand("select * from employee where id="+ this.txtUsername.Text + " and password='"+this.txtPassword.Text+"'", oracon);
            OracleDataAdapter oda = new OracleDataAdapter(oracom);
            DataSet ds = new DataSet();
            oda.Fill(ds);

            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("valid");
            }
            else
            {
                MessageBox.Show("invalid");
            }
            oracon.Close();
        */
        }
    }
}
