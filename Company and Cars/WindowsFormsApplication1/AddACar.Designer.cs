namespace WindowsFormsApplication1
{
    partial class frmAddACar
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
            this.grpEnterDetails = new System.Windows.Forms.GroupBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.txtServiceDate = new System.Windows.Forms.TextBox();
            this.txtTypeOfFuel = new System.Windows.Forms.TextBox();
            this.txtRegistration = new System.Windows.Forms.TextBox();
            this.txtMakeAndModel = new System.Windows.Forms.TextBox();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.lblTypeOfFuel = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblMakeAndModel = new System.Windows.Forms.Label();
            this.lblCarID = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpEnterDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEnterDetails
            // 
            this.grpEnterDetails.Controls.Add(this.txtComments);
            this.grpEnterDetails.Controls.Add(this.txtServiceDate);
            this.grpEnterDetails.Controls.Add(this.txtTypeOfFuel);
            this.grpEnterDetails.Controls.Add(this.txtRegistration);
            this.grpEnterDetails.Controls.Add(this.txtMakeAndModel);
            this.grpEnterDetails.Controls.Add(this.txtCarID);
            this.grpEnterDetails.Controls.Add(this.lblComments);
            this.grpEnterDetails.Controls.Add(this.lblServiceDate);
            this.grpEnterDetails.Controls.Add(this.lblTypeOfFuel);
            this.grpEnterDetails.Controls.Add(this.lblRegistration);
            this.grpEnterDetails.Controls.Add(this.lblMakeAndModel);
            this.grpEnterDetails.Controls.Add(this.lblCarID);
            this.grpEnterDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEnterDetails.Location = new System.Drawing.Point(12, 12);
            this.grpEnterDetails.Name = "grpEnterDetails";
            this.grpEnterDetails.Size = new System.Drawing.Size(862, 297);
            this.grpEnterDetails.TabIndex = 0;
            this.grpEnterDetails.TabStop = false;
            this.grpEnterDetails.Text = "Please enter car details:";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(169, 256);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(636, 26);
            this.txtComments.TabIndex = 11;
            // 
            // txtServiceDate
            // 
            this.txtServiceDate.Location = new System.Drawing.Point(169, 212);
            this.txtServiceDate.Name = "txtServiceDate";
            this.txtServiceDate.Size = new System.Drawing.Size(636, 26);
            this.txtServiceDate.TabIndex = 10;
            // 
            // txtTypeOfFuel
            // 
            this.txtTypeOfFuel.Location = new System.Drawing.Point(169, 167);
            this.txtTypeOfFuel.Name = "txtTypeOfFuel";
            this.txtTypeOfFuel.Size = new System.Drawing.Size(636, 26);
            this.txtTypeOfFuel.TabIndex = 9;
            // 
            // txtRegistration
            // 
            this.txtRegistration.Location = new System.Drawing.Point(169, 123);
            this.txtRegistration.Name = "txtRegistration";
            this.txtRegistration.Size = new System.Drawing.Size(636, 26);
            this.txtRegistration.TabIndex = 8;
            // 
            // txtMakeAndModel
            // 
            this.txtMakeAndModel.Location = new System.Drawing.Point(169, 78);
            this.txtMakeAndModel.Name = "txtMakeAndModel";
            this.txtMakeAndModel.Size = new System.Drawing.Size(636, 26);
            this.txtMakeAndModel.TabIndex = 7;
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(169, 34);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(636, 26);
            this.txtCarID.TabIndex = 6;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(73, 262);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(90, 20);
            this.lblComments.TabIndex = 5;
            this.lblComments.Text = "Comments:";
            // 
            // lblServiceDate
            // 
            this.lblServiceDate.AutoSize = true;
            this.lblServiceDate.Location = new System.Drawing.Point(6, 218);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.Size = new System.Drawing.Size(157, 20);
            this.lblServiceDate.TabIndex = 4;
            this.lblServiceDate.Text = "Date of Last Service:";
            // 
            // lblTypeOfFuel
            // 
            this.lblTypeOfFuel.AutoSize = true;
            this.lblTypeOfFuel.Location = new System.Drawing.Point(63, 173);
            this.lblTypeOfFuel.Name = "lblTypeOfFuel";
            this.lblTypeOfFuel.Size = new System.Drawing.Size(100, 20);
            this.lblTypeOfFuel.TabIndex = 3;
            this.lblTypeOfFuel.Text = "Type of Fuel:";
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Location = new System.Drawing.Point(64, 129);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(99, 20);
            this.lblRegistration.TabIndex = 2;
            this.lblRegistration.Text = "Registration:";
            // 
            // lblMakeAndModel
            // 
            this.lblMakeAndModel.AutoSize = true;
            this.lblMakeAndModel.Location = new System.Drawing.Point(33, 84);
            this.lblMakeAndModel.Name = "lblMakeAndModel";
            this.lblMakeAndModel.Size = new System.Drawing.Size(130, 20);
            this.lblMakeAndModel.TabIndex = 1;
            this.lblMakeAndModel.Text = "Make and Model:";
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.Location = new System.Drawing.Point(104, 37);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(59, 20);
            this.lblCarID.TabIndex = 0;
            this.lblCarID.Text = "Car ID:";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(12, 328);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(182, 56);
            this.btnAddCar.TabIndex = 1;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(341, 328);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(182, 56);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(692, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(182, 56);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel/Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddACar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 402);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.grpEnterDetails);
            this.Name = "frmAddACar";
            this.Text = "Add A Car";
            this.grpEnterDetails.ResumeLayout(false);
            this.grpEnterDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEnterDetails;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.TextBox txtServiceDate;
        private System.Windows.Forms.TextBox txtTypeOfFuel;
        private System.Windows.Forms.TextBox txtRegistration;
        private System.Windows.Forms.TextBox txtMakeAndModel;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.Label lblTypeOfFuel;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblMakeAndModel;
        private System.Windows.Forms.Label lblCarID;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
    }
}