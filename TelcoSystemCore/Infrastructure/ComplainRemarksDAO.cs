using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Domain;
using DbConnection = TelcoSystemCore.Common.DbConnection;

namespace TelcoSystemCore.Infrastructure
{
    public interface IComplainRemarksDAO
    {
        int Save(ComplainRemarks complainRemarks, DbConnection dbConnection);
        int Update(ComplainRemarks complainRemarks, DbConnection dbConnection);

        List<ComplainRemarks> GetComplainRemarksDetailList(DbConnection dbConnection);
    }

    public class ComplainRemarksSqlDAOImpl : IComplainRemarksDAO
    {
        public List<ComplainRemarks> GetComplainRemarksDetailList(DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public int Save(ComplainRemarks complainRemarks, DbConnection dbConnection)
        {
            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = "INSERT INTO lb.complain_remarks (comp_id, section_id, re_info_date, my_remarks) " +
                                                  "values (?,?,?,?)";

            dbConnection.cmd.Parameters.AddWithValue("@CompId", complainRemarks.CompId);
            dbConnection.cmd.Parameters.AddWithValue("@SectionId", complainRemarks.SectionId);
            dbConnection.cmd.Parameters.AddWithValue("@ReInfoDate", complainRemarks.ReInfoDate);
            dbConnection.cmd.Parameters.AddWithValue("@MyRemarks", complainRemarks.MyRemarks);



            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            return output;
        }

        public int Update(ComplainRemarks complainRemarks, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }
    }
}
