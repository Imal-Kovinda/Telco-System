using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using DbConnection = TelcoSystemCore.Common.DbConnection;

namespace TelcoSystemCore.Infrastructure
{
    public interface IPnbsMenuRolesUsersDAO
    {
        int Save(PnbsMenuRolesUsers pnbsMenuRolesUsers, DbConnection dbConnection);
        int Update(PnbsMenuRolesUsers pnbsMenuRolesUsers, DbConnection dbConnection);
        List<PnbsMenuRolesUsers> GetPnbsMenuRolesUsersDetailList(DbConnection dbConnection, PnbsMenuRolesUsers pnbsMenuRolesUsers);
    }
    public class PnbsMenuRolesUsersSqlDAOImpl : IPnbsMenuRolesUsersDAO
    {
        public List<PnbsMenuRolesUsers> GetPnbsMenuRolesUsersDetailList(DbConnection dbConnection, PnbsMenuRolesUsers pnbsMenuRolesUsers)
        {
            List<PnbsMenuRolesUsers> pnbsMenuRolesUsersDetailList = new List<PnbsMenuRolesUsers>();
            dbConnection = new DbConnection();
     

            dbConnection.cmd.CommandText =
                "SELECT * FROM lb.pnbs_menu_roles_users WHERE pnbs_userid = ?";

            dbConnection.cmd.Parameters.AddWithValue("@UserId", pnbsMenuRolesUsers.PnbsUserid);

            //dbConnection.cmd.CommandText = "SELECT * FROM lb.PnbsMenuRolesUsers WHERE PnbsMenuRolesUsers_id = '720971623V'";

            dbConnection.dr = dbConnection.cmd.ExecuteReader();

            DataAccessObject dataAccessObject = new DataAccessObject();

            pnbsMenuRolesUsersDetailList = dataAccessObject.ReadCollection<PnbsMenuRolesUsers>(dbConnection.dr);
            dbConnection.dr.Close();

            return pnbsMenuRolesUsersDetailList;
        }

        public int Save(PnbsMenuRolesUsers pnbsMenuRolesUsers, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public int Update(PnbsMenuRolesUsers pnbsMenuRolesUsers, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }
    }
}
