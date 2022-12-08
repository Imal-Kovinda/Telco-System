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
    public interface IBankBillPaymentController
    {
        int PayBankBill(BankBillPayment bankBillPayment);
    }

    public class BankBillPaymentControllerPgSqlImpl : IBankBillPaymentController
    {
        IBankBillPaymentsDAO bankBillPaymentsDAO = DAOFactory.CreateBankBillPaymentsDAO();

        public int PayBankBill(BankBillPayment bankBillPayment)
        {
            int Output = 0;
            DbConnection dbConnection = null;

            try
            {
                dbConnection = new DbConnection();
                bankBillPayment = bankBillPaymentsDAO.PayBankBill(bankBillPayment, dbConnection);

                if (bankBillPayment.ErrorMessage == null) { Output = 1; }
            }
            catch (Exception)
            {
                dbConnection.RollBack();
                throw;
            }
            finally
            {
                if (Output == 0)
                {
                    dbConnection.RollBack();
                }
                if (dbConnection.con.State == System.Data.ConnectionState.Open && Output == 1)
                {
                    dbConnection.Commit();
                }
            }
            return Output;
        }
    }
}
