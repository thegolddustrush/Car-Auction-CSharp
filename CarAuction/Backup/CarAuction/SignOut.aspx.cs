using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace CarAuction
{
    public partial class SignOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Deletes sessions and Redirects you Home
            FormsAuthentication.SignOut();
            Response.Redirect("~/Default.aspx");
        }
    }
}