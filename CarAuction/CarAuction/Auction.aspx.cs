using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using CarAuction.Code;

namespace CarAuction
{
    public partial class Auction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtBoxUserID.Text = Session["UserId"] == null ? string.Empty : Session["UserId"].ToString();
            txtBoxUserID.ReadOnly = true;
            if (Request.QueryString["CarID"] != null)
            {
                
                var VehicleID = Request.QueryString["CarID"].ToString();

                if (Request.QueryString["CarID"] == null)
                {

                }
                VehicleID = Request.QueryString["CarID"] == null ? string.Empty : Request.QueryString["CarID"].ToString();
                txtBoxCarID.Text = VehicleID;
                
                txtBoxCarID.ReadOnly = true;
                
            }
            else
            {
                txtBoxCarID.ReadOnly = false;
            }
        }

        protected void btnBid_Click(object sender, EventArgs e)
        {
            //Parsing all inputs as intergers
            int User = Int32.Parse(txtBoxUserID.Text);
            int Car = Int32.Parse(txtBoxCarID.Text);
            int Bid = Int32.Parse(txtBoxBid.Text);
            //Calling the current user logged in
            string Name = Session["Username"] == null ? string.Empty : Session["Username"].ToString();

            //Establishing a connection.
            var service = new BiddingService.BiddingDataService();

            //Executes query
            var result = service.BidCar(User, Car, Bid);
            if (result == 1)
            {
                //Writes to the log file located in /LogFiles/Bidding Values.text
                Log logger = new Log();
                logger.WriteToFile(User, Car, Bid, Name);
                Response.Redirect("~/CarsBidded.aspx");
            }
        }
    }
}