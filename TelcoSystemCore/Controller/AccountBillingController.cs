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
    public interface IAccountBillingController
    {
        int Save(AccountBilling accountBilling);
        int Update(AccountBilling accountBilling);
        int Delete(AccountBilling accountBilling);
        List<AccountBilling> GetAccountBillList();

    }

    public class AccountBillingControllerImpl : IAccountBillingController
    {
        IAccountBillingDAO accountBillingDAO= DAOFactory.CreateAccountBillingDAO();

        public List<AccountBilling> GetAccountBillList()
        {
            DbConnection dbConnection = null;
            List<AccountBilling> listAccountBill = new List<AccountBilling>();
            try
            {
                dbConnection = new DbConnection();
                listAccountBill = accountBillingDAO.GetAccountBillList(dbConnection);
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
            return listAccountBill;
        }

        public int Save(AccountBilling accountBilling)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return accountBillingDAO.Save(accountBilling, dbConnection);
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

        public int Update(AccountBilling accountBilling)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return accountBillingDAO.Update(accountBilling, dbConnection);
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

        public int Delete(AccountBilling accountBilling)
        {

            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return accountBillingDAO.Delete(accountBilling, dbConnection);
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
    }


}
