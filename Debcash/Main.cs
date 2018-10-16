using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Debcash.Database;
using Debcash.Account;
using Debcash.Accounting;


namespace Debcash
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        //Object name for DatabaseHelper
        DBHelper dbHelper;
        //Object name for Account
        Biodata biodata;
        //Object name for Summary
        Summary summary;
        //Username variable
        private string username = "";
        //Array month
        string[] month = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dbHelper = new DBHelper();
            if (!File.Exists(dbHelper.DBName))
            {
                Properties.Settings.Default.SetupDB = true;
                Properties.Settings.Default.SaveSession = false;
                Properties.Settings.Default.Save();
            }
            if (DBExists())
            {
                Installation install = new Installation();
                install.ShowDialog();
                if (!install.success)
                {
                    this.Close();
                }
                else
                {
                    Properties.Settings.Default.SetupDB = false;
                    Properties.Settings.Default.Save();
                    FirstSaldo first = new FirstSaldo();
                    first.ShowDialog();
                }
            }

            LoginSession();

            //Get any summary data
            GetTableSummary("ORDER BY tanggal DESC");
            GetSummary();
            GetHistory();


            //Add icon to button
            btnApplyTable.Controls.Add(iconApply);
            iconApply.Location = new Point(5, 4);
            iconApply.BackColor = Color.Transparent;

            //Add icon to button
            btnClearTable.Controls.Add(iconClear);
            iconClear.Location = new Point(5, 4);
            iconClear.BackColor = Color.Transparent;

            //Add icon to button
            btnApply.Controls.Add(iconApply2);
            iconApply2.Location = new Point(45, 4);
            iconApply2.BackColor = Color.Transparent;

            //Add icon to button
            btnExportSummary.Controls.Add(iconExport);
            iconExport.Location = new Point(20, 3);
            iconExport.BackColor = Color.Transparent;

            //Add icon to button
            btnExportPembukuan.Controls.Add(iconExport2);
            iconExport2.Location = new Point(18, 3);
            iconExport2.BackColor = Color.Transparent;

            metroTabControl1.SelectedIndex = 0;
        }

        private void LoginSession()
        {
            //Login session
            Login login = new Login();
            login.ShowDialog();
            if (login.success)
            {
                //Get information about details account
                biodata = new Biodata(Properties.Settings.Default.Username);
                lblUsername.Text = biodata.firstname + " " + biodata.lastname;
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private bool DBExists()
        {
            bool exists = false;
            if (Properties.Settings.Default.SetupDB)
            {
                exists = true;
            }
            return exists;
        }

        private void filterTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void filterTree_AfterCheck(object sender, TreeViewEventArgs e)
        {

        }

        private void kreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pengeluaran peng = new Pengeluaran();
            peng.displayname = lblUsername.Text;
            peng.ShowDialog();
            //Get any summary data
            GetTableSummary("ORDER BY tanggal DESC");
            GetSummary();
            GetHistory();
        }

        private void debitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pemasukan pem = new Pemasukan();
            pem.displayname = lblUsername.Text;
            pem.ShowDialog();
            //Get any summary data
            GetTableSummary("ORDER BY tanggal DESC");
            GetSummary();
            GetHistory();
        }

        private void lblKeluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin logout akun?", "Logout Akun", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Properties.Settings.Default.SaveSession = false;
                Properties.Settings.Default.Save();
                LoginSession();
                
            }
        
        }

        private async void GetHistory()
        {
            GridHistory.Rows.Clear();
            summary = new Summary(string.Empty);
            try
            {
                Task<List<Summary>> sum = new Task<List<Summary>>(() => summary.GetHistory());
                sum.Start();

                foreach (Summary _summary in await sum)
                {
                    GridHistory.Rows.Add(new object[]
                    {
                    _summary.tanggal.ToString("dd-MM-yyyy"),
                    _summary.informasi,
                    _summary.keterangan,
                    _summary.nominal.ToString("N0")
                    });
                }
            }
            catch(Exception ex)
            {

            }
          
        }

        private async void GetTableSummary(string filter)
        {
            TableSumGrid.Rows.Clear();
            summary = new Summary(filter);
            Task<List<Summary>> sum = new Task<List<Summary>>(() 
                => summary.GetSummary());
            sum.Start();

            foreach(Summary _summary in await sum)
            {
                string pemasukan = "";
                string pengeluaran = "";
                if (_summary.pemasukan > 0)
                {
                    pemasukan = _summary.pemasukan.ToString("N0");
                }
                if (_summary.pengeluaran > 0)
                {
                    pengeluaran = _summary.pengeluaran.ToString("N0");
                }
                TableSumGrid.Rows.Add(new object[]
                {
                    _summary.tanggal.ToString("dd-MM-yyyy"),
                    _summary.keterangan,
                    pemasukan,
                    pengeluaran,
                    _summary.saldo.ToString("N0")
                });
                
            }
        }

        private async void GetSummary()
        {
            //Get total Saldo
            Saldo saldo = new Saldo();
            int _saldo = saldo.GetSaldo();
            lblSaldo.Text = "Rp" + _saldo.ToString("N0");

            //Get Total Pemasukan
            summary = new Summary(string.Empty);
            int pemasukan = summary.GetTotalPemasukan();
            lblTotalPemasukan.Text = "Rp" + pemasukan.ToString("N0");

            //Get Total Pengeluaran
            int pengeluaran = summary.GetTotalPengeluaran();
            lblTotalPengeluaran.Text = "Rp" + pengeluaran.ToString("N0");

            //Get Pemasukan tertinggi
            GetTahunBulan();
            //Get Pengleuaran tertinggi
            GetTahunBulanPeng();
        }

        private async void GetTahunBulan()
        {
            summary = new Summary(string.Empty);
            Task<List<Summary>> getDetail = new Task<List<Summary>>(() => summary.GetTahunBulanMax());
            getDetail.Start();

            int total = 0;
            string tanggal = "";

            double oldKenaikan = 0;
            double kenaikan = 0;

            int oldpem = 0;
            int newpem = 0;

            double kenaikantertinggi = 0;
            string tanggalkenaikan = "";

            string statusKenaikan = "";
            foreach (Summary sum in await getDetail)
            {
                oldpem = newpem;
                newpem = sum.tahunbulan_total;

                oldKenaikan = kenaikan;
                kenaikan = ((double)newpem / (double)oldpem) * 100 / 100;
                if (kenaikan.ToString() == "∞")
                {
                    kenaikan = 0;
                }

                if (oldpem > newpem)
                {
                    //Kenaikan turun
                    statusKenaikan = "⏬ " + String.Format("{0:0.0}", kenaikan) + "%";
                    lblPersenUntung.ForeColor = Color.Red;
                }
                else if (oldpem < newpem)
                {
                    //Kenaikan naik
                    statusKenaikan = "⏫ " + String.Format("{0:0.0}", kenaikan) + "%";
                    lblPersenUntung.ForeColor = Color.SeaGreen;
                }
                else
                {
                    lblPersenUntung.ForeColor = Color.Black;
                }

                if (total < sum.tahunbulan_total)
                {
                    total = sum.tahunbulan_total;
                    tanggal = sum.tahunbulan;

                    kenaikantertinggi = kenaikan;
                    tanggalkenaikan = sum.tahunbulan;
                }

            }
            try
            {
                lblTanggalPemasukan.Text = ConvertToDates(tanggal);
                lblPemasukan.Text = "Rp" + total.ToString("N0");
                lblPersenUntung.Text = statusKenaikan + " Kenaikan";
                lblKenaikanTertinggi.Text = "Tertinggi pada bulan " + ConvertToMonth(tanggalkenaikan) + ": " + String.Format("{0:0.0}", kenaikantertinggi) + "%";
            }
            catch (Exception ex)
            {

            }
       
        }

        private async void GetTahunBulanPeng()
        {
            summary = new Summary(string.Empty);
            Task<List<Summary>> getDetail = new Task<List<Summary>>(() => summary.GetTahunBulanMaxPeng());
            getDetail.Start();

            int total = 0;
            string tanggal = "";
            foreach (Summary sum in await getDetail)
            {
                if (total < sum.tahunbulan_totalPeng)
                {
                    total = sum.tahunbulan_totalPeng;
                    tanggal = sum.tahunbulanPeng;
                }
            }

            try
            {
                lblTanggalPengeluaran.Text = ConvertToDates(tanggal);
                lblPengeluarans.Text = "Rp" + total.ToString("N0");
            }
            catch(Exception ex)
            {

            }
         
        }

        private string ConvertToMonth(string tahunbulan)
        {
            string[] spliters = tahunbulan.Split('-');
            int index = int.Parse(spliters[1].TrimStart('0'));
            return month[index - 1];
        }

        private string ConvertToDates(string tahunbulan)
        {
            string[] spliters = tahunbulan.Split('-');
            int index = int.Parse(spliters[1].TrimStart('0'));
            return month[index-1] + " " + spliters[0];
        }

        private string ConvertToDay(string tahunbulan)
        {
            string[] spliters = tahunbulan.Split('-');
            int index = int.Parse(spliters[1].TrimStart('0'));
            return spliters[0] + " " + month[index - 1];
        }

        private async void btnApply_Click(object sender, EventArgs e)
        {
            string selected = treePembukuan.SelectedNode.Name;
            GridPembukuan.Rows.Clear();
            int oldpem = 0;
            int newpem = 0;

            int oldpeng = 0;
            int newpeng = 0;

            double oldKenaikanPem = 0;
            double kenaikanPem = 0;

            double oldKenaikanPeng = 0;
            double kenaikanPeng = 0;

            string statusKenaikanPem = "";
            string statusKenaikanPeng = "";
            if (selected == "Harian")
            {
                summary = new Summary(string.Empty);
                Task<List<Summary>> getDetail = new Task<List<Summary>>(() 
                    => summary.GetPembukuanHarian());
                getDetail.Start();

                int rows = 0;
                foreach (Summary sum in await getDetail)
                {
                    /* Menghitung Persen Kenaikan
                     * */
                    bool isUpPem = false;
                    bool isUpPeng = false;

                    oldpem = newpem;
                    newpem = sum.pemasukan;

                    oldKenaikanPem = kenaikanPem;
                    kenaikanPem = ((double)newpem / (double)oldpem) * 100 / 100;
                    if (kenaikanPem.ToString() == "∞" || kenaikanPem.ToString() == "NaN")
                    {
                        kenaikanPem = 0;
                    }

                    if (oldpem > newpem)
                    {
                        //Kenaikan turun
                        statusKenaikanPem = "⏬ " + String.Format("{0:0.0}", kenaikanPem) + "%";
                        isUpPem = false;
                    }
                    else
                    {
                        //Kenaikan naik
                        statusKenaikanPem = "⏫ " + String.Format("{0:0.0}", kenaikanPem) + "%";
                        isUpPem = true;
                    }


                    /* Menghitung Persen Kenaikan Pengeluaran
                     * */
                    oldpeng = newpeng;
                    newpeng = sum.pengeluaran;

                    oldKenaikanPeng = kenaikanPeng;
                    kenaikanPeng = ((double)newpeng / (double)oldpeng) * 100 / 100;
                    if (kenaikanPeng.ToString() == "∞" || kenaikanPeng.ToString() == "NaN")
                    {
                        kenaikanPeng = 0;
                       
                    }

                    if (oldpeng > newpeng)
                    {
                        //Kenaikan turun
                        statusKenaikanPeng = "⏬ " + String.Format("{0:0.0}", kenaikanPeng) + "%";
                        isUpPeng = false;
                    }
                    else {

                        //Kenaikan naik
                        statusKenaikanPeng = "⏫ " + String.Format("{0:0.0}", kenaikanPeng) + "%";
                        isUpPeng = true;
                    } 

                    string dates = ConvertToDay(sum.tahunbulan);
                    GridPembukuan.Rows.Add(new object[]
                    {
                        dates,
                        sum.pemasukan.ToString("N0"),
                        statusKenaikanPem,
                        sum.pengeluaran.ToString("N0"),
                        statusKenaikanPeng
                    });

                    //Change kenaikan perubahan color
                    if (isUpPem)
                    {
                        GridPembukuan.Rows[rows].Cells[2].Style.ForeColor = Color.SeaGreen;
                    }
                    else
                    {
                        GridPembukuan.Rows[rows].Cells[2].Style.ForeColor = Color.Red;
                    }

                    //Change kenaikan perubahan color
                    if (isUpPeng)
                    {
                        GridPembukuan.Rows[rows].Cells[4].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        GridPembukuan.Rows[rows].Cells[4].Style.ForeColor = Color.SeaGreen;
                    }

                    rows++;
                    //GridPembukuan.Sort(GridPembukuan.Columns[0], ListSortDirection.Ascending);
                }
            }
            else if (selected == "Bulanan")
            {
                summary = new Summary(string.Empty);
                Task<List<Summary>> getDetail = new Task<List<Summary>>(() 
                    => summary.GetPembukuanBulanan());
                getDetail.Start();

                int rows = 0;
                foreach (Summary sum in await getDetail)
                {
                    bool isUpPem = false;
                    bool isUpPeng = false;

                    oldpem = newpem;
                    newpem = sum.pemasukan;

                    oldKenaikanPem = kenaikanPem;
                    kenaikanPem = ((double)newpem / (double)oldpem) * 100 / 100;
                    if (kenaikanPem.ToString() == "∞" || kenaikanPem.ToString() == "NaN")
                    {
                        kenaikanPem = 0;
                    }

                    if (oldpem > newpem)
                    {
                        //Kenaikan turun
                        statusKenaikanPem = "⏬ " + String.Format("{0:0.0}", kenaikanPem) + "%";
                        isUpPem = false;
                    }
                    else
                    {
                        //Kenaikan naik
                        statusKenaikanPem = "⏫ " + String.Format("{0:0.0}", kenaikanPem) + "%";
                        isUpPem = true;
                    }

                    /* Menghitung Persen Kenaikan Pengeluaran
                * */
                    oldpeng = newpeng;
                    newpeng = sum.pengeluaran;

                    oldKenaikanPeng = kenaikanPeng;
                    kenaikanPeng = ((double)newpeng / (double)oldpeng) * 100 / 100;
                    if (kenaikanPeng.ToString() == "∞" || kenaikanPeng.ToString() == "NaN")
                    {
                        kenaikanPeng = 0;
                    }

                    if (oldpeng > newpeng)
                    {
                        //Kenaikan turun
                        statusKenaikanPeng = "⏬ " + String.Format("{0:0.0}", kenaikanPeng) + "%";
                        isUpPeng = false;
                    }
                    else
                    {

                        //Kenaikan naik
                        statusKenaikanPeng = "⏫ " + String.Format("{0:0.0}", kenaikanPeng) + "%";
                        isUpPeng = true;
                    }

                    string dates = ConvertToDates(sum.tahunbulan);
                    GridPembukuan.Rows.Add(new object[]
                    {
                        dates,
                        sum.pemasukan.ToString("N0"),
                        statusKenaikanPem,
                        sum.pengeluaran.ToString("N0"),
                        statusKenaikanPeng
                    });


                    //Change kenaikan perubahan color
                    if (isUpPem)
                    {
                        GridPembukuan.Rows[rows].Cells[2].Style.ForeColor = Color.SeaGreen;
                    }
                    else
                    {
                        GridPembukuan.Rows[rows].Cells[2].Style.ForeColor = Color.Red;
                    }

                    //Change kenaikan perubahan color
                    if (isUpPeng)
                    {
                        GridPembukuan.Rows[rows].Cells[4].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        GridPembukuan.Rows[rows].Cells[4].Style.ForeColor = Color.SeaGreen;
                    }

                    rows++;
                }
            }
            else if (selected == "Tahunan")
            {
                summary = new Summary(string.Empty);
                Task<List<Summary>> getDetail = new Task<List<Summary>>(() => summary.GetPembukuanTahunan());
                getDetail.Start();

                int rows = 0;
                foreach (Summary sum in await getDetail)
                {
                    bool isUpPem = false;
                    bool isUpPeng = false;

                    oldpem = newpem;
                    newpem = sum.pemasukan;

                    oldKenaikanPem = kenaikanPem;
                    kenaikanPem = ((double)newpem / (double)oldpem) * 100 / 100;
                    if (kenaikanPem.ToString() == "∞" || kenaikanPem.ToString() == "NaN")
                    {
                        kenaikanPem = 0;
                    }

                    if (oldpem > newpem)
                    {
                        //Kenaikan turun
                        statusKenaikanPem = "⏬ " + String.Format("{0:0.0}", kenaikanPem) + "%";
                        isUpPem = false;
                    }
                    else
                    {
                        //Kenaikan naik
                        statusKenaikanPem = "⏫ " + String.Format("{0:0.0}", kenaikanPem) + "%";
                        isUpPem = true;
                    }

                    /* Menghitung Persen Kenaikan Pengeluaran
                * */
                    oldpeng = newpeng;
                    newpeng = sum.pengeluaran;

                    oldKenaikanPeng = kenaikanPeng;
                    kenaikanPeng = ((double)newpeng / (double)oldpeng) * 100 / 100;
                    if (kenaikanPeng.ToString() == "∞" || kenaikanPeng.ToString() == "NaN")
                    {
                        kenaikanPeng = 0;
                    }

                    if (oldpeng > newpeng)
                    {
                        //Kenaikan turun
                        statusKenaikanPeng = "⏬ " + String.Format("{0:0.0}", kenaikanPeng) + "%";
                        isUpPeng = false;
                    }
                    else
                    {

                        //Kenaikan naik
                        statusKenaikanPeng = "⏫ " + String.Format("{0:0.0}", kenaikanPeng) + "%";
                        isUpPeng = true;
                    }

                    GridPembukuan.Rows.Add(new object[]
                    {
                        sum.tahunbulan,
                        sum.pemasukan.ToString("N0"),
                        statusKenaikanPem,
                        sum.pengeluaran.ToString("N0"),
                        statusKenaikanPeng
                    });


                    //Change kenaikan perubahan color
                    if (isUpPem)
                    {
                        GridPembukuan.Rows[rows].Cells[2].Style.ForeColor = Color.SeaGreen;
                    }
                    else
                    {
                        GridPembukuan.Rows[rows].Cells[2].Style.ForeColor = Color.Red;
                    }

                    //Change kenaikan perubahan color
                    if (isUpPeng)
                    {
                        GridPembukuan.Rows[rows].Cells[4].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        GridPembukuan.Rows[rows].Cells[4].Style.ForeColor = Color.SeaGreen;
                    }

                    rows++;
                }
            }
        }

        private void btnApplyTable_Click(object sender, EventArgs e)
        {
            string filterSelected = filterTree.SelectedNode.Name;
            GetTableSummary(filterSelected);
        }

        private void btnClearTable_Click(object sender, EventArgs e)
        {
            GetTableSummary("ORDER BY tanggal DESC");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private async void btnExportSummary_Click(object sender, EventArgs e)
        {
            if (TableSumGrid.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Anda yakin ingin melakukan export ke Excel?", "Exporting to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    copyAlltoClipboard(TableSumGrid);
                    Microsoft.Office.Interop.Excel.Application xlexcel;
                    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;
                    xlexcel = new Microsoft.Office.Interop.Excel.Application();
                    xlexcel.Visible = true;
                    xlWorkBook = xlexcel.Workbooks.Add(misValue);
                    xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                    CR.Select();
                    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                }
            }
           
        }

        private void copyAlltoClipboard(MetroFramework.Controls.MetroGrid grid)
        {
            grid.SelectAll();
            DataObject dataObj = grid.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void btnExportPembukuan_Click(object sender, EventArgs e)
        {
            if (GridPembukuan.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Anda yakin ingin melakukan export ke Excel?", "Exporting to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    copyAlltoClipboard(GridPembukuan);
                    Microsoft.Office.Interop.Excel.Application xlexcel;
                    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;
                    xlexcel = new Microsoft.Office.Interop.Excel.Application();
                    xlexcel.Visible = true;
                    xlWorkBook = xlexcel.Workbooks.Add(misValue);
                    xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                    CR.Select();
                    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                }
            }
       
        }
    }
}
