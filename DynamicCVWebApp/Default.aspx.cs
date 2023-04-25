using EntityLayer.Entities;
using LogicLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicCVWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        AboutManager aboutManager = new AboutManager();
        TalentManager talentManager = new TalentManager();
        CommunicationManager communicationManager = new CommunicationManager();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            var about = aboutManager.AboutGetList();
            Repeater1.DataSource = about;
            Repeater1.DataBind();
            Repeater2.DataSource = about;
            Repeater2.DataBind();
            Repeater3.DataSource = about;
            Repeater3.DataBind();
            Repeater4.DataSource = talentManager.TalentGetList();
            Repeater4.DataBind();
        }

        protected void BtnSend(object sender, EventArgs e)
        {
            TblCommunication communication = new TblCommunication();
            communication.NameSurname = TextBox1.Text;
            communication.Mail = TextBox2.Text;
            communication.Subject = TextBox3.Text;
            communication.Message = TextBox4.Text;
            communicationManager.AddCommunucation(communication);


        }
    }
}