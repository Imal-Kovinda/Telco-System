using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TelcoSystemCore.Domain;

namespace TelcoSystem
{
    public partial class ComplainDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadComplains();
        }

        //load data rows
        protected void loadComplains()
        {
            List<CmLogComplains> listCmLogComplains = null;

            listCmLogComplains = new List<CmLogComplains>();

            CmLogComplains cmLogComplains = new CmLogComplains();
            //complains.DataSource = cmLogComplains.GetCmLogComplainsList();

            //.Text = listCmLogComplains.CompId;



        }
        protected void makeComplain(object sender, EventArgs e)
        {

            Server.Transfer("Complain.aspx");
        }
    }
}