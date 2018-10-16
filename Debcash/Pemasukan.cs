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
    public partial class Pemasukan : MetroFramework.Forms.MetroForm
    {
        //Get Displayname
        public string displayname = "";
        //Object for summary
        public Pemasukan()
        {
            InitializeComponent();
        }

        private void Pemasukan_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin menginput pemasukan?", "Input Pemasukan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( result == DialogResult.Yes)
            {
                if (txtKeterangan.Text != string.Empty && txtNominal.Text != string.Empty)
                {
                    DateTime dates = datePemasukan.Value;
                    string keterangan = txtKeterangan.Text;
                    int nominal = int.Parse(txtNominal.Text);

                    Accounting.Saldo saldo = new Accounting.Saldo();
                    int _saldo = saldo.GetSaldo();
                    Accounting.Pemasukan pemasukan = new Accounting.Pemasukan(dates, keterangan, nominal, _saldo);

                    pemasukan.InputPemasukan();

                    saldo.UpdateSaldoIncre(nominal);

                    MessageBox.Show("Pemasukan berhasil diinput!", "Pemasukan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Accounting.Summary summary = new Accounting.Summary(string.Empty);
                    summary.InputHistory(dates, displayname + " menginput pemasukan", txtKeterangan.Text, nominal);

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
