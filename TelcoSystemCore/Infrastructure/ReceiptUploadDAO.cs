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
    public interface IReceiptUploadDAO
    {
        int Save(ReceiptUpload receiptUpload, DbConnection dbConnection);
        ReceiptUpload GetReceiptUpload(DbConnection dbConnection, String accountId);



    }

    public class ReceiptUploadSqlDAOImpl : IReceiptUploadDAO
    {
        ReceiptUpload receiptUpload = new ReceiptUpload();
        public int Save(ReceiptUpload receiptUpload, DbConnection dbConnection)
        {
            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = " insert into lb.receipt_bulk_upload values(?,?,?,?) ";

            dbConnection.cmd.Parameters.AddWithValue("accountId", receiptUpload.accountId);
            dbConnection.cmd.Parameters.AddWithValue("amount", receiptUpload.amount);
            dbConnection.cmd.Parameters.AddWithValue("code", receiptUpload.code);
            dbConnection.cmd.Parameters.AddWithValue("batchNo", receiptUpload.batchNo);


            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());
            return output;

        }

        public ReceiptUpload GetReceiptUpload(DbConnection dbConnection, String accountId)
        {
            dbConnection.cmd.CommandText = "select * from lb.customer_account WHERE ACCOUNT_ID = '" + accountId + "'";
            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            receiptUpload = dataAccessObject.GetSingleOject<ReceiptUpload>(dbConnection.dr);
            dbConnection.dr.Close();
            return receiptUpload;

        }


    }




}
