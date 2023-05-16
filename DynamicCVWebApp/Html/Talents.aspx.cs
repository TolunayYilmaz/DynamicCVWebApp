using LogicLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicCVWebApp
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        TalentManager talent = new TalentManager();
        TalentUserManager user = new TalentUserManager();
        private int userId;
        protected void Page_Load(object sender, EventArgs e)
        {
            //  Repeater1.DataSource = talent.TalentGetList();
           // userId = Convert.ToInt32(Session["userId"]);
            userId = Convert.ToInt32(Request.Cookies["userId"].Value);
            Repeater1.DataSource = user.GetListTalent(userId);
            Repeater1.DataBind();
        }
    }
}