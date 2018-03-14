using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarAuction
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //Creates a new instance of the webservice
            var service = new BiddingService.BiddingDataService();

            //Calls method and executes query
            var x = service.ForgottenPassword(txtBoxRegisterNewPass.Text, txtBoxRegisterQuestion.Text,
               txtBoxRegisterAnswer.Text, txtBxRegisterEmail.Text);
            if (x == "Success!")
            {
                //Redirects to page
                Response.Redirect("~/Default.aspx");
            }

        }
    }
}