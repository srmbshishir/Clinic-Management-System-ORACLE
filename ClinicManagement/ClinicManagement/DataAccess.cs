using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace ClinicManagement
{
    class DataAccess
    {
        private OracleConnection oracon;
        public OracleConnection Oracon
        {
            get { return this.oracon; }
            set { this.oracon = value; }
        }

        private OracleCommand oracom;
        public OracleCommand Oracom
        {
            get { return this.oracom; }
            set { this.oracom = value; }
        }
        private OracleDataAdapter oda;
        public OracleDataAdapter Oda
        {
            get { return this.oda; }
            set { this.oda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }
        public DataAccess()
        {
            this.Oracon = new OracleConnection(@"DATA SOURCE = localhost:1521 / orcl; USER ID =C##SCOTT; PASSWORD =tiger;");
            this.Oracon.Open();
        }

        private void QueryText(string query)
        {
            this.Oracom = new OracleCommand(query, this.Oracon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            try
            {
                this.QueryText(sql);
                this.Oda = new OracleDataAdapter(this.Oracom);
                this.Ds = new DataSet();
                this.Oda.Fill(this.Ds);
                return this.Ds;
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        public int UpdateExecuteQuery(string sql)
        {
            this.QueryText(sql);
            int u = this.Oracom.ExecuteNonQuery();
            return u;
        }

    }

}
