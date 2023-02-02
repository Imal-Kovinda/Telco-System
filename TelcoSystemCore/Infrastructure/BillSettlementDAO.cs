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
    public interface IBillSettlementDAO
    {
        int Save(BillSettlement billSettlement, DbConnection dbConnection);
        int Update(BillSettlement billSettlement, DbConnection dbConnection);
        List<BillSettlement> GetBillSettlementDetailList(DbConnection dbConnection, string phoneNumber);
    }
    public class BillSettlementSqlDAOImpl : IBillSettlementDAO
    {
        public List<BillSettlement> GetBillSettlementDetailList(DbConnection dbConnection, string phoneNumber)
        {
            List<BillSettlement> billSettlementDetailList = new List<BillSettlement>();
            dbConnection = new DbConnection();
            //account id = "97015853000152"

            dbConnection.cmd.CommandText =
                "SELECT * FROM lb.bill_settlement INNER JOIN  lb.customer_account ON lb.bill_settlement.account_id = customer_account.account_id INNER JOIN lb.account_location ON customer_account.account_id = account_location.account_id INNER JOIN lb.customer_account_dn ON account_location.account_location_id = customer_account_dn.account_location_id WHERE customer_account_dn.account_dn = ?";

            dbConnection.cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);

            dbConnection.dr = dbConnection.cmd.ExecuteReader();

            DataAccessObject dataAccessObject = new DataAccessObject();

            billSettlementDetailList = dataAccessObject.ReadCollection<BillSettlement>(dbConnection.dr);
            dbConnection.dr.Close();

            return billSettlementDetailList;
        }

        public int Save(BillSettlement billSettlement, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public int Update(BillSettlement billSettlement, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }
    }
}
