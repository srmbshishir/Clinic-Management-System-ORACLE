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
        public static string SetValue = "";
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
            Form2 f2 = new Form2();
            Form3 f3 = new Form3();
            Form4 f4 = new Form4();
            
            

            DataAccess da = new DataAccess();
            string sql = "select department from employee where id = " + this.txtUsername.Text + " and password = '" + this.txtPassword.Text + "'";

            DataSet ds = da.ExecuteQuery(sql);
            try
            {
                if (ds.Tables[0].Rows[0][0].ToString() == "doctor")
                {
                    SetValue = this.txtUsername.Text;
                    f2.Visible = true;
                    this.Visible = false;
                }
                else if (ds.Tables[0].Rows[0][0].ToString() == "admin")
                {
                    f4.Visible = true;
                    this.Visible = false;
                }
                else if (ds.Tables[0].Rows[0][0].ToString() == "receptionist")
                {
                    f3.Visible = true;
                    this.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("invalid input");    
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtUsername.Text = "";
            this.txtPassword.Text = "";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
