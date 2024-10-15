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
using System.Data.SqlClient; //adding SQL object

namespace Login
{
    public partial class VendorInfo : Form
    {
        //Creates Excel Application
        private SqlConnection sqlConnection;
        private string connectionString = @"Data Source=DESKTOP-RG7KVHB\SQLEXPRESS; Initial Catalog=VendorLogin; 
            Integrated Security=True; TrustServerCertificate=True;"; //Access File
        public VendorInfo()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlCommandText = @"INSERT INTO VendorInfo (ID, Name, Company, Cell, City, Products, Diary_products, Delivery, Payment)
            VALUES (@ID, @Name, @Company, @Cell, @City, @Products, @Diary_products, @Delivery, @Payment)";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                //Gets the next ID
                long nextId = GetNextID(sqlConnection);

                using (SqlCommand sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
                {
                    //Convert ID to long if its bigint
                    sqlCommand.Parameters.AddWithValue("@ID", nextId);

                    //Adds other peramers at strings
                    sqlCommand.Parameters.AddWithValue("@Name", txtName.Text);
                    sqlCommand.Parameters.AddWithValue("@Company", txtCompany.Text);
                    sqlCommand.Parameters.AddWithValue("@Cell", txtCell.Text);
                    sqlCommand.Parameters.AddWithValue("@City", listBox1.GetItemText(listBox1.SelectedItem));
                    string product = rdCoffee.Checked ? "Coffee" :
                                 rdGreenTea.Checked ? "Green Tea" :
                                 rdHerbs.Checked ? "Herbs" : "";
                    string dairyproduct = rdMilk.Checked ? "Milk" :
                                 rdCream.Checked ? "Cream" : "";
                    string deliveryStatus = ckDelayed.Checked ? "Delayed" :
                                ckOntime.Checked ? "On Time" : "";
                    string paymentStatus = ckPaid.Checked ? "Paid" :
                                    ckUnpaid.Checked ? "Unpaid" : "";
                    sqlCommand.Parameters.AddWithValue("@Products", product);
                    sqlCommand.Parameters.AddWithValue("@Diary_products", dairyproduct);
                    sqlCommand.Parameters.AddWithValue("@Delivery", deliveryStatus);
                    sqlCommand.Parameters.AddWithValue("@Payment", paymentStatus);

                    sqlCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Vendor information saved sucessfully!");
                sqlConnection.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Exits Application
            Application.Exit();
        }

        //Function to retrieve the next ID from the database
        public int GetNextID(SqlConnection sqlConnection)
        {
            sqlConnection.Open();

            string query = "SELECCT ISNULL(MAX(ID), 0) + 1 FROM VendorInfo";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            //Use ExecuteScalar to get next ID, solve data type from nvarchar to bigint
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new LoginInfo().Show();
            this.Close();
        }
    }
}
