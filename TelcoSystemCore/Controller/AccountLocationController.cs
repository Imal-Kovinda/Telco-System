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
    public interface IAccountLocationController
    {
        int Save(AccountLocation accountLocation);
        int Update(AccountLocation accountLocation);
        List<AccountLocation> GetAccountLocationDetailList(string phoneNumber);
    }

    public class AccountLocationControllerImpl : IAccountLocationController
    {
        IAccountLocationDAO accountLocationDAO = DAOFactory.CreateAccountLocationDAO();

        public int Save(AccountLocation accountLocation)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return accountLocationDAO.Save(accountLocation, dbConnection);
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

        public int Update(AccountLocation accountLocation)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return accountLocationDAO.Update(accountLocation, dbConnection);
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

        public List<AccountLocation> GetAccountLocationDetailList(string phoneNumber)
        {
            DbConnection dbConnection = null;
            List<AccountLocation> listDetail = new List<AccountLocation>();

            try
            {

                dbConnection = new DbConnection();

                if (phoneNumber != null)
                {

                    return accountLocationDAO.GetAccountLocationDetailList(dbConnection, phoneNumber);
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
