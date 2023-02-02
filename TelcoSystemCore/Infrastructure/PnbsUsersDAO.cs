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
        //bool GetPnbsUsers(string username, string password, DbConnection dbConnection);
        int GetPnbsUsers(DbConnection dbConnection, PnbsUsers pnbsUsers);
    }

    public class PnbsUsersSqlDAOImpl : IPnbsUsersDAO
    {
        public List<PnbsUsers> GetPnbsUsers(DbConnection dbConnection)
        {
            List<PnbsUsers> ListPnbsUsers = new List<PnbsUsers>();

            dbConnection = new DbConnection();
        
            dbConnection.cmd.CommandText = "select * from ";
            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            ListPnbsUsers = dataAccessObject.ReadCollection<PnbsUsers>(dbConnection.dr);
            dbConnection.dr.Close();

            return ListPnbsUsers;
        }

        public int Save(PnbsUsers pnbsUsers, DbConnection dbConnection)
    {
       
            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = " ";


            //dbConnection.cmd.Parameters.AddWithValue("@ID", customer.CustomerId);

        public int GetPnbsUsers(DbConnection dbConnection, PnbsUsers pnbsUsers)
        {
            //"DILEEKAS"
            //"C3E4119CCF6628BA"

            //"LOCHANAW"
            //"2F19F7E5EFEA182EA78FC26F6BCAC7DB"

        public int Delete(PnbsUsers pnbsUsers, DbConnection dbConnection)
        {
            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = "SELECT * FROM lb.pnbs_users WHERE pnbs_id = '"+ pnbsUsers.PnbsId + "' AND password = '"+ pnbsUsers.Password +"'";

            //dbConnection.cmd.Parameters.AddWithValue("@PnbsId", pnbsUsers.PnbsId);
            //dbConnection.cmd.Parameters.AddWithValue("@Password", pnbsUsers.Password);

            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());

            return output;


        }

    }



}
