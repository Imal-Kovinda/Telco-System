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
        //bool GetPnbsUsers(string username, string password);

        int GetPnbsUsers(PnbsUsers pnbsUsers);
        int Save(PnbsUsers pnbsUsers);
        int Update(PnbsUsers pnbsUsers);
        int Delete(PnbsUsers pnbsUsers);
        List<PnbsUsers> GetPnbsUsers();
    }

    public class PnbsUsersControllerSqlImpl : IPnbsUsersController
    public class PnbsUsersControllerImpl : IPnbsUsersController
    {
        IPnbsUsersDAO PnbsUsersDAO = DAOFactory.CreateGetPnbsUsersDAO();
        IPnbsUsersDAO pnbsUsersDAO = DAOFactory.CreatePnbsUsersDAO();

        //public bool GetPnbsUsers(string username, string password)
        //{
        //    DbConnection dbConnection = null;
        //    PnbsUsers PnbsUsers = new PnbsUsers();
        //    bool PnbsUsersStatus;
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

        //    try
        //    {
        //        dbConnection = new DbConnection();
        //        PnbsUsersStatus = PnbsUsersDAO.GetPnbsUsers(username,password, dbConnection);

        //    }
        //    catch (Exception)
        //    {
        //        dbConnection.RollBack();
        //        throw;
        //    }
        //    finally
        //    {
        //        if (dbConnection.con.State == System.Data.ConnectionState.Open)
        //        {
        //            dbConnection.Commit();
        //        }
        //    }
        //    return PnbsUsersStatus;
        //}
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
      
        public int GetPnbsUsers(PnbsUsers pnbsUsers)
        public int Update(PnbsUsers pnbsUsers)
        {
            DbConnection dbConnection = null;
            //PnbsUsers PnbsUsers = new PnbsUsers();
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
                return PnbsUsersDAO.GetPnbsUsers(dbConnection, pnbsUsers);

                return pnbsUsersDAO.Delete(pnbsUsers, dbConnection);
            }
            catch (Exception)
            {
                //HttpContext.Current.Response.Redirect("500.aspx");
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
