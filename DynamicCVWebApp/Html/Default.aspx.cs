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
        //  TalentManager talentManager = new TalentManager();
        TalentUserManager talentUserManager =new TalentUserManager();
        CommunicationManager communicationManager = new CommunicationManager();
        public static string nameTitle;
        protected void Page_Load(object sender, EventArgs e)
        {
            var about = aboutManager.AboutGet(1);
            Repeater1.DataSource = about;
            Repeater1.DataBind();
            Repeater2.DataSource = about;
            Repeater2.DataBind();
            Repeater3.DataSource = about;
            Repeater3.DataBind();
            Repeater4.DataSource = talentUserManager.GetListTalent(1);
            Repeater4.DataBind();
            nameTitle = aboutManager.GetInfo(1);
            Page.Title = nameTitle;
              
         
        }

        protected void BtnSend(object sender, EventArgs e)
        {
            TblCommunication communication = new TblCommunication();
            communication.NameSurname = TextBox1.Text;
            communication.Mail = TextBox2.Text;
            communication.Subject = TextBox3.Text;
            communication.Message = TextBox4.Text;
             TextBox4.Text= communicationManager.AddCommunucation(communication);
            

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}