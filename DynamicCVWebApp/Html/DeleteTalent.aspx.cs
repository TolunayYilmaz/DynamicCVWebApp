using LogicLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicCVWebApp.Html
{
    public partial class DeleteTalent : System.Web.UI.Page
    {
        TalentManager talent = new TalentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            talent.DeleteTalent(x);
            Response.Redirect("Talents.aspx");
        }
    }
}