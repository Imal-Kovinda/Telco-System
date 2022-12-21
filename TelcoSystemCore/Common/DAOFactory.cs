﻿using System;
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

    }
}
