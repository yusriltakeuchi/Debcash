using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Debcash.Database;
using System.Data.SQLite;

namespace Debcash.Accounting
{
    public class Summary
    {
        //Object name for DatabaseHelper
        DBHelper dbHelper;
        //Object for SQLite Connection
        private SQLiteConnection cons;
        //Object for SQLite Command
        private SQLiteCommand cmd;
        //Object for SQlite Reader
        private SQLiteDataReader reader;

        public DateTime tanggal { get; set; }
        public string keterangan { get; set; }
        public int pemasukan { get; set; }
        public int pengeluaran { get; set; }
        public int saldo { get; set; }
        private string filter { get; set; }


        public string tahunbulan { get; set; }
        public int tahunbulan_total { get; set; }

        public string tahunbulanPeng { get; set; }
        public int tahunbulan_totalPeng { get; set; }

        public string informasi { get; set; }
        public int nominal { get; set; }


        public Summary(string filter)
        {
            this.filter = filter;
        }

        public void InputHistory(DateTime tanggal, string informasi, string keterangan, int nominal)
        {
            dbHelper = new DBHelper();
            string sql = "INSERT INTO history (tanggal, informasi, keterangan, nominal) VALUES(@tanggal, @informasi, @keterangan, @nominal)";
            using (cons = new SQLiteConnection(dbHelper.GetConnection()))
            using (cmd = new SQLiteCommand(sql, cons))
            {
                cons.Open();
                cmd.Parameters.AddWithValue("@tanggal", tanggal);
                cmd.Parameters.AddWithValue("@informasi", informasi);
                cmd.Parameters.AddWithValue("@keterangan", keterangan);
                cmd.Parameters.AddWithValue("@nominal", nominal);
                cmd.ExecuteNonQuery();
                cons.Close();
            }
        }

        public List<Summary> GetHistory()
        {
            var summary = new List<Summary>();
            dbHelper = new DBHelper();
            string sql = "SELECT * FROM history ORDER BY tanggal DESC";
            using (cons = new SQLiteConnection(dbHelper.GetConnection()))
            using (cmd = new SQLiteCommand(sql, cons))
            {
                try
                {
                    cons.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        summary.Add(new Summary(string.Empty)
                        {
                            tanggal = DateTime.Parse(reader["tanggal"].ToString()),
                            informasi = reader["informasi"].ToString(),
                            keterangan = reader["keterangan"].ToString(),

                            nominal = int.Parse(reader["nominal"].ToString())
                        });
                    }
                    cons.Close();
                }
                catch(Exception ex)
                {

                }
              
            }
            return summary;
        }


        public List<Summary> GetSummary()
        {
            var summary = new List<Summary>();
            dbHelper = new DBHelper();
            string sql = "SELECT * FROM summary " + filter;
            using (cons = new SQLiteConnection(dbHelper.GetConnection()))
            using (cmd = new SQLiteCommand(sql, cons))
            {
                cons.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    summary.Add(new Summary(filter)
                    {
                        tanggal = DateTime.Parse(reader["tanggal"].ToString()),
                        keterangan = reader["keterangan"].ToString(),
                        pemasukan = int.Parse(reader["pemasukan"].ToString()),
                        pengeluaran = int.Parse(reader["pengeluaran"].ToString()),
                        saldo = int.Parse(reader["saldo"].ToString())
                    });
                }
                cons.Close();
            }
            return summary;
        }

        public int GetTotalPemasukan()
        {
            int total = 0;
            dbHelper = new DBHelper();
            using (cons = new SQLiteConnection(dbHelper.GetConnection()))
            using (cmd = new SQLiteCommand("SELECT * FROM summary", cons))
            {
                try
                {
                    cons.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        total += int.Parse(reader["pemasukan"].ToString());
                    }
                    cons.Close();
                }
                catch(Exception ex)
                {

                }
             

            }
            return total;
        }

        public int GetTotalPengeluaran()
        {
            int total = 0;
            dbHelper = new DBHelper();
            using (cons = new SQLiteConnection(dbHelper.GetConnection()))
            using (cmd = new SQLiteCommand("SELECT * FROM summary", cons))
            {

                cons.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    total += int.Parse(reader["pengeluaran"].ToString());
                }
                cons.Close();
            }
            return total;
        }

        public List<Summary> GetTahunBulanMax()
        {
            var sum = new List<Summary>();
            dbHelper = new DBHelper();
            try
            {
                using (cons = new SQLiteConnection(dbHelper.GetConnection()))
                using (cmd = new SQLiteCommand("SELECT strftime('%Y-%m', tanggal) as yearmonth, SUM(pemasukan) AS total FROM summary WHERE yearmonth between '2010-01' AND '2099-12' GROUP BY yearmonth", cons))
                {
                    cons.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        sum.Add(new Summary(string.Empty)
                        {
                            tahunbulan = reader["yearmonth"].ToString(),
                            tahunbulan_total = int.Parse(reader["total"].ToString())
                        });
                    }
                    cons.Close();
                }
            }
            catch(Exception ex)
            {

            }
         
            return sum;
        }

        public List<Summary> GetTahunBulanMaxPeng()
        {
            var sum = new List<Summary>();
            dbHelper = new DBHelper();
            try
            {
                using (cons = new SQLiteConnection(dbHelper.GetConnection()))
                using (cmd = new SQLiteCommand("SELECT strftime('%Y-%m', tanggal) as yearmonth, SUM(pengeluaran) AS total FROM summary WHERE yearmonth between '2010-01' AND '2099-12' GROUP BY yearmonth", cons))
                {
                    cons.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        sum.Add(new Summary(string.Empty)
                        {
                            tahunbulanPeng = reader["yearmonth"].ToString(),
                            tahunbulan_totalPeng = int.Parse(reader["total"].ToString())
                        });
                    }
                    cons.Close();
                }
            }
            catch (Exception ex)
            {

            }
         
            return sum;
        }

        public List<Summary> GetPembukuanHarian()
        {
            var sum = new List<Summary>();
            dbHelper = new DBHelper();
            try
            {
                using (cons = new SQLiteConnection(dbHelper.GetConnection()))
                using (cmd = new SQLiteCommand("SELECT strftime('%d-%m', tanggal) as yearmonth, SUM(pengeluaran) AS pengeluaran, SUM(pemasukan) AS pemasukan FROM summary WHERE yearmonth between '01-01-2000' AND '31-12-2090' GROUP BY yearmonth order BY DATE(tanggal)", cons))
                {
                    cons.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        sum.Add(new Summary(string.Empty)
                        {
                            tahunbulan = reader["yearmonth"].ToString(),
                            pengeluaran = int.Parse(reader["pengeluaran"].ToString()),
                            pemasukan = int.Parse(reader["pemasukan"].ToString())
                        });
                    }
                    cons.Close();
                }
            }
            catch (Exception ex)
            {

            }
       
            return sum;
        }

        public List<Summary> GetPembukuanBulanan()
        {
            var sum = new List<Summary>();
            dbHelper = new DBHelper();
            try
            {
                using (cons = new SQLiteConnection(dbHelper.GetConnection()))
                using (cmd = new SQLiteCommand("SELECT strftime('%Y-%m', tanggal) as yearmonth, SUM(pengeluaran) AS pengeluaran, SUM(pemasukan) AS pemasukan FROM summary WHERE yearmonth between '2000-01' AND '2099-12' GROUP BY yearmonth", cons))
                {
                    cons.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        sum.Add(new Summary(string.Empty)
                        {
                            tahunbulan = reader["yearmonth"].ToString(),
                            pengeluaran = int.Parse(reader["pengeluaran"].ToString()),
                            pemasukan = int.Parse(reader["pemasukan"].ToString())
                        });
                    }
                    cons.Close();
                }
            }
            catch (Exception ex)
            {

            }
       
            return sum;
        }

        public List<Summary> GetPembukuanTahunan()
        {
            var sum = new List<Summary>();
            dbHelper = new DBHelper();
            try
            {
                using (cons = new SQLiteConnection(dbHelper.GetConnection()))
                using (cmd = new SQLiteCommand("SELECT strftime('%Y', tanggal) as yearmonth, SUM(pengeluaran) AS pengeluaran, SUM(pemasukan) AS pemasukan FROM summary WHERE yearmonth between '2000' AND '2099' GROUP BY yearmonth", cons))
                {
                    cons.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        sum.Add(new Summary(string.Empty)
                        {
                            tahunbulan = reader["yearmonth"].ToString(),
                            pengeluaran = int.Parse(reader["pengeluaran"].ToString()),
                            pemasukan = int.Parse(reader["pemasukan"].ToString())
                        });
                    }
                    cons.Close();
                }
            }
            catch (Exception ex)
            {

            }
         
            return sum;
        }
    }
}
