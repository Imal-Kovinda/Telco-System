using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using DbConnection = TelcoSystemCore.Common.DbConnection;

namespace TelcoSystemCore.Infrastructure
{
    public interface IReceiptDetailsDAO
    {
        int Save(ReceiptDetails receiptDetails, DbConnection dbConnection);
        List<ReceiptDetails> GetReceiptDetails(DbConnection dbConnection);
    }

    public class ReceiptDetailsSqlDAOImpl : IReceiptDetailsDAO
    {
        public List<ReceiptDetails> GetReceiptDetails(DbConnection dbConnection)
        {
            List<ReceiptDetails> ListReceiptDetails = new List<ReceiptDetails>();

            dbConnection = new DbConnection();

            dbConnection.cmd.CommandText = "select * from ";
            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            ListReceiptDetails = dataAccessObject.ReadCollection<ReceiptDetails>(dbConnection.dr);
            dbConnection.dr.Close();

            return ListReceiptDetails;
        }

        public int Save(ReceiptDetails receiptDetails, DbConnection dbConnection)
        {
            string receiptNumber = string.Empty;
            int output = 0;


            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = "Call lb.pr_bank_bill_payment_new( ? , ? , ? ,? , 'receiption' , ? , ? )";
            dbConnection.cmd.CommandType = CommandType.StoredProcedure;

            dbConnection.cmd.Parameters.AddWithValue("accountId", OdbcType.VarChar).Value = receiptDetails.accountId;
            dbConnection.cmd.Parameters.AddWithValue("amount", OdbcType.Numeric).Value = receiptDetails.amount;
            dbConnection.cmd.Parameters.AddWithValue("category", OdbcType.VarChar).Value = receiptDetails.category;
            dbConnection.cmd.Parameters.AddWithValue("payTypeId", OdbcType.VarChar).Value = receiptDetails.payTypeId;

            dbConnection.cmd.Parameters.AddWithValue("receiptNo", OdbcType.Numeric);
            dbConnection.cmd.Parameters["receiptNo"].Direction = ParameterDirection.Output;
            dbConnection.cmd.Parameters.AddWithValue("errMsg", OdbcType.VarChar).Value = receiptDetails.payTypeId;

            //dbConnection.cmd.Parameters.AddWithValue("errMsg", OdbcType.VarChar);
            //dbConnection.cmd.Parameters["errMsg"].Direction = ParameterDirection.Output;

            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());
            return output;
            receiptNumber = (string)dbConnection.cmd.Parameters["receiptNo"].Value;
            receiptDetails.receiptNo = receiptNumber;


        }

    }




}
