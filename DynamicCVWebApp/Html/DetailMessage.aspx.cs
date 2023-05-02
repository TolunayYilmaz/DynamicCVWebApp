using LogicLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicCVWebApp.Html
{
    public partial class DetailMessage : System.Web.UI.Page
    {
        CommunicationManager communication = new CommunicationManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = int.Parse(Request.QueryString["ID"]);
             var com = communication.GetCommunication(Id);
             TxtMail.Text = com.Mail;
             TxtMessage.Text = com.Message;
             TxtNameSurname.Text = com.NameSurname;
             TxtSubject.Text = com.Subject;
          
        
        }
    }
}