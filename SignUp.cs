using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //adding SQL object

namespace Login
{
    public partial class SignUp : Form
    {
        private SqlConnection sqlConnection;
        private string connectionString = @"Data Source=DESKTOP-RG7KVHB\SQLEXPRESS; Initial Catalog=VendorLogin; 
            Integrated Security=True; TrustServerCertificate=True;"; //Access File
        public SignUp()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(connectionString);
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            new LoginInfo().Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Check does the password match with the confirm password
            if(txtNewPassword.Text != txtConfirmPasswords.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            //Insert new user into the database
            try 
            {
                //opens the connection
                sqlConnection.Open();

                //Builds a simple SQL command to intert the data 
                var username = txtNewUsername.Text;
                var password = txtNewPassword.Text;

                string query = $"INSERT INTO VendorCredentials (Username, Password) VALUES (@username, @password)";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                command.ExecuteNonQuery(); //Execute the command, performs inserting and updating

                sqlConnection.Close(); //closes connection

                MessageBox.Show("User registered successfully! Please go back and log in.");
                new LoginInfo().Show();
                this.Close();
            }

            //Message for any errors that were caught
            catch(Exception ex)
            {
                MessageBox.Show("Failed to register: " + ex.Message);
            }
        }
    }
}
