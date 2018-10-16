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
using System.Threading;

namespace Debcash
{
    public partial class Installation : MetroFramework.Forms.MetroForm
    {
        //Object name for DatabaseHelper
        DBHelper dbHelper;
        //Give a status installation
        public bool success = false;
        public Installation()
        {
            InitializeComponent();
        }

        private async void Installation_Load(object sender, EventArgs e)
        {
            if (!DBExists())
            {
                lblStatus.Text = "Membuat database baru...";
                CreateDBFile();
            }
            else
            {
                CreateTable();
            }

        }

        private bool DBExists()
        {
            bool exists = false;
            dbHelper = new DBHelper();
            if (File.Exists(dbHelper.DBName))
            {
                exists = true;
            }
            return exists;
        }

        private async void CreateDBFile()
        {
            dbHelper = new DBHelper();
            try
            {
                File.Create(dbHelper.DBName);
                await Task.Delay(2000);
                lblStatus.Text = "File berhasil dibuat...";
                await Task.Delay(2000);
                lblStatus.Text = "Silahkan buka ulang aplikasi...";
                btnExit.Visible = true;
            }
            catch(Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private async void CreateTable()
        {
            dbHelper = new DBHelper();
            try
            {
                lblStatus.Text = "Membuat tabel database...";
                dbHelper.CreateTable();
                await Task.Delay(2000);
                lblStatus.Text = "Proses instalasi sukses...";
                await Task.Delay(2000);
                success = true;
                this.Close();
            }
            catch(Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
