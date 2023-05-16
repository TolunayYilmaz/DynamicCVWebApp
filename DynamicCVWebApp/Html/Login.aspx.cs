using LogicLayer.Concrete;
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
        private readonly UserManager userManager = new UserManager();


        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Login " + Default.nameTitle;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (userManager.LoginUser(userName.Text, password.Text))
            {
                int aboutId = userManager.AboutId;
                byte addressId = userManager.AddressId;
                int userId = userManager.UserId;
                HttpCookie aboutIdCookie = new HttpCookie("aboutId", aboutId.ToString());
                HttpCookie addressIdCookie = new HttpCookie("addressId", addressId.ToString());
                HttpCookie userIdCookie = new HttpCookie("userId", userId.ToString());
                Response.Cookies.Add(aboutIdCookie);
                Response.Cookies.Add(addressIdCookie);
                Response.Cookies.Add(userIdCookie);

                Response.Redirect("Experiences.aspx");
            }
            else
            {
                Response.Write("Hatalı Giriş");
            }
        }
    }
}