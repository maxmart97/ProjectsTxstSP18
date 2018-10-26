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
    public partial class ChargesForm : Form
    {
        public ChargesForm()
        {
            InitializeComponent();
        }

        // Click event for the Close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            // Closes the MealPlanForm
            this.Close();
        }
    }
}
