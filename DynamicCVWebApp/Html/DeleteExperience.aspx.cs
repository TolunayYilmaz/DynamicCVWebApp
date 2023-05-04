using LogicLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicCVWebApp.Html
{
    public partial class DeleteExperience : System.Web.UI.Page
    {
        AboutManager about = new AboutManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            about.AboutExprienceDelete(x);
            Response.Redirect("Experiences.aspx");

        }
    }
}