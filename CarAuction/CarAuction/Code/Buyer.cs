using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace CarAuction.Code
{
    public class Buyer : UseDatabase<Buyer>
    {
        //Insert statements for Registration
        private const string InsertSQL = @"INSERT INTO [Buyer]([Name], [Surname], [emailAddress], [password], [Question], [DateOfBirth], [Answer]) 
                         VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
        private const string DeleteSQL = @"DELETE FROM [Buyer] WHERE [UserID] = {0}";
        //Select statement ID for bidding
        private const string SelectSQLID = "SELECT UserID FROM [Buyer] WHERE (emailAddress = '{0}') AND (password = '{1}');";
        //Select statement for greeting
        private const string SelectSQLName = @"SELECT     Name
                                        FROM         Buyer
                                        WHERE     (emailAddress = '{0}') AND ([password] = '{1}')";
        //Select statement for logging in
        private const string SelectSQL = @"SELECT     UserID, emailAddress, [password], Name, Surname, DateOfBirth, Question, Answer
                                        FROM         Buyer
                                        WHERE     (emailAddress = '{0}') AND ([password] = '{1}')";
        //Update for forgotten pass
        private const string UpdateSQLForgotPass = @"UPDATE    Buyer SET              [password] = '{0}' WHERE     (emailAddress = '{1}') AND (Question = '{2}') AND (Answer = '{3}');";
        //Update for Details that shall be changed
        private const string UpdateSQLChangeDe = @"UPDATE [Buyer] SET Name = '{0}', Surname = '{1}', DateOfBirth = '{2}', Question = '{3}', 
                                        Answer = '{4}'  WHERE (emailAddress = '{5}') AND (password = '{6}');";

        //Setting Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Question { get; set; }
        public string DateOfBirth { get; set; }
        public string Answer { get; set; }

        public Buyer() { }

        //Passing the values via from the user into the property
        public Buyer(string name, string surname, string email, string password, string question, string DOB, string answer)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
            this.Question = question;
            this.DateOfBirth = DOB;
            this.Answer = answer;
        }

        //Method for updating details
        public override bool UpdateAll()
        {
            try
            {
                //Connection to database
                this.ConnectToDatabase();

                //Creates a string format for the values to passed into the placeholders
                //Executes the query which is called
                return this.ExecuteCommand(string.Format(UpdateSQLChangeDe, this.Name, this.Surname, this.DateOfBirth, 
                    this.Question, this.Answer, this.Email, this.Password));
            }
            catch
            {
                return false;
            }
            finally
            {
                this.DisconnectDatabase();
            }
        }

        //Method for forgotten password
        public override bool Update()
        {
            try
            {
                this.ConnectToDatabase();

                //Creates a string format for the values to passed into the placeholders
                //Executes the query which is called
                return this.ExecuteCommand(string.Format(UpdateSQLForgotPass, this.Password, 
                    this.Email, this.Question, this.Answer));
            }
            catch
            {
                return false;
            }
            finally
            {
                this.DisconnectDatabase();
            }
        }

        public override bool Insert()
        {
            try
            {
                this.ConnectToDatabase();

                //Creates a string format for the values to passed into the placeholders
                //Executes the query which is called
                return this.ExecuteCommand(string.Format(InsertSQL,
                    this.Name, this.Surname, this.Email, this.Password,
                    this.Question, this.DateOfBirth, this.Answer));

            }
            catch (OleDbException)
            {
                return false;
            }
            finally
            {
                this.DisconnectDatabase();
            }
        }
        public override bool Delete()
        {
            return true;
        }

        public override int SelectID()
        {
            try
            {
                //Creates a string format for the values to passed into the placeholders
                //Executes the query which is called
                this.ConnectToDatabase();
                SqlDataReader reader = this.ExecuteQuery(string.Format(SelectSQLID, this.Email, this.Password));
                
                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    //Return success if the data is not null 
                    return id;
                }
                else
                {
                    //Return false if the data is null and has no rows
                    return 0;
                }
            }
            catch
            {

                return 0;
            }
            finally
            {

                this.DisconnectDatabase();
            }
        }

        public override string SelectName()
        {
            try
            {
                //Creates a string format for the values to passed into the placeholders
                //Executes the query which is called
                this.ConnectToDatabase();
                SqlDataReader reader = this.ExecuteQuery(string.Format(SelectSQLName, this.Email, this.Password));
                if (reader.Read())
                {
                    string name = reader.GetString(0);
                    //Return success if the data is not null 
                    return name;
                }
                else
                {
                    //Return "Fail" if the data is null and has no rows
                    return "Fail";
                }
            }
            catch
            {
                //Returns "Fail" if any errors are picked up
                return "Fail";
            }
            finally
            {
                //Disconnection to database
                this.DisconnectDatabase();
            }
        }

        public override bool Select()
        {
            try
            {
                //Creates a string format for the values to passed into the placeholders
                //Executes the query which is called
                this.ConnectToDatabase();
                var reader = this.ExecuteQuery(string.Format(SelectSQL,this.Email, this.Password));
                if (reader != null && reader.HasRows)
                {
                    //Return success if the data is not null 
                    return true;
                }
                else
                {
                    //Return false if the data is null and has no rows
                    return false;
                }
            }
            catch{

                return false;
            }
            finally {
                //Disconnect from database
                this.DisconnectDatabase();
            }
        }

        //Method that can used optionally if someone needs it
        public override List<Buyer> SelectAll()
        {
            return new List<Buyer>();
        }
    }
}