using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;

namespace TelcoSystemCore.Infrastructure
{
    public interface IChequeDetailDAO
    {
        int Save(ChequeDetail cheque, DbConnection dbConnection);
        int Update(ChequeDetail cheque, DbConnection dbConnection);
        List<ChequeDetail> GetChequeDetailList(DbConnection dbConnection, string ChequeQuery = null);
    }

    public class ChequeDetailSqlDAOImpl : IChequeDetailDAO
    {
        public int Save(ChequeDetail chequeDetail, DbConnection dbConnection)
        {
            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = "Insert into Customer (TRANSACTION_ID, RECEIPT_ID, CHEQUE_NO, CHEQUE_DATE,BANK_CD, BRANCH_NAME, RECEIVED_DOC_CATEG, RECEIVED_DOC_NO) " +
                                           "values (@TRANSACTION_ID,@RECEIPT_ID,@CHEQUE_NO,@CHEQUE_DATE,@BANK_CD,@BRANCH_NAME,@RECEIVED_DOC_CATEG, @RECEIVED_DOC_NO) SELECT SCOPE_IDENTITY() ";


            dbConnection.cmd.Parameters.AddWithValue("@TRANSACTION_ID", chequeDetail.TransactionId);
            dbConnection.cmd.Parameters.AddWithValue("@RECEIPT_ID", chequeDetail.ReceiptId);
            dbConnection.cmd.Parameters.AddWithValue("@CHEQUE_NO", chequeDetail.ChequeNo);
            dbConnection.cmd.Parameters.AddWithValue("@CHEQUE_DATE", chequeDetail.ChequeDate);
            dbConnection.cmd.Parameters.AddWithValue("@BANK_CD", chequeDetail.BankCd);
            dbConnection.cmd.Parameters.AddWithValue("@BRANCH_NAME", chequeDetail.BranchName);
            dbConnection.cmd.Parameters.AddWithValue("@RECEIVED_DOC_CATEG", chequeDetail.ReceivedDocCateg);
            dbConnection.cmd.Parameters.AddWithValue("@RECEIVED_DOC_NO", chequeDetail.ReceivedDocNo);

            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            return output;
        }

        public int Update(ChequeDetail chequeDetail, DbConnection dbConnection)
        {
            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = "Update Student set TRANSACTION_ID = @TRANSACTION_ID ,RECEIPT_ID = @RECEIPT_ID,CHEQUE_NO = @CHEQUE_NO,CHEQUE_DATE  = @CHEQUE_DATE ,BANK_CD = @BANK_CD, BRANCH_, NAME = @BRANCH_NAME, RECEIVED_DOC_CATEG = @RECEIVED_DOC_CATEG, RECEIVED_DOC_NO = @RECEIVED_DOC_NO WHERE TRANSACTION_ID = @TRANSACTION_ID ";

            dbConnection.cmd.Parameters.AddWithValue("@TRANSACTION_ID", chequeDetail.TransactionId);
            dbConnection.cmd.Parameters.AddWithValue("@RECEIPT_ID", chequeDetail.ReceiptId);
            dbConnection.cmd.Parameters.AddWithValue("@CHEQUE_NO", chequeDetail.ChequeNo);
            dbConnection.cmd.Parameters.AddWithValue("@CHEQUE_DATE", chequeDetail.ChequeDate);
            dbConnection.cmd.Parameters.AddWithValue("@BANK_CD", chequeDetail.BankCd);
            dbConnection.cmd.Parameters.AddWithValue("@BRANCH_NAME", chequeDetail.BranchName);
            dbConnection.cmd.Parameters.AddWithValue("@RECEIVED_DOC_CATEG", chequeDetail.ReceivedDocCateg);
            dbConnection.cmd.Parameters.AddWithValue("@RECEIVED_DOC_NO", chequeDetail.ReceivedDocNo);

            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            return output;

        }

        public List<ChequeDetail> GetChequeDetailList(DbConnection dbConnection)
        {
            List<ChequeDetail> chequeDetail = new List<ChequeDetail>();
            dbConnection = new DbConnection();
            dbConnection.cmd.CommandText = "select * from ChequeDetail";

            dbConnection.dr = dbConnection.cmd.ExecuteReader();
            DataAccessObject dataAccessObject = new DataAccessObject();
            chequeDetail = dataAccessObject.ReadCollection<ChequeDetail>(dbConnection.dr);
            dbConnection.dr.Close();


            return chequeDetail;
        }

        public List<ChequeDetail> GetChequeDetailList(DbConnection dbConnection, string ChequeQuery = null)
        {
            throw new NotImplementedException();
        }
    }
}
