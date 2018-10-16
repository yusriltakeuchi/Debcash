using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Debcash.Database;
using System.Data.SQLite;

namespace Debcash.Accounting
{
    public class Pemasukan
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
        private int pemasukan { get; set; }
        private int saldo { get; set; }

        public Pemasukan(DateTime tanggal, string keterangan, int pemasukan, int saldo)
        {
            this.tanggal = tanggal;
            this.keterangan = keterangan;
            this.pemasukan = pemasukan;
            this.saldo = saldo;
        }

        public void InputPemasukan()
        {
            dbHelper = new DBHelper();
            string sql = "INSERT INTO summary (tanggal, keterangan, pengeluaran, pemasukan, saldo) VALUES(@tanggal, @keterangan, @pengeluaran, @pemasukan, @saldo)";
            using (cons = new SQLiteConnection(dbHelper.GetConnection()))
            using (cmd = new SQLiteCommand(sql, cons))
            {
                cons.Open();
                cmd.Parameters.AddWithValue("@tanggal", this.tanggal);
                cmd.Parameters.AddWithValue("@keterangan", this.keterangan);
                cmd.Parameters.AddWithValue("@pemasukan", this.pemasukan);
                int _saldo = (this.saldo + this.pemasukan);
                cmd.Parameters.AddWithValue("@saldo", _saldo);
                int peng = 0;
                cmd.Parameters.AddWithValue("@pengeluaran", peng);
                cmd.ExecuteNonQuery();
                cons.Close();
            }
        }
    }
}
