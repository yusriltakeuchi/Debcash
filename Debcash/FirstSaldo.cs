using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Debcash.Accounting;

namespace Debcash
{
    public partial class FirstSaldo : MetroFramework.Forms.MetroForm
    {
        //Object name for Saldo
        Saldo saldo;
        public FirstSaldo()
        {
            InitializeComponent();
        }

        private void FirstSaldo_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (txtSaldo.Text != string.Empty)
            {
                try
                {
                    int _saldo = int.Parse(txtSaldo.Text);
                    saldo = new Saldo();
                    saldo.InsertFirst(_saldo);

                    DateTime dates = dateAwal.Value;
                    Accounting.Pemasukan pemasukan = new Accounting.Pemasukan(dates, string.Empty, 0, _saldo);

                    pemasukan.InputPemasukan();

                    MessageBox.Show("Keuangan pertama berhasil diinput!", "Saldo Awal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            }
            else
            {
                MessageBox.Show("Silahkan masukkan saldo awal", "Saldo Awal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
