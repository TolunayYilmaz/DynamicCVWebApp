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
    public partial class SignIn : System.Web.UI.Page
    {
        UserManager userManager =new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            TblUsers users = new TblUsers();
            users.UserName = txtUserName.Text;
            users.Password = txtPassword.Text;
           lblInfo.Text=userManager.SignInUser(users, txtPassword2.Text);
        }


   
    }
}