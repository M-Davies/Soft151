using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms; //allows use of the 'textbox' data type

namespace WindowsFormsApplication1
{
    class Company
    {
        //ORDER = ID NUMBER, NAME, ADDRESS, POSTCODE, NUMBER OF CARS, THE LIST OF CARS (ARRAYLIST) 

        //Declare variables.
        private string IDNumber;
        private string name;
        private string address;
        private string postcode;
        private int numberOfCars;
        private ArrayList theirCars;

        //Build constructor.
        public Company(string theIDNumber, string theName, string theAddress, string thePostcode, int theNumberOfCars, ArrayList theListOfCars)
        {
            IDNumber = theIDNumber;
            name = theName;
            address = theAddress;
            postcode = thePostcode;
            numberOfCars = theNumberOfCars;
            theirCars = theListOfCars;
        }

        //Open empty constructor. 
        public Company()
        {
        }

        //Getters.
        public string getCompanyInfo()
        {
            string output;
            output = "ID NUMBER = " + IDNumber + " NAME = " + name + " ADDRESS = " + address + " POSTCODE = " + postcode + " NUMBER OF CARS = " + numberOfCars;
            return output;
        }
        public string getIDNumber()
        {
            return IDNumber;
        }
        public string getName()
        {
            return name;
        }
        public string getAddress()
        {
            return address;
        }
        public string getPostcode()
        {
            return postcode;
        }
        public int getNumberOfCars()
        {
            return numberOfCars;
        }
        public ArrayList getListOfCars()
        {
            return theirCars;
        }

        //Setters.
        public void setIDNumber(string inIDNumber)
        {
            IDNumber = inIDNumber;
        }
        public void setName(string inName)
        {
            name = inName;
        }
        public void setAddress(string inAddress)
        {
            address = inAddress; 
        }
        public void setPostcode(string inPostcode)
        {
            postcode = inPostcode;
        }
        public void setNumberOfCars(int inNumberOfCars)
        {
            numberOfCars = inNumberOfCars;
        }
        public void setTheListOfCars(ArrayList inListOfCars)
        {
            theirCars = inListOfCars;
        }

        //Exception handling (When adding a company with a null textbox).
        public static bool textboxIsNotNull(TextBox txtSelected, String userFeedback)
        {
            if (txtSelected.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("ERROR - The input for " + userFeedback + " cannot be empty!. Please try again");
                txtSelected.Focus();
                return false;
            }
            else
                return true;
        }
    }
}
