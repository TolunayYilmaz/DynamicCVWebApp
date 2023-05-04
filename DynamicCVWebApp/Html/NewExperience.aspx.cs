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
    public partial class NewExperience : System.Web.UI.Page
    {
        AboutManager aboutData =new AboutManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            TblAbout about = new TblAbout();
            about.Experience = txtExperience.Text;
            if (aboutData.AddAboutExperience(about))
            {
                Response.Redirect("Experiences.aspx");
            }
            else
            {
                txtExperience.Text = "Lütfen 50 karakterden fazla metin girişi yapınız.";
            }
        }
    }
}