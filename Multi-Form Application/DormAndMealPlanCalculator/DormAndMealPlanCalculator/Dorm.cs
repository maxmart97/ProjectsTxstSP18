using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormAndMealPlanCalculator
{
    // Class for dorm information
    class Dorm
    {
        // Backing fields
        private string _name;
        private decimal _pricePerSemester;

        // Constructor
        public Dorm(string name, decimal price)
        {
            _name = name;
            _pricePerSemester = price;
        }

        // Name property (Read-Only)
        public string Name
        {
            get { return _name; }
        }

        //Price per semester property (Read-Only)
        public decimal PricePerSemester
        {
            get { return _pricePerSemester; }
        }
    }
}
