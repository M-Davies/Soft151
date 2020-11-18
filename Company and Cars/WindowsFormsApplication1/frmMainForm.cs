using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; //gets the array collections
using System.IO; //gets the file collections

namespace WindowsFormsApplication1
{
    //COMPANY ORDER = ID NUMBER, NAME, ADDRESS, POSTCODE, NUMBER OF CARS, THE LIST OF CARS (ARRAYLIST) 
    //CAR ORDER = ID NUMBER, MAKE, REGISTRATION, TYPE OF FUEL, DATE OF LAST SERVICE, COMMENTS

    public partial class frmMainForm : Form
    {
        //Create reference to jump back to.
        public static frmMainForm KeepMainForm = null;

        //Declare file location.
        public static string fileLocation = @"Companies + Cars.txt";

        //Declare big array
        public static ArrayList allObjects;

        //Declare selection index.
        public static int selectedCompany;
        public static int selectedCar;

        public frmMainForm()
        {
            InitializeComponent();

            //Provides reference point to jump back to.
            KeepMainForm = this;

            //Creates big array. 
            allObjects = new ArrayList();

            //Reads file.
            readReport();

            //Shows Companies.
            showCompanyData();

            //Selects the first company and car.
            setSelected();   
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Clears all listboxes and textboxes.
            clearAll();

            showCompanyData();

            setSelected();
        }

        private void readReport()
        {
            try
            {
                //Declare company variables.
                string compID, compName, compAddress, compPostcode;
                int compNoOfCars;
                ArrayList allCars;

                //Declare car variables.
                string carID, carMake, carReg, carFuel, carDateService, carComments;

                //Open stream reader
                StreamReader readFile = new StreamReader(fileLocation);

                //While there is still content in the file.
                while (!readFile.EndOfStream)
                {
                    //Read file and assign data to variables.
                    compID = readFile.ReadLine();
                    compName = readFile.ReadLine();
                    compAddress = readFile.ReadLine();
                    compPostcode = readFile.ReadLine();
                    compNoOfCars = Convert.ToInt32(readFile.ReadLine());

                    //Open array.
                    allCars = new ArrayList();

                    //Input cars for the company.
                    for (int i = 0; i < compNoOfCars; i++)
                    {
                        carID = readFile.ReadLine();
                        carMake = readFile.ReadLine();
                        carReg = readFile.ReadLine();
                        carFuel = readFile.ReadLine();
                        carDateService = readFile.ReadLine();
                        carComments = readFile.ReadLine();

                        //Create car object.
                        Cars newCar = new Cars(carID, carMake, carReg, carFuel, carDateService, carComments);

                        //Add to array.
                        allCars.Add(newCar);
                    }

                    //Create company object.
                    Company tempCompany = new Company(compID, compName, compAddress, compPostcode, compNoOfCars, allCars);

                    //Add to array.
                    allObjects.Add(tempCompany);
                }
                //Close stream.
                readFile.Close();
            }
            //If no file is found.
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("File not found. Please check your program folder");
                Application.Exit();
            }
            
        }

        private void showCompanyData()
        {
            //Clear. 
            lstCompanies.Items.Clear();
            
            //Call string from class for all companies in array.
            foreach (Company currentCompany in allObjects)
            {
                //Import output from class.
                string output = currentCompany.getCompanyInfo();                
                
                //Display.
                lstCompanies.Items.Add(output);
            }
        }

        private void showCarData()
        {
            try
            {
                if (selectedCompany >= 0 && selectedCar >= 0)
                {
                    //Clear.
                    lstCars.Items.Clear();

                    //Specify company.
                    Company tempCompany = (Company)allObjects[selectedCompany];

                    //Display in listbox.
                    foreach (Cars currentCar in tempCompany.getListOfCars())
                    {
                        lstCars.Items.Add(currentCar.getCarInfo());
                    }
                }
            }

            //Catches a double click by the user on the listbox.
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("--Please select a company to view--");
            }
        }

        public static void writeAll()
        {
            try
            {
                //Open writer.
                StreamWriter writeOut = new StreamWriter(fileLocation);

                //Write out company array.
                foreach (Company c in allObjects)
                {
                    writeOut.WriteLine(c.getIDNumber());
                    writeOut.WriteLine(c.getName());
                    writeOut.WriteLine(c.getAddress());
                    writeOut.WriteLine(c.getPostcode());
                    writeOut.WriteLine(c.getNumberOfCars());

                    //Write out car array's inside company array.                                
                    foreach (Cars car in c.getListOfCars())
                    {
                        writeOut.WriteLine(car.getIDNumber());
                        writeOut.WriteLine(car.getMake());
                        writeOut.WriteLine(car.getRegistration());
                        writeOut.WriteLine(car.getTypeOfFuel());
                        writeOut.WriteLine(car.getDateOfLastService());
                        writeOut.WriteLine(car.getComments());
                    }
                }

                //Close writer.
                writeOut.Close();
            }
            //If blocked by the antivirus.
            catch(UnauthorizedAccessException)
            {
                MessageBox.Show("Access to the file has been blocked. Please check your antivirus settings");
            }
            
        }

        private void showCompDataInBoxes()
        {
            try
            {
                if (selectedCompany >= 0)
                {
                    //Create index.
                    Company tempCompany = (Company)allObjects[selectedCompany];

                    //Grab data from class in selected company.
                    string id = tempCompany.getIDNumber();
                    string name = tempCompany.getName();
                    string address = tempCompany.getAddress();
                    string postcode = tempCompany.getPostcode();
                    int numberOfCars = tempCompany.getNumberOfCars();

                    //Output in text boxes.
                    txtCompId.Text = id;
                    txtName.Text = name;
                    txtAddress.Text = address;
                    txtPostcode.Text = postcode;
                    txtNumberOfCars.Text = Convert.ToString(numberOfCars);
                }                                
            }

            //Catches a double click by the user on the listbox.
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("--Please select a car to view--");
            }
        }

        private void showCarDatainBoxes()
        {
            try
            {
                if (selectedCompany >= 0 && selectedCar >= 0)
                {
                    //Create local array.
                    ArrayList carSelectionArray = ((Company)allObjects[selectedCompany]).getListOfCars();

                    //Create index.
                    Cars tempCar = (Cars)carSelectionArray[selectedCar];

                    //Grab data from class in selected company.
                    string id = tempCar.getIDNumber();
                    string make = tempCar.getMake();
                    string reg = tempCar.getRegistration();
                    string fuel = tempCar.getTypeOfFuel();
                    string date = tempCar.getDateOfLastService();
                    string comments = tempCar.getComments();

                    //Output in textboxes
                    txtCarId.Text = id;
                    txtMake.Text = make;
                    txtReg.Text = reg;
                    txtFuel.Text = fuel;
                    txtDate.Text = date;
                    txtComments.Text = comments;
                }                
            }

            //Catches a double click by the user on the listbox.
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("--Please select a car to view--");
            }
        }

        private void deleteCompany()
        {
            if (lstCompanies.SelectedItems.Count == 1)
            {
                //Finds length of textbox.
                int lengthOfTextBox = txtCompId.TextLength;

                if (lengthOfTextBox >= 1)
                {
                    //Confirmation of deletion.
                    DialogResult confirmation = MessageBox.Show("Are you sure you wish to delete this?",
                        "Confirmation", MessageBoxButtons.YesNo);

                    if (confirmation == DialogResult.Yes)
                    {
                        try
                        {
                            //Specify company for deletion.
                            allObjects.RemoveAt(selectedCompany);

                            //Update file.
                            writeAll();

                            //Confirmation.
                            MessageBox.Show("Selected company has been successfully deleted");
                        }
                        //If user did not select a company after an empty searchbox.
                        catch (ArgumentOutOfRangeException)
                        {
                            MessageBox.Show("Please select a company to delete");
                        }

                    }
                    else if (confirmation == DialogResult.No)
                    {
                        MessageBox.Show("Confirmation was denied. No changes have been made");
                    }
                }
                //If details are empty (used to prevent user from deleting a company they haven't selected).
                else
                {
                    MessageBox.Show("Please select a company to delete");
                }

                //Clear.
                lstCompanies.Items.Clear();
                lstCars.Items.Clear();
                clearAll();

                //Refresh.
                showCompanyData();
            }
            //If more than one item is selected.
            else if (lstCompanies.SelectedItems.Count > 1)
            {
                MessageBox.Show("You have selected more than one item in the company list. \nPlease remove any unnecessary selected listbox items");
            }
        }

        private void deleteCar()
        {
            if (lstCars.SelectedItems.Count == 1)
            {
                //Read length of textbox.
                int lengthOfTextBox = txtCarId.TextLength;

                if (lengthOfTextBox >= 1)
                {
                    //Confirmation of deletion. 
                    DialogResult confirmation = MessageBox.Show("Are you sure wish to delete this?",
                        "Confirmation", MessageBoxButtons.YesNo);

                    if (confirmation == DialogResult.Yes)
                    {
                        try
                        {
                            //Remove from big array (also specfies which car to delete).
                            ((Company)allObjects[selectedCompany]).getListOfCars().RemoveAt(selectedCar);

                            //Update number of cars.
                            ((Company)allObjects[selectedCompany]).setNumberOfCars(((Company)allObjects[selectedCompany]).getNumberOfCars() - 1);

                            //Update file.
                            writeAll();

                            //Confirmation.
                            MessageBox.Show("Selected Car has been successfully deleted");
                        }
                        //If user did not select a car after an empty searchbox.
                        catch (ArgumentOutOfRangeException)
                        {
                            MessageBox.Show("Please select a car to delete");
                            showCarData();
                        }

                    }
                    else if (confirmation == DialogResult.No)
                    {
                        MessageBox.Show("Confirmation was denied. No changes have been made");
                    }
                }
                else //If details are empty (used to prevent the user from deleting a car they haven't selected).
                {
                    MessageBox.Show("Please select a car to delete");
                }

                //Clear.
                lstCompanies.Items.Clear();
                lstCars.Items.Clear();
                clearAll();

                //Refresh report.
                showCompanyData();
                showCarData();
            }
            //If more than one item is selected.
            else if (lstCars.SelectedItems.Count > 1)
            {
                MessageBox.Show("You have selected more than one item in the cars list. \nPlease remove any unnecessary selected listbox items");
            }
        }

        private void clearAll()
        {
            //Clear lists.
            lstCompanies.Items.Clear();

            //Clear boxes.
            txtCompId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtPostcode.Clear();
            txtNumberOfCars.Clear();

            txtCarId.Clear();
            txtMake.Clear();
            txtReg.Clear();
            txtFuel.Clear();
            txtDate.Clear();
            txtComments.Clear();
        }

        private void setSelected()
        {
            try
            {
                //Select first company and car in list.
                lstCompanies.SetSelected(0, true);
                lstCars.SetSelected(0, true);
            }

            //If no companies/cars are in the file.
            catch (ArgumentOutOfRangeException)
            {
                lstCompanies.ClearSelected();
                lstCars.ClearSelected();
            }
        }

        private void searchCompanies()
        {            
            if (txtCompSearch.Text != "")
            {
                //Clear.
                lstCompanies.ClearSelected();

                //While there are still items to look for.
                for (int i = 0; i < lstCompanies.Items.Count; i++)
                {
                    //Checks input to see if string contains the input.
                    if (lstCompanies.Items[i].ToString().ToLower().Contains(txtCompSearch.Text.ToLower()))
                    {
                        //Highlights matches if so.
                        lstCompanies.SetSelected(i, true);
                    }                    
                }
            }
            else if (txtCompSearch.Text == "")
            {
                //Clears if textbox is empty.
                lstCompanies.ClearSelected();

                try
                {
                    lstCompanies.SetSelected(0, true);
                }
                catch (ArgumentOutOfRangeException)
                {
                    //if there are no companies
                    MessageBox.Show("No results found");
                }
            }
        }

        private void searchCars()
        {
            if (txtCarSearch.Text != "")
            {
                //Clear.
                lstCars.ClearSelected();

                //While there are still items to look for.
                for (int i = 0; i < lstCars.Items.Count; i++)
                {
                    //Checks input to see if string contains the text.
                    if (lstCars.Items[i].ToString().ToLower().Contains(txtCarSearch.Text.ToLower()))
                    {
                        //Highlights matches if so.
                        lstCars.SetSelected(i, true);
                    }
                }
            }
            else if (txtCarSearch.Text == "")
            {
                //Clears if textbox is empty.
                lstCars.ClearSelected();
                try
                {
                    lstCars.SetSelected(0, true);
                }
                catch (ArgumentOutOfRangeException)
                {
                    lstCars.ClearSelected();                    
                }
            }            
        }

        private void lstCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Select company to view car.
            selectedCompany = lstCompanies.SelectedIndex;
            showCarData();

            //Show details in text boxes for easy reading.
            showCompDataInBoxes();

            try
            {
                //Selects first car in company.
                lstCars.SetSelected(0, true);
            }
            catch (ArgumentOutOfRangeException)
            {
                lstCars.ClearSelected();
            }        
        }

        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Select car.
            selectedCar = lstCars.SelectedIndex;
             
            //Show details in text boxes for easy reading.
            showCarDatainBoxes();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (lstCompanies.SelectedItems.Count == 1)
            {
                //Find length of comp id.
                int lengthOfTextBox = txtCompId.TextLength;

                if (lengthOfTextBox >= 1)
                {
                    //Open add car form and hide this one.
                    frmAddACar OpenAddACar = new frmAddACar();
                    OpenAddACar.Show();
                    this.Hide();
                }

                //If empty (used to prevent the user from trying to add a car to a company they haven't selected).
                else
                {
                    MessageBox.Show("Please select a company to add the car to");
                }
            }
            //If more than one item is selected.
            else if (lstCompanies.SelectedItems.Count > 1)
            {
                MessageBox.Show("You have selected more than one item in the company list. \nPlease remove any unnecessary selected listbox items");
            }
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            //Find length of car id.
            int lengthOfTextBox = txtCarId.TextLength;

            if (lengthOfTextBox >= 1)
            {
                if (lstCars.SelectedItems.Count == 1)
                {
                    //Open edit car form and hide this one.
                    frmEditACar OpenEditACar = new frmEditACar();
                    OpenEditACar.Show();
                    this.Hide();
                }
                //If more than one item is selected.
                else if (lstCars.SelectedItems.Count > 1)
                {
                    MessageBox.Show("You have selected more than one item in the cars list. \nPlease remove any unnecessary selected listbox items");
                }
            }

            //If empty (used to prevent the user from trying to edit a car they haven't selected).
            else
            {
                MessageBox.Show("Please select a car to edit");
            }
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {            
                //Open Add Company form and hide this one.
                frmAddACompany OpenAddACompany = new frmAddACompany();
                OpenAddACompany.Show();
                this.Hide();                        
        }

        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            //Find length of company id.
            int lengthOfTextBox = txtCompId.TextLength;

            if (lengthOfTextBox >= 1)
            {
                if (lstCompanies.SelectedItems.Count == 1)
                {
                    //Open Edit Company form and hide this one.
                    frmEditACompany OpenEditACompany = new frmEditACompany();
                    OpenEditACompany.Show();
                    this.Hide();
                }
                //If more than one item is selected.
                else if (lstCompanies.SelectedItems.Count > 1)
                {
                    MessageBox.Show("You have selected more than one item in the company list. \nPlease remove any unnecessary selected listbox items");
                }                
            }

            //If empty (used to prevent the user from trying to edit a company they haven't selected).
            else
            {
                MessageBox.Show("Please select a company to edit");
            }
        }

        private void btnCompDelete_Click(object sender, EventArgs e)
        {
            deleteCompany();
            setSelected();
        }

        private void btnCarDelete_Click(object sender, EventArgs e)
        {
            deleteCar();
            setSelected();
        }

        private void txtCompSearch_TextChanged(object sender, EventArgs e)
        {
            searchCompanies();

            //Counts number of selected items in car list.
            int numberOfItems = lstCompanies.SelectedItems.Count;

            //If there are no results from the search, select the first company. This was done to avoid a bug appearing in the code where conducting
            //an action with an unselected car or company causes a wipe of the listbox data.
            if (numberOfItems == 0)
            {
                try
                {
                    lstCompanies.SetSelected(0, true);
                }
                catch (ArgumentOutOfRangeException)
                {
                    //If entering into an empty file.
                    MessageBox.Show("No companies in the file");
                }

            }
        }

        private void txtCarSearch_TextChanged(object sender, EventArgs e)
        {
            searchCars();

            //Counts number of selected items in car list.
            int numberOfItems = lstCars.SelectedItems.Count;

            //If there are no results from the search, select the first car.
            if (numberOfItems == 0)
            {
                try
                {
                    lstCars.SetSelected(0, true);
                }
                catch(ArgumentOutOfRangeException)
                {
                    //If entering into an empty company.
                    MessageBox.Show("No cars in the company");
                }
                
            }
        }

        private void btnClearCompSearch_Click(object sender, EventArgs e)
        {
            //Clear.
            txtCompSearch.Clear();
            lstCompanies.ClearSelected();
            clearAll();

            //Show companies.
            showCompanyData();

            //Select first company and car.
            setSelected();
        }

        private void btnClearCarSearch_Click(object sender, EventArgs e)
        {
            //Clear.
            txtCarSearch.Clear();

            //Clear textboxes (has to be seperate to the clearAll method as program doesnt update otherwise).
            txtCarId.Clear();
            txtMake.Clear();
            txtReg.Clear();
            txtFuel.Clear();
            txtDate.Clear();
            txtComments.Clear();

            //Show companies.
            showCompanyData();

            //Select first company and car.
            setSelected();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the program.
            Application.Exit();
        }
    }
}