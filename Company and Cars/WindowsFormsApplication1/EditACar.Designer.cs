namespace WindowsFormsApplication1
{
    partial class frmEditACar
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
            this.grpCarDetails = new System.Windows.Forms.GroupBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblCarId = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtFuel = new System.Windows.Forms.TextBox();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.grpCarDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(152, 57);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(294, 365);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 57);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(592, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(152, 57);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel/Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpCarDetails
            // 
            this.grpCarDetails.Controls.Add(this.lblComments);
            this.grpCarDetails.Controls.Add(this.lblDate);
            this.grpCarDetails.Controls.Add(this.lblFuel);
            this.grpCarDetails.Controls.Add(this.lblRegistration);
            this.grpCarDetails.Controls.Add(this.lblMake);
            this.grpCarDetails.Controls.Add(this.lblCarId);
            this.grpCarDetails.Controls.Add(this.txtComments);
            this.grpCarDetails.Controls.Add(this.txtDate);
            this.grpCarDetails.Controls.Add(this.txtFuel);
            this.grpCarDetails.Controls.Add(this.txtReg);
            this.grpCarDetails.Controls.Add(this.txtMake);
            this.grpCarDetails.Controls.Add(this.txtCarID);
            this.grpCarDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCarDetails.Location = new System.Drawing.Point(12, 12);
            this.grpCarDetails.Name = "grpCarDetails";
            this.grpCarDetails.Size = new System.Drawing.Size(732, 336);
            this.grpCarDetails.TabIndex = 3;
            this.grpCarDetails.TabStop = false;
            this.grpCarDetails.Text = "Car Details:";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(63, 299);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(86, 18);
            this.lblComments.TabIndex = 11;
            this.lblComments.Text = "Comments:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(17, 248);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(145, 18);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "Date of Last Service:";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(63, 201);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(93, 18);
            this.lblFuel.TabIndex = 9;
            this.lblFuel.Text = "Type of Fuel:";
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Location = new System.Drawing.Point(63, 146);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(91, 18);
            this.lblRegistration.TabIndex = 8;
            this.lblRegistration.Text = "Registration:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(40, 89);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(122, 18);
            this.lblMake.TabIndex = 7;
            this.lblMake.Text = "Make and Model:";
            // 
            // lblCarId
            // 
            this.lblCarId.AutoSize = true;
            this.lblCarId.Location = new System.Drawing.Point(108, 34);
            this.lblCarId.Name = "lblCarId";
            this.lblCarId.Size = new System.Drawing.Size(54, 18);
            this.lblCarId.TabIndex = 6;
            this.lblCarId.Text = "Car ID:";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(168, 296);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(544, 24);
            this.txtComments.TabIndex = 5;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(168, 242);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(544, 24);
            this.txtDate.TabIndex = 4;
            // 
            // txtFuel
            // 
            this.txtFuel.Location = new System.Drawing.Point(168, 195);
            this.txtFuel.Name = "txtFuel";
            this.txtFuel.Size = new System.Drawing.Size(544, 24);
            this.txtFuel.TabIndex = 3;
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(168, 140);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(544, 24);
            this.txtReg.TabIndex = 2;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(168, 86);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(544, 24);
            this.txtMake.TabIndex = 1;
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(168, 31);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(544, 24);
            this.txtCarID.TabIndex = 0;
            // 
            // frmEditACar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 438);
            this.Controls.Add(this.grpCarDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Name = "frmEditACar";
            this.Text = "Edit A Car";
            this.Load += new System.EventHandler(this.frmEditACar_Load);
            this.grpCarDetails.ResumeLayout(false);
            this.grpCarDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpCarDetails;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtFuel;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblCarId;
    }
}