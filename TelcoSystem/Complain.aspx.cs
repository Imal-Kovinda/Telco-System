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
    public partial class Complain : System.Web.UI.Page
    {
        List<Customer> listCustomer = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
         protected void backToDashboard(object sender, EventArgs e)
        {
            Server.Transfer("ComplainDashboard.aspx");
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

            account_address.Text = address;
            city.Text = listCustomer[0].City;
            customer_name.Text = listCustomer[0].CustomerName;
            nic.Text = listCustomer[0].NewIdNumber;

        }

        protected void Save_btn(object sender, EventArgs e)
        {
            //CustomerAccountDN custDn = new CustomerAccountDN();

            //user_code.Text = "Hello";
            //var accCode = acc_code.Text;
            //var lineType = line_type.Text;
            var onl = online.Text;
            var conState = connection_status.Text;
            var accRating = acc_rating.Text;
            var lineUsage = line_usage.Text;
            var totalAmt = total_amt.Text;
            //var loginName = login_name.Text;
            var fyRating = f_y_rating.Text.ToString();
            var Nic = nic.Text;
            var accCategory = account_category.Text;
            //var billMonth = bill_month.Text;
            var billRunDate = bill_run_date.Text;
            var billBalance =bill_balance.Text;
            var billStation = bill_station.Text;
            var creditLimit = credit_limit.Text;
            //var conc = concern.Text;
            var conactPerson = contact_person.Text;
            var Email = email.Text;
            //var nearestBD = nearest_bd.Text;
            var informedBy = informed_by.Text;
            //var cat = category.Text;
            //var comp = complain.Text;
       
            //var complainSubCategory = complain_sub_category.Text;
            var Fid = fid.Text;

            
            


        }
    }
}