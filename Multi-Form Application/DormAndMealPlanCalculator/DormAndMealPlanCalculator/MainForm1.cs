using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormAndMealPlanCalculator
{
    public partial class MainForm1 : Form
    {
        // Lists to hold Dorm and Meal Plan objects
        private List<Dorm> dormsAvailable = new List<Dorm>();
        private List<MealPlan> mealPlansAvailable = new List<MealPlan>();

        // Object that references a MealPlanForm
        private MealPlanForm mealPlan;

        // Variable to keep track of currently added dorm
        private int currentDormIndex = -1;

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
            dormChargesLabel.Text = dormCharges.ToString("c");
        }

        // Gets meal charges and displays them in the appropriate location
        private void UpdateMealCharges()
        {
            // Meal charges set based on meal plan chosen in the mealPlansListBox
            mealCharges = mealPlansAvailable[mealPlan.mealPlansListBox.SelectedIndex].PricePerSemester;

            // Displays and formats meal charges
            mealPlanChargesLabel.Text = mealCharges.ToString("c");
        }

        // Gets total charges and displays them in the appropriate location
        private void UpdateTotalCharges()
        {
            // Total charges calculated by adding the dorm charges and meal charges together
            totalCharges = dormCharges + mealCharges;

            // Displays and formats total charges
            totalChargesLabel.Text = totalCharges.ToString("c");
        }

        // Click event for the Add Dormitory button
        private void addDormButton_Click(object sender, EventArgs e)
        {
            // Checks to make sure a dorm has been selected
            if (dormListBox.SelectedIndex != -1)
            {
                // Updates currentDormIndex variable to the index of the dorm selected
                currentDormIndex = dormListBox.SelectedIndex;

                // Updates and displays dorm charges and total charges
                UpdateDormCharges();
                UpdateTotalCharges();

                // Checks if meal charges contains a value
                if (mealCharges == 0m)
                {
                    // Displays appropriate string if meal charges doesn't have a value
                    mealPlanChargesLabel.Text = "$0.00";
                }
            }
            // Error message if user doesn't choose a dorm
            else
            {
                MessageBox.Show("Please select a dormitory.");
            }
        }

        // Click event for the View Meal Plans button
        private void viewMealPlansButton_Click(object sender, EventArgs e)
        {
            // Sets/Resets default value for flag variable inside mealPlan object
            mealPlan.addSelected = false;

            // Opens up the mealPlan object's form
            mealPlan.ShowDialog();

            // Checks if user clicked the Add Meal Plan button
            if (mealPlan.addSelected == true)
            {
                // Updates meal charges and total charges
                UpdateMealCharges();
                UpdateTotalCharges();

                // Checks if dorm charges contains a value
                if (dormCharges == 0m)
                {
                    // Displays appropriate string if dorm charges doesn't have a value
                    dormChargesLabel.Text = "$0.00";
                }
            }

            /* 
             * The checks below are used to prevent user confusion if the user selects a different dorm 
             * or meal plan, but doesn't add them.
            */
            if (mealPlan.mealPlansListBox.SelectedIndex != mealPlan.currentMealPlanIndex)
            {
                // Resets meal plan selection to the currently added meal plan (if any)
                mealPlan.mealPlansListBox.SelectedIndex = mealPlan.currentMealPlanIndex;
            }
            if (dormListBox.SelectedIndex != currentDormIndex)
            {
                // Resets dorm selection to the currently added dorm (if any)
                dormListBox.SelectedIndex = currentDormIndex;
            }
        }

        // Click event for the Reset button
        private void resetButton_Click(object sender, EventArgs e)
        {
            // Selected indexes for both listboxes reset
            dormListBox.SelectedIndex = -1;
            mealPlan.mealPlansListBox.SelectedIndex = -1;

            // Resets the index variables used to track the indexes of the meal plan added and the dorm added
            currentDormIndex = -1;
            mealPlan.currentMealPlanIndex = -1;

            // Sets focus on dorm listbox
            dormListBox.Focus();

            // Labels reset to blank
            dormChargesLabel.Text = "";
            mealPlanChargesLabel.Text = "";
            totalChargesLabel.Text = "";

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
            Dorm farthingHall = new Dorm("Farthing Hall", 1200m);
            Dorm universitySuites = new Dorm("University Suites", 1800m);

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

            // Initialization of the MealPlanForm object
            mealPlan = new MealPlanForm();

            // Initialization of 3 MealPlan objects with appropriate data
            MealPlan sevenMealsPerWeek = new MealPlan("7 meals per week", 560m);
            MealPlan fourteenMealsPerWeek = new MealPlan("14 meals per week", 1095m);
            MealPlan unlimitedMealsPerWeek = new MealPlan("Unlimited meals", 1500m);

            // MealPlan objects added to the appropriate list
            mealPlansAvailable.Add(sevenMealsPerWeek);
            mealPlansAvailable.Add(fourteenMealsPerWeek);
            mealPlansAvailable.Add(unlimitedMealsPerWeek);

            // Loop to display meal plan amounts in appropriate listbox on the mealPlan object's form
            foreach (MealPlan option in mealPlansAvailable)
            {
                mealPlan.mealPlansListBox.Items.Add(option.Amount);
            }
        }
    }
}
