using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            double gpa;
            double score;

            if (double.TryParse(gpaTextBox.Text, out gpa) && double.TryParse(scoreTextBox.Text, out score))
            {
                gpa = Math.Round(gpa, 2);
                score = Math.Round(score, 2);

                gpaTextBox.Text = gpa.ToString("n2");
                scoreTextBox.Text = score.ToString("n2");

                if ((gpa >= 0.00 && gpa <= 4.00) && (score >= 0.00 && score <= 100.00))
                {
                    if (gpa >= 3.50)
                    {
                        honorRollLabel.Text = "Honor Roll";
                    }
                    else if (gpa < 2.50)
                    {
                        honorRollLabel.Text = "P R O B A T I O N";
                    }
                    else
                    {
                        honorRollLabel.Text = "Tootsie Roll";
                    }

                    if (score >= 90.0)
                    {
                        gradeLabel.Text = "A";
                    }
                    else if (score >= 80.0 && score < 90.0)
                    {
                        gradeLabel.Text = "B";
                    }
                    else if (score >= 70.0 && score < 80.0)
                    {
                        gradeLabel.Text = "C";
                    }
                    else if (score >= 60.0 && score < 70.0)
                    {
                        gradeLabel.Text = "D";
                    }
                    else
                    {
                        gradeLabel.Text = "F";
                    }

                }
                else if ((gpa < 0.00 || gpa > 4.00) && (score >= 0.00 && score <= 100.00))
                {
                    MessageBox.Show("Please enter a GPA between (0.00-4.00).");

                    gpaTextBox.Clear();
                    honorRollLabel.Text = "";

                    gpaTextBox.Focus();
                }
                else if ((gpa >= 0.00 && gpa <= 4.00) && (score < 0.00 || score > 100.00))
                {
                    MessageBox.Show("Please enter a score between (0.00-100.00).");

                    scoreTextBox.Clear();
                    gradeLabel.Text = "";

                    scoreTextBox.Focus();
                }
                else if ((gpa < 0.00 || gpa > 4.00) && (score < 0.00 || score > 100.00))
                {
                    MessageBox.Show("Please enter a GPA between (0.00-4.00) and/or a score between (0.00-100.00).");

                    gpaTextBox.Clear();
                    honorRollLabel.Text = "";

                    scoreTextBox.Clear();
                    gradeLabel.Text = "";

                    gpaTextBox.Focus();
                }
            }
            else if (double.TryParse(gpaTextBox.Text, out gpa) && !double.TryParse(scoreTextBox.Text, out score))
            {
                gpa = Math.Round(gpa, 2);

                gpaTextBox.Text = gpa.ToString("n2");

                if ((gpa >= 0.00 && gpa <= 4.00) && (scoreTextBox.Text == ""))
                {
                    if (gpa >= 3.50)
                    {
                        honorRollLabel.Text = "Honor Roll";
                    }
                    else if (gpa < 2.50)
                    {
                        honorRollLabel.Text = "P R O B A T I O N";
                    }
                    else
                    {
                        honorRollLabel.Text = "Tootsie Roll";
                    }

                    gradeLabel.Text = "";
                }
                else if ((gpa >= 0.00 && gpa <= 4.00) && scoreTextBox.Text != "")
                {
                    MessageBox.Show("Please enter a score between (0.00-100.00) or leave it blank.");

                    scoreTextBox.Clear();
                    gradeLabel.Text = "";
                    scoreTextBox.Focus();
                }
                else if ((gpa < 0.00 || gpa > 4.00) && scoreTextBox.Text == "")
                {
                    MessageBox.Show("Please enter a GPA between (0.00-4.00).");

                    gpaTextBox.Clear();
                    honorRollLabel.Text = "";
                    gpaTextBox.Focus();
                }
                else if ((gpa < 0.00 || gpa > 4.00) && scoreTextBox.Text != "")
                {
                    MessageBox.Show("Please enter a GPA between (0.00-4.00) and/or a score between (0.00-100.00).");

                    gpaTextBox.Clear();
                    honorRollLabel.Text = "";

                    scoreTextBox.Clear();
                    gradeLabel.Text = "";

                    gpaTextBox.Focus();
                }
            }
            else if (!double.TryParse(gpaTextBox.Text, out gpa) && double.TryParse(scoreTextBox.Text, out score))
            {
                score = Math.Round(score, 2);

                scoreTextBox.Text = score.ToString("n2");

                if ((gpaTextBox.Text == "") && (score >= 0.00 && score <= 100.00))
                {
                    if (score >= 90.0)
                    {
                        gradeLabel.Text = "A";
                    }
                    else if (score >= 80.0 && score < 90.0)
                    {
                        gradeLabel.Text = "B";
                    }
                    else if (score >= 70.0 && score < 80.0)
                    {
                        gradeLabel.Text = "C";
                    }
                    else if (score >= 60.0 && score < 70.0)
                    {
                        gradeLabel.Text = "D";
                    }
                    else
                    {
                        gradeLabel.Text = "F";
                    }

                    honorRollLabel.Text = "";
                }
                else if ((gpaTextBox.Text != "") && (score >= 0.00 && score <= 100.00))
                {
                    MessageBox.Show("Please enter a GPA between (0.00-4.00) or leave it blank.");

                    gpaTextBox.Clear();
                    honorRollLabel.Text = "";
                    gpaTextBox.Focus();
                }
                else if ((gpaTextBox.Text == "") && (score < 0.00 || score > 100.00))
                {
                    MessageBox.Show("Please enter a score between (0.00-100.00).");

                    scoreTextBox.Clear();
                    gradeLabel.Text = "";
                    scoreTextBox.Focus();
                }
                else if ((gpaTextBox.Text != "") && (score < 0.00 || score > 100.00))
                {
                    MessageBox.Show("Please enter a GPA between (0.00-4.00) and/or a score between (0.00-100.00).");

                    gpaTextBox.Clear();
                    honorRollLabel.Text = "";

                    scoreTextBox.Clear();
                    gradeLabel.Text = "";

                    gpaTextBox.Focus();
                }
            }
            else
            {
                    MessageBox.Show("Please enter a GPA between (0.00-4.00) and/or a score between (0.00-100.00).");

                    honorRollLabel.Text = "";
                    gradeLabel.Text = "";

                    gpaTextBox.Clear();
                    honorRollLabel.Text = "";

                    scoreTextBox.Clear();
                    gradeLabel.Text = "";

                    gpaTextBox.Focus();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            gpaTextBox.Clear();
            honorRollLabel.Text = "";

            scoreTextBox.Clear();
            gradeLabel.Text = "";

            gpaTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
