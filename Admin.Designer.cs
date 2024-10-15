namespace Login
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnViewUserData = new System.Windows.Forms.Button();
            this.btnViewVendorData = new System.Windows.Forms.Button();
            this.btnViewVendorDelivery = new System.Windows.Forms.Button();
            this.btnBackLogin = new System.Windows.Forms.Button();
            this.btnNewVendorLog = new System.Windows.Forms.Button();
            this.gdUserData = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorCredentialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorLoginDataSet = new Login.VendorLoginDataSet();
            this.vendorCredentialsTableAdapter = new Login.VendorLoginDataSetTableAdapters.VendorCredentialsTableAdapter();
            this.vendorInfoData = new Login.VendorInfoData();
            this.vendorInfoTableAdapter = new Login.VendorInfoDataTableAdapters.VendorInfoTableAdapter();
            this.dgNewVendor = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newVendorCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newVendorCred = new Login.NewVendorCred();
            this.newVendorCDTableAdapter = new Login.NewVendorCredTableAdapters.NewVendorCDTableAdapter();
            this.dgVendorDelivery = new System.Windows.Forms.DataGridView();
            this.newVendorInformation = new Login.NewVendorInformation();
            this.vendorInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorInformationTableAdapter = new Login.NewVendorInformationTableAdapters.VendorInformationTableAdapter();
            this.pOCNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCJobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOCCompanyAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdUserData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorCredentialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLoginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNewVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorCDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorCred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendorDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewUserData
            // 
            this.btnViewUserData.Location = new System.Drawing.Point(50, 108);
            this.btnViewUserData.Name = "btnViewUserData";
            this.btnViewUserData.Size = new System.Drawing.Size(185, 52);
            this.btnViewUserData.TabIndex = 0;
            this.btnViewUserData.Text = "View User Data";
            this.btnViewUserData.UseVisualStyleBackColor = true;
            this.btnViewUserData.Click += new System.EventHandler(this.btnViewUserData_Click);
            // 
            // btnViewVendorData
            // 
            this.btnViewVendorData.Location = new System.Drawing.Point(50, 351);
            this.btnViewVendorData.Name = "btnViewVendorData";
            this.btnViewVendorData.Size = new System.Drawing.Size(185, 52);
            this.btnViewVendorData.TabIndex = 0;
            this.btnViewVendorData.Text = "View New Vendor Data";
            this.btnViewVendorData.UseVisualStyleBackColor = true;
            this.btnViewVendorData.Click += new System.EventHandler(this.btnViewVendorData_Click);
            // 
            // btnViewVendorDelivery
            // 
            this.btnViewVendorDelivery.Location = new System.Drawing.Point(50, 234);
            this.btnViewVendorDelivery.Name = "btnViewVendorDelivery";
            this.btnViewVendorDelivery.Size = new System.Drawing.Size(185, 52);
            this.btnViewVendorDelivery.TabIndex = 0;
            this.btnViewVendorDelivery.Text = "View Vendor Delivery";
            this.btnViewVendorDelivery.UseVisualStyleBackColor = true;
            this.btnViewVendorDelivery.Click += new System.EventHandler(this.btnViewVendorDelivery_Click);
            // 
            // btnBackLogin
            // 
            this.btnBackLogin.Location = new System.Drawing.Point(833, 555);
            this.btnBackLogin.Name = "btnBackLogin";
            this.btnBackLogin.Size = new System.Drawing.Size(185, 52);
            this.btnBackLogin.TabIndex = 0;
            this.btnBackLogin.Text = "Back";
            this.btnBackLogin.UseVisualStyleBackColor = true;
            this.btnBackLogin.Click += new System.EventHandler(this.btnBackLogin_Click);
            // 
            // btnNewVendorLog
            // 
            this.btnNewVendorLog.Location = new System.Drawing.Point(50, 555);
            this.btnNewVendorLog.Name = "btnNewVendorLog";
            this.btnNewVendorLog.Size = new System.Drawing.Size(185, 52);
            this.btnNewVendorLog.TabIndex = 0;
            this.btnNewVendorLog.Text = "New Vendor Log";
            this.btnNewVendorLog.UseVisualStyleBackColor = true;
            this.btnNewVendorLog.Click += new System.EventHandler(this.btnNewVendorLog_Click);
            // 
            // gdUserData
            // 
            this.gdUserData.AllowUserToOrderColumns = true;
            this.gdUserData.AutoGenerateColumns = false;
            this.gdUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdUserData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.gdUserData.DataSource = this.vendorCredentialsBindingSource;
            this.gdUserData.Location = new System.Drawing.Point(272, 35);
            this.gdUserData.Name = "gdUserData";
            this.gdUserData.RowHeadersWidth = 62;
            this.gdUserData.RowTemplate.Height = 28;
            this.gdUserData.Size = new System.Drawing.Size(746, 462);
            this.gdUserData.TabIndex = 1;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 150;
            // 
            // vendorCredentialsBindingSource
            // 
            this.vendorCredentialsBindingSource.DataMember = "VendorCredentials";
            this.vendorCredentialsBindingSource.DataSource = this.vendorLoginDataSet;
            // 
            // vendorLoginDataSet
            // 
            this.vendorLoginDataSet.DataSetName = "VendorLoginDataSet";
            this.vendorLoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorCredentialsTableAdapter
            // 
            this.vendorCredentialsTableAdapter.ClearBeforeFill = true;
            // 
            // vendorInfoData
            // 
            this.vendorInfoData.DataSetName = "VendorInfoData";
            this.vendorInfoData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorInfoTableAdapter
            // 
            this.vendorInfoTableAdapter.ClearBeforeFill = true;
            // 
            // dgNewVendor
            // 
            this.dgNewVendor.AutoGenerateColumns = false;
            this.dgNewVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNewVendor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn1});
            this.dgNewVendor.DataSource = this.newVendorCDBindingSource;
            this.dgNewVendor.Location = new System.Drawing.Point(272, 35);
            this.dgNewVendor.Name = "dgNewVendor";
            this.dgNewVendor.RowHeadersWidth = 62;
            this.dgNewVendor.RowTemplate.Height = 28;
            this.dgNewVendor.Size = new System.Drawing.Size(746, 462);
            this.dgNewVendor.TabIndex = 2;
            // 
            // usernameDataGridViewTextBoxColumn1
            // 
            this.usernameDataGridViewTextBoxColumn1.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn1.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.usernameDataGridViewTextBoxColumn1.Name = "usernameDataGridViewTextBoxColumn1";
            this.usernameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn1
            // 
            this.passwordDataGridViewTextBoxColumn1.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn1.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn1.Name = "passwordDataGridViewTextBoxColumn1";
            this.passwordDataGridViewTextBoxColumn1.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            this.typeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // newVendorCDBindingSource
            // 
            this.newVendorCDBindingSource.DataMember = "NewVendorCD";
            this.newVendorCDBindingSource.DataSource = this.newVendorCred;
            // 
            // newVendorCred
            // 
            this.newVendorCred.DataSetName = "NewVendorCred";
            this.newVendorCred.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newVendorCDTableAdapter
            // 
            this.newVendorCDTableAdapter.ClearBeforeFill = true;
            // 
            // dgVendorDelivery
            // 
            this.dgVendorDelivery.AutoGenerateColumns = false;
            this.dgVendorDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendorDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pOCNameDataGridViewTextBoxColumn,
            this.pOCJobTitleDataGridViewTextBoxColumn,
            this.pOCEmailDataGridViewTextBoxColumn,
            this.pOCPhoneDataGridViewTextBoxColumn,
            this.pOCCompanyDataGridViewTextBoxColumn,
            this.pOCCompanyAddressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn});
            this.dgVendorDelivery.DataSource = this.vendorInformationBindingSource;
            this.dgVendorDelivery.Location = new System.Drawing.Point(272, 35);
            this.dgVendorDelivery.Name = "dgVendorDelivery";
            this.dgVendorDelivery.RowHeadersWidth = 62;
            this.dgVendorDelivery.RowTemplate.Height = 28;
            this.dgVendorDelivery.Size = new System.Drawing.Size(746, 462);
            this.dgVendorDelivery.TabIndex = 3;
            // 
            // newVendorInformation
            // 
            this.newVendorInformation.DataSetName = "NewVendorInformation";
            this.newVendorInformation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorInformationBindingSource
            // 
            this.vendorInformationBindingSource.DataMember = "VendorInformation";
            this.vendorInformationBindingSource.DataSource = this.newVendorInformation;
            // 
            // vendorInformationTableAdapter
            // 
            this.vendorInformationTableAdapter.ClearBeforeFill = true;
            // 
            // pOCNameDataGridViewTextBoxColumn
            // 
            this.pOCNameDataGridViewTextBoxColumn.DataPropertyName = "POC_Name";
            this.pOCNameDataGridViewTextBoxColumn.HeaderText = "POC_Name";
            this.pOCNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCNameDataGridViewTextBoxColumn.Name = "pOCNameDataGridViewTextBoxColumn";
            this.pOCNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCJobTitleDataGridViewTextBoxColumn
            // 
            this.pOCJobTitleDataGridViewTextBoxColumn.DataPropertyName = "POC_JobTitle";
            this.pOCJobTitleDataGridViewTextBoxColumn.HeaderText = "POC_JobTitle";
            this.pOCJobTitleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCJobTitleDataGridViewTextBoxColumn.Name = "pOCJobTitleDataGridViewTextBoxColumn";
            this.pOCJobTitleDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCEmailDataGridViewTextBoxColumn
            // 
            this.pOCEmailDataGridViewTextBoxColumn.DataPropertyName = "POC_Email";
            this.pOCEmailDataGridViewTextBoxColumn.HeaderText = "POC_Email";
            this.pOCEmailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCEmailDataGridViewTextBoxColumn.Name = "pOCEmailDataGridViewTextBoxColumn";
            this.pOCEmailDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCPhoneDataGridViewTextBoxColumn
            // 
            this.pOCPhoneDataGridViewTextBoxColumn.DataPropertyName = "POC_Phone";
            this.pOCPhoneDataGridViewTextBoxColumn.HeaderText = "POC_Phone";
            this.pOCPhoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCPhoneDataGridViewTextBoxColumn.Name = "pOCPhoneDataGridViewTextBoxColumn";
            this.pOCPhoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCCompanyDataGridViewTextBoxColumn
            // 
            this.pOCCompanyDataGridViewTextBoxColumn.DataPropertyName = "POC_Company";
            this.pOCCompanyDataGridViewTextBoxColumn.HeaderText = "POC_Company";
            this.pOCCompanyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCCompanyDataGridViewTextBoxColumn.Name = "pOCCompanyDataGridViewTextBoxColumn";
            this.pOCCompanyDataGridViewTextBoxColumn.Width = 150;
            // 
            // pOCCompanyAddressDataGridViewTextBoxColumn
            // 
            this.pOCCompanyAddressDataGridViewTextBoxColumn.DataPropertyName = "POC_CompanyAddress";
            this.pOCCompanyAddressDataGridViewTextBoxColumn.HeaderText = "POC_CompanyAddress";
            this.pOCCompanyAddressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pOCCompanyAddressDataGridViewTextBoxColumn.Name = "pOCCompanyAddressDataGridViewTextBoxColumn";
            this.pOCCompanyAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 150;
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            this.photoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            this.photoDataGridViewTextBoxColumn.Width = 150;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 672);
            this.Controls.Add(this.dgVendorDelivery);
            this.Controls.Add(this.dgNewVendor);
            this.Controls.Add(this.gdUserData);
            this.Controls.Add(this.btnNewVendorLog);
            this.Controls.Add(this.btnBackLogin);
            this.Controls.Add(this.btnViewVendorDelivery);
            this.Controls.Add(this.btnViewVendorData);
            this.Controls.Add(this.btnViewUserData);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdUserData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorCredentialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLoginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInfoData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNewVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorCDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorCred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendorDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVendorInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorInformationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewUserData;
        private System.Windows.Forms.Button btnViewVendorData;
        private System.Windows.Forms.Button btnViewVendorDelivery;
        private System.Windows.Forms.Button btnBackLogin;
        private System.Windows.Forms.Button btnNewVendorLog;
        private System.Windows.Forms.DataGridView gdUserData;
        private VendorLoginDataSet vendorLoginDataSet;
        private VendorLoginDataSetTableAdapters.VendorCredentialsTableAdapter vendorCredentialsTableAdapter;
        private VendorInfoData vendorInfoData;
        private VendorInfoDataTableAdapters.VendorInfoTableAdapter vendorInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vendorCredentialsBindingSource;
        private System.Windows.Forms.DataGridView dgNewVendor;
        private NewVendorCred newVendorCred;
        private NewVendorCredTableAdapters.NewVendorCDTableAdapter newVendorCDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource newVendorCDBindingSource;
        private System.Windows.Forms.DataGridView dgVendorDelivery;
        private NewVendorInformation newVendorInformation;
        private System.Windows.Forms.BindingSource vendorInformationBindingSource;
        private NewVendorInformationTableAdapters.VendorInformationTableAdapter vendorInformationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCJobTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOCCompanyAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
    }
}