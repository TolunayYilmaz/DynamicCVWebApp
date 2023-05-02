using LogicLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicCVWebApp.Html
{
    public partial class Statistics : System.Web.UI.Page
    {
        TalentManager manager = new TalentManager();
        AboutManager aboutManager = new AboutManager(); 
        TalentManager talentManager= new TalentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = manager.TalentGetList().Count.ToString();
            Label2.Text=aboutManager.AboutGetList().Count.ToString();
            Label3.Text = talentManager.AvarageGrade();
            Label5.Text=talentManager.MaxTalent();
            Label4.Text = talentManager.MaxGrade();
        }
    }
}