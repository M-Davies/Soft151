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
    public partial class frmEditACompany : Form
    {
        //Declare which comany data using selected index.
        Company currentComp = (Company)frmMainForm.allObjects[frmMainForm.selectedCompany];
        public frmEditACompany()
        {
            InitializeComponent();
        }

        private void getCompanyDetails()
        {
            try
            { 
            //Input details into textboxes.
            txtIdNumber.Text = currentComp.getIDNumber();
            txtName.Text = currentComp.getName();
            txtAddress.Text = currentComp.getAddress();
            txtPostcode.Text = currentComp.getPostcode();
            txtNumberOfCars.Text = Convert.ToString(currentComp.getNumberOfCars());
            }

            //If cars is not lined up correctly in file.
            catch (FormatException)
            {
                MessageBox.Show("--Number of Cars is not a number or does not equal the number of cars in the company. Please check your data and try again--");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Create exception handler.
            bool InputOK = false;

            //Validation check of textboxes.
            InputOK = Company.textboxIsNotNull(txtIdNumber, "the ID Number") && Company.textboxIsNotNull(txtName, "the Company Name") && Company.textboxIsNotNull(txtAddress, "the Company Address")
                && Company.textboxIsNotNull(txtPostcode, "the Company Postcode") && Company.textboxIsNotNull(txtNumberOfCars, "the Number of Cars");

            if (InputOK)
            {
                try
                {
                    //Get inputs.
                    string id = txtIdNumber.Text;
                    string name = txtName.Text;
                    string address = txtAddress.Text;
                    string postcode = txtPostcode.Text;
                    int numberOfCars = Convert.ToInt32(txtNumberOfCars.Text);
                    ArrayList listOfCars = currentComp.getListOfCars();

                    //Update company with new details.
                    Company updated = new Company(id, name, address, postcode, numberOfCars, listOfCars);

                    //Update array.
                    frmMainForm.allObjects[frmMainForm.selectedCompany] = updated;

                    //Write out.
                    frmMainForm.writeAll();

                    //Show confirmation.
                    MessageBox.Show(name + " was updated successfully");
                }
                catch (FormatException)
                {
                    MessageBox.Show("--Number of Cars is not an number or does not equal the total number of cars in the company. Please check your data and try again--");
                }
            }           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear
            txtIdNumber.Clear();
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

        private void EditACompany_Load(object sender, EventArgs e)
        {
            //Input details into text boxes.
            getCompanyDetails();
        }
    }
}