namespace WindowsFormsApplication1
{
    partial class frmEditACompany
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
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtNumberOfCars = new System.Windows.Forms.TextBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblNumberOfCars = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(152, 169);
            this.txtPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(507, 22);
            this.txtPostcode.TabIndex = 0;
            // 
            // txtNumberOfCars
            // 
            this.txtNumberOfCars.Location = new System.Drawing.Point(152, 219);
            this.txtNumberOfCars.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumberOfCars.Name = "txtNumberOfCars";
            this.txtNumberOfCars.ReadOnly = true;
            this.txtNumberOfCars.Size = new System.Drawing.Size(507, 22);
            this.txtNumberOfCars.TabIndex = 1;
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(152, 25);
            this.txtIdNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(507, 22);
            this.txtIdNumber.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 76);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(507, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(152, 122);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(507, 22);
            this.txtAddress.TabIndex = 4;
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.lblNumberOfCars);
            this.grpDetails.Controls.Add(this.lblAddress);
            this.grpDetails.Controls.Add(this.lblPostcode);
            this.grpDetails.Controls.Add(this.lblName);
            this.grpDetails.Controls.Add(this.lblIdNumber);
            this.grpDetails.Controls.Add(this.txtIdNumber);
            this.grpDetails.Controls.Add(this.txtNumberOfCars);
            this.grpDetails.Controls.Add(this.txtAddress);
            this.grpDetails.Controls.Add(this.txtPostcode);
            this.grpDetails.Controls.Add(this.txtName);
            this.grpDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetails.Location = new System.Drawing.Point(11, 10);
            this.grpDetails.Margin = new System.Windows.Forms.Padding(2);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Padding = new System.Windows.Forms.Padding(2);
            this.grpDetails.Size = new System.Drawing.Size(678, 266);
            this.grpDetails.TabIndex = 5;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Company Details:";
            // 
            // lblNumberOfCars
            // 
            this.lblNumberOfCars.AutoSize = true;
            this.lblNumberOfCars.Location = new System.Drawing.Point(27, 222);
            this.lblNumberOfCars.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfCars.Name = "lblNumberOfCars";
            this.lblNumberOfCars.Size = new System.Drawing.Size(106, 16);
            this.lblNumberOfCars.TabIndex = 9;
            this.lblNumberOfCars.Text = "Number Of Cars:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(71, 122);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 16);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address:";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(64, 172);
            this.lblPostcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(69, 16);
            this.lblPostcode.TabIndex = 7;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(85, 79);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Location = new System.Drawing.Point(63, 28);
            this.lblIdNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(85, 16);
            this.lblIdNumber.TabIndex = 5;
            this.lblIdNumber.Text = "Company ID:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(17, 294);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 48);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(278, 294);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(146, 48);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(524, 294);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 48);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel/Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEditACompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 352);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpDetails);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEditACompany";
            this.Text = "Edit A Company";
            this.Load += new System.EventHandler(this.EditACompany_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtNumberOfCars;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblNumberOfCars;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
    }
}