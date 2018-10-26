using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormAndMealPlanCalculator
{
    // Class for meal plan information
    class MealPlan
    {
        // Backing fields
        private string _amount;
        private decimal _pricePerSemester;

        // Constructor
        public MealPlan(string amount, decimal price)
        {
            _amount = amount;
            _pricePerSemester = price;
        }

        // Amount property
        public string Amount
        {
            get { return _amount; }
        }

        // Price per semester property
        public decimal PricePerSemester
        {
            get { return _pricePerSemester; }
        }
    }
}
