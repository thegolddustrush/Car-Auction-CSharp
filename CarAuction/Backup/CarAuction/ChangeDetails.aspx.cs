using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarAuction
{
    public partial class ChangeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //Creates a new instance of the webservice
            var service = new BiddingService.BiddingDataService();
            //Calls method and executes query
            var result = service.ChangeDetails(txtBoxName.Text, txtBoxSurname.Text, txtBoxEmail.Text,
                txtBoxQuestion.Text, txtBoxAnswer.Text, txtBoxPass.Text);
            if (result == true)
            {
                //Redirects you to the Home page
                Response.Redirect("~/Default.aspx");
            }
        }
    }
}