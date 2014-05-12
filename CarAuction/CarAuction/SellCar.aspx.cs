using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarAuction
{
    public partial class SellCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Calls current date and time
            DateTime DT = DateTime.Now;
            //Adds 7 days and sets it to the TextBox
            var expired = DT.AddDays(7);
            txtBoxClosingDate.Text = expired.ToString();
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            
            string imageName = "";

            //Creates a unique name for and image so there is no clash
            if (fileUploadImage.HasFile) {
                imageName = Guid.NewGuid().ToString() + "." + fileUploadImage.FileName.Split('.')[1].ToString();
                string imgPath = Server.MapPath("~/CarImages/" + imageName.ToString());
                fileUploadImage.SaveAs(imgPath);
            }

            //Creates new instance of the webservice
            var service = new BiddingService.BiddingDataService();
            //Calls method and executes query
            var x = service.SellCar(txtBoxDesc.Text, txtBoxBrand.Text, txtBoxModel.Text,
                txtBoxYear.Text, Int32.Parse(txtBoxStartBid.Text), Int32.Parse(txtBoxKilometer.Text),
                txtBoxClosingDate.Text, Int32.Parse(txtBoxValue.Text), imageName);

            if (x == "Success!")
            {
                //Redirects to page
                Response.Redirect("~/CarsAvailable.aspx");
            }
            else
            {
                //Reports erro to the user
                lblError.Text = "Error uploading your car!";
            }
        }
    }
}