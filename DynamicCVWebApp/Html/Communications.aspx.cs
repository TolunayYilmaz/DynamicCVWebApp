using LogicLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicCVWebApp.Html
{
    public partial class Communications : System.Web.UI.Page
    {
        CommunicationManager communication = new CommunicationManager();
        int userId;
        protected void Page_Load(object sender, EventArgs e)
        {
            userId = Convert.ToInt32(Request.Cookies["userId"].Value);
            Repeater1.DataSource = communication.CommunucationGetList(userId);
            Repeater1.DataBind();
        }
    }
}