using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarAuction
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //Creates a new instance of the webservice
            var service = new BiddingService.BiddingDataService();

            //Calls method and executes query
            var result = service.AddUser(txtBoxName.Text, txtBoxSurname.Text, txtBoxEmail.Text, txtBoxPass.Text,
                txtBoxQuestion.Text, txtDate.Text, txtBoxAnswer.Text);

            if (result == "Successful")
            {
                Response.Redirect("~/CarsAvailable.aspx");
            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
        }
    }
}