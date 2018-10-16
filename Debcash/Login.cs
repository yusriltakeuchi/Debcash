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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        //Session login success
        public bool success = false;
        //Username to pass into main
        public string username = "";
        //Object login
        private Debcash.Account.Login logins;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SaveSession)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
                cbxSession.Checked = true;
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register regis = new Register();
            regis.ShowDialog();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                logins = new Account.Login();
                if (logins.UserExists(txtUsername.Text))
                {
                    Task<bool> auth = new Task<bool>(() => logins.LoginAccount(txtUsername.Text, txtPassword.Text));
                    auth.Start();
                    try
                    {
                        if (await auth)
                        {
                            if (!Properties.Settings.Default.SaveSession)
                            {
                                success = true;
                                MessageBox.Show("Berhasil login!", "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            if (cbxSession.Checked)
                            {
                                Properties.Settings.Default.SaveSession = true;
                                Properties.Settings.Default.Username = txtUsername.Text;
                                Properties.Settings.Default.Password = txtPassword.Text;
                                Properties.Settings.Default.Save();
                                success = true;
                            }
                            else
                            {
                                Properties.Settings.Default.Username = txtUsername.Text;
                                Properties.Settings.Default.Save();

                            }
                            success = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Username atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Username atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                  
                }
            }
            else
            {
                MessageBox.Show("Username dan password kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
