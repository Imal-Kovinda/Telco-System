using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TelcoSystemCore.Domain;
using TelcoSystemCore.Common;
using TelcoSystemCore.Controller;
using System.Security.Policy;

namespace TelcoSystem
{
    public partial class ComplainDashboard : System.Web.UI.Page
    {
        List<CmLogComplains> listCmLogComplains = new List<CmLogComplains>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDataSource();
            }
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
                
        }

        //load data rows
        protected void BindDataSource()
        {
            var userId = "LBEXAM";
            ICmLogComplainsController cmLogComplainsController = ControllerFactory.CreateCmLogComplainsDAO();
            listCmLogComplains = cmLogComplainsController.GetCmLogComplainsList(userId);
           
            GridView.DataSource = listCmLogComplains;
            GridView.DataBind();

        }
        protected void btnView_Click(object sender, EventArgs e)
        {
            //
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