using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarAuction.BiddingService;

namespace CarAuction
{
    public partial class LoginPg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtBoxLoginEmail.Text = "hoakld";
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            var service = new BiddingService.BiddingDataService();
            //var result = service.login(txtBoxEmail.Text,txtBoxLoginPassword.Text);
        }
        protected void TextBoxLoginPassword_TextChanged(object sender, EventArgs e)
        {

        }
        protected void txtBoxLoginEmail_TextChanged(object sender, EventArgs e)
        {

        }
}
}