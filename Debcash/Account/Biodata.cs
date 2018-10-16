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
    public class Biodata
    {
        //Object name for DatabaseHelper
        DBHelper dbHelper;
        //Object for SQLite Connection
        private SQLiteConnection cons;
        //Object for SQLite Command
        private SQLiteCommand cmd;
        //Object for SQlite Reader
        private SQLiteDataReader reader;
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }

        public Biodata(string username)
        {
            dbHelper = new DBHelper();
            string sql = String.Format("SELECT * FROM users WHERE username = '{0}'", username);
            using (cons = new SQLiteConnection(dbHelper.GetConnection()))
            using (cmd = new SQLiteCommand(sql, cons))
            {
                cons.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    firstname = reader["firstname"].ToString();
                    lastname = reader["lastname"].ToString();
                    email = reader["email"].ToString();
                }
                cons.Close();
            }
        }
    }
}
