using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive_Shop
{
    public partial class Form1 : Form
    {
        // Oil and Lube Prices
        private const decimal OIL_CHANGE_PRICE = 26.00m;
        private const decimal REGULAR_OIL_PRICE = 0.00m;
        private const decimal MIXED_OIL_PRICE = 10.00m;
        private const decimal SYNTHETIC_OIL_PRICE = 20.00m;
        private const decimal LUBE_JOB_PRICE = 18.00m;

        // Carwash Prices
        private const decimal NO_CARWASH_PRICE = 0.00m;
        private const decimal COMPLIMENTARY_CARWASH_PRICE = 0.00m;
        private const decimal FULL_SERVICE_CARWASH_PRICE = 6.00m;
        private const decimal PREMIUM_CARWASH_PRICE = 9.00m;

        // Flushes Prices
        private const decimal RADIATOR_FLUSH_PRICE = 30.00m;
        private const decimal TRANSMISSION_FLUSH_PRICE = 80.00m;

        // Miscellaneous Prices
        private const decimal INSPECTION_PRICE = 15.00m;
        private const decimal REPLACE_MUFFLER_PRICE = 100.00m;
        private const decimal TIRE_ROTATION_PRICE = 20.00m;

        // Sales Tax Percentage for Parts
        private const decimal SALES_TAX = 0.06m;

        // Cost per hour of labor
        private const decimal LABOR_PRICE_PER_HOUR = 20.00m;

        // Extra variables for calculation
        private decimal partsCost;
        private decimal laborHours;
        private decimal laborCost;
        private decimal taxCharges;
        private decimal serviceCost;
        private decimal serviceAndLaborCost;
        

        public Form1()
        {
            InitializeComponent();
        }

        // Check if the value entered in the parts and labor textboxes are valid
        // Valid if textboxes contain decimals greater than zero
        // Valid if textboxes contain no text
        private bool IsInputValid(ref decimal partsCost, ref decimal laborHours)
        {
            if ( (decimal.TryParse(partsTextBox.Text, out partsCost) && partsCost >= 0m) || (partsTextBox.Text == "") )
            {
                // Rounds cost of parts for consistent calculations                
                partsCost = Math.Round(partsCost, 2, MidpointRounding.AwayFromZero);

                // Format text entered into parts textbox and display formatted string
                partsTextBox.Text = partsCost.ToString("n2");

                if ( (decimal.TryParse(laborTextBox.Text, out laborHours) && laborHours >= 0m) || (laborTextBox.Text == "") )
                {
                    // Rounds labor hours for consistent calculations
                    laborHours = Math.Round(laborHours, 2, MidpointRounding.AwayFromZero);

                    // Format text entered into labor textbox and display formatted string
                    laborTextBox.Text = laborHours.ToString("n2");

                    // Labor cost calculation; laborCost will always end up >= 0m
                    // Labor cost is the total labor hours multiplied by the price per hour of labor ($20)
                    laborCost = laborHours * LABOR_PRICE_PER_HOUR;

                    return true;
                }
                else
                {
                    // Error message if labor hours entered are invalid
                    MessageBox.Show("Labor hours is invalid.");

                    // Clear labor textbox and set focus on it
                    laborTextBox.Clear();
                    laborTextBox.Focus();
                }
            }
            else
            {
                // Error message if parts cost entered is invalid
                MessageBox.Show("Parts cost is invalid.");

                // Clear parts textbox and set focus on it
                partsTextBox.Clear();
                partsTextBox.Focus();
            }

            return false;
        }

        // Activates oil type radiobuttons only if the oil change checkbox is checked
        private void oilChangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (oilChangeCheckBox.Checked)
            {
                regularOilRadioButton.Enabled = true;
                mixedOilRadioButton.Enabled = true;
                syntheticOilRadioButton.Enabled = true;
            }
            else
            {
                regularOilRadioButton.Enabled = false;
                mixedOilRadioButton.Enabled = false;
                syntheticOilRadioButton.Enabled = false;
            }
        }

        // Calculates and returns charges for oil change and oil, and/or lube job if any
        private decimal OilLubeCharges()
        {
            // Variable to track total oil and lube charges
            decimal oilAndLubeCharges = 0.00m;

            // Checks if oil change checkbox is checked
            if (oilChangeCheckBox.Checked)
            {
                // Checks to see which type of oil the user picked
                // Adds to total charges based off user's choice
                if (regularOilRadioButton.Checked)
                {
                    oilAndLubeCharges = oilAndLubeCharges + OIL_CHANGE_PRICE + REGULAR_OIL_PRICE;
                }
                else if (mixedOilRadioButton.Checked)
                {
                    oilAndLubeCharges = oilAndLubeCharges + OIL_CHANGE_PRICE + MIXED_OIL_PRICE;
                }
                else
                {
                    oilAndLubeCharges = oilAndLubeCharges + OIL_CHANGE_PRICE + SYNTHETIC_OIL_PRICE;
                }
            }

            // Checks if lube checkbox is checked
            // Adds to total charges if checked
            if (lubeJobCheckBox.Checked)
            {
                oilAndLubeCharges += LUBE_JOB_PRICE;
            }

            return oilAndLubeCharges;
        }

        // Returns carwash charges based off the service checked
        private decimal CarwashCharges()
        {
            if (noCarwashRadioButton.Checked)
            {
                return NO_CARWASH_PRICE;
            }
            else if (compCarwashRadioButton.Checked)
            {
                return COMPLIMENTARY_CARWASH_PRICE;
            }
            else if (fullServiceCarwashRadioButton.Checked)
            {
                return FULL_SERVICE_CARWASH_PRICE;
            }
            else
            {
                return PREMIUM_CARWASH_PRICE;
            }
        }

        // Calculates and returns flush charges if any
        private decimal FlushCharges()
        {
            // Variable to track total flush charges
            decimal flushCharges = 0.00m;

            // Checks to see which flush(s) the user picked
            // Adds to total flush charges based off user's choice
            if (radiatorFlushCheckBox.Checked)
            {
                flushCharges += RADIATOR_FLUSH_PRICE;
            }
            if (transmissionFlushCheckBox.Checked)
            {
                flushCharges += TRANSMISSION_FLUSH_PRICE;
            }

            return flushCharges;
        }

        // Calculates and returns miscellaneous charges if any
        private decimal MiscCharges()
        {
            // Variable to track total miscellaneous charges
            decimal miscCharges = 0.00m;

            // Checks to see which miscellaneous service(s) the user picked
            // Adds to total miscellaneous charges based off user's choice
            if (inspectionCheckBox.Checked)
            {
                miscCharges += INSPECTION_PRICE;
            }
            if (replaceMufflerCheckBox.Checked)
            {
                miscCharges += REPLACE_MUFFLER_PRICE;
            }
            if (tireRotationCheckBox.Checked)
            {
                miscCharges += TIRE_ROTATION_PRICE;
            }

            return miscCharges;
        }

        // Calculates and returns charges for parts and/or labor if any
        private decimal OtherCharges()
        {
            return partsCost + laborCost;
        }

        // Calculates and returns tax charges on parts if any
        private decimal TaxCharges()
        {
            // Tax charges calculation
            taxCharges = partsCost * SALES_TAX;

            // Rounds tax charges for consistent calculations
            taxCharges = Math.Round(taxCharges, 2, MidpointRounding.AwayFromZero);

            return taxCharges;
        }

        // Calculates and returns total charges
        private decimal TotalCharges()
        {
            // Total charges calculation
            decimal totalCharges = OilLubeCharges() + CarwashCharges() + FlushCharges() + 
                MiscCharges() + OtherCharges() + TaxCharges();

            return totalCharges;
        }

        // Clears any checked values in 'Oil and Lube' groupbox
        private void ClearOilLube()
        {
            oilChangeCheckBox.Checked = false;
            lubeJobCheckBox.Checked = false;
            regularOilRadioButton.Checked = true;
        }

        // Resets the checked value to the 'None' radiobutton in the Carwash groupbox
        private void ResetCarwash()
        {
            noCarwashRadioButton.Checked = true;
            compCarwashRadioButton.Checked = false;
            fullServiceCarwashRadioButton.Checked = false;
            premiumCarwashRadioButton.Checked = false;
        }

        // Clears any checked values in 'Flushes' groupbox
        private void ClearFlushes()
        {
            radiatorFlushCheckBox.Checked = false;
            transmissionFlushCheckBox.Checked = false;
        }

        // Clears any checked values in 'Misc' groupbox
        private void ClearMisc()
        {
            inspectionCheckBox.Checked = false;
            replaceMufflerCheckBox.Checked = false;
            tireRotationCheckBox.Checked = false;
        }

        // Clears both textboxes in 'Parts and Labor' groupbox
        private void ClearOther()
        {
            partsTextBox.Clear();
            laborTextBox.Clear();
        }

        // Clears all labels in the 'Summary' groupbox
        private void ClearFees()
        {
            serviceAndLaborLabel.Text = "";
            partsLabel.Text = "";
            taxLabel.Text = "";
            totalChargesLabel.Text = "";
        }

        // Displays all charges for each label in the 'Summary' groupbox
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Uses the IsInputValid method to check if the values in the parts and labor textboxes are valid
            if (IsInputValid(ref partsCost, ref laborHours))
            {
                // Calculates the service and labor cost
                serviceCost = OilLubeCharges() + CarwashCharges() + FlushCharges() + MiscCharges();
                serviceAndLaborCost = serviceCost + laborCost;

                // Displays total of service and labor cost in serviceAndLaborLabel
                // Formats cost in currency format
                serviceAndLaborLabel.Text = serviceAndLaborCost.ToString("c");

                // Displays parts cost in partsLabel
                // Formats cost in currency format
                partsLabel.Text = partsCost.ToString("c");

                // Displays tax on parts cost in taxLabel
                // Formats cost in currency format
                taxLabel.Text = TaxCharges().ToString("c");

                // Displays total charges in totalChargesLabel
                // Formats charges in currency format
                totalChargesLabel.Text = TotalCharges().ToString("c");

                clearButton.Focus();
            }
        }

        // Clears the entire form and focuses the cursor on the oil and lube groupbox
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
            ResetCarwash();

            oilAndLubeGroupBox.Focus();
        }

        // Closes the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
