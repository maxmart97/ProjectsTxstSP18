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

namespace Driver_s_License_Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Size for the examAnswers array and the studentAnswers array.
        private const int SIZE = 20;

        // Variables that will hold the file name of each file selected.
        string examAnswersFileName, studentAnswersFileName;

        // Creation of both the examAnswers array and the studentAnswers array.
        // Max size is 20 per the constant SIZE.
        string[] examAnswers = new string[SIZE];
        string[] studentAnswers = new string[SIZE];

        // StreamReader variables for exam answers and student answers.
        StreamReader inputFileExamAnswers;
        StreamReader inputFileStudentAnswers;
        
        // Method to read exam answers into examAnswers array and student answers into studentAnswers array.
        // Returns true if both files were read successfully.
        private bool GetAnswers()
        {
            try
            {
                // Counter variables.
                int index1 = 0;
                int index2 = 0;

                // Loops through exam answers file and adds each value to the 
                // examAnswers array at specified index.
                while (!inputFileExamAnswers.EndOfStream)
                {
                    examAnswers[index1] = inputFileExamAnswers.ReadLine();
                    index1++;
                }

                // Loops through student answers file and adds each value to the 
                // studentAnswers array at specified index.
                while (!inputFileStudentAnswers.EndOfStream)
                {
                    studentAnswers[index2] = inputFileStudentAnswers.ReadLine();
                    index2++;
                }

                return true;
            }

            // Displays error message if the file is unreadable.
            catch
            {
                MessageBox.Show("Unable to read file(s).\n\nPlease make sure both file(s) " +
                    "are a .txt files with one answer per line.");

                return false;
            }
        }

        // Method to calculate and return the total number of correct answers.
        private int GetTotalCorrectAnswers(string[] answers1, string[] answers2)
        {
            // Counter variable to loop through arrays.
            int index = 0;

            // Counter variable to keep track of the number of correct answers.
            int numberCorrect = 0;

            // Loop that compares the value of both arrays at the same index to see if
            // the values are the same. If so, increases the numberCorrect variable by 1.
            while (index < SIZE)
            {
                if (answers1[index] == answers2[index])
                {
                    numberCorrect++;
                }

                index++;
            }

            return numberCorrect;
        }

        // Method to display a number of correct answers in the numberCorrectLabel.
        private void DisplayTotalCorrect(int value)
        {
            numberCorrectLabel.Text = value.ToString();
        }

        // Method to calculate and return the total number of incorrect answers.
        // Also displays question number of each incorrect answer in incorrectListbox.
        private int GetTotalIncorrectAnswers(string[] answers1, string[] answers2)
        {
            // Counter variable to loop through arrays.
            int index = 0;

            // Counter variable to keep track of the number of incorrect answers.
            int numberIncorrect = 0;

            // Loop that compares the value of both arrays at the same index to see if
            // the values are not the same. If so, increases the numberIncorrect variable by 1.
            while (index < SIZE)
            {
                if (answers1[index] != answers2[index])
                {
                    numberIncorrect++;

                    // Adds and displays the question number missed to the incorrectListBox.
                    incorrectListBox.Items.Add("Question: " + (index + 1));
                }

                index++;
            }

            return numberIncorrect;
        }

        // Method to display a number of incorrect answers in the numberIncorrectLabel.
        private void DisplayTotalIncorrect(int numberIncorrect)
        {
            numberIncorrectLabel.Text = numberIncorrect.ToString();
        }

        // Method to see if the student passed or failed the test.
        private string GetStatus(int numberCorrect)
        {
            // Returns "PASSED" if numberCorrect is greater than or equal to 15.
            if (numberCorrect >= 15)
            {
                return "PASSED";
            }
            // Returns "FAILED" if numberCorrect is less than 15.
            else
            {
                return "FAILED";
            }
        }

        // Method to display the student's status (passed or failed) in the statusLabel.
        private void DisplayStatus(string status)
        {
            statusLabel.Text = status;
        }

        // Method to clear everything.
        private void ClearAll()
        {
            // Resets all labels and global string variables to blank.
            statusLabel.Text = "";
            numberCorrectLabel.Text = "";
            numberIncorrectLabel.Text = "";
            examAnswersFileName = "";
            studentAnswersFileName = "";
            examAnswersFileLabel.Text = "";
            studentAnswersFileLabel.Text = "";
            
            // Closes both input files.
            inputFileExamAnswers.Close();
            inputFileStudentAnswers.Close();

            // Clears all items from the incorrectListBox.
            incorrectListBox.Items.Clear();

            // Focuses the cursor on the chooseExamAnswersButton.
            chooseExamAnswersButton.Focus();
        }

        // Clears only the bottom half of the form
        private void ClearBottomHalf()
        {
            statusLabel.Text = "";
            numberCorrectLabel.Text = "";
            numberIncorrectLabel.Text = "";
            incorrectListBox.Items.Clear();
        }

        // Method to check if the user has selected both files; returns true or false.
        private bool BothFilesSelected()
        {
            // Flag variable.
            bool bothSelected;

            // If both files are not blank or null, flag variable set to true; else false.
            if ( (examAnswersFileName != "") && (studentAnswersFileName != "") 
                && (examAnswersFileName != null) && (studentAnswersFileName != null))
            {
                bothSelected = true;
            }
            else
            {
                // Displays error message if user selects no files or only one file.
                MessageBox.Show("Please make sure you have selected both files.");

                bothSelected = false;
            }

            return bothSelected;
        }

        // Click event for when the user clicks the chooseExamAnswersButton.
        private void chooseExamAnswersButton_Click(object sender, EventArgs e)
        {
            // Clear exam answers file dialog file name.
            openFileDialogExamAnswers.FileName = "";

            // Opens an openFileDialog and checks to see if user picked a file and clicked ok.
            if (openFileDialogExamAnswers.ShowDialog() == DialogResult.OK)
            {
                // Initializes examAnswersFileName with the FileName of the file that the user selected.
                examAnswersFileName = openFileDialogExamAnswers.FileName;

                // Initializes the StreamReader variable inputFileExamAnswers as a reference to the
                // open file of the file that the user selected.
                inputFileExamAnswers = File.OpenText(examAnswersFileName);

                // Clears entire bottom half of form and focuses cursor on chooseStudentAnswersButton.
                ClearBottomHalf();
                chooseStudentAnswersButton.Focus();
            }

            // Displays the file name that the user picked in the examAnswersFileLabel.
            examAnswersFileLabel.Text = examAnswersFileName;
        }

        // Click event for when the user clicks the chooseStudentAnswersButton.
        private void chooseStudentAnswersButton_Click(object sender, EventArgs e)
        {
            // Clear student answers file dialog file name.
            openFileDialogStudentAnswers.FileName = "";

            // Opens an openFileDialog and checks to see if user picked a file and clicked ok.
            if (openFileDialogStudentAnswers.ShowDialog() == DialogResult.OK)
            {
                // Initializes studentAnswersFileName with the FileName of the file that the user selected.
                studentAnswersFileName = openFileDialogStudentAnswers.FileName;

                // Initializes the StreamReader variable inputFileStudentAnswers as a reference to the
                // open file of the file that the user selected.
                inputFileStudentAnswers = File.OpenText(studentAnswersFileName);

                /// Clears entire bottom half of form and focuses cursor on gradeButton.
                ClearBottomHalf();
                gradeButton.Focus();
            }

            // Displays the file name that the user picked in the studentAnswersFileLabel.
            studentAnswersFileLabel.Text = studentAnswersFileName;
        }

        // Click event for when the user clicks the gradeButton.
        private void gradeButton_Click(object sender, EventArgs e)
        {
            // Variables to hold the number of correct and incorrect answers.
            int numberCorrect, numberIncorrect;

            // Variable to hold the student's status (whether they passed or failed the exam).
            string status;

            // Checks to see if the user selected two files to use and both files were readable.
            if (BothFilesSelected() && GetAnswers())
            {
                // Clears the entire bottom half of form.
                ClearBottomHalf();

                // Initializes the numberCorrect variable to total number of correct answers
                // GetTotalCorrect returns the total number of correct answers after comparing the two arrays.
                numberCorrect = GetTotalCorrectAnswers(examAnswers, studentAnswers);

                // Displays the total number of correct answers in the designated label.
                DisplayTotalCorrect(numberCorrect);

                // Initializes the numberIncorrect variable to total number of incorrect answers
                // GetTotalIncorrect returns the total number of incorrect answers after comparing the two arrays.
                numberIncorrect = GetTotalIncorrectAnswers(examAnswers, studentAnswers);

                // Displays the total number of incorrect answers in the designated label.
                DisplayTotalIncorrect(numberIncorrect);

                //Initializes the status variable to whether the student passed or failed the exam.
                // GetStatus returns either "PASSED" or "FAILED" based off the number of correct answers.
                status = GetStatus(numberCorrect);

                // Displays whether the student passed or failed in the designated label.
                DisplayStatus(status);

                // Focuses cursor on chooseStudentAnswersButton.
                chooseStudentAnswersButton.Focus();
            }
        }

        // Click event for when the user clicks the clearButton
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clears everything on the form; clears all variables that need to be cleared; 
            // and closes the two open files.
            ClearAll();
        }
    }
}
