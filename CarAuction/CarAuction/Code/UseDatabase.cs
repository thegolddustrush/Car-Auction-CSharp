using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace CarAuction
{
    /// 
    /// A connection to any access database if the path is given
    ///
    public class UseDatabase<T> where T: class
    {
        OleDbConnection conn;
        string databasePath = "";

        public UseDatabase()
        {
            this.databasePath = HttpContext.Current.Server.MapPath("~/" + ConfigurationManager.AppSettings["DatabasePath"].ToString());
            
        }

        //Method that creates a database connection and opens it
        public void ConnectToDatabase()
        {
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + databasePath + ";");
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
                cmd.ExecuteNonQuery();
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

        //Methos which are optional in using
        public virtual bool UpdateAll() {
            throw new NotImplementedException();
        }

        public virtual bool Update() {
            throw new NotImplementedException();
        }

        public virtual bool Insert() {
            throw new NotImplementedException();
        }

        public virtual bool Delete() {
            throw new NotImplementedException();
        }

        public virtual string SelectName() {
            throw new NotImplementedException();
        }

        public virtual int SelectID()
        {
            throw new NotImplementedException();
        }

        public virtual bool Select() {
            throw new NotImplementedException();
        }

        public virtual List<T> SelectAll() {
            throw new NotImplementedException();
        }
    }
}