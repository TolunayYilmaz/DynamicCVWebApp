using LogicLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicCVWebApp.Html
{
    public partial class Address : System.Web.UI.Page
    {
        private int addressId;
        AddressManager addressManager = new AddressManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            //  addressId = Convert.ToInt32(Session["addressId"]);
            addressId=Convert.ToByte(Request.Cookies["addressId"].Value);
            Repeater1.DataSource=addressManager.AddressGet(addressId);
            Repeater1.DataBind();
        }
    }
}