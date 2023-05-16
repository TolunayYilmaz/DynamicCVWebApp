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
        //TalentManager talent = new TalentManager();
        TalentUserManager talentUserManager = new TalentUserManager();
        int talentId;
        protected void Page_Load(object sender, EventArgs e)
        {
            talentId = int.Parse(Request.QueryString["ID"]);
            talentUserManager.DelteTalentUser(talentId);
            Response.Redirect("Talents.aspx");
        }
    }
}