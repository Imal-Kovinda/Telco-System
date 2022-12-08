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
    public interface ILteLoginController
    {
        List<LteLogin> GetLteLoginList();

        LteLogin GetLteLogin(string Id);
    }

    public class LteLoginControllerPgSqlImpl : ILteLoginController
    {
        ILteLoginDAO lteLoginDAO = DAOFactory.CreateLteLoginDAO();

        public List<LteLogin> GetLteLoginList()
        {
            DbConnection dbConnection = null;
            List<LteLogin> listLteLogin = new List<LteLogin>();

            try
            {
                dbConnection = new DbConnection();
                listLteLogin = lteLoginDAO.GetLteLoginList(dbConnection);

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
            return listLteLogin;
        }

        public LteLogin GetLteLogin(string Id)
        {
            DbConnection dbConnection = null;
            LteLogin lteLogin = new LteLogin();

            try
            {
                dbConnection = new DbConnection();
                lteLogin = lteLoginDAO.GetLteLogin(Id, dbConnection);

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
            return lteLogin;
        }
    }
}
