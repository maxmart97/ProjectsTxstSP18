using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Looping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //While Loop Example

            int i = 1;

            while (i < 5)
            {
                outputListbox.Items.Add("WHILE LOOP ITERATION: " + i);

                i++;
            }
        }

        private void startButtonDoWhileLoop_Click(object sender, EventArgs e)
        {
            //Do-While Loop Example

            int i = 10;

            do
            {
                outputListbox.Items.Add("DO-WHILE LOOP ITERATION: " + i);
                MessageBox.Show("Infinite loop " + i);
                i++;
            }
            while (i < 16);
        }

        private void startButtonForLoop_Click(object sender, EventArgs e)
        {
            //For Loop Example

            for (int i = 20; i < 26; i++)
            {
                outputListbox.Items.Add("FOR LOOP ITERATION: " + i);
            }
        }
    }
}
