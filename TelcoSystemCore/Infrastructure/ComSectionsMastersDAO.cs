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
    public interface IComSectionsMastersDAO
    {
        int Save(ComSectionsMasters comSectionsMasters, DbConnection dbConnection);
        int Update(ComSectionsMasters comSectionsMasters, DbConnection dbConnection);
        List<ComSectionsMasters> GetComSectionsMastersDetailList(DbConnection dbConnection);
    }

    public class ComSectionsMastersSqlDAOImpl : IComSectionsMastersDAO
    {
        public List<ComSectionsMasters> GetComSectionsMastersDetailList(DbConnection dbConnection)
        {
            List<ComSectionsMasters> comSectionsMastersDetailList = new List<ComSectionsMasters>();
            dbConnection = new DbConnection();

            dbConnection.cmd.CommandText =
                    "SELECT * FROM lb.com_sections_masters ";


            dbConnection.dr = dbConnection.cmd.ExecuteReader();

            DataAccessObject dataAccessObject = new DataAccessObject();

            comSectionsMastersDetailList = dataAccessObject.ReadCollection<ComSectionsMasters>(dbConnection.dr);
            dbConnection.dr.Close();

            return comSectionsMastersDetailList;
        }

        public int Save(ComSectionsMasters comSectionsMasters, DbConnection dbConnection)
        {
            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = "Insert into Customer (section_id, section_name, created_by, created_on,valid_until, parent_sec) " +
                                                  "values (?,?,?,?,?,?)";

            dbConnection.cmd.Parameters.AddWithValue("@SectionId", comSectionsMasters.SectionId);
            dbConnection.cmd.Parameters.AddWithValue("@SectionName", comSectionsMasters.SectionName);
            dbConnection.cmd.Parameters.AddWithValue("@CreatedBy", comSectionsMasters.CreatedBy);
            dbConnection.cmd.Parameters.AddWithValue("@Createdn", comSectionsMasters.CreatedOn);
            dbConnection.cmd.Parameters.AddWithValue("@ValidUntil", comSectionsMasters.ValidUntil);
            dbConnection.cmd.Parameters.AddWithValue("@ParentSec", comSectionsMasters.ParentSec);



            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            return output;
        }

        public int Update(ComSectionsMasters comSectionsMasters, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }
    }
}
