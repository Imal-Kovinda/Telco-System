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
    public interface IReceiptUploadController
    {
        int Save(ReceiptUpload receiptUpload);

        ReceiptUpload GetReceiptUpload(string accountId);
    }

    public class ReceiptUploadControllerImpl : IReceiptUploadController
    {
        IReceiptUploadDAO receiptUploadDAO = DAOFactory.CreateReceiptUploadDAO();

        public int Save(ReceiptUpload receiptUpload)
        {
            DbConnection dbConnection = null;
            try
            {
                dbConnection = new DbConnection();
                return receiptUploadDAO.Save(receiptUpload, dbConnection);
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


        public ReceiptUpload GetReceiptUpload(String accountId)
        {
            DbConnection dbConnection = null;
            ReceiptUpload receiptUpload = new ReceiptUpload();
            try
            {
                dbConnection = new DbConnection();
                receiptUpload = receiptUploadDAO.GetReceiptUpload(dbConnection, accountId);
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
            return receiptUpload;
        }


    }



}
