using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TelcoSystemCore.Common;
using TelcoSystemCore.Controller;
using TelcoSystemCore.Domain;

namespace TelcoSystem
{
    public partial class ViewComplains : System.Web.UI.Page
    {
        List<CmLogComplains> listCmLogComplains = new List<CmLogComplains>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewMore();
        }

        protected void ViewMore()
        {
            //LinkButton button = (LinkButton)sender;
            //string compid = button.CommandArgument;

            //ICmLogComplainsController cmLogComplainsController = ControllerFactory.CreateCmLogComplainsDAO();
            //listCmLogComplains = cmLogComplainsController.ViewMoreCmLogComplains(compid);

            //comp_id.Text = listCmLogComplains[0].CompId;
            //txn_date.Text = listCmLogComplains[0].TxnDate.ToString();
        }
        

        protected void backToDashboard(object sender, EventArgs e)
        {
            Server.Transfer("ComplainDashboard.aspx");
        }
    }
}