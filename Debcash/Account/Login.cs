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
    public class Login
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

        public bool LoginAccount(string username, string password)
        {
            bool success = false;
            dbHelper = new DBHelper();
            password = Hash.CreateMD5(password);
            string sql = String.Format("SELECT * FROM users WHERE username = '{0}' AND password = '{1}'", username, password);
            using (cons = new SQLiteConnection(dbHelper.GetConnection()))
            using (cmd = new SQLiteCommand(sql, cons))
            {
                cons.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    success = true;
                }
                cons.Close();
            }
            return success;
        }
    }
}
