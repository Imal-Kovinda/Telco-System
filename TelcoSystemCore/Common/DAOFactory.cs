using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Domain;
using TelcoSystemCore.Infrastructure;

namespace TelcoSystemCore.Common
{
    public class DAOFactory
    {
        public static ICustomerDAO CreateCustomerDAO()
        {
            ICustomerDAO customerDAO = new CustomerSqlDAOImpl();
            return (ICustomerDAO)customerDAO;
        }

        public static IReceiptDetailsDAO CreateReceiptDetailsDAO()
        {
            IReceiptDetailsDAO receiptDetailsDAO = new ReceiptDetailsSqlDAOImpl();
            return (IReceiptDetailsDAO)receiptDetailsDAO;
        }

        public static IAccountBillingDAO CreateAccountBillingDAO()
        {
            IAccountBillingDAO accountBillingDAO = new AccountBillingSqlDAOImpl();
            return (IAccountBillingDAO)accountBillingDAO;
        }

        public static IPaymentTypeDAO CreatePaymentTypeDAO()
        {
            IPaymentTypeDAO paymentTypeDAO = new PaymentTypeSqlDAOImpl();
            return (IPaymentTypeDAO)paymentTypeDAO;
        }

        public static IPnbsUsersDAO CreatePnbsUsersDAO()
        {
            IPnbsUsersDAO pnbsUsersDAO = new PnbsUsersSqlDAOImpl();
            return (IPnbsUsersDAO)pnbsUsersDAO;
        }

        public static IPaymentModeDAO CreatePaymentModeDAO()
        {
            IPaymentModeDAO paymentModeDAO = new PaymentModeSqlDAOImpl();
            return (IPaymentModeDAO)paymentModeDAO;
        }

        public static ICustomerAccountDAO CreateCustomerAccountDAO()
        {
            ICustomerAccountDAO customerAccountDAO = new CustomerAccountSqlDAOImpl();
            return (ICustomerAccountDAO)customerAccountDAO;
        }

        public static ICusAccountDNDAO CreateCusAccountDNDAO()
        {
            ICusAccountDNDAO cusAccountDNDAO = new CusAccountDNSqlDAOImpl();
            return (ICusAccountDNDAO)cusAccountDNDAO;
        }

        public static IReceiptUploadDAO CreateReceiptUploadDAO()
        {
            IReceiptUploadDAO receiptUploadDAO = new ReceiptUploadSqlDAOImpl();
            return (IReceiptUploadDAO)receiptUploadDAO;

        }

        public static IDocumentCategoryDAO CreateDocumentCategoryDAO()
        {
            IDocumentCategoryDAO documentCategoryDAO = new DocumentCategorySqlDAOImpl();
            return (IDocumentCategoryDAO)documentCategoryDAO;
        }




    }
}
