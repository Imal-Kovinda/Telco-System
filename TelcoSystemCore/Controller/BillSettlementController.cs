using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using TelcoSystemCore.Infrastructure;

namespace TelcoSystemCore.Controller
{
    public interface IBillSettlementController
    {
        int Save(BillSettlement billSettlement);
        int Update(BillSettlement billSettlement);
        //List<BillSettlement> GetBillSettlementList(string CustomQuery = null);

        List<BillSettlement> GetBillSettlementDetailList(string phoneNumber);
    }
    public class BillSettlementControllerImpl : IBillSettlementController
    {
        IBillSettlementDAO billSettlementDAO = DAOFactory.CreateBillSettlementDAO();

        public List<BillSettlement> GetBillSettlementDetailList(string phoneNumber)
        {
            DbConnection dbConnection = null;
            List<BillSettlement> listDetail = new List<BillSettlement>();

            try
            {

                dbConnection = new DbConnection();


                if (phoneNumber != null)
                {

                    return billSettlementDAO.GetBillSettlementDetailList(dbConnection, phoneNumber);
                }

            }
            catch (Exception)
            {
                dbConnection.RollBack();
                throw;
            }
            finally
            {
                if (dbConnection.con.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Commit();
                }
            }
            return listDetail;
        }
        public int Save(BillSettlement billSettlement)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return billSettlementDAO.Save(billSettlement, dbConnection);
            }
            catch (Exception)
            {
                dbConnection.RollBack();
                throw;
            }
            finally
            {
                if (dbConnection.con.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Commit();
                }
            }


        }
        public int Update(BillSettlement billSettlement)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return billSettlementDAO.Update(billSettlement, dbConnection);
            }
            catch (Exception)
            {
                dbConnection.RollBack();
                throw;
            }
            finally
            {
                if (dbConnection.con.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Commit();
                }
            }
        }

    }

}
