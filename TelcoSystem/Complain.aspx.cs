using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TelcoSystemCore.Controller;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using System.Security.Policy;

namespace TelcoSystem
{
    public partial class Complain : System.Web.UI.Page
    {
        List<Customer> listCustomer = new List<Customer>();
        List<CustomerAccount> listCustomerAccount = new List<CustomerAccount>();
        List<AccountLocation> listAccountLocation = new List<AccountLocation>();
        

        //ICustomerController customerController = ControllerFactory.CreateCustomerDetailController();
        //Customer customer = new Customer();

        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void customerDetails_TextChanged(object sender, EventArgs e)
        {
            if (service_number.Text != "")
            {
                var test = service_number.Text;
                var phone = test.ToString();
                ICustomerController customerController = ControllerFactory.CreateCustomerDetailController();
                listCustomer = customerController.GetCustomerDetailList(phone);
                //listCustomer = customerController.GetCustomerDetailList(service_number.Text);
                ICustomerAccountController customerAccountController = ControllerFactory.CreateCustomerAccountDetailController();
                listCustomerAccount = customerAccountController.GetCustomerAccountDetailList(phone);
                //account location
                IAccountLocationController accountLocationController = ControllerFactory.CreateAccountLocationDetailController();
                listAccountLocation = accountLocationController.GetAccountLocationDetailList(phone);
                


                if (listCustomer[0].CustomerId != "" || listCustomer[0].CustomerId != null)
                {
                    
                    //customer
                    customer_name.Text = listCustomer[0].CustomerName;
                    customer_id.Text = listCustomer[0].CustomerId;

                    //customerAccount
                   
                    acc_code.Text = listCustomerAccount[0].AccountId;

                    var ad1 = listCustomerAccount[0].AddressLine1;
                    var ad2 = listCustomerAccount[0].AddressLine2;
                    var ad3 = listCustomerAccount[0].AddressLine3;

                    var address = ad1 + ", " + ad2 + ", " + ad3;

                    account_address.Text = address;

                    city.Text = listCustomerAccount[0].City;

                    //additional data pack request
                    user_code.Text = listAccountLocation[0].AccountLocationId;

                }
            }

        }
 

        protected void Save_btn(object sender, EventArgs e)
        {
            //CustomerAccountDN custDn = new CustomerAccountDN();

            //var onl = online.Text;
            var conState = connection_status.Text;
            var accRating = acc_rating.Text;
            var lineUsage = line_usage.Text;
            
            var fyRating = f_y_rating.Text.ToString();
            var accCategory = account_category.Text;
            
            var billBalance =bill_balance.Text;
            var creditLimit = credit_limit.Text;
            var conc = concern.Text;
            var conactPerson = contact_person.Text;
            var contactNum = contact_number.Text;
            var Email = email.Text;
            //var nearestBD = nearest_bd.Text;
            BindNearestBO();
            var informedBy = informed_by.Text;
            //var cat = category.Text;
            //var comp = complain.Text;
       
            //var complainSubCategory = complain_sub_category.Text;
            var Fid = fid.Text;

            //var bound
            //var follow_up


        }
        private void BindNearestBO()
        {
            ILocationProfileController locationProfileController = ControllerFactory.CreateLocationProfileDetailController();
      
            ddlNearestBd.DataSource = locationProfileController.GetLocationProfileDetailList();
            ddlNearestBd.DataValueField = "locat_cd";
            ddlNearestBd.DataValueField = "locat_name";

            ddlNearestBd.DataBind();
        }

        protected void GoToDashboard(object sender, EventArgs e)
        {
            //Server.Transfer("ComplainDashboard.aspx");
        }
    }
}