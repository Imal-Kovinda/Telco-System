using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public static IChequeDetailDAO CreateChequeDetailDAO()
        {
            IChequeDetailDAO chequeDetailDAO = new ChequeDetailSqlDAOImpl();
            return (IChequeDetailDAO)chequeDetailDAO;
        }

        public static ILteLoginDAO CreateLteLoginDAO()
        {
            ILteLoginDAO lteLoginDAO = new LteloginPgSqlDAOImpl();
            return (ILteLoginDAO)lteLoginDAO;
        }

        public static IBankBillPaymentsDAO CreateBankBillPaymentsDAO()
        {
            IBankBillPaymentsDAO bankBillPaymentsDAO = new BankBillPaymentsDAOPgSqlImpl();
            return (IBankBillPaymentsDAO)bankBillPaymentsDAO;
        }

        public static IPnbsUsersDAO CreateGetPnbsUsersDAO()
        {
            IPnbsUsersDAO PnbsUsersDAO = new PnbsUsersSqlDAOImpl();
            return (IPnbsUsersDAO)PnbsUsersDAO;
        }

        //cmLogComplain
        public static ICmLogComplainsDAO CreateCmLogComplainsDAO()
        {
            ICmLogComplainsDAO CmLogComplainsDAO = new CmLogComplainsSqlDAOImpl();
            return (ICmLogComplainsDAO)CmLogComplainsDAO;
        }

        //CustomerAccount
        public static ICustomerAccountDAO CreateCustomerAccountDAO()
        {
            ICustomerAccountDAO customerAccountDAO = new CustomerAccountSqlDAOImpl();
            return (ICustomerAccountDAO)customerAccountDAO;
        }

        //Additional data pack request
        public static IAdditionalDataPackRequestDAO CreateAdditionalDataPackRequestDAO()
        {
            IAdditionalDataPackRequestDAO additionalDataPackRequestDAO = new AdditionalDataPackRequestSqlDAOImpl();
            return (IAdditionalDataPackRequestDAO)additionalDataPackRequestDAO;
        }

        //account location
        public static IAccountLocationDAO CreateAccountLocationDAO()
        {
            IAccountLocationDAO accountLocationDAO = new AccountLocationSqlDAOImpl();
            return (IAccountLocationDAO)accountLocationDAO;
        }

        //location profile
        public static ILocationProfileDAO CreateLocationProfileDAO()
        {
            ILocationProfileDAO locationProfileDAO = new LocationProfileSqlDAOImpl();
            return (ILocationProfileDAO)locationProfileDAO;
        }

    }
}
