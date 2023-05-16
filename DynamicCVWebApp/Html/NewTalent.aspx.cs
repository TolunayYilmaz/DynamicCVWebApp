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
        private readonly TalentManager talentManager = new TalentManager();
        private readonly TalentUserManager userManager = new TalentUserManager();
        private int userId;
        protected void Page_Load(object sender, EventArgs e)
        {
            userId= Convert.ToInt32(Request.Cookies["userId"].Value);
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {

            TblTalent talent = new TblTalent()
            {
                Talent= txtTalent.Text
            };
           
            talentManager.AddTalent(talent);
            int talentId = talentManager.LastGetTalent().Id;
            userManager.AddTalentUser(talentId, userId);
            Response.Redirect("Talents.aspx");
        }
    }
}