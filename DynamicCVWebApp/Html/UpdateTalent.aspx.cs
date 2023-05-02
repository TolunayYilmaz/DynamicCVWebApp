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
    public partial class UpdateTalent : System.Web.UI.Page
    {
        TalentManager talentManager = new TalentManager();
        int x;
        protected void Page_Load(object sender, EventArgs e)
        {
           x = int.Parse(Request.QueryString["ID"]);
            if (Page.IsPostBack == false)
            {
                txtTalent.Text = talentManager.GetTalent(x).Talent;
            }
          
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
           
            TblTalent talent = new TblTalent();
            talent.Talent = txtTalent.Text;
            talentManager.UpdateTalent(x, talent);
            Response.Redirect("Talents.aspx");
        }
    }
}