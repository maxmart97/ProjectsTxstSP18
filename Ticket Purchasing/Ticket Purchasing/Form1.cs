using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Purchasing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double grandTotal = 0;

        private void computeButton_Click(object sender, EventArgs e)
        {
            int tickets;
            String selectedDay, selectedLocation;

            const double SU_T_TH_TICKET_PRICE = 10.00;
            const double M_W_F_S_TICKET_PRICE = 15.00;

            const double IMAX_PRICE = 15.00;
            const double SOUTH_AND_RIVER_PRICE = 10.00; 
            const double CAPITOL_PRICE = 12.00;

            double totalPrice;

            if (int.TryParse(ticketsTextBox.Text, out tickets) && tickets > 0 && 
                dayListBox.SelectedIndex != -1 && locationListBox.SelectedIndex != -1)
            {
                selectedDay = dayListBox.SelectedItem.ToString();
                selectedLocation = locationListBox.SelectedItem.ToString();

                if ((selectedDay == "Sunday" || selectedDay == "Tuesday" || selectedDay == "Thursday")  && (selectedLocation == "IMAX"))
                {
                    totalPrice = (tickets * SU_T_TH_TICKET_PRICE) + IMAX_PRICE;
                    totalTextBox.Text = totalPrice.ToString("c");

                    grandTotal += totalPrice;

                    purchaseInformationListBox.Items.Add(tickets + " tickets - " + selectedDay + " - " + selectedLocation + " = " + totalPrice.ToString("c"));
                }
                else if ((selectedDay == "Sunday" || selectedDay == "Tuesday" || selectedDay == "Thursday")  && (selectedLocation == "South" || selectedLocation == "River"))
                {
                    totalPrice = (tickets * SU_T_TH_TICKET_PRICE) + SOUTH_AND_RIVER_PRICE;
                    totalTextBox.Text = totalPrice.ToString("c");

                    grandTotal += totalPrice;

                    purchaseInformationListBox.Items.Add(tickets + " tickets - " + selectedDay + " - " + selectedLocation + " = " + totalPrice.ToString("c"));
                }
                else if ((selectedDay == "Sunday" || selectedDay == "Tuesday" || selectedDay == "Thursday") && (selectedLocation == "Capitol"))
                {
                    totalPrice = (tickets * SU_T_TH_TICKET_PRICE) + CAPITOL_PRICE;
                    totalTextBox.Text = totalPrice.ToString("c");

                    grandTotal += totalPrice;

                    purchaseInformationListBox.Items.Add(tickets + " tickets - " + selectedDay + " - " + selectedLocation + " = " + totalPrice.ToString("c"));
                }
                else if ((selectedDay == "Monday" || selectedDay == "Wednesday" || selectedDay == "Friday" || selectedDay == "Saturday") && (selectedLocation == "IMAX"))
                {
                    totalPrice = (tickets * M_W_F_S_TICKET_PRICE) + IMAX_PRICE;
                    totalTextBox.Text = totalPrice.ToString("c");

                    grandTotal += totalPrice;

                    purchaseInformationListBox.Items.Add(tickets + " tickets - " + selectedDay + " - " + selectedLocation + " = " + totalPrice.ToString("c"));
                }
                else if ((selectedDay == "Monday" || selectedDay == "Wednesday" || selectedDay == "Friday" || selectedDay == "Saturday") && (selectedLocation == "South" || selectedLocation == "River"))
                {
                    totalPrice = (tickets * M_W_F_S_TICKET_PRICE) + SOUTH_AND_RIVER_PRICE;
                    totalTextBox.Text = totalPrice.ToString("c");

                    grandTotal += totalPrice;

                    purchaseInformationListBox.Items.Add(tickets + " tickets - " + selectedDay + " - " + selectedLocation + " = " + totalPrice.ToString("c"));
                }
                else if ((selectedDay == "Monday" || selectedDay == "Wednesday" || selectedDay == "Friday" || selectedDay == "Saturday") && (selectedLocation == "Capitol"))
                {
                    totalPrice = (tickets * M_W_F_S_TICKET_PRICE) + CAPITOL_PRICE;
                    totalTextBox.Text = totalPrice.ToString("c");

                    grandTotal += totalPrice;

                    purchaseInformationListBox.Items.Add(tickets + " tickets - " + selectedDay + " - " + selectedLocation + " = " + totalPrice.ToString("c"));
                }
            }
            else
            {
                MessageBox.Show("Please make sure you have entered in a correct amount of tickets (must be an integer" +
                " greater than zero) and that you have chosen a day and a location.");

                ticketsTextBox.Focus();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ticketsTextBox.Clear();
            dayListBox.SelectedIndex = -1;
            locationListBox.SelectedIndex = -1;
            totalTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grandTotalButton_Click(object sender, EventArgs e)
        {
            grandTotalLabel.Text = grandTotal.ToString("c");
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            ticketsTextBox.Clear();
            dayListBox.SelectedIndex = -1;
            locationListBox.SelectedIndex = -1;
            totalTextBox.Clear();

            grandTotal = 0;
            grandTotalLabel.Text = "";
            purchaseInformationListBox.Items.Clear();
        }
    }
}
