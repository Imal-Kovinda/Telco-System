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
    public interface ICmComplainTypeMasterDAO
    {
        int Save(CmComplainTypeMaster cmComplainTypeMaster, DbConnection dbConnection);
        int Update(CmComplainTypeMaster cmComplainTypeMaster, DbConnection dbConnection);
        List<CmComplainTypeMaster> GetCmComplainTypeMasterDetailList(DbConnection dbConnection);
        List<CmComplainTypeMaster> GetCmComplainTypeMaster(DbConnection dbConnection, string complain);
    }

    public class CmComplainTypeMasterSqlDAOImpl : ICmComplainTypeMasterDAO
    {
        public List<CmComplainTypeMaster> GetCmComplainTypeMasterDetailList(DbConnection dbConnection)
        {
            List<CmComplainTypeMaster> cmComplainTypeMasterDetailList = new List<CmComplainTypeMaster>();
            dbConnection = new DbConnection();


            dbConnection.cmd.CommandText =
                "SELECT * FROM lb.cm_complain_type_master WHERE status = 'A'";


            //dbConnection.cmd.Parameters.AddWithValue(":phoneNumber", phoneNumber);



            dbConnection.dr = dbConnection.cmd.ExecuteReader();

            DataAccessObject dataAccessObject = new DataAccessObject();

            cmComplainTypeMasterDetailList = dataAccessObject.ReadCollection<CmComplainTypeMaster>(dbConnection.dr);
            dbConnection.dr.Close();

            return cmComplainTypeMasterDetailList;
        }

        public List<CmComplainTypeMaster> GetCmComplainTypeMaster(DbConnection dbConnection, string complain)
        {
            List<CmComplainTypeMaster> cmComplainTypeMasterDetailList = new List<CmComplainTypeMaster>();
            dbConnection = new DbConnection();

            dbConnection.cmd.CommandText =
                "SELECT code FROM lb.cm_Complain_type_master WHERE description = ?";



            dbConnection.cmd.Parameters.AddWithValue("@complain", complain);

            dbConnection.dr = dbConnection.cmd.ExecuteReader();

            DataAccessObject dataAccessObject = new DataAccessObject();

            cmComplainTypeMasterDetailList = dataAccessObject.ReadCollection<CmComplainTypeMaster>(dbConnection.dr);
            dbConnection.dr.Close();

            return cmComplainTypeMasterDetailList;
        }

        public int Save(CmComplainTypeMaster cmComplainTypeMaster, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public int Update(CmComplainTypeMaster cmComplainTypeMaster, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }
    }
}
