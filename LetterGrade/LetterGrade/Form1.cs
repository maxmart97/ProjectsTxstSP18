using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterGrade
{
    public partial class Form1 : Form
    {
        private decimal score;
        private string grade;

        public Form1()
        {
            InitializeComponent();
        }

        private bool GetScore()
        {
            bool isValid = false;

            if (decimal.TryParse(scoreTextBox.Text, out score) && (score >= 0m && score <= 100m))
            {
                score = Math.Truncate(100m * score) / 100m;
                isValid = true;
            }
            else
            {
                MessageBox.Show("Score must be an integer between 0 and 100.");
                ClearAll();
                isValid = false;
            }

            return isValid;
        }

        private string GetLetterGrade(decimal score)
        {
            if (score >= 90m)
            {
                grade = "A";
            }
            else if (score >= 80m && score < 90m)
            {
                grade = "B";
            }
            else if (score >= 70m && score < 80m)
            {
                grade = "C";
            }
            else if (score >= 60m && score < 70m)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            return grade;
        }

        private void DisplayLetterGrade()
        {
            gradeLabel.Text = grade;
        }

        private void ClearAll()
        {
            scoreTextBox.Clear();
            scoreTextBox.Focus();
            gradeLabel.Text = "";
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            if (GetScore())
            {
                GetLetterGrade(score);
                DisplayLetterGrade();
                scoreTextBox.Text = score.ToString("N");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
