using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Debcash.Account;

namespace Debcash
{
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        //Object untuk registrasi
        Registration register;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin data sudah benar?", "Registrasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty
                && txtConfirmPassword.Text != string.Empty && txtEmail.Text != string.Empty
                && txtFirstname.Text != string.Empty && txtLastname.Text != string.Empty)
                {
                    if (txtEmail.Text.Contains("@"))
                    {
                        if (txtPassword.Text == txtConfirmPassword.Text)
                        {
                            register = new Registration();
                            if (!register.UserExists(txtUsername.Text))
                            {
                                Task<bool> regis = new Task<bool>(() => register.Register(txtUsername.Text, txtPassword.Text, txtFirstname.Text, txtLastname.Text, txtEmail.Text));
                                regis.Start();

                                if (await regis)
                                {
                                    MessageBox.Show("Pendaftaran akun berhasil!", "Registrasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username tersebut sudah ada", "Gagal Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Confirm Password harus sesuai", "Gagal Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Format email salah", "Gagal Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Semua field harus diisi", "Gagal Registrasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
    }
}
