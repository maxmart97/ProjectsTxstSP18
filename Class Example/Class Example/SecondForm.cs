using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Example
{
    public partial class SecondForm : Form
    {
        public int totalPoints = 0;
        public bool processClicked = false;

        public SecondForm()
        {
            InitializeComponent();
        }

        private int GetPoints(string grade)
        {
            if (grade == "A")
            {
                return 4;
            }
            else if (grade == "B")
            {
                return 3;
            }
            else if (grade == "C")
            {
                return 2;
            }
            else if (grade == "D")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            processClicked = true;
            totalPoints = GetPoints(gradeLabel.Text);
        }

        private void returnToMainFormButton_Click(object sender, EventArgs e)
        {
            if (processClicked == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Please process your grade.");
            }
        }
    }
}
