using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.OleDb;
using System.Text;
using CarAuction.Code;

namespace CarAuction
{
    /// <summary>
    /// Summary description for BiddingDataService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BiddingDataService : System.Web.Services.WebService
    {

        [WebMethod(Description = "AddUser method used for new users")]
        public string AddUser(string name, string surname, string email, string password, string question, string DOB, string answer)
        {
            var buyer = new Buyer(name,surname,email,password,question,DOB,answer);
            
            if(buyer.Insert()){

                return "Successful";
            }
            else {
                return "Unsuccessful";
            }
        }

        //Method used to login
        [WebMethod(Description = "Login Method for existing users")]
        public string Login(string email, string password)
        {

            var buyer = new Buyer { 
                Email = email,
                Password = password
            };
            if (buyer.Select())
            {
                //Return success if the data is not null 
                return "Success!";
            }
            else
            {
                //Return false if the data is null and has no rows
                return "Failure!";
            }
        }

        //Method used to add a item
        [WebMethod(Description = "SellCar method used to adding cars")]
        public string SellCar(string description, string brand, string model, string year, int startBid, int kilometer, string closeDate, int value, string image)
        {
            var carInfo = new CarInformation(0, description, brand, model, year, startBid, kilometer, closeDate, value, image);
            if (carInfo.Insert())
            {
                return "Success!";
            }
            else {
                return "Fail!";
            }
        }

        //Method to check the users password
        [WebMethod(Description = "ForgottenPassword method is used to reset a password is forgotten")]
        public string ForgottenPassword(string password, string question, string answer, string email)
        {
            var BuyerForgot = new Buyer { 
                Password = password,
                Email = email,
                Question = question,
                Answer = answer
            };
            if (BuyerForgot.Update())
            {
                return "Success!";
            }
            else {
                return "Fail";
            }
        }

        //Method to change passwords
        [WebMethod(Description = "ChangePassword method is used to add a new password")]
        public string ChangePassword(string password, string email, string question, string answer)
        {
            var buyerChangePass = new Buyer();
            buyerChangePass.Update();
            if (buyerChangePass.Update())
            {
                return "Success!";
            }
            else
            {
                return "Fail";
            }

        }

        //Method used to change users details
        [WebMethod(Description = "ChangeDetails method is used to update information when neccessary")]
        public bool ChangeDetails(string name, string surname, string email, string question, string answer, string password)
        {
            var BuyerDetails = new Buyer();
            BuyerDetails.UpdateAll();
            if(BuyerDetails.UpdateAll())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method used to get the users ID
        [WebMethod(Description = "GetUserID method is used to Retrieve the user's ID")]
        public int GetUserID(string email, string password)
        {
            var BuyerName = new Buyer
            {
                Email = email,
                Password = password
            };

            return BuyerName.SelectID();
            
        }

        //Method used for purchasing a item
        [WebMethod(Description = "BidCar method is used to insert a Bid")]
        public int BidCar(int useID, int carID, int BidValue)
        {
            var BidInfo = new BidInformation
            {
                UserId = useID,
                CarId = carID,
                Bid = BidValue
            };

            if (BidInfo.Insert())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //Method use for bidding
        [WebMethod(Description = "UserName method is used to Retrieve the user's name for a greeting")]
        public string UserName(string email, string password)
        {
            var BuyerName = new Buyer { 
                Email = email,
                Password = password
            };

            return BuyerName.SelectName();
        }
    }
}
