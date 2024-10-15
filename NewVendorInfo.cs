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
using System.Xml.Linq;
using System.Data.SqlClient; //adding SQL object

namespace Login
{
    public partial class NewVendorInfo : Form
    {
        //Creates Excel Application
        private SqlConnection sqlConnection;
        private string connectionString = @"Data Source=DESKTOP-RG7KVHB\SQLEXPRESS; Initial Catalog=VendorLogin; 
            Integrated Security=True; TrustServerCertificate=True;"; //Access File
        public NewVendorInfo()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            //Open the file dialog
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Loads image into picturebox
                    picVendorPhoto.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Failed to load the photo: " + ex.Message);
                }
            }
        }

        private void btnNewLog_Click(object sender, EventArgs e)
        {
            new NewVendorInfo().Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sqlCommandText = @"INSERT INTO VendorInformation (New_VID, POC_Name, POC_JobTitle, POC_Email, POC_Phone, POC_Company, POC_CompanyAddress, City)
            VALUES (@New_VID, @POC_Name, @POC_JobTitle, @POC_Email, @POC_Phone, @POC_Company, @POC_CompanyAddress, @City)";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                //Gets the next ID
                long nextId = GetNextID(sqlConnection);

                using (SqlCommand sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
                {
                    //Convert ID to long if its bigint
                    sqlCommand.Parameters.AddWithValue("@New_VID", nextId);

                    //Adds other peramers at strings
                    sqlCommand.Parameters.AddWithValue("@POC_Name", txtPOCName.Text);
                    sqlCommand.Parameters.AddWithValue("@POC_JobTitle", txtPOCJobTitle.Text);
                    sqlCommand.Parameters.AddWithValue("@POC_Email", txtPOCEmail.Text);
                    sqlCommand.Parameters.AddWithValue("@POC_Phone", txtPOCPhone.Text);
                    sqlCommand.Parameters.AddWithValue("@POC_Company", txtPOCCompany.Text);
                    sqlCommand.Parameters.AddWithValue("@POC_CompanyAddress", txtPOCCompany.Text);
                    sqlCommand.Parameters.AddWithValue("@City", listBox1.GetItemText(listBox1.SelectedItem));
                  

                    sqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Vendor information saved sucessfully!");
                sqlConnection.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits Application
            Application.Exit();
        }

        //Function to retrieve the next ID from the database
        public int GetNextID(SqlConnection sqlConnection)
        {
            sqlConnection.Open();

            string query = "SELECCT ISNULL(MAX(ID), 0) + 1 FROM VenderInformation";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            //Use ExecuteScalar to get next ID, solve data type from nvarchar to bigint
            return (int)cmd.ExecuteScalar();
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            new Admin().Show();
            this.Close();
        }
    }
}
