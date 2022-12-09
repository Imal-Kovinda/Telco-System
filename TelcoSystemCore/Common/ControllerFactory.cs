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
        public static ICustomerController CreateCustomerController()
        {
            ICustomerController customerController = new CustomerControllerImpl();
            return (ICustomerController)customerController;
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


    }
}
