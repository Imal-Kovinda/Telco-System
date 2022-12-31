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
        
        //cmLogComplains
        public static ICmLogComplainsController CreateCmLogComplainsDAO()
        {
            ICmLogComplainsController cmLogComplainsController = new CmLogComplainsControllerImpl();
            return (ICmLogComplainsController)cmLogComplainsController;
        }

        //CustomerAccount
        public static ICustomerAccountController CreateCustomerAccountDetailController()
        {
            ICustomerAccountController customerAccountDetailController = new CustomerAccountControllerImpl();
            return (ICustomerAccountController)customerAccountDetailController;
        }

        //Additional data pack request
        public static IAdditionalDataPackRequestController CreateAdditionalDataPackRequestDetailController()
        {
            IAdditionalDataPackRequestController additionalDataPackRequestDetailController = new AdditionalDataPackRequestControllerImpl();
            return (IAdditionalDataPackRequestController)additionalDataPackRequestDetailController;
        }

        //account location
        public static IAccountLocationController CreateAccountLocationDetailController()
        {
            IAccountLocationController accountLocationDetailController = new AccountLocationControllerImpl();
            return (IAccountLocationController)accountLocationDetailController;
        }

        //location profile
        public static ILocationProfileController CreateLocationProfileDetailController()
        {
            ILocationProfileController locationProfileDetailController = new LocationProfileControllerImpl();
            return (ILocationProfileController)locationProfileDetailController;
        }


    }
}
