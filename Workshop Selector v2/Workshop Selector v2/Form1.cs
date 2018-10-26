using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_Selector_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Instantiation and assignment of all constant values
        const double handlingStressDays = 3.0;
        const double timeManagementDays = 3.0;
        const double supervisionSkillsDays = 3.0;
        const double negotiationDays = 5.0;
        const double howToInterviewDays = 1.0;
        const double handlingStressPrice = 1000.0;
        const double timeManagementPrice = 800.0;
        const double supervisionSkillsPrice = 1500.0;
        const double negotiationPrice = 1300.0;
        const double howToInterviewPrice = 500.0;
        const double austinLodgingPricePerDay = 150.0;
        const double chicagoLodgingPricePerDay = 225.0;
        const double dallasLodgingPricePerDay = 175.0;
        const double orlandoLodgingPricePerDay = 300.0;
        const double phoenixLodgingPricePerDay = 175.0;
        const double raleighLodgingPricePerDay = 150.0;

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Instantiation of variables used for calculation
            double totalLodgingCost;
            double totalCost;

            //Clear the output listbox of any items so multiple entries do not appear.
            pricingListBox.Items.Clear();

            //A check to see if the user has selected a workshop and a location
            if (workshopListBox.SelectedIndex != -1 && locationListBox.SelectedIndex != -1)
            {
                //Instantiates and assigns workshop and location strings to the item the user clicks in each listbox
                string selectedWorkshop = workshopListBox.SelectedItem.ToString();
                string selectedLocation = locationListBox.SelectedItem.ToString();

                /*
                  An extremely long list of if-else statements to check if the user chooses a specific workshop
                  and location. When the user chooses a specific workshop and location, the total lodging cost 
                  and the total cost are calculated. The values calculated are assigned to their respective variables. 
                  The information regarding the set workshop registration price, total lodging cost based off the 
                  number of days the workshop occurs, and total cost is then formatted and displayed in the pricing 
                  listbox. This formula repeats for every possible combination of workshops and locations that the user 
                  can choose (30). 
                */
                if (selectedWorkshop == "Handling Stress" && selectedLocation == "Austin")
                {
                    totalLodgingCost = handlingStressDays * austinLodgingPricePerDay;
                    totalCost = handlingStressPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + handlingStressPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + austinLodgingPricePerDay.ToString("c0") + " x " +
                        handlingStressDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Handling Stress" && selectedLocation == "Chicago")
                {
                    totalLodgingCost = handlingStressDays * chicagoLodgingPricePerDay;
                    totalCost = handlingStressPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + handlingStressPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + chicagoLodgingPricePerDay.ToString("c0") + " x " +
                        handlingStressDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Handling Stress" && selectedLocation == "Dallas")
                {
                    totalLodgingCost = handlingStressDays * dallasLodgingPricePerDay;
                    totalCost = handlingStressPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + handlingStressPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + dallasLodgingPricePerDay.ToString("c0") + " x " +
                        handlingStressDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Handling Stress" && selectedLocation == "Orlando")
                {
                    totalLodgingCost = handlingStressDays * orlandoLodgingPricePerDay;
                    totalCost = handlingStressPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + handlingStressPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + orlandoLodgingPricePerDay.ToString("c0") + " x " +
                        handlingStressDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Handling Stress" && selectedLocation == "Phoenix")
                {
                    totalLodgingCost = handlingStressDays * phoenixLodgingPricePerDay;
                    totalCost = handlingStressPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + handlingStressPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + phoenixLodgingPricePerDay.ToString("c0") + " x " +
                        handlingStressDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Handling Stress" && selectedLocation == "Raleigh")
                {
                    totalLodgingCost = handlingStressDays * raleighLodgingPricePerDay;
                    totalCost = handlingStressPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + handlingStressPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + raleighLodgingPricePerDay.ToString("c0") + " x " +
                        handlingStressDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Time Management" && selectedLocation == "Austin")
                {
                    totalLodgingCost = timeManagementDays * austinLodgingPricePerDay;
                    totalCost = timeManagementPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + timeManagementPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + austinLodgingPricePerDay.ToString("c0") + " x " +
                        timeManagementDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Time Management" && selectedLocation == "Chicago")
                {
                    totalLodgingCost = timeManagementDays * chicagoLodgingPricePerDay;
                    totalCost = timeManagementPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + timeManagementPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + chicagoLodgingPricePerDay.ToString("c0") + " x " +
                        timeManagementDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Time Management" && selectedLocation == "Dallas")
                {
                    totalLodgingCost = timeManagementDays * dallasLodgingPricePerDay;
                    totalCost = timeManagementPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + timeManagementPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + dallasLodgingPricePerDay.ToString("c0") + " x " +
                        timeManagementDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Time Management" && selectedLocation == "Orlando")
                {
                    totalLodgingCost = timeManagementDays * orlandoLodgingPricePerDay;
                    totalCost = timeManagementPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + timeManagementPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + orlandoLodgingPricePerDay.ToString("c0") + " x " +
                        timeManagementDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Time Management" && selectedLocation == "Phoenix")
                {
                    totalLodgingCost = timeManagementDays * phoenixLodgingPricePerDay;
                    totalCost = timeManagementPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + timeManagementPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + phoenixLodgingPricePerDay.ToString("c0") + " x " +
                        timeManagementDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Time Management" && selectedLocation == "Raleigh")
                {
                    totalLodgingCost = timeManagementDays * raleighLodgingPricePerDay;
                    totalCost = timeManagementPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + timeManagementPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + raleighLodgingPricePerDay.ToString("c0") + " x " +
                        timeManagementDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Supervision Skills" && selectedLocation == "Austin")
                {
                    totalLodgingCost = supervisionSkillsDays * austinLodgingPricePerDay;
                    totalCost = supervisionSkillsPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + supervisionSkillsPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + austinLodgingPricePerDay.ToString("c0") + " x " +
                        supervisionSkillsDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Supervision Skills" && selectedLocation == "Chicago")
                {
                    totalLodgingCost = supervisionSkillsDays * chicagoLodgingPricePerDay;
                    totalCost = supervisionSkillsPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + supervisionSkillsPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + chicagoLodgingPricePerDay.ToString("c0") + " x " +
                        supervisionSkillsDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Supervision Skills" && selectedLocation == "Dallas")
                {
                    totalLodgingCost = supervisionSkillsDays * dallasLodgingPricePerDay;
                    totalCost = supervisionSkillsPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + supervisionSkillsPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + dallasLodgingPricePerDay.ToString("c0") + " x " +
                        supervisionSkillsDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Supervision Skills" && selectedLocation == "Orlando")
                {
                    totalLodgingCost = supervisionSkillsDays * orlandoLodgingPricePerDay;
                    totalCost = supervisionSkillsPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + supervisionSkillsPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + orlandoLodgingPricePerDay.ToString("c0") + " x " +
                        supervisionSkillsDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Supervision Skills" && selectedLocation == "Phoenix")
                {
                    totalLodgingCost = supervisionSkillsDays * phoenixLodgingPricePerDay;
                    totalCost = supervisionSkillsPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + supervisionSkillsPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + phoenixLodgingPricePerDay.ToString("c0") + " x " +
                        supervisionSkillsDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Supervision Skills" && selectedLocation == "Raleigh")
                {
                    totalLodgingCost = supervisionSkillsDays * raleighLodgingPricePerDay;
                    totalCost = supervisionSkillsPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + supervisionSkillsPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + raleighLodgingPricePerDay.ToString("c0") + " x " +
                        supervisionSkillsDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Negotiation" && selectedLocation == "Austin")
                {
                    totalLodgingCost = negotiationDays * austinLodgingPricePerDay;
                    totalCost = negotiationPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + negotiationPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + austinLodgingPricePerDay.ToString("c0") + " x " +
                        negotiationDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Negotiation" && selectedLocation == "Chicago")
                {
                    totalLodgingCost = negotiationDays * chicagoLodgingPricePerDay;
                    totalCost = negotiationPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + negotiationPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + chicagoLodgingPricePerDay.ToString("c0") + " x " +
                        negotiationDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Negotiation" && selectedLocation == "Dallas")
                {
                    totalLodgingCost = negotiationDays * dallasLodgingPricePerDay;
                    totalCost = negotiationPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + negotiationPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + dallasLodgingPricePerDay.ToString("c0") + " x " +
                        negotiationDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Negotiation" && selectedLocation == "Orlando")
                {
                    totalLodgingCost = negotiationDays * orlandoLodgingPricePerDay;
                    totalCost = negotiationPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + negotiationPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + orlandoLodgingPricePerDay.ToString("c0") + " x " +
                        negotiationDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Negotiation" && selectedLocation == "Phoenix")
                {
                    totalLodgingCost = negotiationDays * phoenixLodgingPricePerDay;
                    totalCost = negotiationPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + negotiationPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + phoenixLodgingPricePerDay.ToString("c0") + " x " +
                        negotiationDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "Negotiation" && selectedLocation == "Raleigh")
                {
                    totalLodgingCost = negotiationDays * raleighLodgingPricePerDay;
                    totalCost = negotiationPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + negotiationPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + raleighLodgingPricePerDay.ToString("c0") + " x " +
                        negotiationDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "How to Interview" && selectedLocation == "Austin")
                {
                    totalLodgingCost = howToInterviewDays * austinLodgingPricePerDay;
                    totalCost = howToInterviewPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + howToInterviewPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + austinLodgingPricePerDay.ToString("c0") + " x " +
                        howToInterviewDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "How to Interview" && selectedLocation == "Chicago")
                {
                    totalLodgingCost = howToInterviewDays * chicagoLodgingPricePerDay;
                    totalCost = howToInterviewPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + howToInterviewPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + chicagoLodgingPricePerDay.ToString("c0") + " x " +
                        howToInterviewDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "How to Interview" && selectedLocation == "Dallas")
                {
                    totalLodgingCost = howToInterviewDays * dallasLodgingPricePerDay;
                    totalCost = howToInterviewPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + howToInterviewPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + dallasLodgingPricePerDay.ToString("c0") + " x " +
                        howToInterviewDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "How to Interview" && selectedLocation == "Orlando")
                {
                    totalLodgingCost = howToInterviewDays * orlandoLodgingPricePerDay;
                    totalCost = howToInterviewPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + howToInterviewPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + orlandoLodgingPricePerDay.ToString("c0") + " x " +
                        howToInterviewDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "How to Interview" && selectedLocation == "Phoenix")
                {
                    totalLodgingCost = howToInterviewDays * phoenixLodgingPricePerDay;
                    totalCost = howToInterviewPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + howToInterviewPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + phoenixLodgingPricePerDay.ToString("c0") + " x " +
                        howToInterviewDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
                else if (selectedWorkshop == "How to Interview" && selectedLocation == "Raleigh")
                {
                    totalLodgingCost = howToInterviewDays * raleighLodgingPricePerDay;
                    totalCost = howToInterviewPrice + totalLodgingCost;

                    pricingListBox.Items.Add("Registration: " + howToInterviewPrice.ToString("c0"));
                    pricingListBox.Items.Add("Lodging: " + raleighLodgingPricePerDay.ToString("c0") + " x " +
                        howToInterviewDays.ToString("n0") + " days = " + totalLodgingCost.ToString("c0"));
                    pricingListBox.Items.Add("Total: " + totalCost.ToString("c0"));
                }
            }
            //Displays a message box with an error message if the user does not select both a workshop and a location
            else
            {
                MessageBox.Show("Please select a workshop and a location.");
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            workshopListBox.SelectedIndex = -1; //De-selects any item selected in workshop listbox
            locationListBox.SelectedIndex = -1; //De-selects any item selected in location listbox
            pricingListBox.Items.Clear(); //Clears any entry from pricing listbox

            workshopListBox.Focus(); //Focuses the users cursor on the workshop listbox
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Closes the program
        }
    }
}
