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
    public interface ICustomerController
    {
        int Save(Customer customer);
        int Update(Customer customer);
        List<Customer> GetCustomerList(string CustomQuery = null);

        List<Customer> GetCustomerDetailList(string phoneNumber);
    }

    public class CustomerControllerImpl : ICustomerController
    {
        ICustomerDAO customerDAO = DAOFactory.CreateCustomerDAO();

        public int Save(Customer customer)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return customerDAO.Save(customer, dbConnection);
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

        public int Update(Customer customer)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return customerDAO.Update(customer, dbConnection);
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

        public List<Customer> GetCustomerList(string CustomQuery = null)
        {
            DbConnection dbConnection = null;
            List<Customer> listCustomer = new List<Customer>();
            try
            {
               
                dbConnection = new DbConnection();
                listCustomer = customerDAO.GetCustomerList(dbConnection);

                if (CustomQuery != null)
                {

                    return customerDAO.GetCustomerList(dbConnection, CustomQuery);
                }
                else
                {
                    //check
                    return customerDAO.GetCustomerList(dbConnection);
                   
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
            return listCustomer;
        }

        public List<Customer> GetCustomerDetailList(string phoneNumber)
        {
            DbConnection dbConnection = null;
            List<Customer> listDetail = new List<Customer>();

            try
            {

                dbConnection = new DbConnection();
                listDetail = customerDAO.GetCustomerList(dbConnection);

                if (phoneNumber != null)
                {

                    return customerDAO.GetCustomerList(dbConnection, phoneNumber);
                }
                else
                {
                    //check
                    return customerDAO.GetCustomerList(dbConnection);

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
