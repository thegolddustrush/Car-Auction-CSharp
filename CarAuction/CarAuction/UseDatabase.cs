using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;

namespace CarAuction
{
    /// <summary>
    /// Summary description for UseDatabase
    /// </summary>
    public class UseDatabase
    {
        OleDbConnection conn;
        string databasePath = "";

        public UseDatabase(string databasePath)
        {
            this.databasePath = databasePath;
        }

        //Method that creates a database connection and opens it
        public void ConnectToDatabase()
        {
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + databasePath);
            conn.Open();
        }

        //Method which disconnects from the database
        public void DisconnectDatabase()
        {
            conn.Close();
        }

        //Method use to execute query which has no result: INSERT, DELETE, UPDATE
        public bool ExecuteCommand(string query)
        {
            try
            {
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteReader();
                ////Returning true indicates success
                return true;
            }

            catch (OleDbException odbe)
            {
                //Retuning false indicates failure
                return false;
            }
        }

        //Method use to execute query and returns he result if any.
        public OleDbDataReader ExecuteQuery(String query)
        {
            try
            {
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                return cmd.ExecuteReader();
            }
            catch (OleDbException odbe)
            {
                return null;
            }
        }
    }
}