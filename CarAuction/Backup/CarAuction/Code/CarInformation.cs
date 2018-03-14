using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace CarAuction.Code
{
    public class CarInformation : UseDatabase<CarInformation>
    {
        //Insert used to upload cars
        private const string InsertSQL = @"INSERT INTO [CarInformation] ([Description], [brand], [model], [year], 
                                    [startingBid], [photo], [Kilometers], [closingDate], [estValue]) 
                                    VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}', {8})";
        //
        private const string DeleteSQL = @"DELETE FROM [CarInformation] WHERE [carId] = {0}";
        //
        private const string SelectSQL = @"SELECT * FROM [CarInformation]";

        //Setting Properties
        public int CarId { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public int StartingBid { get; set; }
        public int Kilometers { get; set; }
        public string ClosingDate { get; set; }
        public int Value { get; set; }
        public string Photo { get; set; }

        //Passing the values via from the user into the property
        public CarInformation(int carId, string description, string brand, string model, 
                              string year, int startBid, int kilometer, string closeDate, int value,
                              string image)
        {
            this.CarId = carId;
            this.Description = description;
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.StartingBid = startBid;
            this.Kilometers = kilometer;
            this.ClosingDate = closeDate;
            this.Value = value;
            this.Photo = image;
        }

        //Insert method used to upload cars
        public override bool Insert()
        {
            try
            {
                //Connection to the database
                this.ConnectToDatabase();

                //Creates a string format for the values to passed into the placeholders
                //Executes the query which is called
                return this.ExecuteCommand(string.Format(InsertSQL,
                    this.Description, this.Brand, this.Model, this.Year,
                    this.StartingBid,this.Photo, this.Kilometers,
                    this.ClosingDate, this.Value));

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

        public override List<CarInformation> SelectAll()
        {
            return base.SelectAll();
        }
    }
}