using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// Cameron Davis
/// CS 1182
/// T,R 9:30-10:45
/// Deliverable 2, Car Rental Form


namespace CarRental
{
    public partial class fmRentalReturn : Form
    {
        private string[] _RentalCars = new string[] { "Ford Mustang","Chevrolet Camaro","Ford Raptor" };
        private double[] _CostPerDay = new double[] { 52.5, 55, 68.65 };
        private double[] _CostPerMile = new double[] { .14, .18, .25 };
        public fmRentalReturn()
        {
            InitializeComponent();
            fillUnitRented();
            rbtnEmpty.Checked = true;
            
        }
        private void fillUnitRented()  //fills the combobox and sets its default value//
        {
            foreach (String s in _RentalCars)
            {
                cmbUnitRented.Items.Add(s);
                cmbUnitRented.SelectedIndex = 0;
            }
            
        }
        /// <summary>
        /// listens for the combobox index to be changed by user, and populates the costPerDay & costPerMile text boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbUnitRented_SelectedIndexChanged(object sender, EventArgs e) 
        {
            int index = Array.IndexOf(_RentalCars, cmbUnitRented.Text);
            txtCostPerDay.Text = _CostPerDay[index].ToString();
            txtCostPerMile.Text = _CostPerMile[index].ToString(); 
        }

        /// <summary>
        /// Listens for the event (print bill) button to be pressed.  then populates the rental bill text box. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            if (checkForErrors() == false)
            {
                txtRentalBill.Clear();
                txtRentalBill.Text += "Daily Charge $" + calcNumberOfDays().ToString() + "\r\n";
                txtRentalBill.Text += "Mileage Charge $" + calcMileage().ToString() + "\r\n";
                txtRentalBill.Text += "Gas Charge $" + calcGasTank().ToString() + "\r\n";
                txtRentalBill.Text += "Discount $" + Math.Round(discountTotal(),2).ToString() + "\r\n";
                txtRentalBill.Text += "Total Charge $" + Math.Round(totalCharge(),2).ToString() + "\r\n";

                //txtRentalBill.Text = String.Format("Daily Charge ${0} \r\nMileage Charge ${1} \r\nGas Charge ${2} \r\nDiscount ${4} \r\nTotal Charge${3}"
                //, numberOfDaysCalc(), mileageCalc(), gasTankCalc(), totalCharge(), discountTotal());
            }                                                                              
        }
        /// <summary>
        /// Check the validity of all entries.
        /// </summary>
        /// <returns>True if an error is found.</returns>
        private bool checkForErrors()
        {
            txtRentalBill.Clear();
            bool errorFound = false;
            if (checkFirstName() == false)
                errorFound = true;
            if (checkLastName() == false)
                errorFound = true;
            if ( checkNumberOfDays() == 0)
                errorFound = true;
            if ( checkBeginningMileage() == 0)
                errorFound = true;
            if ( checkEndingMileage() == 0)
                errorFound = true;
            if ( checkMileage() == 0)
                errorFound = true;
            return errorFound;
        }
        
        /// <summary>
        /// checks the first name and returns false if the txtFirstName is empty.
        /// </summary>
        /// <returns></returns>
        private bool checkFirstName()
        {
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                erpvdFirstName.SetError(txtFirstName, "Missing first name");
                return false;
            }
            else
            {
                erpvdFirstName.Clear();
                return true;
            }
        }

        /// <summary>
        /// Checks the last name and returns false if txtLastName is empty.
        /// </summary>
        /// <returns></returns>
        private bool checkLastName()
        {
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                erpvdLastName.SetError(txtLastName, "Missing last name");
                return false;
            }
            else
            {
                erpvdLastName.Clear();
                return true;
            }
        }
        /// <summary>
        /// checks the beginning mileage entered for string or empty txtBeginningMileage.
        /// </summary>
        /// <returns>0 if error</returns>
            
        private int checkBeginningMileage()
        {
            int goodBeginningMileage = 0;

            if (int.TryParse(txtBeginningMileage.Text, out goodBeginningMileage) && String.IsNullOrEmpty(txtBeginningMileage.Text) == false)
            {
                erpvdBeginningMileage.Clear();
                return goodBeginningMileage;
            }
            else
            {
                erpvdBeginningMileage.SetError(txtBeginningMileage, "Invalid miles, please enter whole number mileage");

                return 0;
            }
        }

        /// <summary>
        /// checks ending miles entered for string or empty txtEndingMileage
        /// </summary>
        /// <returns>0 if error</returns>
        private int checkEndingMileage()
        {
            int goodEndingMileage = 0;
            if (int.TryParse(txtEndingMileage.Text, out goodEndingMileage) && String.IsNullOrEmpty(txtEndingMileage.Text) == false)
            {
                erpvdEndingMileage.Clear();
                    
                return goodEndingMileage;
            }
            else
            {
                erpvdEndingMileage.SetError(txtBeginningMileage, "Invalid miles, please enter whole number mileage");
                return 0;
            }
               
        }

        /// <summary>
        /// checks that the ending mileage is greater than the beginning mileage
        /// </summary>
        /// <returns>0 if error</returns>
        private int checkMileage()
        {                               
            int totalMiles = checkEndingMileage() - checkBeginningMileage();
            if (totalMiles <= 0)
            {
                erpvdBeginningMileage.SetError(txtBeginningMileage, "Invalid Miles, Ending Mileage Must be greater than Beginning Mileage");
                erpvdEndingMileage.SetError(txtEndingMileage, "Invalid Miles, Ending Mileage Must be greater than Beginning Mileage ");
                return 0;
            }
            else
            {
                erpvdBeginningMileage.Clear();
                erpvdEndingMileage.Clear();
                return totalMiles; 
            }
        }

           
        /// <summary>
            /// checks the number of days txtbox for string or empty set.
            /// </summary>
            /// <returns>0 if error</returns>
        private int checkNumberOfDays()
        {

            int goodDaysCheck = 0;

            if (int.TryParse(txtNumberOfDays.Text, out goodDaysCheck) && String.IsNullOrEmpty(txtNumberOfDays.Text) == false)
            {
                txtNumberOfDays.Text = goodDaysCheck.ToString();
                erpvdNumberOfDays.Clear();
                    
                return goodDaysCheck;
            }
            else
            {
                erpvdNumberOfDays.SetError(txtNumberOfDays, ("Invalid days, please enter whole days amount"));
                return 0;
            }
        }

        /// <summary>
        /// takes the number of days and multiplies it by the cost per day assosciated with the cb index selected 
        /// </summary>
        /// <returns>total cost per days of car rental</returns>
        private double calcNumberOfDays()
        {
            int numberOfDays = checkNumberOfDays();
            int index = Array.IndexOf(_RentalCars, cmbUnitRented.Text);

            double total = numberOfDays * _CostPerDay[index];
            return total;             
        }

        /// <summary>
        /// takes the total amount of miles driven and multiplies it by the cost per miles associated with the cb index selected
        /// </summary>
        /// <returns>total cost of miles driven</returns>
        private double calcMileage()
        {
            double mileageCost = checkMileage();
            int index = Array.IndexOf(_RentalCars, cmbUnitRented.Text);
            double total = mileageCost * _CostPerMile[index];
            return total;
        }

        /// <summary>
        /// outputs the cost associated with the amount of fuel selected by the radio buttons.
        /// </summary>
        /// <returns>radio button selected</returns>
        private double calcGasTank()
        {
            if (rbtnEmpty.Checked == true)
            {
                return 44.04;
                    
            }
            else if (rbtnOneFourth.Checked == true)
            {
                return 33.03;
                    
            }
            else if (rbtnOneHalf.Checked == true)
            {
                return 22.02;
            }
            else if (rbtnThreeFourths.Checked == true)
            {
                return 11.01;
            }
            else if (rbtnFullTank.Checked == true)
            {
                return 0;
            }
            else
            {
                return 0;
            }

        }

        /// <summary>
        /// summarized the total charge adding cost per days, cost per miles, and gas tank level,
        /// </summary>
        /// <returns></returns>
        private double totalCharge()
        {
            double total = 0;
            total = calcNumberOfDays() + calcMileage() + calcGasTank();
               
            if (ckbFrequentRenter.Checked || ckbSeniorCitizen.Checked)
            {
                total = total - discountTotal();
                return total;
            }
            else
            {
                return total;
            }                              
        }

        /// <summary>
        /// retrieves the amount that the senior citizen discount will be and returns said amount/// NEED TO DO!!!--> change totalCharge() to numberOfDaysCalc + mileageCalc() + gasTankCalc();
        /// </summary>
        /// <returns>0 if not checked, discount amount if checked</returns>
        private double seniorCitizenDiscount()
        {
            if (ckbSeniorCitizen.Checked)
            {
                double total = calcNumberOfDays() + calcMileage() + calcGasTank();
                double seniorDiscount = total * .05;
                return seniorDiscount;
            }
            else 
            {
                return 0;
            }
        }
        /// <summary>
        /// retrieves the amount that the frequent renter discount will be and returns said amount
        /// </summary>
        /// <returns>0 if not checked, discount amount if checked</returns>
        private double frequentRenterDiscount()
        {
            if (ckbFrequentRenter.Checked)
            {
                double total = calcNumberOfDays() + calcMileage() + calcGasTank();
                double frequentRenter = total  * .03;
                return frequentRenter;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// returns the total discount be it 0 or >
        /// </summary>
        /// <returns></returns>
        private double discountTotal()
        {
            double discount = seniorCitizenDiscount() + frequentRenterDiscount();
            return discount;
        }
    }
}
