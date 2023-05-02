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
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = talent.TalentGetList();
            Repeater1.DataBind();
        }
    }
}