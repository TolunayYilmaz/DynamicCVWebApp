﻿using LogicLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicCVWebApp.Html
{
    public partial class Login : System.Web.UI.Page
    {
        UserManager userManager = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            if (userManager.LoginUser(userName.Text,password.Text))
            {
                Response.Redirect("Communications.aspx");
            }
            else
            {
                Response.Write("Hatalı Giriş");
            }
        }
    }
}