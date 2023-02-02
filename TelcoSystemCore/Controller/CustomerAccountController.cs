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

        List<CustomerAccount> GetCustomerAccountDetailList(string phoneNumber);
        int Save(CustomerAccount customerAccount);
        int Delete(CustomerAccount customerAccount);
        int Update(CustomerAccount customerAccount);
        List<CustomerAccount> GetCustomerAccounts();

        CustomerAccount GetCustomerAccount(String customerAccountId);

    }

    public class CustomerAccountControllerImpl : ICustomerAccountController
    {
        ICustomerAccountDAO customerAccountDAO = DAOFactory.CreateCustomerAccountDAO();

        public List<CustomerAccount> GetCustomerAccounts()
        {
            DbConnection dbConnection = null;
            List<CustomerAccount> listCusAccount = new List<CustomerAccount>();
            try
            {
                dbConnection = new DbConnection();
                listCusAccount = customerAccountDAO.GetCustomerAccounts(dbConnection);
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
            return listCusAccount;
        }

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


        public int Delete(CustomerAccount customerAccount)
        {

            DbConnection dbConnection = null;
            List<CustomerAccount> listDetail = new List<CustomerAccount>();

            try
            {

                dbConnection = new DbConnection();


                if (phoneNumber != null)
                    return customerAccountDAO.Delete(customerAccount, dbConnection);
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

                    return customerAccountDAO.GetCustomerAccountDetailList(dbConnection, phoneNumber);
                    dbConnection.Commit();
                }
            }
        }

        public CustomerAccount GetCustomerAccount(String customerAccountId)
        {
            DbConnection dbConnection = null;
            CustomerAccount customerAccount = new CustomerAccount();
            try
            {
                dbConnection = new DbConnection();
                customerAccount = customerAccountDAO.GetCustomerAccount(dbConnection, customerAccountId);
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
            return customerAccount;
        }


    }



}
