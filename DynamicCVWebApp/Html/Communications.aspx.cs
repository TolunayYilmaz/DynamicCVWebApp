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
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = communication.CommunucationGetList();
            Repeater1.DataBind();
        }
    }
}