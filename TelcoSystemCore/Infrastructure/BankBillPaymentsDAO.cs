using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;

namespace TelcoSystemCore.Infrastructure
{
    public interface IBankBillPaymentsDAO
    {
        BankBillPayment PayBankBill(BankBillPayment bankBillPayment, DbConnection dbConnection);
    }

    public class BankBillPaymentsDAOPgSqlImpl : IBankBillPaymentsDAO
    {
        public BankBillPayment PayBankBill(BankBillPayment bankBillPayment, DbConnection dbConnection)
        {
            BankBillPayment bankBillPayment1 = new BankBillPayment();

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandText = "CALL pr_bank_bill_payment(@AccountCode, @Amount, @DocumentCategory, @PaymentType);";

            dbConnection.cmd.Parameters.AddWithValue("@AccountCode", bankBillPayment.AccountCode);
            dbConnection.cmd.Parameters.AddWithValue("@Amount", bankBillPayment.Amount);
            dbConnection.cmd.Parameters.AddWithValue("@DocumentCategory", bankBillPayment.DocumentCategory);
            dbConnection.cmd.Parameters.AddWithValue("@PaymentType", bankBillPayment.PaymentType);


            return bankBillPayment;
        }
    }
}
