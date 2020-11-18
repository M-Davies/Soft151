using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //ORDER = ID NUMBER, MAKE, REGISTRATION, TYPE OF FUEL, DATE OF LAST SERVICE, COMMENTS
    public partial class frmAddACar : Form
    {
        public static frmAddACar KeepfrmAddACar = null;
        public frmAddACar()
        {
            InitializeComponent();
            KeepfrmAddACar = this; 
        }

        private void addingACar(string id, string make, string reg, string fuel, string date, string comments)
        {
            //Create object.
            Cars newCar = new Cars(id, make, reg, fuel, date, comments);

            //Add to array.
            ((Company) frmMainForm.allObjects[frmMainForm.selectedCompany]).getListOfCars().Add(newCar);

            //Update number of cars in array.
            ((Company)frmMainForm.allObjects[frmMainForm.selectedCompany]).setNumberOfCars(((Company)frmMainForm.allObjects[frmMainForm.selectedCompany]).getNumberOfCars() + 1);

            //Write car to file.
            frmMainForm.writeAll();

            //Confirmation for user.
            MessageBox.Show(make + " has been successfully added");
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            //Create exception handler.
            bool InputOK = false;

            //Validation check of textboxes.
            InputOK = Cars.textboxIsNotNull(txtCarID, "the Car ID") && Cars.textboxIsNotNull(txtMakeAndModel, "the Car Make/Model") && Cars.textboxIsNotNull(txtRegistration, "the Car Registration")
                && Cars.textboxIsNotNull(txtTypeOfFuel, "the Type of Fuel") && Cars.textboxIsNotNull(txtServiceDate, "the Date of Service") &&
                Cars.textboxIsNotNull(txtComments, "the Comments Section");

            if (InputOK)
            {
                //Declare and assign.
                string idNum = txtCarID.Text;
                string make = txtMakeAndModel.Text;
                string reg = txtRegistration.Text;
                string fuel = txtTypeOfFuel.Text;
                string date = txtServiceDate.Text;
                string comments = txtComments.Text;

                //Display new car in array.
                addingACar(idNum, make, reg, fuel, date, comments);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Back to main form.
            frmMainForm OpenMainForm = new frmMainForm();
            OpenMainForm.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear.
            txtCarID.Clear();
            txtMakeAndModel.Clear();
            txtRegistration.Clear();
            txtTypeOfFuel.Clear();
            txtServiceDate.Clear();
            txtComments.Clear();
        }
    }
}
