using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Records
{
    // Software Engineer: Maxwell Martin
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Array of advisors.
        string[] advisors = { "Dr. I. Jones", "Dr. Marcus Litrell", "Dr. Harris Ford", "Dr. Jamie Bond" };

        // Method to process and display the contents of a file.
        private void ProcessFile(string pathToFile)
        {
            // Exception handler
            try 
            {
                // Creation of a StreamReader object that references a file.
                StreamReader inputFile = File.OpenText(pathToFile);

                // Variables to use with processing and displaying data.
                string name;
                double gpa;
                int advisorNumber;
                string advisorName;
                string status;
                string studentInformation;
                int numberOfRecordsProcessed = 0;

                // Loops through the entire file.
                while (!inputFile.EndOfStream)
                {
                    // Gets name from first line of 3 line data set.
                    name = inputFile.ReadLine();

                    // Gets gpa from second line of 3 line data set.
                    gpa = Math.Round(double.Parse(inputFile.ReadLine()), 2, MidpointRounding.AwayFromZero);

                    // Gets advisor number from third line of 3 line data set.
                    advisorNumber = int.Parse(inputFile.ReadLine());

                    // Calls method to get the name of the student's advisor.
                    advisorName = GetAdvisorName(advisorNumber);

                    // Calls method to get the student's academic status.
                    status = GetStatus(gpa);

                    // Concatenation and formatting of all student information.
                    studentInformation = name + " \t\t\t" + gpa.ToString("n2") + "\t\t\t" + status +
                        " \t\t   " + advisorName;

                    // Add student's information to the student information listbox.
                    studentInformationListBox.Items.Add(studentInformation);

                    // Adds up the total number of records processed.
                    numberOfRecordsProcessed++;
                }

                // Displays the total number of records processed in the correct label.
                numberOfRecordsLabel.Text = numberOfRecordsProcessed.ToString("n0");

                // Closes the input file.
                inputFile.Close();

                // Focuses the cursor on the clear button.
                clearButton.Focus();
            }
            catch 
            {
                // Error message if the file chosen is unreadable.
                MessageBox.Show("File is unreadable.");
            }
            
        }

        // Method to get the advisor's name from the advisors array.
        private string GetAdvisorName(int subscript)
        {
            return advisors[subscript];
        }

        // Method to get the student's status based on his or her GPA.
        private string GetStatus(double studentGPA)
        {
            if (studentGPA >= 3.95)
            {
                return "Highest HONORS";
            }
            else if (studentGPA >= 3.75 && studentGPA < 3.95)
            {
                return "High HONORS";
            }
            else if (studentGPA >= 3.50 && studentGPA < 3.75)
            {
                return "HONORS ";
            }
            else if (studentGPA >= 2.50 &&  studentGPA < 3.50) 
            {
                return "*                         *";
            }
            else
            {
                return "PROBATION";
            }
        }

        // Click event for the user to process a file.
        private void processButton_Click(object sender, EventArgs e)
        {
            // Variable to hold the fileName of the file the user chooses.
            string fileName;

            // Clears the file dialog's file name if there is one.
            openFileDialog1.FileName = "";

            // Checks to see if the user selected a file.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Assigns the file name of the file chosen to the fileName variable.
                fileName = openFileDialog1.FileName;

                // Clears all data in the student information listbox.
                studentInformationListBox.Items.Clear();

                // Calls method to process the file that the user selected.
                ProcessFile(fileName);
            }
            else
            {
                // Error message if the user does not select a file.
                MessageBox.Show("Action canceled.\n\n"
                + "If you would like to read a file, click Process, choose a file, and select OK.");
            }
        }

        // Click event to clear data.
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clears all items in the student information listbox.
            studentInformationListBox.Items.Clear();

            // Focuses the cursor on the process button.
            processButton.Focus();

            // Clears the file dialog file name if any.
            openFileDialog1.FileName = "";
            
            // Clears the number of records label.
            numberOfRecordsLabel.Text = "";
        }

        // Click event to close the program.
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
