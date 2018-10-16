using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Debcash.Database;
using Debcash.Security;
using System.Data.SQLite;

namespace Debcash.Account
{
    public class Registration
    {
        //Object name for DatabaseHelper
        DBHelper dbHelper;
        //Object for SQLite Connection
        private SQLiteConnection cons;
        //Object for SQLite Command
        private SQLiteCommand cmd;
        //Object for SQlite Reader
        private SQLiteDataReader reader;
        public bool UserExists(string username)
        {
            bool exists = false;
            dbHelper = new DBHelper();
            using (cons = new SQLiteConnection(dbHelper.GetConnection()))
            using (cmd = new SQLiteCommand("SELECT * FROM users WHERE username = '" + username + "'", cons))
            {
                cons.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    exists = true;
                }
                cons.Close();
            }

            return exists;
        }

        public bool Register(string username, string password, string firstname, string lastname, string email)
        {
            //Encrypt the password
            password = Hash.CreateMD5(password);
            bool success = false;

            dbHelper = new DBHelper();
            using (cons = new SQLiteConnection(dbHelper.GetConnection()))
            using (cmd = new SQLiteCommand("INSERT INTO users (username, password, firstname, lastname, email) VALUES(@user, @password, @firstname, @lastname, @email)", cons))
            {
                cons.Open();
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
                cons.Close();
                success = true;
            }
            return success;
        }
    }
}
