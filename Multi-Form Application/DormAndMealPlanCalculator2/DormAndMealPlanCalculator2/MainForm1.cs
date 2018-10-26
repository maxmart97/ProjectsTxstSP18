using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormAndMealPlanCalculator2
{
    public partial class MainForm1 : Form
    {
        // Lists to hold Dorm and Meal Plan objects
        private List<Dorm> dormsAvailable = new List<Dorm>();
        private List<MealPlan> mealPlansAvailable = new List<MealPlan>();

        // Object that references a ChargesForm
        private ChargesForm totalChargesForm;

        // Variable to keep track of currently added dorm
        private int currentDormIndex = -1;
        private int currentMealPlanIndex = -1;

        // Variables for calculation
        private decimal dormCharges = 0m;
        private decimal mealCharges = 0m;
        private decimal totalCharges = 0m;

        public MainForm1()
        {
            InitializeComponent();
        }

        // Gets dorm charges and displays them in the appropriate location
        private void UpdateDormCharges()
        {
            // Dorm charges set based on dorm chosen from dormListBox
            dormCharges = dormsAvailable[dormListBox.SelectedIndex].PricePerSemester;

            // Displays and formats dorm charges
            totalChargesForm.dormChargesLabel.Text = dormCharges.ToString("c");
        }

        // Gets meal charges and displays them in the appropriate location
        private void UpdateMealCharges()
        {
            // Meal charges set based on meal plan chosen in the mealPlansListBox
            mealCharges = mealPlansAvailable[mealPlansListBox.SelectedIndex].PricePerSemester;

            // Displays and formats meal charges
            totalChargesForm.mealPlanChargesLabel.Text = mealCharges.ToString("c");
        }

        // Gets total charges and displays them in the appropriate location
        private void UpdateTotalCharges()
        {
            // Total charges calculated by adding the dorm charges and meal charges together
            totalCharges = dormCharges + mealCharges;

            // Displays and formats total charges
            totalChargesForm.totalChargesLabel.Text = totalCharges.ToString("c");
        }

        // Click event for the Add Dormitory button
        private void addDormButton_Click(object sender, EventArgs e)
        {
            // Checks to make sure a dorm has been selected
            if (dormListBox.SelectedIndex != -1)
            {
                // Enables the show charges button
                showChargesButton.Enabled = true;

                // Updates currentDormIndex variable to the index of the dorm selected
                currentDormIndex = dormListBox.SelectedIndex;

                // Updates and displays dorm charges and total charges
                UpdateDormCharges();
                UpdateTotalCharges();

                // Checks if meal charges contains a value
                if (mealCharges == 0m)
                {
                    // Displays appropriate string if meal charges doesn't have a value
                    totalChargesForm.mealPlanChargesLabel.Text = "$0.00";
                }

                // Message to inform the user that the dorm selected has been added
                MessageBox.Show("Dorm: *" + dormsAvailable[dormListBox.SelectedIndex].Name + "* has been added.");
            }
            // Error message if user doesn't choose a dorm
            else
            {
                MessageBox.Show("Please select a dormitory.");
            }
        }

        // Click event for the Add Meal Plan button
        private void addMealPlanButton_Click(object sender, EventArgs e)
        {
            // Checks if user clicked the Add Meal Plan button
            if (mealPlansListBox.SelectedIndex != -1)
            {
                // Enables the show charges button
                showChargesButton.Enabled = true;

                // Updates currentMealPlanIndex variable to the index of the meal plan selected
                currentMealPlanIndex = mealPlansListBox.SelectedIndex;

                // Updates meal charges and total charges
                UpdateMealCharges();
                UpdateTotalCharges();

                // Checks if dorm charges contains a value
                if (dormCharges == 0m)
                {
                    // Displays appropriate string if dorm charges doesn't have a value
                    totalChargesForm.dormChargesLabel.Text = "$0.00";
                }

                // Message to inform the user that the meal plan selected has been added
                MessageBox.Show("Meal Plan: *" + mealPlansAvailable[mealPlansListBox.SelectedIndex].Amount + "* has been added.");
            }
            // Error message if user doesn't choose a meal plan
            else
            {
                MessageBox.Show("Please select a meal plan.");
            }
        }

        // Click event for the Reset button
        private void resetButton_Click(object sender, EventArgs e)
        {
            // Resets the show charges button to disabled
            showChargesButton.Enabled = false;

            // Selected indexes for both listboxes reset
            dormListBox.SelectedIndex = -1;
            mealPlansListBox.SelectedIndex = -1;

            // Resets the variables used to track the indexes of the meal plan added and the dorm added
            currentDormIndex = -1;
            currentMealPlanIndex = -1;

            // Sets focus on dorm listbox
            dormListBox.Focus();

            // Appropriate labels reset to blank
            totalChargesForm.dormChargesLabel.Text = "";
            totalChargesForm.mealPlanChargesLabel.Text = "";
            totalChargesForm.totalChargesLabel.Text = "";

            // Variables for calculation reset to 0
            dormCharges = 0m;
            mealCharges = 0m;
            totalCharges = 0m;
        }

        // Click event for the Exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the program.
            Close();
        }

        // Load event for the main form
        private void MainForm1_Load(object sender, EventArgs e)
        {
            // Initialization of 4 Dorm objects with appropriate data
            Dorm allenHall = new Dorm("Allen Hall", 1500m);
            Dorm pikeHall = new Dorm("Pike Hall", 1600m);
            Dorm farthingHall = new Dorm("Farthing Hall", 1800m);
            Dorm universitySuites = new Dorm("University Suites", 2500m);

            // Dorm objects added to the appropriate list
            dormsAvailable.Add(allenHall);
            dormsAvailable.Add(pikeHall);
            dormsAvailable.Add(farthingHall);
            dormsAvailable.Add(universitySuites);

            // Loop to display dorm names in appropriate listbox
            foreach (Dorm name in dormsAvailable)
            {
                dormListBox.Items.Add(name.Name);
            }

            // Initialization of 3 MealPlan objects with appropriate data
            MealPlan sevenMealsPerWeek = new MealPlan("7 meals per week", 600m);
            MealPlan fourteenMealsPerWeek = new MealPlan("14 meals per week", 1200m);
            MealPlan unlimitedMealsPerWeek = new MealPlan("Unlimited meals", 1700m);

            // MealPlan objects added to the appropriate list
            mealPlansAvailable.Add(sevenMealsPerWeek);
            mealPlansAvailable.Add(fourteenMealsPerWeek);
            mealPlansAvailable.Add(unlimitedMealsPerWeek);

            // Loop to display meal plan amounts in appropriate listbox
            foreach (MealPlan option in mealPlansAvailable)
            {
                mealPlansListBox.Items.Add(option.Amount);
            }

            // Initialization of the ChargesForm object
            totalChargesForm = new ChargesForm();
        }

        private void showChargesButton_Click(object sender, EventArgs e)
        {
            // Opens up the ChargesForm object's form
            totalChargesForm.ShowDialog();

            /* 
                * The checks below are used to prevent user confusion if the user selects a different dorm 
                * or meal plan, but doesn't add them.
            */

            if (dormListBox.SelectedIndex != currentDormIndex)
            {
                // Resets dorm selection to the currently added dorm (if any)
                dormListBox.SelectedIndex = currentDormIndex;
            }
            if (mealPlansListBox.SelectedIndex != currentMealPlanIndex)
            {
                // Resets meal plan selection to the currently added meal plan (if any)
                mealPlansListBox.SelectedIndex = currentMealPlanIndex;
            }
        }
    }
}
