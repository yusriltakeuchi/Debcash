using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Debcash.Database;
using System.Data.SQLite;

namespace Debcash.Accounting
{
    public class Saldo
    {
        //Object name for DatabaseHelper
        DBHelper dbHelper;
        //Object for SQLite Connection
        private SQLiteConnection cons;
        //Object for SQLite Command
        private SQLiteCommand cmd;
        //Object for SQlite Reader
        private SQLiteDataReader reader;

        public void InsertFirst(int amount)
        {
            dbHelper = new DBHelper();
            using (cons = new SQLiteConnection(dbHelper.GetConnection()))
            using (cmd = new SQLiteCommand("INSERT INTO money (saldo) VALUES(@saldo)", cons))
            {
                cons.Open();
                cmd.Parameters.AddWithValue("@saldo", amount);
                cmd.ExecuteNonQuery();
                cons.Close();
            }
        }

        public int GetSaldo()
        {
            int saldo = 0;
            dbHelper = new DBHelper();
            using (cons = new SQLiteConnection(dbHelper.GetConnection()))
            using (cmd = new SQLiteCommand("SELECT * FROM money", cons))
            {
                cons.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    saldo = int.Parse(reader["saldo"].ToString());
                }
                cons.Close();
            }
            return saldo;
        }

        public void UpdateSaldoIncre(int increment)
        {
            int _saldo = (GetSaldo() + increment);
            dbHelper = new DBHelper();
            using (cons = new SQLiteConnection(dbHelper.GetConnection()))
            using (cmd = new SQLiteCommand("UPDATE money SET saldo = " + _saldo, cons))
            {
                cons.Open();
                cmd.ExecuteNonQuery();
                cons.Close();
            }
        }

        public void UpdateSaldoDecre(int decrement)
        {
            int _saldo = (GetSaldo() - decrement);
            dbHelper = new DBHelper();
            using (cons = new SQLiteConnection(dbHelper.GetConnection()))
            using (cmd = new SQLiteCommand("UPDATE money SET saldo = " + _saldo, cons))
            {
                cons.Open();
                cmd.ExecuteNonQuery();
                cons.Close();
            }
        }
    }
}
