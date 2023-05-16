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
        private int aboutId;

       private readonly AboutManager about = new AboutManager();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            aboutId = Convert.ToInt32(Request.Cookies["aboutId"].Value);
            Repeater1.DataSource = about.AboutGet(aboutId);
            Repeater1.DataBind();
        }
    }
}