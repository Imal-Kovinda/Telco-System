using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;

namespace TelcoSystemCore.Infrastructure
{
    public interface IChequeDetailDAO
    {
        int Save(ChequeDetail cheque, DbConnection dbConnection);
        int Update(ChequeDetail cheque, DbConnection dbConnection);
        List<ChequeDetail> GetChequeDetailList(DbConnection dbConnection, string ChequeQuery = null);
    }

    public class ChequeDetailSqlDAOImpl : IChequeDetailDAO
    {
        public int Save(ChequeDetail chequeDetail, DbConnection dbConnection)
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

        public int Update(ChequeDetail chequeDetail, DbConnection dbConnection)
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

        public List<ChequeDetail> GetChequeDetailList(DbConnection dbConnection)
        {
            List<ChequeDetail> chequeDetail = new List<ChequeDetail>();
            dbConnection = new DbConnection();
            dbConnection.cmd.CommandText = "select * from ChequeDetail";

            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            chequeDetail = dataAccessObject.ReadCollection<ChequeDetail>(dbConnection.dr);
            dbConnection.dr.Close();


            return chequeDetail;
        }

        public List<ChequeDetail> GetChequeDetailList(DbConnection dbConnection, string ChequeQuery = null)
        {
            throw new NotImplementedException();
        }
    }
}
