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
    public interface ICmLogComplainsDAO
    {
        int Save(CmLogComplains cmLogComplains, DbConnection dbConnection);
        int Update(CmLogComplains cmLogComplains, DbConnection dbConnection);
        List<CmLogComplains> GetCmLogComplainsList(DbConnection dbConnection, string CmLogComplains = null);
    }

    public class CmLogComplainsSqlDAOImpl : ICmLogComplainsDAO
    {
        

        public int Save(CmLogComplains cmLogComplains, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public int Update(CmLogComplains cmLogComplains, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public List<CmLogComplains> GetCmLogComplainsList(DbConnection dbConnection, string CmLogComplains = null)
        {
            List<CmLogComplains> cmLogComplains = new List<CmLogComplains>();
            dbConnection = new DbConnection();
            dbConnection.cmd.CommandText = "select * from cm_log_complains";

            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            cmLogComplains = dataAccessObject.ReadCollection<CmLogComplains>(dbConnection.dr);
            dbConnection.dr.Close();


            return cmLogComplains;
        }
    }
}
