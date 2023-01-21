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
    public interface ICmComplainSubTypeMasterDAO
    {
        int Save(CmComplainSubTypeMaster cmComplainSubTypeMaster, DbConnection dbConnection);
        int Update(CmComplainSubTypeMaster cmComplainSubTypeMaster, DbConnection dbConnection);
        List<CmComplainSubTypeMaster> GetCmComplainSubTypeMasterDetailList(DbConnection dbConnection);
        List<CmComplainSubTypeMaster> GetCmComplainSubTypeMaster(DbConnection dbConnection, string complainSub);
    }

    public class CmComplainSubTypeMasterSqlDAOImpl : ICmComplainSubTypeMasterDAO
    {
        public List<CmComplainSubTypeMaster> GetCmComplainSubTypeMasterDetailList(DbConnection dbConnection)
        {
            List<CmComplainSubTypeMaster> cmComplainSubTypeMasterDetailList = new List<CmComplainSubTypeMaster>();
            dbConnection = new DbConnection();
            //phone = "0115511971"

            //query....

            dbConnection.cmd.CommandText =
                "SELECT * FROM lb.cm_complain_sub_type_master WHERE status = 'A'";


            //dbConnection.cmd.Parameters.AddWithValue(":phoneNumber", phoneNumber);

            dbConnection.dr = dbConnection.cmd.ExecuteReader();

            DataAccessObject dataAccessObject = new DataAccessObject();

            cmComplainSubTypeMasterDetailList = dataAccessObject.ReadCollection<CmComplainSubTypeMaster>(dbConnection.dr);
            dbConnection.dr.Close();

            return cmComplainSubTypeMasterDetailList;
        }

        public List<CmComplainSubTypeMaster> GetCmComplainSubTypeMaster(DbConnection dbConnection, string complainSub)
        {
            List<CmComplainSubTypeMaster> cmComplainSubTypeMasterDetailList = new List<CmComplainSubTypeMaster>();
            dbConnection = new DbConnection();

            dbConnection.cmd.CommandText =
                "SELECT code FROM lb.cm_complain_sub_type_master WHERE description = ?";



            dbConnection.cmd.Parameters.AddWithValue("@complainSub", complainSub);

            dbConnection.dr = dbConnection.cmd.ExecuteReader();

            DataAccessObject dataAccessObject = new DataAccessObject();

            cmComplainSubTypeMasterDetailList = dataAccessObject.ReadCollection<CmComplainSubTypeMaster>(dbConnection.dr);
            dbConnection.dr.Close();

            return cmComplainSubTypeMasterDetailList;
        }

        public int Save(CmComplainSubTypeMaster cmComplainSubTypeMaster, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public int Update(CmComplainSubTypeMaster cmComplainSubTypeMaster, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }
    }
}
