using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using DbConnection = TelcoSystemCore.Common.DbConnection;

namespace TelcoSystemCore.Infrastructure
{
    public interface ICusAccountDNDAO
    {

        int Save(CusAccountDN cusAccountDN, DbConnection dbConnection);
        int Update(CusAccountDN cusAccountDN, DbConnection dbConnection);
        int Delete(CusAccountDN cusAccountDN, DbConnection dbConnection);
        List<CusAccountDN> GetCusAccountDNs(DbConnection dbConnection);


    }

    public class CusAccountDNSqlDAOImpl : ICusAccountDNDAO
    {
        public List<CusAccountDN> GetCusAccountDNs(DbConnection dbConnection)
        {
            List<CusAccountDN> ListCusAccDN = new List<CusAccountDN>();

            

            dbConnection.cmd.CommandText = "select * from ";
            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            ListCusAccDN = dataAccessObject.ReadCollection<CusAccountDN>(dbConnection.dr);
            dbConnection.dr.Close();

            return ListCusAccDN;
        }

        public int Save(CusAccountDN cusAccountDN, DbConnection dbConnection)
        {

            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = " ";


            //dbConnection.cmd.Parameters.AddWithValue("@ID", customer.CustomerId);

            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            return output;

        }

        public int Update(CusAccountDN cusAccountDN, DbConnection dbConnection)
        {

            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = " ";


            //dbConnection.cmd.Parameters.AddWithValue("@ID", customer.CustomerId);

            output = dbConnection.cmd.ExecuteNonQuery();

            return output;

        }

        public int Delete(CusAccountDN cusAccountDN, DbConnection dbConnection)
        {
            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = " ";


            //dbConnection.cmd.Parameters.AddWithValue("@ID", customer.CustomerId);

            output = dbConnection.cmd.ExecuteNonQuery();

            return output;


        }


    }



}
