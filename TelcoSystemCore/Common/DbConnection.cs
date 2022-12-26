using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelcoSystemCore.Common
{
    public class DbConnection
    {

        public SqlConnection con;
        public SqlCommand cmd;
        public SqlTransaction tr;
        public SqlDataReader dr;


        public DbConnection()
        {
            //con = new SqlConnection("Data Source=10.2.5.72;Initial Catalog=Student;User ID=sa;Password=Bell123");
            con = new SqlConnection("Dsn=telcoSystem;Data Source=10.12.14.75;UID=postgres; PWD=1234");
            
            cmd = new SqlCommand();
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
