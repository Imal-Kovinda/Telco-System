using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using DbConnection = TelcoSystemCore.Common.DbConnection;

namespace TelcoSystemCore.Infrastructure
{
    public interface IPnbsUsersDAO
    {
        bool GetPnbsUsers(string username, string password, DbConnection dbConnection);
        PnbsUsers GetPnbsUsers(string username, DbConnection dbConnection);
    }

    public class PnbsUsersSqlDAOImpl : IPnbsUsersDAO
        
    {

        public bool GetPnbsUsers(string username, string password, DbConnection dbConnection)
        {
            PnbsUsers getPnbsUsers = new PnbsUsers();


            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandText = "SELECT * FROM PNBS_USERS WHERE PNBS_ID = " + username;
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            using (dbConnection.dr = dbConnection.cmd.ExecuteReader())
            {
                DataAccessObject dataAccessObject = new DataAccessObject();
                getPnbsUsers = dataAccessObject.GetSingleOject<PnbsUsers>(dbConnection.dr);
            }

            if (getPnbsUsers.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public PnbsUsers GetPnbsUsers(string username, DbConnection dbConnection)
        {
            PnbsUsers getPnbsUsers = new PnbsUsers();


            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandText = "SELECT * FROM PNBS_USERS WHERE PNBS_ID = " + username;
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            using (dbConnection.dr = dbConnection.cmd.ExecuteReader())
            {
                DataAccessObject dataAccessObject = new DataAccessObject();
                getPnbsUsers = dataAccessObject.GetSingleOject<PnbsUsers>(dbConnection.dr);
            }
            return getPnbsUsers;
        }
            



    }
}
