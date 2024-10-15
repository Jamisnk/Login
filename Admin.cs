using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            new LoginInfo().Show();
            this.Close();
        }

        private void btnNewVendorLog_Click(object sender, EventArgs e)
        {
            new NewVendorInfo().Show();
            this.Close();
        }

        private void btnViewUserData_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendorLoginDataSet.VendorCredentials' table. You can move, or remove it, as needed.
            this.vendorCredentialsTableAdapter.Fill(this.vendorLoginDataSet.VendorCredentials);
            
            gdUserData.DataSource = this.vendorLoginDataSet.VendorCredentials;

            //Visibility settings
            gdUserData.Visible = true;
            gdUserData.BringToFront();
            dgNewVendor.Visible = false;
            dgVendorDelivery.Visible = false;
        }

        private void btnViewVendorData_Click(object sender, EventArgs e)
        {
            //loads new vendor data
            this.newVendorCDTableAdapter.Fill(this.newVendorCred.NewVendorCD);

            dgNewVendor.DataSource = this.newVendorCred.NewVendorCD;
            
            //visibility settings
            dgNewVendor.Visible = true;
            dgNewVendor.BringToFront();
            gdUserData.Visible = false;
            dgVendorDelivery.Visible = false;
        }

        private void btnViewVendorDelivery_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendorInfoData.VendorInfo' table. You can move, or remove it, as needed.
            this.vendorInformationTableAdapter.Fill(this.newVendorInformation.VendorInformation);
            dgVendorDelivery.DataSource = this.newVendorInformation.VendorInformation;

            dgVendorDelivery.Visible = true;
            dgVendorDelivery.BringToFront();
            gdUserData.Visible = false;
            dgNewVendor.Visible = false;
        }
    }
}
