using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using TelcoSystemCore.Infrastructure;

namespace TelcoSystemCore.Controller
{
    public interface ICustomerAccountController
    {
        int Save(CustomerAccount customer);
        int Update(CustomerAccount customer);
        List<CustomerAccount> GetCustomerAccountDetailList(string phoneNumber);

    }

    public class CustomerAccountControllerImpl : ICustomerAccountController
    {
        ICustomerAccountDAO customerAccountDAO = DAOFactory.CreateCustomerAccountDAO();

        public int Save(CustomerAccount customerAccount)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return customerAccountDAO.Save(customerAccount, dbConnection);
            }
            catch (Exception)
            {
                dbConnection.RollBack();
                throw;
            }
            finally
            {
                if (dbConnection.con.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Commit();
                }
            }

        }

        public int Update(CustomerAccount customerAccount)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return customerAccountDAO.Update(customerAccount, dbConnection);
            }
            catch (Exception)
            {
                dbConnection.RollBack();
                throw;
            }
            finally
            {
                if (dbConnection.con.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Commit();
                }
            }
        }

        public List<CustomerAccount> GetCustomerAccountDetailList(string phoneNumber)
        {
            DbConnection dbConnection = null;
            List<CustomerAccount> listDetail = new List<CustomerAccount>();

            try
            {

                dbConnection = new DbConnection();
              

                if (phoneNumber != null)
                {

                    return customerAccountDAO.GetCustomerAccountDetailList(dbConnection, phoneNumber);
                }

            }
            catch (Exception)
            {
                dbConnection.RollBack();
                throw;
            }
            finally
            {
                if (dbConnection.con.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Commit();
                }
            }
            return listDetail;
        }
    }
}
