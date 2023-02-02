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
        List<PnbsMenuRolesUsers> listUserRoles = new List<PnbsMenuRolesUsers>();
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
            //IPnbsUsersController loginController = ControllerFactory.CreatePnbsUsersController();
            PnbsUsers pnbsUsers = new PnbsUsers();
            pnbsUsers.PnbsId = txtUserName.Text;
            pnbsUsers.Password = txtPassword.Text;
            //pnbsUsers.Password = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "SHA1");



            IPnbsUsersController login = ControllerFactory.CreatePnbsUsersController();
            var result = login.GetPnbsUsers(pnbsUsers);

            //get user role
            PnbsMenuRolesUsers MenuRole = new PnbsMenuRolesUsers();
            MenuRole.PnbsUserid = txtUserName.Text;

            IPnbsMenuRolesUsersController getUserRole = ControllerFactory.CreatePnbsMenuRolesUsersDetailController();
            listUserRoles = getUserRole.GetPnbsMenuRolesUsersDetailList(MenuRole);

            MenuRole.RoleName = listUserRoles[0].RoleName;
            

            //pnbsUsers = loginController.GetPnbsUsers(pnbsUsers);

            if (result > 0)
            {
                //txtPassword.Text = string.Empty;
                //lblErrorMsg.Text = "Incorrect Username or Password!";
                Session["pnbs_id"] = pnbsUsers.PnbsId;
                //Session["User_Role_Id"] = userLogin.UserRoleId;

                //Response.Redirect("ComplainDashboard.aspx");
                Response.Redirect("ComplainDashboard.aspx?id=" + Session["pnbs_id"]);

            }
            else
            {
               
                Response.Redirect("Login.aspx");
                txtUserName.Text = string.Empty;
                txtPassword.Text = string.Empty;


            }
        }
        
    }
}
