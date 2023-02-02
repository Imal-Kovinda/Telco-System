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
    public interface IPnbsMenuRolesUsersController
    {
        int Save(PnbsMenuRolesUsers pnbsMenuRolesUsers);
        int Update(PnbsMenuRolesUsers pnbsMenuRolesUsers);
        //List<PnbsMenuRolesUsers> GetPnbsMenuRolesUsersList(string CustomQuery = null);

        List<PnbsMenuRolesUsers> GetPnbsMenuRolesUsersDetailList(PnbsMenuRolesUsers userId);
    }

    public class PnbsMenuRolesUsersControllerImpl : IPnbsMenuRolesUsersController
    {
        IPnbsMenuRolesUsersDAO pnbsMenuRolesUsersDAO = DAOFactory.CreatePnbsMenuRolesUsersDAO();

        public List<PnbsMenuRolesUsers> GetPnbsMenuRolesUsersDetailList(PnbsMenuRolesUsers userId)
        {
            DbConnection dbConnection = null;
            List<PnbsMenuRolesUsers> listDetail = new List<PnbsMenuRolesUsers>();

            try
            {

                dbConnection = new DbConnection();

                return pnbsMenuRolesUsersDAO.GetPnbsMenuRolesUsersDetailList(dbConnection, userId);

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

        public int Save(PnbsMenuRolesUsers PnbsMenuRolesUsers)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return pnbsMenuRolesUsersDAO.Save(PnbsMenuRolesUsers, dbConnection);
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

        public int Update(PnbsMenuRolesUsers PnbsMenuRolesUsers)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return pnbsMenuRolesUsersDAO.Update(PnbsMenuRolesUsers, dbConnection);
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
