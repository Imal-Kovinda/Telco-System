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
    public interface ICustomerDAO
    {
        int Save(Customer customer, DbConnection dbConnection);
        int Update(Customer customer, DbConnection dbConnection);
        List<Customer> GetCustomerList(DbConnection dbConnection, string CustomQuery = null);
    }

    public class CustomerSqlDAOImpl : ICustomerDAO
    {
        public List<Customer> GetCustomerList(DbConnection dbConnection, string CustomQuery = null)
        {
            throw new NotImplementedException();
        }

        public int Save(Customer customer, DbConnection dbConnection)
        {
            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = "Insert into Customer (ID, Name, Email, Address,City, Contact_No, NIC) " +
                                           "values (@ID,@Name,@Email,@Address,@City,@Contact_No,@NIC) SELECT SCOPE_IDENTITY() ";


            //dbConnection.cmd.Parameters.AddWithValue("@ID", customer.CustomerId);
            //dbConnection.cmd.Parameters.AddWithValue("@Name", customer.CustomerName);
            //dbConnection.cmd.Parameters.AddWithValue("@Email", customer.CusEmail);
            //dbConnection.cmd.Parameters.AddWithValue("@Address", customer.AccAddress);
            //dbConnection.cmd.Parameters.AddWithValue("@City", customer.City);
            //dbConnection.cmd.Parameters.AddWithValue("@Contact_No", customer.ContactNo);
            //dbConnection.cmd.Parameters.AddWithValue("@NIC", customer.CusNIC);

            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            return output;
        }

        public int Update(Customer customer, DbConnection dbConnection)
        {
            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = "Update Student set Country_ID = @ID ,Name = @Name,Email = @Email,Address  =@Address ,City = @City WHERE ID = @ID ";

            //dbConnection.cmd.Parameters.AddWithValue("@ID", customer.CustomerID);
            //dbConnection.cmd.Parameters.AddWithValue("@Name", customer.CustomerName);
            //dbConnection.cmd.Parameters.AddWithValue("@Email", customer.CusEmail);
            //dbConnection.cmd.Parameters.AddWithValue("@Address", customer.AccAddress);
            //dbConnection.cmd.Parameters.AddWithValue("@City", customer.City);
            //dbConnection.cmd.Parameters.AddWithValue("@Contact_No", customer.ContactNo);
            //dbConnection.cmd.Parameters.AddWithValue("@NIC", customer.CusNIC);

            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            return output;

        }

        public List<Customer> GetCustomerList(DbConnection dbConnection)
        {
            List<Customer> customerList = new List<Customer>();
            dbConnection = new DbConnection();
            dbConnection.cmd.CommandText = "select * from customer";

            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            customerList = dataAccessObject.ReadCollection<Customer>(dbConnection.dr);
            dbConnection.dr.Close();


            return customerList;
        }
    }
}
