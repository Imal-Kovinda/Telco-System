using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using TelcoSystemCore.Controller;
using Login = TelcoSystemCore.Domain.PnbsUsers;
using System.Security.Policy;

namespace TelcoSystem
{
    public partial class Login : System.Web.UI.Page
    {
        List<PnbsUsers> listPnbsUsers = new List<PnbsUsers>();
        //CompanyLoginController companyLoginController = ControllerFactory.CreateCompanyLoginController();
        //WarehouseControllerInterface warehouseController = ControllerFactory.CreateWarehouseController();
        //SubDepartmentControllerInterface subDepartmentController = ControllerFactory.userWarehouseController();

        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        if (Request.Cookies["UserNameA"] != null && Request.Cookies["PasswordA"] != null)
        //        {
        //            txtUserName.Text = Request.Cookies["UserNameA"].Value;
        //            txtPwd.Attributes["value"] = Request.Cookies["PasswordA"].Value;
        //        }
        //        else
        //        {
        //            txtUserName.Text = "";
        //            txtPwd.Attributes["value"] = null;
        //        }
        //    }

        //}




        [Obsolete]


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            IPnbsUsersController loginController = ControllerFactory.CreatePnbsUsersController();
            PnbsUsers pnbsUsers = new PnbsUsers();
            pnbsUsers.PnbsId = txtUserName.Text;
            pnbsUsers.Password = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "SHA1");

         
       

            pnbsUsers = loginController.GetPnbsUsers(pnbsUsers);

            if (pnbsUsers.PnbsId == "")
            {
                txtPassword.Text = string.Empty;
                lblErrorMsg.Text = "Incorrect Username or Password!";
            }
            else
            {
            //    Session["pnbs_userid"] = pnbsUsers.PnbsUserid;
            //    Session["role_name"] = pnbsUsers.RoleName;


            //    if (pnbsUsers.RoleName == "CASHIER")
            //        Response.Redirect("ComplainDashboard.aspx");
            //    else
            //        Response.Redirect("Dashboard.aspx");

            }
        }
        
    }
}
