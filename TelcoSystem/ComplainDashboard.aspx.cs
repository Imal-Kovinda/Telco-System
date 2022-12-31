using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TelcoSystemCore.Domain;
using TelcoSystemCore.Common;
using TelcoSystemCore.Controller;

namespace TelcoSystem
{
    public partial class ComplainDashboard : System.Web.UI.Page
    {
        List<CmLogComplains> listCmLogComplains = new List<CmLogComplains>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["user_id"]== null)
            //{
            //    Response.Redirect("Login.aspx");
            //}
            //else
            //{
            //    if (Session["User_Role_Id"].ToString() == "1" || Session["User_Role_Id"].ToString() == "2")
            //    {
            //        BindDataSource();
            //    }
            //    else
            //    {
            //        Response.Redirect("404.aspx");
            //    }
            //}
            BindDataSource();
        }

        //load data rows
        protected void BindDataSource()
        {

            //ICmLogComplainsController cmLogComplainsController = ControllerFactory.CreateCmLogComplainsDAO();
            //listCmLogComplains = cmLogComplainsController.GetCmLogComplainsList();
            //GridView.DataSource = listCmLogComplains;
            //GridView.DataBind();

        }
        protected void makeComplain(object sender, EventArgs e)
        {

            Server.Transfer("Complain.aspx");
        }

        protected void btn_view_click(object sender, EventArgs e)
        {
            Server.Transfer("ViewComplains.aspx");
        }
    }
}