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
    public interface IDirectoryNumbersDAO
    {
        int Save(DirectoryNumbers dn, DbConnection dbConnection);
        int Update(DirectoryNumbers dn, DbConnection dbConnection);
        List<DirectoryNumbers> GetCustomerList(DbConnection dbConnection, string phoneNumber);
    }

    public class DirectoryNumbersDAOImpl : IDirectoryNumbersDAO
    {
        public List<DirectoryNumbers> GetCustomerList(DbConnection dbConnection, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public int Save(DirectoryNumbers dn, DbConnection dbConnection)
        {
            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = "Insert into DIRECTORY_NUMBERS (RBS_RBS_CODE, SERVICE_NUMBER, CATEGORY, AVAILABLE_FROM,VALID_UNTIL, DC_DN_CATEGORY_CODE, DN_STATUS, GENERATED_BY, CA_AREA_CODE, VANITY_TYPE, SWITCH_TYPE, PRE_PAID, UNIT_ASSIGN, OG_FREE_MINUTES, SWITCH_ID) " +
                                                  "values (@RBS_RBS_CODE,@SERVICE_NUMBER,@CATEGORY,@AVAILABLE_FROM,@VALID_UNTIL,@DC_DN_CATEGORY_CODE,@DN_STATUS, @GENERATED_BY, @CA_AREA_CODE, @VANITY_TYPE, @SWITCH_TYPE, @PRE_PAID, @UNIT_ASSIGN, @OG_FREE_MINUTES, @SWITCH_ID) SELECT SCOPE_IDENTITY() ";


            dbConnection.cmd.Parameters.AddWithValue("@RBS_RBS_CODE", dn.RbsRbsCode);
            dbConnection.cmd.Parameters.AddWithValue("@SERVICE_NUMBER", dn.ServiceNumber);
            dbConnection.cmd.Parameters.AddWithValue("@CATEGORY", dn.Category);
            dbConnection.cmd.Parameters.AddWithValue("@AVAILABLE_FROM", dn.AvailableFrom);
            dbConnection.cmd.Parameters.AddWithValue("@VALID_UNTIL", dn.ValidUntil);
            dbConnection.cmd.Parameters.AddWithValue("@DC_DN_CATEGORY_CODE", dn.DcDnCategoryCode);
            dbConnection.cmd.Parameters.AddWithValue("@DN_STATUS", dn.DnStatus);
            dbConnection.cmd.Parameters.AddWithValue("@GENERATED_BY", dn.GeneratedBy);
            dbConnection.cmd.Parameters.AddWithValue("@CA_AREA_CODE", dn.CaAreaCode);
            dbConnection.cmd.Parameters.AddWithValue("@VANITY_TYPE", dn.VanityType);
            dbConnection.cmd.Parameters.AddWithValue("@SWITCH_TYPE", dn.SwitchType);
            dbConnection.cmd.Parameters.AddWithValue("@PRE_PAID", dn.PrePaid);
            dbConnection.cmd.Parameters.AddWithValue("@UNIT_ASSIGN", dn.UnitAssign);
            dbConnection.cmd.Parameters.AddWithValue("@OG_FREE_MINUTES", dn.OgFreeMinutes);
            dbConnection.cmd.Parameters.AddWithValue("@SWITCH_ID", dn.SwitchId);



            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            return output;
        }

        public int Update(DirectoryNumbers dn, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }
    }
}
