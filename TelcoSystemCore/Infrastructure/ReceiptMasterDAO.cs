using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Domain;
using TelcoSystemCore.Common;
using DbConnection = TelcoSystemCore.Common.DbConnection;

namespace TelcoSystemCore.Infrastructure
{
    public interface IReceiptMasterDAO
    {
        int Save(Customer customer, DbConnection dbConnection);
        int Update(Customer customer, DbConnection dbConnection);
    }

    public class ReceiptMasterDAOSqlDAOImpl : IReceiptMasterDAO
    {
        public int Save(Customer customer, DbConnection dbConnection)
        {
            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = "Insert into Customer (RECEIPT_ID, RECEIPT_DATE, RECEIPT_NO, BRANCH_ID,PAYMENT_MODE_ID, LEDGER_CD, NARRATION, ADDED_BY, ADDED_ON, STATUS_OF_RECEIPT, POSTED, SEQ_NO, POSTED_CP, BANK_CODE, BANKING_DATE, MODIFIED_BY, MODIFIED_ON, CURRENCY_CODE, PROVISIONARY_REC_NUMBER, EMAIL_SENT, RECEIPT_CATEG) " +
                                                  "values (@RECEIPT_ID,@RECEIPT_DATE,@RECEIPT_NO,@BRANCH_ID,@PAYMENT_MODE_ID,@LEDGER_CD,@NARRATION, @ADDED_BY, @ADDED_ON, @STATUS_OF_RECEIPT, @POSTED, @SEQ_NO, @POSTED_CP, @BANK_CODE, @BANKING_DATE, @MODIFIED_BY, @MODIFIED_ON, @CURRENCY_CODE, @PROVISIONARY_REC_NUMBER, @EMAIL_SENT, @RECEIPT_CATEG) SELECT SCOPE_IDENTITY() ";


            dbConnection.cmd.Parameters.AddWithValue("@RECEIPT_ID", customer.CustomerId);
            dbConnection.cmd.Parameters.AddWithValue("@RECEIPT_DATE", customer.CustomerName);
            dbConnection.cmd.Parameters.AddWithValue("@RECEIPT_NO", customer.CustomerTypeId);
            dbConnection.cmd.Parameters.AddWithValue("@BRANCH_ID", customer.Title);
            dbConnection.cmd.Parameters.AddWithValue("@PAYMENT_MODE_ID", customer.ActivatedOn);
            dbConnection.cmd.Parameters.AddWithValue("@LEDGER_CD", customer.ActivatedBy);
            dbConnection.cmd.Parameters.AddWithValue("@NARRATION", customer.AddressLine1);
            dbConnection.cmd.Parameters.AddWithValue("@ADDED_BY", customer.AddressLine2);
            dbConnection.cmd.Parameters.AddWithValue("@ADDED_ON", customer.AddressLine3);
            dbConnection.cmd.Parameters.AddWithValue("@STATUS_OF_RECEIPT", customer.City);
            dbConnection.cmd.Parameters.AddWithValue("@POSTED", customer.PostalCode);
            dbConnection.cmd.Parameters.AddWithValue("@SEQ_NO", customer.ModifiedBy);
            dbConnection.cmd.Parameters.AddWithValue("@POSTED_CP", customer.ModifiedOn);
            dbConnection.cmd.Parameters.AddWithValue("@BANK_CODE", customer.ProfileStatus);
            dbConnection.cmd.Parameters.AddWithValue("@BANKING_DATE", customer.CpRemarks);
            dbConnection.cmd.Parameters.AddWithValue("@MODIFIED_BY", customer.District);
            dbConnection.cmd.Parameters.AddWithValue("@MODIFIED_ON", customer.Province);
            dbConnection.cmd.Parameters.AddWithValue("@CURRENCY_CODE", customer.CustGroup);
            dbConnection.cmd.Parameters.AddWithValue("@PROVISIONARY_REC_NUMBER", customer.CustRating);
            dbConnection.cmd.Parameters.AddWithValue("@EMAIL_SENT", customer.TopCustomerStat);
            dbConnection.cmd.Parameters.AddWithValue("@RECEIPT_CATEG", customer.Confidential);

            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            return output;

        }

        public int Update(Customer customer, DbConnection dbConnection)
        {
            throw new NotImplementedException();
        }
    }
}
