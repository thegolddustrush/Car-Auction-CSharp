using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using CarAuction.BiddingService;
using System.Web.Services;

namespace CarAuction
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //Redirects you if there is no session
                if (Session["UserId"] == null)
                {
                    FormsAuthentication.SignOut();
                    Response.Redirect("~/Default.aspx");
                }
            }

            //Checks if the user is Authenticated before the Url Changes
            bool Check = System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            if (Check != true)
            {
                CarLink.NavigateUrl = "~/Registration.aspx";

            }
            else
            {
                //Ensures User is logged out
                if (Session["UserId"] == null) {
                    FormsAuthentication.SignOut();
                    Response.Redirect("~/Default.aspx");
                }
                CarLink.NavigateUrl = "~/CarsAvailable.aspx";
                //Finds Control to greet user
                Label lbl1 = (Label)(LoginViewSignIn.FindControl("lblGreetUser"));

                //Greets user
                string Name = Session["Username"] == null ? string.Empty : Session["Username"].ToString();
                lbl1.Text = "Welcome " + Name + "!";
            }
        }

        protected void btnClick(object sender, EventArgs e) { 

        }
    }
}
