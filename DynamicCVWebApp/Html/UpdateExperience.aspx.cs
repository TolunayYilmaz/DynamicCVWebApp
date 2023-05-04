using EntityLayer.Entities;
using LogicLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicCVWebApp.Html
{
    public partial class UpdateExperience : System.Web.UI.Page
    {  
        AboutManager about = new AboutManager();
        int x;
        protected void Page_Load(object sender, EventArgs e)
        {
            x = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                txtExperience.Text = about.GetExperience(x);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            TblAbout experience = new TblAbout();
            experience.Experience = txtExperience.Text;
            about.UpdateExperience(x, experience);
            Response.Redirect("Experiences.aspx");
        }
    }
}