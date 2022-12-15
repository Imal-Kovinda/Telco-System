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

namespace TelcoSystem
{
    public partial class Login : System.Web.UI.Page
    {
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
        protected void login(object sender, EventArgs e)
        {
            //var user_name = userName.Text;
            //var pwd = password.Text;

            IPnbsUsersController loginController = ControllerFactory.CreatePnbsUsersController();
            TelcoSystemCore.Domain.PnbsUsers login = new TelcoSystemCore.Domain.PnbsUsers();
            login.PnbsId = userName.Text;
            login.Password = FormsAuthentication.HashPasswordForStoringInConfigFile(password.Text, "SHA1");
            if(loginController.GetPnbsUsers(login.PnbsId, login.Password))
            {
                login = loginController.GetPnbsUsers(login.PnbsId);

                Session["EMP_ID"] = login.EmpId;
                Session["Name"] = login.Name;
                Session["PNBS_ID"] = login.PnbsId;
                Session["NW_USERID"] = login.NwUserid;


                if (login.EmpId == 3)
                    Response.Redirect("ViewPaymentMemo.aspx");
                else
                    Response.Redirect("Dashboard.aspx");
            }
            else
            {
                password.Text = string.Empty;
            }
        }
    }
}
