using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Price_and_Tip_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            /* This program uses significant figures to two decimal points.
             * For example, if the original price entered is 1000.356, the number taken is 1000.36
             * Another example, if the percent entered is 20.9987, the number taken is 21.00
             * 
             * This is important because the original values affect the calculated values.
             * Therefore, the calculated values are based off of the rounded original values.
            */


            try
            {
                //Takes the price inputed in the price textbox, turns the value into a double, and sets it to the double originalPrice.
                double originalPrice = Math.Round(double.Parse(priceTextBox.Text), 2);

                //Initializes a double and assigns it to the value 0.30 (which is used to calculate a 30% tip).
                double tipPercentage = Math.Round((double.Parse(tipPercentTextBox.Text) / 100.0), 2);

                //Calculates the tip amount by multiplying the original price by the tip percentage.
                double tipAmount = originalPrice * tipPercentage;

                //Calculates the total bill by adding the original price plus the tip amount.
                double total = originalPrice + tipAmount;

                //Formats the text in the price text box to be in currency format.
                priceTextBox.Text = originalPrice.ToString("c");

                //Formats the text in the tip percentage text box to be in percent format.
                tipPercentTextBox.Text = tipPercentage.ToString("p");

                //Sets both the tip label text to the amount of the tip in currency format.
                tipLabel.Text = tipAmount.ToString("c");

                //Sets the total label text to the amount of the total in currency format.
                totalLabel.Text = total.ToString("c");

                //Displays "thank you" message and two smiley faces.
                thankYouLabel.Visible = true;
                smileyFacePictureBox1.Visible = true;
                smileyFacePictureBox2.Visible = true;

            }
            catch (Exception ex)
            {
                //Displays the default exception message when the user enters in anything that isn't a double.
                MessageBox.Show(ex.Message);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears the text for all textboxes and output labels.
            priceTextBox.Text = "";
            tipPercentTextBox.Text = "";
            tipLabel.Text = "";
            totalLabel.Text = "";
            thankYouLabel.Visible = false;
            smileyFacePictureBox1.Visible = false;
            smileyFacePictureBox2.Visible = false;

            priceTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closes the program.
            this.Close();
        }
    }
}
