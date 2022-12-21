using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TelcoSystemCore.Controller;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;

namespace TelcoSystem
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        List<Customer> listCustomer = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void FilledUp(object sender, EventArgs e)
        {
            var pNumber = service_number.Text;
            //user_code.Text = "Hello";

            ICustomerController customerController = ControllerFactory.CreateCustomerDetailController();
            listCustomer = customerController.GetCustomerDetailList(pNumber);

            var ad1 = listCustomer[0].AddressLine1;
            var ad2 = listCustomer[0].AddressLine2;
            var ad3 = listCustomer[0].AddressLine3;

            var address = ad1 + ", " + ad2 + ", " + ad3;

            accountAddress.Text = address;
            city.Text = listCustomer[0].City;
            customer_name.Text = listCustomer[0].CustomerName;
            nic.Text = listCustomer[0].NewIdNumber;

        }

        protected void Save_btn(object sender, EventArgs e)
        {
            user_code.Text = "Hello";
        }
    }
}