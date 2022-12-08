using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Controller;

namespace TelcoSystemCore.Common
{
    public class ControllerFactory
    {
        public static ILteLoginController CreateLteLoginController()
        {
            ILteLoginController lteLoginController = new LteLoginControllerPgSqlImpl();
            return (ILteLoginController)lteLoginController;
        }

        public static IBankBillPaymentController CreateBankBillPaymentController()
        {
            IBankBillPaymentController bankBillPaymentController = new BankBillPaymentControllerPgSqlImpl();
            return (IBankBillPaymentController)bankBillPaymentController;
        }
    }
}
