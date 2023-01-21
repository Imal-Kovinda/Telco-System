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

        int DoneCmLogComplains(DbConnection dbConnection, CmLogComplains done);
        List<CmLogComplains> GetCmLogComplainsList(DbConnection dbConnection, string userId);

        List<CmLogComplains> ViewMoreCmLogComplains(DbConnection dbConnection, string compId);

  


    }

    public class CmLogComplainsSqlDAOImpl : ICmLogComplainsDAO
    {
        

        public int Save(CmLogComplains cmLogComplains, DbConnection dbConnection)
        {
            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText =

            //data size......
            //    ('abc15', '03-MAR-2022', 'Kovinda300', '1214', '3284', '6442', '0716489633', " +
            //"'imal kovinda50', '324015', 'dfg30', 'ok30', '325030', '8965030', '7524030', 85.56, " +
            //"'8526025', 'Matara600', 'Matara100', 'abc800', 'Kovinda100', 'imal100', '0715893080', " +
            //"'y', 'ok3', 'kk30', 'kovinda40', '04-APR-2022', 'Kamal40', '09-APR-2022',  '09-APR-2022', " +
            //"'09-APR-2022','Message15', 'k','b2', 'ac100', 'e','c05','abc14','12-APR-2022','l', 12,'abc50'," +
            //"'m','any200')


            "INSERT INTO lb.cm_log_complains (" +
            "comp_id, cust_name, comp_cat_code, comp_type, comp_sub_type, dn_svc_no, " +
            "login_name, acc_code, acc_rating, conn_status, acc_category, line_type, line_usage, " +
            "last_month_bill, user_code, address, city, cust_remarks, contact_person, informed_by, " +
            "contact_no, followup, status, it_bstr, logged_by, logged_on, modified_by, modified_on, " +
            "attended_on, completed_on, ref_comp_id, urgent_comp, system_type, email, directed, info_to, " +
            "completed_by, hold_to, call_type, fault_id, comp_section_id, rejected, note, txn_date) " +
            "VALUES (?,?, ?, ?, ?, ?, " +
            "?, ?, ?, ?, ?, ?, ?, ?, " +
            "?, ?, ?, ?, ?, ?, ?, " +
            "?, ?, ?, ?, ?, ?, ?,  ?, " +
            "?,?, ?,?, ?, ?,?,?," +
            "?, ?, ?, ?, ?, ?, ?)";

            //"VALUES (@CompId, @CustName, @CompCatCode, @CompType, @CompSubType, @DnSvcNo, " +
            //"@LoginName, @AccCode, @AccRating, @ConnStatus, @AccCategory, @LineType, @LineUsage, @LastMonthBill, " +
            //"@UserCode, @Address, @City, @CustRemarks, @ContactPerson, @InformedBy, @ContactNo, " +
            //"@Followup, @Status, @ItBstr, @LoggedBy, @LoggedOn, @ModifiedBy, @ModifiedOn,  @AttendedOn, " +
            //"@CompletedOn,@RefCompId, @UrgentComp,@SystemType, @Email, @Directed,@InfoTo,@CompletedBy," +
            //"@HoldTo, @CallType, @FaultId, @CompSectionId, @Rejected, @Note, @TxnDate)";

            dbConnection.cmd.Parameters.AddWithValue("@CompId", cmLogComplains.CompId);
            
            //dbConnection.cmd.Parameters.AddWithValue("@TxnDate", cmLogComplains.TxnDate).Value = DateTime.Now.ToString("yyyy-MM-dd");
            dbConnection.cmd.Parameters.AddWithValue("@CustName", cmLogComplains.CustName);
            dbConnection.cmd.Parameters.AddWithValue("@CompCatCode", cmLogComplains.CompCatCode);
            dbConnection.cmd.Parameters.AddWithValue("@CompType", cmLogComplains.CompType);
            dbConnection.cmd.Parameters.AddWithValue("@CompSubType", cmLogComplains.CompSubType);
            dbConnection.cmd.Parameters.AddWithValue("@DnSvcNo", cmLogComplains.DnSvcNo);
            dbConnection.cmd.Parameters.AddWithValue("@LoginName", cmLogComplains.LoginName);
            dbConnection.cmd.Parameters.AddWithValue("@AccCode", cmLogComplains.AccCode);
            dbConnection.cmd.Parameters.AddWithValue("@AccRating", cmLogComplains.AccRating);
            dbConnection.cmd.Parameters.AddWithValue("@ConnStatus", cmLogComplains.ConnStatus);
            dbConnection.cmd.Parameters.AddWithValue("@AccCategory", cmLogComplains.AccCategory);
            dbConnection.cmd.Parameters.AddWithValue("@LineType", cmLogComplains.LineType);
            dbConnection.cmd.Parameters.AddWithValue("@LineUsage", cmLogComplains.LineUsage);

            dbConnection.cmd.Parameters.AddWithValue("@LastMonthBill", cmLogComplains.LastMonthBill);
            dbConnection.cmd.Parameters.AddWithValue("@UserCode", cmLogComplains.UserCode);
            dbConnection.cmd.Parameters.AddWithValue("@Address", cmLogComplains.Address);
            dbConnection.cmd.Parameters.AddWithValue("@City", cmLogComplains.City);
            dbConnection.cmd.Parameters.AddWithValue("@CustRemarks", cmLogComplains.CustRemarks);
            dbConnection.cmd.Parameters.AddWithValue("@ContactPerson", cmLogComplains.ContactPerson);
            dbConnection.cmd.Parameters.AddWithValue("@InformedBy", cmLogComplains.InformedBy);
            dbConnection.cmd.Parameters.AddWithValue("@ContactNo", cmLogComplains.ContactNo);
            dbConnection.cmd.Parameters.AddWithValue("@Followup", cmLogComplains.Followup);
            dbConnection.cmd.Parameters.AddWithValue("@Status", cmLogComplains.Status);
            dbConnection.cmd.Parameters.AddWithValue("@ItBstr", cmLogComplains.ItBstr);
            dbConnection.cmd.Parameters.AddWithValue("@LoggedBy", cmLogComplains.LoggedBy);
            dbConnection.cmd.Parameters.AddWithValue("@LoggedOn", cmLogComplains.LoggedOn);
            dbConnection.cmd.Parameters.AddWithValue("@ModifiedBy", cmLogComplains.ModifiedBy);
            dbConnection.cmd.Parameters.AddWithValue("@ModifiedOn", cmLogComplains.ModifiedOn);
            dbConnection.cmd.Parameters.AddWithValue("@AttendedOn", cmLogComplains.AttendedOn);


            dbConnection.cmd.Parameters.AddWithValue("@CompletedOn", cmLogComplains.CompletedOn);
            dbConnection.cmd.Parameters.AddWithValue("@RefCompId", cmLogComplains.RefCompId);
            dbConnection.cmd.Parameters.AddWithValue("@UrgentComp", cmLogComplains.UrgentComp);
            dbConnection.cmd.Parameters.AddWithValue("@SystemType", cmLogComplains.SystemType);
            dbConnection.cmd.Parameters.AddWithValue("@Email", cmLogComplains.Email);
            dbConnection.cmd.Parameters.AddWithValue("@Directed", cmLogComplains.Directed);
            dbConnection.cmd.Parameters.AddWithValue("@InfoTo", cmLogComplains.InfoTo);
            dbConnection.cmd.Parameters.AddWithValue("@CompletedBy", cmLogComplains.CompletedBy);
            dbConnection.cmd.Parameters.AddWithValue("@HoldTo", cmLogComplains.HoldTo);
            dbConnection.cmd.Parameters.AddWithValue("@CallType", cmLogComplains.CallType);
            dbConnection.cmd.Parameters.AddWithValue("@FaultId", cmLogComplains.FaultId);
            dbConnection.cmd.Parameters.AddWithValue("@CompSectionId", cmLogComplains.CompSectionId);
            dbConnection.cmd.Parameters.AddWithValue("@Rejected", cmLogComplains.Rejected);
            dbConnection.cmd.Parameters.AddWithValue("@Note", cmLogComplains.Note);
            dbConnection.cmd.Parameters.AddWithValue("@TxnDate", cmLogComplains.TxnDate);


            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            return output;
        }

        public int Update(CmLogComplains cmLogComplains, DbConnection dbConnection)
        {
            //update informed_by

            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText =
                "UPDATE lb.cm_log_complains SET note = ?, info_to = ? WHERE comp_id = ?";

            dbConnection.cmd.Parameters.AddWithValue("@Note", cmLogComplains.Note);
            dbConnection.cmd.Parameters.AddWithValue("@InfoTo", cmLogComplains.InfoTo);
            dbConnection.cmd.Parameters.AddWithValue("@CompId", cmLogComplains.CompId);

            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());

            return output;
        }

        public int DoneCmLogComplains(DbConnection dbConnection, CmLogComplains done)
        {
            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText =
                "UPDATE lb.cm_log_complains SET status = 'D' WHERE comp_id = ?";

            dbConnection.cmd.Parameters.AddWithValue("@Status", done.Status);

            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());

            return output;
        }

        public List<CmLogComplains> GetCmLogComplainsList(DbConnection dbConnection, string userId)
        {
            List<CmLogComplains> cmLogComplains = new List<CmLogComplains>();
            dbConnection = new DbConnection();
            dbConnection.cmd.CommandText = "SELECT * FROM lb.cm_log_complains INNER JOIN lb.cm_department_users ON cm_log_complains.info_to = lb.cm_department_users.section_id WHERE cm_department_users.user_id = ? AND cm_log_complains.status = 'P'";

            dbConnection.cmd.Parameters.AddWithValue("@userId", userId);

            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            cmLogComplains = dataAccessObject.ReadCollection<CmLogComplains>(dbConnection.dr);
            dbConnection.dr.Close();


            return cmLogComplains;
        }

        public List<CmLogComplains> ViewMoreCmLogComplains(DbConnection dbConnection, string compId)
        {
            List<CmLogComplains> cmLogComplains = new List<CmLogComplains>();
            dbConnection = new DbConnection();
            dbConnection.cmd.CommandText = "SELECT * FROM lb.cm_log_complains WHERE comp_id = ?";

            dbConnection.cmd.Parameters.AddWithValue("@comp_id", compId);

            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            cmLogComplains = dataAccessObject.ReadCollection<CmLogComplains>(dbConnection.dr);
            dbConnection.dr.Close();


            return cmLogComplains;
        }

       
      

       
    }
}
