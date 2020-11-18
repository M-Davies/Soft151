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
    public partial class frmEditACar : Form
    {
        public frmEditACar()
        {
            InitializeComponent();
        }

        private void getCarDetails()
        {
            //Declare what company using selected index.
            Company currentComp = (Company) frmMainForm.allObjects[frmMainForm.selectedCompany];

            //Declare what car using selected index.
            Cars currentCar = (Cars) currentComp.getListOfCars()[frmMainForm.selectedCar];

            //Inputs car info into text boxes.
            txtCarID.Text = currentCar.getIDNumber();
            txtMake.Text = currentCar.getMake();
            txtReg.Text = currentCar.getRegistration();
            txtFuel.Text = currentCar.getTypeOfFuel();
            txtDate.Text = currentCar.getDateOfLastService();
            txtComments.Text = currentCar.getComments();
        }

        private void frmEditACar_Load(object sender, EventArgs e)
        {
            getCarDetails();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Create exception handler.
            bool InputOK = false;

            //Validation check of textboxes.
            InputOK = Cars.textboxIsNotNull(txtCarID, "the Car ID") && Cars.textboxIsNotNull(txtMake, "the Car Make/Model") && Cars.textboxIsNotNull(txtReg, "the Car Registration")
                && Cars.textboxIsNotNull(txtFuel, "the Fuel Type") && Cars.textboxIsNotNull(txtDate, "the Date of Service") && Cars.textboxIsNotNull(txtComments, "the Comments Section (put N/A if no comments to add");

            if (InputOK)
            {
                //Get inputs.
                string id = txtCarID.Text;
                string make = txtMake.Text;
                string reg = txtReg.Text;
                string fuel = txtFuel.Text;
                string date = txtDate.Text;
                string comments = txtComments.Text;
                Company whichComp = (Company)frmMainForm.allObjects[frmMainForm.selectedCompany];

                //Update car with new details.
                Cars updated = new Cars(id, make, reg, fuel, date, comments);

                //Update array.
                whichComp.getListOfCars()[frmMainForm.selectedCar] = updated;

                //Write back out.
                frmMainForm.writeAll();

                //Show confirmation.
                MessageBox.Show(make + " was updated successfully");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears.
            txtCarID.Clear();
            txtMake.Clear();
            txtReg.Clear();
            txtFuel.Clear();
            txtDate.Clear();
            txtComments.Clear();
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
