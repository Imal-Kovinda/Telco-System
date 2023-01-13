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
    public interface ICmCategoryTypeMasterDAO
    {
        int Save(CmCategoryTypeMaster cmCategoryTypeMaster, DbConnection dbConnection);
        int Update(CmCategoryTypeMaster cmCategoryTypeMaster, DbConnection dbConnection);
        List<CmCategoryTypeMaster> GetCmCategoryTypeMasterDetailList(DbConnection dbConnection);
        List<CmCategoryTypeMaster> GetCmCategoryTypeMaster(DbConnection dbConnection, string category);
    }
    public class CmCategoryTypeMasterSqlDAOImpl : ICmCategoryTypeMasterDAO
    {
        public List<CmCategoryTypeMaster> GetCmCategoryTypeMasterDetailList(DbConnection dbConnection)
        {
            List<CmCategoryTypeMaster> cmCategoryTypeMasterDetailList = new List<CmCategoryTypeMaster>();
            dbConnection = new DbConnection();

            dbConnection.cmd.CommandText =
                "SELECT * FROM lb.cm_category_type_master WHERE status = 'A'";

            //dbConnection.cmd.Parameters.AddWithValue(":phoneNumber", phoneNumber);
             
            dbConnection.dr = dbConnection.cmd.ExecuteReader();

            DataAccessObject dataAccessObject = new DataAccessObject();

            cmCategoryTypeMasterDetailList = dataAccessObject.ReadCollection<CmCategoryTypeMaster>(dbConnection.dr);
            dbConnection.dr.Close();

            return cmCategoryTypeMasterDetailList;
        }

        public List<CmCategoryTypeMaster> GetCmCategoryTypeMaster(DbConnection dbConnection, string category)
        {
            List<CmCategoryTypeMaster> cmCategoryTypeMasterDetailList = new List<CmCategoryTypeMaster>();
            dbConnection = new DbConnection();

            dbConnection.cmd.CommandText =
                "SELECT code FROM lb.cm_category_type_master WHERE description = :category";



            dbConnection.cmd.Parameters.AddWithValue(":category", category);

            dbConnection.dr = dbConnection.cmd.ExecuteReader();

            DataAccessObject dataAccessObject = new DataAccessObject();

            cmCategoryTypeMasterDetailList = dataAccessObject.ReadCollection<CmCategoryTypeMaster>(dbConnection.dr);
            dbConnection.dr.Close();

            return cmCategoryTypeMasterDetailList;
        }

        public int Save(CmCategoryTypeMaster cmCategoryTypeMaster, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public int Update(CmCategoryTypeMaster cmCategoryTypeMaster, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }
    }
}
