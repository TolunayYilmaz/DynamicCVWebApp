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
        
        TalentUserManager userManager = new TalentUserManager();
        CommunicationManager communicationManager = new CommunicationManager();
       
        TalentManager talentManager= new TalentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            Label1.Text = userManager.GetListTalentCount(1).ToString();
            Label2.Text =communicationManager.MessageCount(1).ToString();

            Label3.Text = talentManager.AvarageGrade();
            Label5.Text=talentManager.MaxTalent();
            Label4.Text = talentManager.MaxGrade();
        }
    }
}