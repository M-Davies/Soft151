using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class frmAddACompany : Form
    {
        public static frmAddACompany KeepAddACompany = null;
        public frmAddACompany()
        {
            InitializeComponent();
            KeepAddACompany = this;
        }

        //ORDER = ID NUMBER, NAME, ADDRESS, POSTCODE, NUMBER OF CARS, THE LIST OF CARS (ARRAYLIST)

        private void addACompany(string id, string name, string address, string postcode, int numberOfCars, ArrayList listOfCars)
        {
            //Create object.
            Company newComp = new Company(id, name, address, postcode, numberOfCars, listOfCars);

            //Add to array. 
            frmMainForm.allObjects.Add(newComp);

            //Update file.
            frmMainForm.writeAll();

            //Confirmation of completion.
            MessageBox.Show(name + " has been successfully added");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Create exception handler.
            bool InputOK = false;

            //Validation check of textboxes.
            InputOK = Company.textboxIsNotNull(txtCompId, "the Company ID") && Company.textboxIsNotNull(txtName, "the Company Name") && Company.textboxIsNotNull(txtAddress, "the Address") &&
                Company.textboxIsNotNull(txtPostcode, "the Postcode") && Company.textboxIsNotNull(txtNumberOfCars, "the Number Of Cars");

            if (InputOK)
            {
                //Get inputs.
                string id = txtCompId.Text;
                string name = txtName.Text;
                string address = txtAddress.Text;
                string postcode = txtPostcode.Text;
                int numberOfCars = Convert.ToInt32(txtNumberOfCars.Text);
                ArrayList listOfCars = new ArrayList();

                //Assign inputs to new company.
                addACompany(id, name, address, postcode, numberOfCars, listOfCars);

                //Back to main form.
                frmMainForm OpenMainForm = new frmMainForm();
                OpenMainForm.Show();
                this.Hide();
            }                               
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear fields.
            txtCompId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtPostcode.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Back to main form.
            frmMainForm OpenMainForm = new frmMainForm();
            OpenMainForm.Show();
            this.Hide();
        }
    }
}
