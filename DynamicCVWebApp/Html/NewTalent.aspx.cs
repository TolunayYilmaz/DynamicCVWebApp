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
    public partial class NewTalent : System.Web.UI.Page
    {
        TalentManager talentManager = new TalentManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnİnsert_Click(object sender, EventArgs e)
        {
            TblTalent talent = new TblTalent();
            talent.Talent=txtTalent.Text;
            talentManager.AddTalent(talent);
            Response.Redirect("Talents.aspx");
        }
    }
}