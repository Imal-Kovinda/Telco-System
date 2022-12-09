using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;

namespace TelcoSystemCore.Infrastructure
{
    public interface ILteLoginDAO
    {
        List<LteLogin> GetLteLoginList(DbConnection dbConnection);

        LteLogin GetLteLogin(string Id, DbConnection dbConnection);
    }

    public class LteloginPgSqlDAOImpl : ILteLoginDAO
    {
        public List<LteLogin> GetLteLoginList(DbConnection dbConnection)
        {
            List<LteLogin> listLteLogin = new List<LteLogin>();

            dbConnection.cmd.CommandText = "SELECT * FROM LTE_LOGIN;";

            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            listLteLogin = dataAccessObject.ReadCollection<LteLogin>(dbConnection.dr);
            dbConnection.dr.Close();


            return listLteLogin;
        }

        public LteLogin GetLteLogin(string Id, DbConnection dbConnection)
        {
            LteLogin lteLogin = new LteLogin();

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandText = "SELECT * FROM LTE_LOGIN WHERE MSIDN = @MSIDN;";
            dbConnection.cmd.Parameters.AddWithValue("@MSIDN", Id);

            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            lteLogin = dataAccessObject.GetSingleOject<LteLogin>(dbConnection.dr);
            dbConnection.dr.Close();


            return lteLogin;
        }
    }
}
