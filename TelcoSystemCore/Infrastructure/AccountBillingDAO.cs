using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using DbConnection = TelcoSystemCore.Common.DbConnection;

namespace TelcoSystemCore.Infrastructure
{
    public interface IAccountBillingDAO
    {
        int Save(AccountBilling accountBilling, DbConnection dbConnection);
        int Update(AccountBilling accountBilling, DbConnection dbConnection);
        int Delete(AccountBilling accountBilling, DbConnection dbConnection);
        List<AccountBilling> GetAccountBillList(DbConnection dbConnection);

    }

    public class AccountBillingSqlDAOImpl : IAccountBillingDAO
    {
        public List<AccountBilling> GetAccountBillList(DbConnection dbConnection)
        {
            List<AccountBilling> ListAccountBill = new List<AccountBilling>();

            dbConnection = new DbConnection();

            dbConnection.cmd.CommandText = "select * from ";
            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            ListAccountBill = dataAccessObject.ReadCollection<AccountBilling>(dbConnection.dr);
            dbConnection.dr.Close();

            return ListAccountBill;
        }

        public int Save(AccountBilling accountBilling, DbConnection dbConnection)
        {

            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = " ";


            //dbConnection.cmd.Parameters.AddWithValue("@ID", customer.CustomerId);

            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            return output;

        }

        public int Update(AccountBilling accountBilling, DbConnection dbConnection)
        {

            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = " ";


            //dbConnection.cmd.Parameters.AddWithValue("@ID", customer.CustomerId);

            output = dbConnection.cmd.ExecuteNonQuery();

            return output;

        }

        public int Delete(AccountBilling accountBilling, DbConnection dbConnection)
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
