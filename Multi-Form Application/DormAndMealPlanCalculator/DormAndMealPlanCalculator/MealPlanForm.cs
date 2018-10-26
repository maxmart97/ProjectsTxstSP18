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
    public partial class MealPlanForm : Form
    {
        // Flag variable
        public bool addSelected;

        // Variable to keep track of the meal plan selected
        public int currentMealPlanIndex = -1;

        public MealPlanForm()
        {
            InitializeComponent();
        }

        // Click event for the Add Meal Plan button
        private void addMealPlanButton_Click(object sender, EventArgs e)
        {
            // Check if the user selected a meal plan
            if (mealPlansListBox.SelectedIndex != -1)
            {
                // Updates flag variable
                addSelected = true;

                // Updates currentIndex to keep track of the added meal plan
                currentMealPlanIndex = mealPlansListBox.SelectedIndex;

                // Closes the MealPlanForm
                this.Close();
            }
            // Error message if the user does not select a meal plan
            else
            {
                MessageBox.Show("Please select a meal plan.");
            }
        }

        // Click event for the Close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            // Closes the MealPlanForm
            this.Close();
        }
    }
}
