namespace WindowsFormsApplication1
{
    partial class frmAddACompany
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.txtNumberOfCars = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCompID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCompId = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNumberOfCars = new System.Windows.Forms.Label();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 67);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Add Company";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(240, 254);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 67);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(495, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 67);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel/Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.txtNumberOfCars);
            this.grpDetails.Controls.Add(this.lblPostcode);
            this.grpDetails.Controls.Add(this.txtPostcode);
            this.grpDetails.Controls.Add(this.txtAddress);
            this.grpDetails.Controls.Add(this.lblCompID);
            this.grpDetails.Controls.Add(this.txtName);
            this.grpDetails.Controls.Add(this.lblName);
            this.grpDetails.Controls.Add(this.txtCompId);
            this.grpDetails.Controls.Add(this.lblAddress);
            this.grpDetails.Controls.Add(this.lblNumberOfCars);
            this.grpDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.Location = new System.Drawing.Point(12, 12);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(633, 224);
            this.grpDetails.TabIndex = 3;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Please enter company details:";
            // 
            // txtNumberOfCars
            // 
            this.txtNumberOfCars.Location = new System.Drawing.Point(133, 177);
            this.txtNumberOfCars.Name = "txtNumberOfCars";
            this.txtNumberOfCars.ReadOnly = true;
            this.txtNumberOfCars.Size = new System.Drawing.Size(469, 24);
            this.txtNumberOfCars.TabIndex = 13;
            this.txtNumberOfCars.Text = "0";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(55, 135);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(72, 18);
            this.lblPostcode.TabIndex = 7;
            this.lblPostcode.Text = "Postcode";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(133, 135);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(469, 24);
            this.txtPostcode.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(130, 101);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(469, 24);
            this.txtAddress.TabIndex = 11;
            // 
            // lblCompID
            // 
            this.lblCompID.AutoSize = true;
            this.lblCompID.Location = new System.Drawing.Point(30, 38);
            this.lblCompID.Name = "lblCompID";
            this.lblCompID.Size = new System.Drawing.Size(94, 18);
            this.lblCompID.TabIndex = 4;
            this.lblCompID.Text = "Company ID:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(469, 24);
            this.txtName.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(72, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // txtCompId
            // 
            this.txtCompId.Location = new System.Drawing.Point(130, 35);
            this.txtCompId.Name = "txtCompId";
            this.txtCompId.Size = new System.Drawing.Size(469, 24);
            this.txtCompId.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(58, 101);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 18);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address:";
            // 
            // lblNumberOfCars
            // 
            this.lblNumberOfCars.AutoSize = true;
            this.lblNumberOfCars.Location = new System.Drawing.Point(6, 177);
            this.lblNumberOfCars.Name = "lblNumberOfCars";
            this.lblNumberOfCars.Size = new System.Drawing.Size(121, 18);
            this.lblNumberOfCars.TabIndex = 8;
            this.lblNumberOfCars.Text = "Number Of Cars:";
            // 
            // frmAddACompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 342);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Name = "frmAddACompany";
            this.Text = "Add A Company";
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblCompID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblNumberOfCars;
        private System.Windows.Forms.TextBox txtCompId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtNumberOfCars;
    }
}