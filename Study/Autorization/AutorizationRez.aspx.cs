using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Study.Autorization
{
    public partial class AutorizationRez : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = Session["user"] as User;
           
            if (user != null && CheckUser.Check_Stday(user))
                Rezultat.Text = "OK";

        }

        protected void LoOutButton_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Response.Cookies["user"];
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);

            Session["user"] = null;

            Response.Redirect("AutorizationPage.aspx");
        }
    }
}