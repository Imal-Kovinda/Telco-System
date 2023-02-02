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
    public interface IReceiptDetailsController
    {
        int Save(ReceiptDetails receiptDetails);
        List<ReceiptDetails> GetReceiptDetailTypes();
    }

    public class ReceiptDetailsControllerImpl : IReceiptDetailsController
    {

        IReceiptDetailsDAO receiptDetailsDAO = DAOFactory.CreateReceiptDetailsDAO();

        public List<ReceiptDetails> GetReceiptDetailTypes()
        {
            DbConnection dbConnection = null;
            List<ReceiptDetails> listReceiptDetails = new List<ReceiptDetails>();
            try
            {
                dbConnection = new DbConnection();
                listReceiptDetails = receiptDetailsDAO.GetReceiptDetails(dbConnection);
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
            return listReceiptDetails;
        }

        public int Save(ReceiptDetails receiptDetails)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return receiptDetailsDAO.Save(receiptDetails, dbConnection);
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
