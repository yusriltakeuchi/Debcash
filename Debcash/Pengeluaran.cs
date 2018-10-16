using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debcash
{
    public partial class Pengeluaran : MetroFramework.Forms.MetroForm
    {
        //Get Displayname
        public string displayname = "";
        public Pengeluaran()
        {
            InitializeComponent();
        }

        private void Pengeluaran_Load(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin menginput pengeluaran?", "Input Pengeluaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtKeterangan.Text != string.Empty && txtNominal.Text != string.Empty)
                {
                    DateTime dates = datePengeluaran.Value;
                    string keterangan = txtKeterangan.Text;
                    int nominal = int.Parse(txtNominal.Text);

                    Accounting.Saldo saldo = new Accounting.Saldo();
                    int _saldo = saldo.GetSaldo();
                    Accounting.Pengeluaran pengeluaran = new Accounting.Pengeluaran(dates, keterangan, nominal, _saldo);

                    pengeluaran.InputPengeluaran();

                    saldo.UpdateSaldoDecre(nominal);

                    MessageBox.Show("Pengeluaran berhasil diinput!", "Pengeluaran Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Accounting.Summary summary = new Accounting.Summary(string.Empty);
                    summary.InputHistory(dates, displayname + " menginput pengeluaran", txtKeterangan.Text, nominal);

                    txtNominal.Text = string.Empty;
                    txtKeterangan.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Silahkan isi semua field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
