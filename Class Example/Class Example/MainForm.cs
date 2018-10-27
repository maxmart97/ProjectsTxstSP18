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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool IsInputValid(ref string str)
        {
            str = str.ToUpper();

            if (str != "" && str != null && (str == "A" || str == "B" || str == "C"
                || str == "D" || str == "F"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetStatus(string grade)
        {
            if (grade == "A")
            {
                return "Above Average";
            }
            else if (grade == "B")
            {
                return "Okay";
            }
            else if (grade == "C")
            {
                return "Average";
            }
            else if (grade == "D")
            {
                return "Below Average";
            }
            else
            {
                return "Failed";
            }
        }

        private void displaySecondForm_Click(object sender, EventArgs e)
        {
            string grade = letterGradeTextBox.Text;
            string status;

            int points = 0;

            if (IsInputValid(ref grade)) 
            {
                letterGradeTextBox.Text = grade;

                SecondForm secondFormInformation = new SecondForm();
                secondFormInformation.gradeLabel.Text = grade;

                secondFormInformation.ShowDialog();

                status = GetStatus(grade);

                statusLabel.Text = status;

                if (secondFormInformation.processClicked)
                {
                    points = secondFormInformation.totalPoints;

                    totalPointsLabel.Text = points.ToString();
                }
                else
                {
                    totalPointsLabel.Text = "Failed to click process button.";
                }
            }
            else
            {
                MessageBox.Show("Input invalid.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
