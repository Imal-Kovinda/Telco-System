using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using TelcoSystemCore.Infrastructure;

namespace TelcoSystemCore.Controller
{
    public interface IPnbsUsersController
    {
        int Save(PnbsUsers pnbsUsers);
        int Update(PnbsUsers pnbsUsers);
        int Delete(PnbsUsers pnbsUsers);
        List<PnbsUsers> GetPnbsUsers();
    }

    public class PnbsUsersControllerImpl : IPnbsUsersController
    {
        IPnbsUsersDAO pnbsUsersDAO = DAOFactory.CreatePnbsUsersDAO();

        public List<PnbsUsers> GetPnbsUsers()
        {
            DbConnection dbConnection = null;
            List<PnbsUsers> listPnbsUsers = new List<PnbsUsers>();
            try
            {
                dbConnection = new DbConnection();
                listPnbsUsers = pnbsUsersDAO.GetPnbsUsers(dbConnection);
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
            return listPnbsUsers;
        }

        public int Save(PnbsUsers pnbsUsers)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return pnbsUsersDAO.Save(pnbsUsers, dbConnection);
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

        public int Update(PnbsUsers pnbsUsers)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return pnbsUsersDAO.Update(pnbsUsers, dbConnection);
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

        public int Delete(PnbsUsers pnbsUsers)
        {

            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return pnbsUsersDAO.Delete(pnbsUsers, dbConnection);
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
