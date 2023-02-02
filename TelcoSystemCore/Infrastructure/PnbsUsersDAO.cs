using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using DbConnection = TelcoSystemCore.Common.DbConnection;

namespace TelcoSystemCore.Domain
{
    public interface IPnbsUsersDAO
    {
        int Save(PnbsUsers pnbsUsers, DbConnection dbConnection);
        int Update(PnbsUsers pnbsUsers, DbConnection dbConnection);
        int Delete(PnbsUsers pnbsUsers, DbConnection dbConnection);
        List<PnbsUsers> GetPnbsUsers(DbConnection dbConnection);
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

            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            return output;

        }

        public int Update(PnbsUsers pnbsUsers, DbConnection dbConnection)
        {

            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = " ";


            //dbConnection.cmd.Parameters.AddWithValue("@ID", customer.CustomerId);

            output = dbConnection.cmd.ExecuteNonQuery();

            return output;

        }

        public int Delete(PnbsUsers pnbsUsers, DbConnection dbConnection)
        {
            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = " ";


            //dbConnection.cmd.Parameters.AddWithValue("@ID", customer.CustomerId);

            output = dbConnection.cmd.ExecuteNonQuery();

            return output;


        }

    }



}
