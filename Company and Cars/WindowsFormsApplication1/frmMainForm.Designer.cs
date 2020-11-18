namespace WindowsFormsApplication1
{
    partial class frmMainForm
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lstCompanies = new System.Windows.Forms.ListBox();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.lblCompanies = new System.Windows.Forms.Label();
            this.lblCars = new System.Windows.Forms.Label();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.btnEditCompany = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.grpCompanyDetails = new System.Windows.Forms.GroupBox();
            this.btnCompDelete = new System.Windows.Forms.Button();
            this.lblNumberOfCars = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCompId = new System.Windows.Forms.Label();
            this.txtNumberOfCars = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCompId = new System.Windows.Forms.TextBox();
            this.grpCarDetails = new System.Windows.Forms.GroupBox();
            this.btnCarDelete = new System.Windows.Forms.Button();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblDateService = new System.Windows.Forms.Label();
            this.lblTypeOfFuel = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblCarId = new System.Windows.Forms.Label();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtFuel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtCarId = new System.Windows.Forms.TextBox();
            this.txtCompSearch = new System.Windows.Forms.TextBox();
            this.txtCarSearch = new System.Windows.Forms.TextBox();
            this.btnClearCarSearch = new System.Windows.Forms.Button();
            this.btnClearCompSearch = new System.Windows.Forms.Button();
            this.grpOptions.SuspendLayout();
            this.grpCompanyDetails.SuspendLayout();
            this.grpCarDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(16, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 39);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lstCompanies
            // 
            this.lstCompanies.FormattingEnabled = true;
            this.lstCompanies.Location = new System.Drawing.Point(165, 30);
            this.lstCompanies.Name = "lstCompanies";
            this.lstCompanies.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCompanies.Size = new System.Drawing.Size(973, 134);
            this.lstCompanies.TabIndex = 2;
            this.lstCompanies.SelectedIndexChanged += new System.EventHandler(this.lstCompanies_SelectedIndexChanged);
            // 
            // lstCars
            // 
            this.lstCars.FormattingEnabled = true;
            this.lstCars.Location = new System.Drawing.Point(165, 194);
            this.lstCars.Name = "lstCars";
            this.lstCars.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCars.Size = new System.Drawing.Size(973, 264);
            this.lstCars.TabIndex = 3;
            this.lstCars.SelectedIndexChanged += new System.EventHandler(this.lstCars_SelectedIndexChanged);
            // 
            // lblCompanies
            // 
            this.lblCompanies.AutoSize = true;
            this.lblCompanies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanies.Location = new System.Drawing.Point(161, 6);
            this.lblCompanies.Name = "lblCompanies";
            this.lblCompanies.Size = new System.Drawing.Size(93, 20);
            this.lblCompanies.TabIndex = 4;
            this.lblCompanies.Text = "Companies:";
            // 
            // lblCars
            // 
            this.lblCars.AutoSize = true;
            this.lblCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCars.Location = new System.Drawing.Point(165, 171);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(46, 20);
            this.lblCars.TabIndex = 5;
            this.lblCars.Text = "Cars:";
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCompany.Location = new System.Drawing.Point(16, 75);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(105, 68);
            this.btnAddCompany.TabIndex = 1;
            this.btnAddCompany.Text = "Add Company";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCompany.Location = new System.Drawing.Point(16, 157);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Size = new System.Drawing.Size(105, 71);
            this.btnEditCompany.TabIndex = 2;
            this.btnEditCompany.Text = "Edit Company";
            this.btnEditCompany.UseVisualStyleBackColor = true;
            this.btnEditCompany.Click += new System.EventHandler(this.btnEditCompany_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(16, 240);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(105, 71);
            this.btnAddCar.TabIndex = 3;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCar.Location = new System.Drawing.Point(16, 325);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(105, 71);
            this.btnEditCar.TabIndex = 4;
            this.btnEditCar.Text = "Edit Car";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(16, 408);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.btnExit);
            this.grpOptions.Controls.Add(this.btnEditCar);
            this.grpOptions.Controls.Add(this.btnAddCar);
            this.grpOptions.Controls.Add(this.btnEditCompany);
            this.grpOptions.Controls.Add(this.btnAddCompany);
            this.grpOptions.Controls.Add(this.btnRefresh);
            this.grpOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOptions.Location = new System.Drawing.Point(12, 12);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(147, 453);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Admin Features:";
            // 
            // grpCompanyDetails
            // 
            this.grpCompanyDetails.Controls.Add(this.btnCompDelete);
            this.grpCompanyDetails.Controls.Add(this.lblNumberOfCars);
            this.grpCompanyDetails.Controls.Add(this.lblPostcode);
            this.grpCompanyDetails.Controls.Add(this.lblAddress);
            this.grpCompanyDetails.Controls.Add(this.lblName);
            this.grpCompanyDetails.Controls.Add(this.lblCompId);
            this.grpCompanyDetails.Controls.Add(this.txtNumberOfCars);
            this.grpCompanyDetails.Controls.Add(this.txtPostcode);
            this.grpCompanyDetails.Controls.Add(this.txtAddress);
            this.grpCompanyDetails.Controls.Add(this.txtName);
            this.grpCompanyDetails.Controls.Add(this.txtCompId);
            this.grpCompanyDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCompanyDetails.Location = new System.Drawing.Point(1147, 6);
            this.grpCompanyDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpCompanyDetails.Name = "grpCompanyDetails";
            this.grpCompanyDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpCompanyDetails.Size = new System.Drawing.Size(213, 211);
            this.grpCompanyDetails.TabIndex = 6;
            this.grpCompanyDetails.TabStop = false;
            this.grpCompanyDetails.Text = "Company Details:";
            // 
            // btnCompDelete
            // 
            this.btnCompDelete.Location = new System.Drawing.Point(59, 169);
            this.btnCompDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompDelete.Name = "btnCompDelete";
            this.btnCompDelete.Size = new System.Drawing.Size(125, 30);
            this.btnCompDelete.TabIndex = 12;
            this.btnCompDelete.Text = "Delete";
            this.btnCompDelete.UseVisualStyleBackColor = true;
            this.btnCompDelete.Click += new System.EventHandler(this.btnCompDelete_Click);
            // 
            // lblNumberOfCars
            // 
            this.lblNumberOfCars.AutoSize = true;
            this.lblNumberOfCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfCars.Location = new System.Drawing.Point(5, 141);
            this.lblNumberOfCars.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfCars.Name = "lblNumberOfCars";
            this.lblNumberOfCars.Size = new System.Drawing.Size(106, 16);
            this.lblNumberOfCars.TabIndex = 10;
            this.lblNumberOfCars.Text = "Number Of Cars:";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(42, 107);
            this.lblPostcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(69, 16);
            this.lblPostcode.TabIndex = 9;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(49, 75);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 16);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(61, 50);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // lblCompId
            // 
            this.lblCompId.AutoSize = true;
            this.lblCompId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompId.Location = new System.Drawing.Point(88, 21);
            this.lblCompId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompId.Name = "lblCompId";
            this.lblCompId.Size = new System.Drawing.Size(24, 16);
            this.lblCompId.TabIndex = 6;
            this.lblCompId.Text = "ID:";
            // 
            // txtNumberOfCars
            // 
            this.txtNumberOfCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfCars.Location = new System.Drawing.Point(115, 138);
            this.txtNumberOfCars.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumberOfCars.Name = "txtNumberOfCars";
            this.txtNumberOfCars.ReadOnly = true;
            this.txtNumberOfCars.Size = new System.Drawing.Size(95, 22);
            this.txtNumberOfCars.TabIndex = 5;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(115, 104);
            this.txtPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.ReadOnly = true;
            this.txtPostcode.Size = new System.Drawing.Size(95, 22);
            this.txtPostcode.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(115, 72);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(94, 22);
            this.txtAddress.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(114, 44);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(95, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtCompId
            // 
            this.txtCompId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompId.Location = new System.Drawing.Point(115, 18);
            this.txtCompId.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompId.Name = "txtCompId";
            this.txtCompId.ReadOnly = true;
            this.txtCompId.Size = new System.Drawing.Size(95, 22);
            this.txtCompId.TabIndex = 0;
            // 
            // grpCarDetails
            // 
            this.grpCarDetails.Controls.Add(this.btnCarDelete);
            this.grpCarDetails.Controls.Add(this.lblComments);
            this.grpCarDetails.Controls.Add(this.lblDateService);
            this.grpCarDetails.Controls.Add(this.lblTypeOfFuel);
            this.grpCarDetails.Controls.Add(this.lblRegistration);
            this.grpCarDetails.Controls.Add(this.lblMake);
            this.grpCarDetails.Controls.Add(this.lblCarId);
            this.grpCarDetails.Controls.Add(this.txtReg);
            this.grpCarDetails.Controls.Add(this.txtComments);
            this.grpCarDetails.Controls.Add(this.txtDate);
            this.grpCarDetails.Controls.Add(this.txtFuel);
            this.grpCarDetails.Controls.Add(this.txtMake);
            this.grpCarDetails.Controls.Add(this.txtCarId);
            this.grpCarDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCarDetails.Location = new System.Drawing.Point(1147, 221);
            this.grpCarDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpCarDetails.Name = "grpCarDetails";
            this.grpCarDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpCarDetails.Size = new System.Drawing.Size(213, 244);
            this.grpCarDetails.TabIndex = 7;
            this.grpCarDetails.TabStop = false;
            this.grpCarDetails.Text = "Car Details:";
            // 
            // btnCarDelete
            // 
            this.btnCarDelete.Location = new System.Drawing.Point(63, 197);
            this.btnCarDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnCarDelete.Name = "btnCarDelete";
            this.btnCarDelete.Size = new System.Drawing.Size(125, 32);
            this.btnCarDelete.TabIndex = 14;
            this.btnCarDelete.Text = "Delete";
            this.btnCarDelete.UseVisualStyleBackColor = true;
            this.btnCarDelete.Click += new System.EventHandler(this.btnCarDelete_Click);
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(37, 163);
            this.lblComments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(75, 16);
            this.lblComments.TabIndex = 20;
            this.lblComments.Text = "Comments:";
            // 
            // lblDateService
            // 
            this.lblDateService.AutoSize = true;
            this.lblDateService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateService.Location = new System.Drawing.Point(15, 135);
            this.lblDateService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateService.Name = "lblDateService";
            this.lblDateService.Size = new System.Drawing.Size(97, 16);
            this.lblDateService.TabIndex = 19;
            this.lblDateService.Text = "Date Serviced:";
            // 
            // lblTypeOfFuel
            // 
            this.lblTypeOfFuel.AutoSize = true;
            this.lblTypeOfFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfFuel.Location = new System.Drawing.Point(26, 105);
            this.lblTypeOfFuel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeOfFuel.Name = "lblTypeOfFuel";
            this.lblTypeOfFuel.Size = new System.Drawing.Size(86, 16);
            this.lblTypeOfFuel.TabIndex = 18;
            this.lblTypeOfFuel.Text = "Type of Fuel:";
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistration.Location = new System.Drawing.Point(29, 77);
            this.lblRegistration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(83, 16);
            this.lblRegistration.TabIndex = 17;
            this.lblRegistration.Text = "Registration:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(4, 50);
            this.lblMake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(112, 16);
            this.lblMake.TabIndex = 16;
            this.lblMake.Text = "Make and Model:";
            // 
            // lblCarId
            // 
            this.lblCarId.AutoSize = true;
            this.lblCarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarId.Location = new System.Drawing.Point(88, 21);
            this.lblCarId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarId.Name = "lblCarId";
            this.lblCarId.Size = new System.Drawing.Size(24, 16);
            this.lblCarId.TabIndex = 15;
            this.lblCarId.Text = "ID:";
            // 
            // txtReg
            // 
            this.txtReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReg.Location = new System.Drawing.Point(116, 74);
            this.txtReg.Margin = new System.Windows.Forms.Padding(2);
            this.txtReg.Name = "txtReg";
            this.txtReg.ReadOnly = true;
            this.txtReg.Size = new System.Drawing.Size(97, 22);
            this.txtReg.TabIndex = 14;
            // 
            // txtComments
            // 
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(116, 160);
            this.txtComments.Margin = new System.Windows.Forms.Padding(2);
            this.txtComments.Name = "txtComments";
            this.txtComments.ReadOnly = true;
            this.txtComments.Size = new System.Drawing.Size(96, 22);
            this.txtComments.TabIndex = 13;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(117, 132);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(95, 22);
            this.txtDate.TabIndex = 12;
            // 
            // txtFuel
            // 
            this.txtFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuel.Location = new System.Drawing.Point(116, 102);
            this.txtFuel.Margin = new System.Windows.Forms.Padding(2);
            this.txtFuel.Name = "txtFuel";
            this.txtFuel.ReadOnly = true;
            this.txtFuel.Size = new System.Drawing.Size(97, 22);
            this.txtFuel.TabIndex = 11;
            // 
            // txtMake
            // 
            this.txtMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMake.Location = new System.Drawing.Point(116, 47);
            this.txtMake.Margin = new System.Windows.Forms.Padding(2);
            this.txtMake.Name = "txtMake";
            this.txtMake.ReadOnly = true;
            this.txtMake.Size = new System.Drawing.Size(97, 22);
            this.txtMake.TabIndex = 10;
            // 
            // txtCarId
            // 
            this.txtCarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarId.Location = new System.Drawing.Point(116, 15);
            this.txtCarId.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarId.Name = "txtCarId";
            this.txtCarId.ReadOnly = true;
            this.txtCarId.Size = new System.Drawing.Size(96, 22);
            this.txtCarId.TabIndex = 8;
            // 
            // txtCompSearch
            // 
            this.txtCompSearch.Location = new System.Drawing.Point(924, 5);
            this.txtCompSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompSearch.Name = "txtCompSearch";
            this.txtCompSearch.Size = new System.Drawing.Size(214, 20);
            this.txtCompSearch.TabIndex = 8;
            this.txtCompSearch.TextChanged += new System.EventHandler(this.txtCompSearch_TextChanged);
            // 
            // txtCarSearch
            // 
            this.txtCarSearch.Location = new System.Drawing.Point(924, 166);
            this.txtCarSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarSearch.Name = "txtCarSearch";
            this.txtCarSearch.Size = new System.Drawing.Size(214, 20);
            this.txtCarSearch.TabIndex = 9;
            this.txtCarSearch.TextChanged += new System.EventHandler(this.txtCarSearch_TextChanged);
            // 
            // btnClearCarSearch
            // 
            this.btnClearCarSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCarSearch.Location = new System.Drawing.Point(894, 166);
            this.btnClearCarSearch.Name = "btnClearCarSearch";
            this.btnClearCarSearch.Size = new System.Drawing.Size(25, 23);
            this.btnClearCarSearch.TabIndex = 10;
            this.btnClearCarSearch.Text = "X";
            this.btnClearCarSearch.UseVisualStyleBackColor = true;
            this.btnClearCarSearch.Click += new System.EventHandler(this.btnClearCarSearch_Click);
            // 
            // btnClearCompSearch
            // 
            this.btnClearCompSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCompSearch.Location = new System.Drawing.Point(894, 2);
            this.btnClearCompSearch.Name = "btnClearCompSearch";
            this.btnClearCompSearch.Size = new System.Drawing.Size(25, 24);
            this.btnClearCompSearch.TabIndex = 11;
            this.btnClearCompSearch.Text = "X";
            this.btnClearCompSearch.UseVisualStyleBackColor = true;
            this.btnClearCompSearch.Click += new System.EventHandler(this.btnClearCompSearch_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 473);
            this.Controls.Add(this.btnClearCompSearch);
            this.Controls.Add(this.btnClearCarSearch);
            this.Controls.Add(this.txtCarSearch);
            this.Controls.Add(this.txtCompSearch);
            this.Controls.Add(this.grpCarDetails);
            this.Controls.Add(this.grpCompanyDetails);
            this.Controls.Add(this.lblCars);
            this.Controls.Add(this.lblCompanies);
            this.Controls.Add(this.lstCars);
            this.Controls.Add(this.lstCompanies);
            this.Controls.Add(this.grpOptions);
            this.Name = "frmMainForm";
            this.Text = "Hire Car Maintenence Inc.";
            this.grpOptions.ResumeLayout(false);
            this.grpCompanyDetails.ResumeLayout(false);
            this.grpCompanyDetails.PerformLayout();
            this.grpCarDetails.ResumeLayout(false);
            this.grpCarDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox lstCompanies;
        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.Label lblCompanies;
        private System.Windows.Forms.Label lblCars;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Button btnEditCompany;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.GroupBox grpCompanyDetails;
        private System.Windows.Forms.Label lblNumberOfCars;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCompId;
        private System.Windows.Forms.TextBox txtNumberOfCars;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCompId;
        private System.Windows.Forms.GroupBox grpCarDetails;
        private System.Windows.Forms.TextBox txtCarId;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblDateService;
        private System.Windows.Forms.Label lblTypeOfFuel;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblCarId;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtFuel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Button btnCompDelete;
        private System.Windows.Forms.Button btnCarDelete;
        private System.Windows.Forms.TextBox txtCompSearch;
        private System.Windows.Forms.TextBox txtCarSearch;
        private System.Windows.Forms.Button btnClearCarSearch;
        private System.Windows.Forms.Button btnClearCompSearch;
    }
}

