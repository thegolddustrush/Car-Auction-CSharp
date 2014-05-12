using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace CarAuction.Code
{
    public class Log
    {
        private string fileName;

        public Log()
        {
            //File name of the file being written to
            this.fileName = HttpContext.Current.Server.MapPath("~/LogFiles/Bidding Values.txt");
        }

        //Passing the fileName to retrieve a directory
        public Log(string fileName)
        {
            this.fileName = fileName;
        }
        //// LogFile to document each run results
        /// The WriteToFile method is used to document details of each run.
        public bool WriteToFile(int UserIDz, int CarIDz, int Value, string UserName)
        {
            // Store the script names and test results in a output text file.
            using (StreamWriter writer = new StreamWriter(new FileStream(fileName, FileMode.Append)))
            {
                writer.WriteLine("User ID = {0}, Car ID = {1}, Value = R {2}, Name = {3}", UserIDz, CarIDz, Value, UserName);
            }
            return true;
        }

    }
}