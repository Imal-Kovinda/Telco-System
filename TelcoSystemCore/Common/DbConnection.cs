using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelcoSystemCore.Common
{
    public class DbConnection
    {

        [NonSerialized]
        public OdbcConnection con;
        [NonSerialized]
        public OdbcCommand cmd;
        [NonSerialized]
        public OdbcTransaction tr;
        [NonSerialized]
        public OdbcDataReader dr;

        //public SqlConnection con;
        //public SqlCommand cmd;
        //public SqlTransaction tr;
        //public SqlDataReader dr;


        public DbConnection()
        {
            con = new OdbcConnection("Dsn=PostgreSQL30;uid=postgres;PWD=1234");
            cmd = new OdbcCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                con.Open();
                tr = con.BeginTransaction();
                cmd.Transaction = tr;

            }
            catch (Exception)
            {

                throw;
            }

            //
            // TODO: Add constructor logic here
            //
        }

        public void Commit()
        {
            this.cmd.Dispose();
            if (this.dr != null)
                this.dr.Close();
            tr.Commit();
            this.con.Close();
        }
        public void RollBack()
        {
            this.tr.Rollback();
            if (this.dr != null)
                this.dr.Close();
            this.cmd.Dispose();
            this.con.Close();
        }
    }
}
