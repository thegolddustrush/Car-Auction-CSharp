using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarAuction.Code
{
    public class BidInformation: UseDatabase<BidInformation>
    {
        private const string InsertSQL = @"INSERT INTO [BidInformation]([UserID], [CarID], [bid]) VALUES('{0}','{1}','{2}')";
        private const string DeleteSQL = @"DELETE FROM [BidInformation] WHERE [useID] = {0}";

        private const string SelectSQL = @"SELECT * FROM [BidInformation]";

        //Setting Properties
        public int UserId { get; set; }
        public int CarId { get; set; }
        public int Bid { get; set; }
        public int Value { get; set; }

        //Passing the values via from the user into the property
        public BidInformation(int uID, int carID, int bid, int value)
        {
            this.UserId = uID;
            this.CarId = carID;
            this.Bid = bid;
            this.Value = value;
        }

        public BidInformation()
        {

        }

        public override bool Insert()
        {
            try
            {
                //Connection to the database
                this.ConnectToDatabase();

                //Creates a string format for the values to passed into the placeholders
                //Executes the query which is called
                return this.ExecuteCommand(string.Format(InsertSQL,
                    this.UserId,this.CarId, this.Bid));

            }
            catch
            {
                //Returns false if are any errors with the query
                return false;
            }
            finally
            {
                //Disconnection to the database
                this.DisconnectDatabase();
            }
        }

        //Methods that are used optionally if someone needs it
        public override bool Delete()
        {
            return true;
        }
        public override bool Select()
        {
            return true;
        }
        public override List<BidInformation> SelectAll()
        {
            return new List<BidInformation>();
        }
    }
}