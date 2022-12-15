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
        public static ICustomerController CreateCustomerDetailController()
        {
            ICustomerController customerDetailController = new CustomerControllerImpl();
            return (ICustomerController)customerDetailController;
        }

        public static IChequeDetailController CreateChequeDetailController()
        {
            IChequeDetailController chequeDetailController = new ChequeDetailControllerImpl();
            return (IChequeDetailController)chequeDetailController;
        }

        public static IBankBillPaymentController CreateBankBillPaymentController()
        {
            IBankBillPaymentController bankBillPaymentController = new BankBillPaymentControllerPgSqlImpl();
            return (IBankBillPaymentController)bankBillPaymentController;
        }

        //PnbsUsers
        public static IPnbsUsersController CreatePnbsUsersController()
        {
            IPnbsUsersController PnbsUsersController = new PnbsUsersControllerSqlImpl();
            return (IPnbsUsersController)PnbsUsersController;
        }
    }
}
