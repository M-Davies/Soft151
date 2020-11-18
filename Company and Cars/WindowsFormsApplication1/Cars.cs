using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //allows use of the 'textbox' object type

namespace WindowsFormsApplication1
{
    class Cars
    {
        //ORDER = ID NUMBER, MAKE, REGISTRATION, TYPE OF FUEL, DATE OF LAST SERVICE, COMMENTS

        //Declare.
        private string idNumber;
        private string make;
        private string registration;
        private string typeOfFuel;
        private string dateOfLastService;
        private string comments;

        //Build constructor.
        public Cars(string theIDNumber, string theMake, string theRegistration, string theTypeOfFuel, string theDateofService, string theComments)
        {
            idNumber = theIDNumber;
            make = theMake;
            registration = theRegistration;
            typeOfFuel = theTypeOfFuel;
            dateOfLastService = theDateofService;
            comments = theComments;
        }

        //Open empty constructor.
        public Cars()
        {
        }

        //Getters.
        public string getCarInfo()
        {
            string output;
            output = "ID NUMBER = " + idNumber + " MAKE = " + make + " REGISTRATION = " + registration + " TYPE OF FUEL = " + typeOfFuel + " DATE OF LAST SERIVCE = " + dateOfLastService + " COMMENTS = " + comments;
            return output;
        }
        public string getIDNumber()
        {
            return idNumber;
        }
        public string getMake()
        {
            return make;
        }
        public string getRegistration()
        {
            return registration;
        }
        public string getTypeOfFuel()
        {
            return typeOfFuel;
        }
        public string getDateOfLastService()
        {
            return dateOfLastService;
        }
        public string getComments()
        {
            return comments;
        }

        //Setters.
        public void setIDNumber(string inIDNumber)
        {
            idNumber = inIDNumber;
        }
        public void setMake(string inMake)
        {
            make = inMake;
        }
        public void setRegistration(string inRegistration)
        {
            registration = inRegistration;
        }
        public void setTypeOfFuel(string inTypeOfFuel)
        {
            typeOfFuel = inTypeOfFuel;
        }
        public void setDateofLastService(string inDateOfLastService)
        {
            dateOfLastService = inDateOfLastService;
        }
        public void setComments(string inComments)
        {
            comments = inComments;
        }

        //Exception handling (When adding a car with a null textbox).
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
