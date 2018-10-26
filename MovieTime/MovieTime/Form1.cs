using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            const double DRACULA_PRICE = 5.00;
            const double SUSPERIA_PRICE = 3.00;
            const double FRIDAY_THE_13_PRICE = 6.00;

            const double STADIUM_PRICE = 15.00;
            const double AMPHITHEATER_PRICE = 10.00;
            const double REGULAR_PRICE = 5.00;

            const double PLAIN_POPCORN_PRICE = 2.00;
            const double BUTTER_POPCORN_PRICE = 3.00;
            const double COKE_PRICE = 4.00;
            const double HOTDOG_PRICE = 5.00;
            const double ALMONDS_PRICE = 6.00;

            double movieCost = 0.00;
            double seatCost = 0.00;
            double totalFoodCost = 0.00;
            double totalCost = 0.00;

            if (draculaRadioButton.Checked) 
            {
                 movieCost = DRACULA_PRICE;
                 //MessageBox.Show("The cost to see Dracula is: " + movieCost.ToString("c"));
            }
            else if (susperiaRadioButton.Checked) 
            {
                 movieCost = SUSPERIA_PRICE;
                 //MessageBox.Show("The cost to see Susperia is: " + movieCost.ToString("c"));
            }
            else if (fridayThe13RadioButton.Checked) 
            {
                 movieCost = FRIDAY_THE_13_PRICE;
                 //MessageBox.Show("The cost to see Friday The 13th is: " + movieCost.ToString("c"));
            }

            if (stadiumRadioButton.Checked)
            {
                seatCost = STADIUM_PRICE;
                //MessageBox.Show("The cost of stadium seating is: " + seatCost.ToString("c"));
            }
            else if (amphitheaterRadioButton.Checked)
            {
                seatCost = AMPHITHEATER_PRICE;
                //MessageBox.Show("The cost of amphitheater seating is: " + seatCost.ToString("c"));
            }
            else if (regularRadioButton.Checked)
            {
                seatCost = REGULAR_PRICE;
                //MessageBox.Show("The cost of regular seating is: " + seatCost.ToString("c"));
            }

            if (plainPopcornCheckBox.Checked)
            {
                totalFoodCost += PLAIN_POPCORN_PRICE;
            }
            if (butterPopcornCheckBox.Checked)
            {
                totalFoodCost += BUTTER_POPCORN_PRICE;
            }
            if (cokeCheckBox.Checked)
            {
                totalFoodCost += COKE_PRICE;
            }
            if (hotDogCheckBox.Checked)
            {
                totalFoodCost += HOTDOG_PRICE;
            }
            if (chocolateAlmondsCheckBox.Checked)
            {
                totalFoodCost += ALMONDS_PRICE;
            }
            if (!plainPopcornCheckBox.Checked && !butterPopcornCheckBox.Checked && !cokeCheckBox.Checked && 
                !hotDogCheckBox.Checked && !chocolateAlmondsCheckBox.Checked)
            {
                totalFoodCost = 0.00;
            }

            //MessageBox.Show("The total food cost is: " + totalFoodCost.ToString("c"));

            totalCost = movieCost + seatCost + totalFoodCost;

            if (discountTextBox.Checked)
            {
                totalCost = totalCost - (totalCost * 0.05);

                totalLabel.Text = totalCost.ToString("c");
            }
            else
            {
                totalLabel.Text = totalCost.ToString("c");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            draculaRadioButton.Checked = true;
            draculaRadioButton.Focus();

            stadiumRadioButton.Checked = true;

            plainPopcornCheckBox.Checked = false;
            butterPopcornCheckBox.Checked = false;
            cokeCheckBox.Checked = false;
            hotDogCheckBox.Checked = false;
            chocolateAlmondsCheckBox.Checked = false;

            discountTextBox.Checked = false;

            totalLabel.Text = "";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
