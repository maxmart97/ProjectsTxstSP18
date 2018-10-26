using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Service_Provider_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double hoursUsed;

            //Parses for a double and for a correct number of hours entered
            if (double.TryParse(hoursTextBox.Text, out hoursUsed) && (hoursUsed >= 0.00 && hoursUsed <= 744.00))
            {
                hoursUsed = Math.Round(hoursUsed, 2); //Rounds number of hours used to two decimal places

                hoursTextBox.Text = hoursUsed.ToString("n2"); //Guarantees hours is displayed with two decimal places; displays in hours textbox

                //Initializes and sets the value of all needed constant variables
                const int A_NUMBER_OF_HOURS_ACCESS_PER_MONTH = 10;
                const double A_PRICE_PER_MONTH = 9.95;
                const double A_PRICE_PER_ADDITIONAL_HOUR_USED = 2.00;
                const int B_NUMBER_OF_HOURS_ACCESS_PER_MONTH = 20;
                const double B_PRICE_PER_MONTH = 14.95;
                const double B_PRICE_PER_ADDITIONAL_HOUR_USED = 1.00;
                const double C_PRICE_PER_MONTH = 19.95;
                const double NONPROFIT_DISCOUNT = 0.20;

                //Initializes various extra variables that are needed for calculations
                double totalAmtDueNoDiscount;
                double subTotal;
                double totalAmtDueWithDiscount;
                double additionalHoursUsed;
                double additionalHoursCost;
                double nonProfitDiscountAmt;

                //Checks if Package A is checked and Nonprofit Organization is not checked
                if (packageARadioButton.Checked && !nonProfitCheckBox.Checked)
                {
                    //Checks if hours used is greater than the amount of hours allowed with Package A
                    if (hoursUsed > A_NUMBER_OF_HOURS_ACCESS_PER_MONTH)
                    {
                        //Calculates cost of any additional hours used
                        additionalHoursUsed = hoursUsed - A_NUMBER_OF_HOURS_ACCESS_PER_MONTH;
                        additionalHoursCost = additionalHoursUsed * A_PRICE_PER_ADDITIONAL_HOUR_USED;

                        totalAmtDueNoDiscount = A_PRICE_PER_MONTH + additionalHoursCost; //Calculates total payment due

                        totalLabel.Text = totalAmtDueNoDiscount.ToString("c"); //Displays total payment formatted in currency format
                    }
                    else
                    {
                        //Displays total payment due; the user didn't go over hours limit and only pays subscription price
                        totalLabel.Text = A_PRICE_PER_MONTH.ToString("c");
                    }
                }
                //Checks if Package A is checked and Nonprofit Organization is checked
                else if (packageARadioButton.Checked && nonProfitCheckBox.Checked)
                {
                    //Checks if hours used is greater than the amount of hours allowed with Package A
                    if (hoursUsed > A_NUMBER_OF_HOURS_ACCESS_PER_MONTH)
                    {
                        //Calculates cost of any additional hours used
                        additionalHoursUsed = hoursUsed - A_NUMBER_OF_HOURS_ACCESS_PER_MONTH;
                        additionalHoursCost = additionalHoursUsed * A_PRICE_PER_ADDITIONAL_HOUR_USED;

                        //Calculates subtotal and then the nonprofit organization discount
                        subTotal = A_PRICE_PER_MONTH + additionalHoursCost;
                        nonProfitDiscountAmt = subTotal * NONPROFIT_DISCOUNT;

                        totalAmtDueWithDiscount = subTotal - nonProfitDiscountAmt; //Calculates total payment due with nonprofit organization discount

                        totalLabel.Text = totalAmtDueWithDiscount.ToString("c"); //Displays total payment formatted in currency format
                    }
                    else
                    {
                        //Occurs if user did not go over in hours; calculates nonprofit organization discount and then the total
                        nonProfitDiscountAmt = A_PRICE_PER_MONTH * NONPROFIT_DISCOUNT;
                        totalAmtDueWithDiscount = A_PRICE_PER_MONTH - nonProfitDiscountAmt;

                        totalLabel.Text = totalAmtDueWithDiscount.ToString("c"); //Displays total payment formatted in currency format
                    }
                }
                //Checks if Package B is checked and Nonprofit Organization is not checked
                else if (packageBRadioButton.Checked && !nonProfitCheckBox.Checked)
                {
                    //Checks if hours used is greater than the amount of hours allowed with Package B
                    if (hoursUsed > B_NUMBER_OF_HOURS_ACCESS_PER_MONTH)
                    {
                        //Calculates cost of any additional hours used
                        additionalHoursUsed = hoursUsed - B_NUMBER_OF_HOURS_ACCESS_PER_MONTH;
                        additionalHoursCost = additionalHoursUsed * B_PRICE_PER_ADDITIONAL_HOUR_USED;

                        totalAmtDueNoDiscount = B_PRICE_PER_MONTH + additionalHoursCost; //Calculates total payment due

                        totalLabel.Text = totalAmtDueNoDiscount.ToString("c"); //Displays total payment formatted in currency format
                    }
                    else
                    {
                        //Displays total payment due; the user didn't go over hours limit and only pays subscription price
                        totalLabel.Text = B_PRICE_PER_MONTH.ToString("c");
                    }
                }
                //Checks if Package B is checked and Nonprofit Organization is checked
                else if (packageBRadioButton.Checked && nonProfitCheckBox.Checked)
                {
                    //Checks if hours used is greater than the amount of hours allowed with Package B
                    if (hoursUsed > B_NUMBER_OF_HOURS_ACCESS_PER_MONTH)
                    {
                        //Calculates cost of any additional hours used
                        additionalHoursUsed = hoursUsed - B_NUMBER_OF_HOURS_ACCESS_PER_MONTH;
                        additionalHoursCost = additionalHoursUsed * B_PRICE_PER_ADDITIONAL_HOUR_USED;

                        //Calculates subtotal and then the nonprofit organization discount
                        subTotal = B_PRICE_PER_MONTH + additionalHoursCost;
                        nonProfitDiscountAmt = subTotal * NONPROFIT_DISCOUNT;

                        totalAmtDueWithDiscount = subTotal - nonProfitDiscountAmt; //Calculates total payment due with nonprofit organization discount

                        totalLabel.Text = totalAmtDueWithDiscount.ToString("c"); //Displays total payment formatted in currency format
                    }
                    else
                    {
                        //Occurs if user did not go over in hours; calculates nonprofit organization discount and then the total
                        nonProfitDiscountAmt = B_PRICE_PER_MONTH * NONPROFIT_DISCOUNT;
                        totalAmtDueWithDiscount = B_PRICE_PER_MONTH - nonProfitDiscountAmt;

                        totalLabel.Text = totalAmtDueWithDiscount.ToString("c"); //Displays total payment formatted in currency format
                    }
                }
                //Checks if Package C is checked and Nonprofit Organization is not checked
                else if (packageCRadioButton.Checked && !nonProfitCheckBox.Checked)
                {
                        totalLabel.Text = C_PRICE_PER_MONTH.ToString("c"); //Displays total payment formatted in currency format
                }
                //Only runs if all other combinations are false (therefore, checks if Package C is checked and Nonprofit Organization is checked)
                else
                {
                    //Calculates nonprofit organization discount and then the total
                    nonProfitDiscountAmt = C_PRICE_PER_MONTH * NONPROFIT_DISCOUNT;
                    totalAmtDueWithDiscount = C_PRICE_PER_MONTH - nonProfitDiscountAmt;

                    totalLabel.Text = totalAmtDueWithDiscount.ToString("c"); //Displays total payment formatted in currency format
                }

                clearButton.Focus();

            }
            //Displays error message if hours entered cannot be parsed and/or is out of the range
            else
            {
                MessageBox.Show("The data entered is invalid. Please enter a number between 0 and 744.");

                hoursTextBox.Clear();
                hoursTextBox.Focus();
            }
        }

        //Resets program to stock settings
        private void clearButton_Click(object sender, EventArgs e)
        {
            packageARadioButton.Focus();
            nonProfitCheckBox.Checked = false;
            hoursTextBox.Clear();
            totalLabel.Text = "";
        }

        //Closes the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
