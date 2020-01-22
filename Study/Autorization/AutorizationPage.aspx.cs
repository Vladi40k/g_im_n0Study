using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Study.Autorization
{
    public partial class AutorizationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] as User != null)
                Response.Redirect("AutorizationRez.aspx");

        }

        protected void SingButton_Click(object sender, EventArgs e)
        {
            User user = new User(EmailBox.Text, PassBox.Text);
            
            ViewState["user"] = user;
            
            Session["user"] = user;
            Session.Timeout = 1;

            Response.Redirect("AutorizationRez.aspx");
        }

  
    }
}