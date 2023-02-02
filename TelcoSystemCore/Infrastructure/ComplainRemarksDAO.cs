using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using DbConnection = TelcoSystemCore.Common.DbConnection;

namespace TelcoSystemCore.Infrastructure
{
    public interface IComplainRemarksDAO
    {
        int Save(ComplainRemarks complainRemarks, DbConnection dbConnection);
        int Update(ComplainRemarks complainRemarks, DbConnection dbConnection);
        int Count(ComplainRemarks complainRemarks, DbConnection dbConnection);

        List<ComplainRemarks> GetComplainRemarksDetailList(DbConnection dbConnection, string compRemarks);
    }

    public class ComplainRemarksSqlDAOImpl : IComplainRemarksDAO
    {
        public int Count(ComplainRemarks complainRemarks, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public List<ComplainRemarks> GetComplainRemarksDetailList(DbConnection dbConnection, string compRemarks)
        {
            List<ComplainRemarks> complainRemarks = new List<ComplainRemarks>();
            dbConnection = new DbConnection();
            dbConnection.cmd.CommandText =
                "SELECT * FROM lb.complain_remarks WHERE comp_id ='"+ compRemarks+"'";

            //dbConnection.cmd.Parameters.AddWithValue("@CompId", complainRemarks);

            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            complainRemarks = dataAccessObject.ReadCollection<ComplainRemarks>(dbConnection.dr);
            dbConnection.dr.Close();


            return complainRemarks;
        }




        public int Save(ComplainRemarks complainRemarks, DbConnection dbConnection)
        {
            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;

            //var rest = "SELECT * FROM lb.complain_remarks WHERE seq_id = '" + complainRemarks.CompId + "'";
            //if (rest == null)
            //{
            //    complainRemarks.SeqId = "1";
            //}

            dbConnection.cmd.CommandText = "INSERT INTO lb.complain_remarks (comp_id, section_id, re_info_date, my_remarks, user_code) " +
                                                  "values (?,?,?,?,?)";

            //SELECT employee_id, COUNT(*)
            //FROM table_name
            //GROUP BY employee_id;


            //dbConnection.cmd.Parameters.AddWithValue("@RemarkId", complainRemarks.RemarkId);
            //dbConnection.cmd.Parameters.AddWithValue("@SeqId", complainRemarks.SeqId);
            dbConnection.cmd.Parameters.AddWithValue("@CompId", complainRemarks.CompId);
            dbConnection.cmd.Parameters.AddWithValue("@SectionId", complainRemarks.SectionId);
            dbConnection.cmd.Parameters.AddWithValue("@ReInfoDate", complainRemarks.ReInfoDate);
            dbConnection.cmd.Parameters.AddWithValue("@MyRemarks", complainRemarks.MyRemarks);
            dbConnection.cmd.Parameters.AddWithValue("@UserCode", complainRemarks.UserCode);



            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            return output;
        }



        public int Update(ComplainRemarks complainRemarks, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }
    }
}
