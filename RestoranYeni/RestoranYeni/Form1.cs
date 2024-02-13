using Microsoft.Win32;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RestoranYeni
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\restoran.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.Show();
            this.Hide();
        }

        public bool EmptyFields()
        {
            return string.IsNullOrEmpty(login_username.Text) || string.IsNullOrEmpty(login_password.Text);
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
            {
                MessageBox.Show("All fields are required to be filled", "Error Message", MessageBoxButtons.OK);
                return;
            }

            try
            {
                if (connect != null && connect.State == ConnectionState.Closed)
                {
                    connect.Open();

                    string selectAccount = "SELECT COUNT(*) FROM users WHERE username = @usern AND password = @pass AND status = @status";
                    using (SqlCommand cmd = new SqlCommand(selectAccount, connect))
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", "Active");

                        int rowCount = (int)cmd.ExecuteScalar();

                        if (rowCount > 0)
                        {
                            string selectRole = "SELECT role FROM users WHERE username = @usern and password=@pass";
                            using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                            {
                                getRole.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                                getRole.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                                string userRole = getRole.ExecuteScalar() as string;

                                MessageBox.Show("Login Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (userRole == "Admin")
                                {
                                    AdminMainForm adminForm = new AdminMainForm();
                                    adminForm.Show();
                                    this.Hide();
                                }
                                else if (userRole == "Cashier")
                                {
                                    CashierMainForm cashierForm = new CashierMainForm();
                                    cashierForm.Show();
                                    this.Hide();
                                }



                                if (remind_me.Checked)
                                {
                                    Properties.Settings.Default.beniHatirla = true;
                                    Properties.Settings.Default.uname = login_username.Text;
                                    Properties.Settings.Default.sifre = login_password.Text;
                                }
                                else
                                {
                                    Properties.Settings.Default.uname = string.Empty;
                                    Properties.Settings.Default.sifre = string.Empty;
                                    Properties.Settings.Default.beniHatirla = false;
                                }

                                Properties.Settings.Default.Save();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username/password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.beniHatirla)
            {
                remind_me.Checked = true;
                login_username.Text = Properties.Settings.Default.uname;
                login_password.Text = Properties.Settings.Default.sifre;
            }
        }
    }
}
