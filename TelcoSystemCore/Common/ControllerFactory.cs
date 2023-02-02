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

        public static IAccountBillingController CreateAccountBillingController()
        {
            IAccountBillingController accountBillingController = new AccountBillingControllerImpl();
            return (IAccountBillingController)accountBillingController;
        }

        public static IReceiptDetailsController CreateReceiptDetailsController()
        {
            IReceiptDetailsController receiptDetailsController = new ReceiptDetailsControllerImpl();
            return (IReceiptDetailsController)receiptDetailsController;
        }



        public static IPaymentTypeController CreatePaymentTypeController()
        {
            IPaymentTypeController paymentTypeController = new PaymentTypeControllerImpl();
            return (IPaymentTypeController)paymentTypeController;
        }

        public static IPnbsUsersController CreatePnbsUsersController()
        {
            IPnbsUsersController pnbsUsersController = new PnbsUsersControllerImpl();
            return (IPnbsUsersController)pnbsUsersController;
        }

        public static IPaymentModeController CreatePaymentModeController()
        {
            IPaymentModeController paymentModeController = new PaymentModeControllerImpl();
            return (IPaymentModeController)paymentModeController;
        }

        public static ICustomerAccountController CreateCustomerAccountController()
        {
            ICustomerAccountController customerAccountController = new CustomerAccountControllerImpl();
            return (ICustomerAccountController)customerAccountController;
        }

        public static ICusAccountDNController CreateCusAccountDNController()
        {
            ICusAccountDNController cusAccountDNController = new CusAccountDNControllerImpl();
            return (ICusAccountDNController)cusAccountDNController;
        }

        public static IReceiptUploadController CreateReceiptUploadController()
        {
            IReceiptUploadController receiptUploadController = new ReceiptUploadControllerImpl();
            return (IReceiptUploadController)receiptUploadController;
        }

        public static IDocumentCategoryController CretaeDocumentCategoryController()
        {
            IDocumentCategoryController documentCategoryController = new DocumentCategoryCpntrollerImpl();
            return (IDocumentCategoryController)documentCategoryController;
        }

    }
}
