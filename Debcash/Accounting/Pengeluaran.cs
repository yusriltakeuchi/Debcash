using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Debcash.Database;
using System.Data.SQLite;

namespace Debcash.Accounting
{
    public class Pengeluaran
    {
        //Object name for DatabaseHelper
        DBHelper dbHelper;
        //Object for SQLite Connection
        private SQLiteConnection cons;
        //Object for SQLite Command
        private SQLiteCommand cmd;
        //Object for SQlite Reader
        private SQLiteDataReader reader;

        private DateTime tanggal { get; set; }
        private string keterangan { get; set; }
        private int pengeluaran { get; set; }
        private int saldo { get; set; }

        public Pengeluaran(DateTime tanggal, string keterangan, int pengeluaran, int saldo)
        {
            this.tanggal = tanggal;
            this.keterangan = keterangan;
            this.pengeluaran = pengeluaran;
            this.saldo = saldo;
        }

        public void InputPengeluaran()
        {
            dbHelper = new DBHelper();
            string sql = "INSERT INTO summary (tanggal, keterangan, pengeluaran, pemasukan, saldo) VALUES(@tanggal, @keterangan, @pengeluaran, @pemasukan, @saldo)";
            using (cons = new SQLiteConnection(dbHelper.GetConnection()))
            using (cmd = new SQLiteCommand(sql, cons))
            {
                cons.Open();
                cmd.Parameters.AddWithValue("@tanggal", this.tanggal);
                cmd.Parameters.AddWithValue("@keterangan", this.keterangan);
                cmd.Parameters.AddWithValue("@pengeluaran", this.pengeluaran);
                int _saldo = (this.saldo - this.pengeluaran);
                cmd.Parameters.AddWithValue("@saldo", _saldo);
                int pem = 0;
                cmd.Parameters.AddWithValue("@pemasukan", pem);
                cmd.ExecuteNonQuery();
                cons.Close();
            }
        }
    }
}
