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
    public interface ICustomerAccountDAO
    {
        int Save(CustomerAccount customerAccount, DbConnection dbConnection);
        int Update(CustomerAccount customerAccount, DbConnection dbConnection);
        int Delete(CustomerAccount customerAccount, DbConnection dbConnection);
        List<CustomerAccount> GetCustomerAccounts(DbConnection dbConnection);

        CustomerAccount GetCustomerAccount(DbConnection dbConnection, String accountId);

    }

    public class CustomerAccountSqlDAOImpl : ICustomerAccountDAO
    {
        CustomerAccount customerAccount = new CustomerAccount();
        public List<CustomerAccount> GetCustomerAccounts(DbConnection dbConnection)
        {
            List<CustomerAccount> ListCusAccount = new List<CustomerAccount>();

            dbConnection = new DbConnection();
            dbConnection.cmd.CommandText = "select * from lb.customer_account ";
            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            ListCusAccount = dataAccessObject.ReadCollection<CustomerAccount>(dbConnection.dr);
            dbConnection.dr.Close();

            return ListCusAccount;
        }

        public int Save(CustomerAccount customerAccount, DbConnection dbConnection)
        {

            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = " ";


            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            return output;

        }

        public int Update(CustomerAccount customerAccount, DbConnection dbConnection)
        {

            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = " ";


            //dbConnection.cmd.Parameters.AddWithValue("@ID", customer.CustomerId);

            output = dbConnection.cmd.ExecuteNonQuery();

            return output;

        }

        public int Delete(CustomerAccount customerAccount, DbConnection dbConnection)
        {
            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = " ";


            //dbConnection.cmd.Parameters.AddWithValue("@ID", customer.CustomerId);

            output = dbConnection.cmd.ExecuteNonQuery();

            return output;


        }

        public CustomerAccount GetCustomerAccount(DbConnection dbConnection, String accountId)
        {

            dbConnection.cmd.CommandText = "select * from lb.customer_account WHERE ACCOUNT_ID = '" + accountId + "'";
            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            customerAccount = dataAccessObject.GetSingleOject<CustomerAccount>(dbConnection.dr);
            dbConnection.dr.Close();
            return customerAccount;
        }


    }


}
