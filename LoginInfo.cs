using ADODB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Access = System.Data.SqlClient; //adding an SQL Object

namespace Login
{
    public partial class LoginInfo : Form
    {
        //Creates Sql Connection
        private SqlConnection sqlConnection;
        private string connectionString = @"Data Source=DESKTOP-RG7KVHB\SQLEXPRESS; Initial Catalog=VendorLogin; 
            Integrated Security=True; TrustServerCertificate=True;"; //Access File
        public LoginInfo()
        {
            InitializeComponent();

            //Initialize SqlConnection
            sqlConnection = new SqlConnection(connectionString);
        }
        private bool ValidateUser(string username, string passwords)
        {
            sqlConnection.Open();


            string query = @"SELECT COUNT(*) AS UserCount FROM VendorCredentials WHERE Username = @username AND Password = @password";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", passwords);
            int userCount = (int)command.ExecuteScalar();
            return userCount > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateUser(txtUsername.Text, txtPassword.Text))
            {
                if (comboBoxType.SelectedItem == null)
                {
                    MessageBox.Show("Please select a valid user type.");
                    comboBoxType.Focus();
                    return;
                }

                string userSelectedType = comboBoxType.Text; //Gets selected user type

                //Fetches user type
                string userTypeQuery = "SELECT Type FROM VendorCredentials WHERE Username = @Username";
                SqlCommand command = new SqlCommand(userTypeQuery, sqlConnection);
                command.Parameters.AddWithValue("@Username", txtUsername.Text);

                string sqlType = (string)command.ExecuteScalar();
                sqlConnection.Close();

                if (userSelectedType == sqlType)
                {
                    //User type correct
                    if (userSelectedType == "Admin")
                    {
                        new Admin().Show();
                        this.Hide();
                    }
                    else if (userSelectedType == "Vendor")
                    {
                        new NewVendorInfo().Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("User type is incorrect! Please select the correct user type.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or passwords!");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }


        private void label3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '*')
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }
    }
}
