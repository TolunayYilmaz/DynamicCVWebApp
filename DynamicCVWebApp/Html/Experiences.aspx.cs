using LogicLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicCVWebApp
{
    public partial class Deneyimler : System.Web.UI.Page
    {
        
        AboutManager about = new AboutManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            int aboutId = Convert.ToInt32(Session["aboutId"]);
            Repeater1.DataSource = about.AboutGet(aboutId);
            Repeater1.DataBind();
        }
    }
}