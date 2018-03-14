using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace CarAuction
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            var service = new BiddingService.BiddingDataService();
            var result = service.Login(txtBoxLoginEmail.Text, txtBoxLoginPassword.Text);
            if (result == "Success!")
            {
                //Creates a session cookie
                FormsAuthentication.SetAuthCookie(txtBoxLoginEmail.Text, false);

                //Declares a session to greet user
                Session["Username"] = service.UserName(txtBoxLoginEmail.Text, txtBoxLoginPassword.Text);
                //Declares a session so the user may bid
                Session["UserId"] = service.GetUserID(txtBoxLoginEmail.Text, txtBoxLoginPassword.Text);
                //Redirects you to the Home page
                Response.Redirect("~/CarsBidded.aspx");
            }
            else
            {
                //Reports an error
                lblError.Text = "Your creditials are incorrect!";
            }
        }
    }
}