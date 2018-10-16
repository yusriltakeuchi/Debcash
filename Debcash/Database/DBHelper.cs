using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Debcash.Database
{
    public class DBHelper
    {
        //Database name
        public string DBName = "DebStorage.db";
        //Connection string path
        private string StringPath = @"Data Source=DebStorage.db;Version=3;";
        //Object for SQLite Connection
        private SQLiteConnection cons;
        //Object for SQLite Command
        private SQLiteCommand cmd;

        public void CreateTable()
        {
            using (cons = new SQLiteConnection(GetConnection()))
            using (cmd = new SQLiteCommand("CREATE TABLE users (user_id integer PRIMARY KEY AUTOINCREMENT, username TEXT, password TEXT, firstname TEXT, lastname TEXT, email TEXT);CREATE TABLE summary (id_summary integer PRIMARY KEY AUTOINCREMENT, tanggal DATE, keterangan TEXT NOT NULL, pengeluaran integer NULL, pemasukan integer NULL, saldo integer NOT NULL);CREATE TABLE money (id_money integer PRIMARY KEY AUTOINCREMENT, saldo integer);CREATE TABLE history (id_history integer PRIMARY KEY AUTOINCREMENT, tanggal DATE, informasi TEXT, keterangan TEXT, nominal integer)", cons))
            {
                cons.Open();
                cmd.ExecuteNonQuery();
                cons.Close();
            }
        }

        public string GetConnection()
        {
            return StringPath;
        }
    }
}
