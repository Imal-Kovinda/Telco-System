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


    }
}
