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

namespace Blood_Pressure_Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Number of blood pressure records per patient.
        private const int SIZE = 5;

        // Arrays to hold systolic and diastolic values of each patient.
        int[] systolic = new int[SIZE];
        int[] diastolic = new int[SIZE];

        // Array that holds the names of each doctor.
        string[] doctors = { "D.ABRAMS,MD", "D.JARVIC,MD", "T.PANOS,MD" };

        // String to hold name of file that user chooses.
        string fileName = "";

        // Method that reads a file with the patient(s)'s data and displays information in a listbox.
        private void ReadandDisplayFile()
        {
            /* 
             * This method works with text files in this format:
             * 
             * FirstPatientName
             * Systolic Blood Pressure 1
             * Diastolic Blood Pressure 1
             * Systolic Blood Pressure 2
             * Diastolic Blood Pressure 2
             * Systolic Blood Pressure 3
             * Diastolic Blood Pressure 3
             * Systolic Blood Pressure 4
             * Diastolic Blood Pressure 4
             * Systolic Blood Pressure 5
             * Diastolic Blood Pressure 5
             * Doctor Number (0 = "DOCTOR NAME1", 1 = "DOCTOR NAME2", 2 ="DOCTOR NAME3")
             * SecondPatientName
             * ...and so on repeated like above.
             * 
            */

            try
            {
                // Opens of the patient data file.
                StreamReader inputFile = File.OpenText(fileName);

                // Variables used to make displaying information the the listbox easier.
                string name;
                double averageSystolic;
                double averageDiastolic;
                string status;
                string doctorName;
                string patientInformation;

                // Loops through the entire file.
                while (!inputFile.EndOfStream)
                {
                    // Name of the patient.
                    name = inputFile.ReadLine();

                    // Loops through the next 5 sets of lines of systolic and diastolic blood pressures.
                    for (int index = 0; index < SIZE; index++)
                    {
                        // Assigns systolic number to systolic array and diastolic number to diastolic array.
                        systolic[index] = int.Parse(inputFile.ReadLine());
                        diastolic[index] = int.Parse(inputFile.ReadLine());
                    }

                    // Name of doctor assigned by getting the doctor number from the file and using the number
                    // as the index in the doctors array.
                    doctorName = doctors[int.Parse(inputFile.ReadLine())];

                    // The calculated and rounded average systolic and diastolic blood pressures for the patient.
                    averageSystolic = Math.Round(systolic.Average(), 0, MidpointRounding.AwayFromZero);
                    averageDiastolic = Math.Round(diastolic.Average(), 0, MidpointRounding.AwayFromZero);

                    // The status ("WARNING" or "NORMAL") for the patient based on average BP numbers.
                    status = GetStatus(averageSystolic, averageDiastolic);

                    // The patient's information that will be displayed.
                        // Contains advanced formatting by modifying padding.
                            // Will break if "name" is greater than 40 characters in length.
                    patientInformation = name + averageSystolic.ToString().PadLeft(40 - name.Length) +
                    averageDiastolic.ToString().PadLeft(15) + status.PadLeft(17) + doctorName.PadLeft(19);

                        /* 
                         * Above code could have also been formatted like below; however, issues arise when 
                         * name length increases past a certain point.
                         * 
                         * patientInformation = name + " \t\t\t\t\t\t\t\t" + averageSystolic + " \t\t\t" +
                         * averageDiastolic + " \t\t\t" + status + " \t\t" + doctorName;
                        */

                    // Adding the patient's information to the listbox.
                    patientInformationListBox.Items.Add(patientInformation);


                    // *Extra* for the added ListView Control.
                    ListViewItem items = new ListViewItem(name);
                    items.SubItems.Add(averageSystolic.ToString());
                    items.SubItems.Add(averageDiastolic.ToString());
                    items.SubItems.Add(status);
                    items.SubItems.Add(doctorName);
                    patientInformationListView.Items.Add(items);
                }

                // *Extra* - changes the listbox items font to a monospace font which aids the proper formatting.
                patientInformationListBox.Font = new Font(FontFamily.GenericMonospace, patientInformationListBox.Font.Size);

                // Closes file.
                inputFile.Close();

                // Focuses cursor on clear button.
                clearButton.Focus();
            }
            catch
            {
                // Error message if the file is unreadable.
                MessageBox.Show("File is unreadable.");

                // Focuses cursor on choose file button.
                chooseFileButton.Focus();
            }
        }

        // Method to get the patient's status based on their average systolic and diastolic blood pressures.
        private string GetStatus(double systolicAvgBP, double diastolicAvgBP)
        {
            // Check to determine if the patient's systolic or diastolic numbers are over/under the limit.
            if (systolicAvgBP <= 90.0 || systolicAvgBP >= 160.0 
                || diastolicAvgBP <= 60.0 || diastolicAvgBP >= 90.0)
            {
                return "WARNING";
            }
            else
            {
                return "NORMAL";
            }
        }

        // Click event to display the each patient's information to the listbox and listview.
        private void displayButton_Click(object sender, EventArgs e)
        {
            // Check to make sure user has selected a file.
            if (fileName != "" &&  fileName != null)
            {
                // Clears data in listbox and listview to prevent duplicate data appearing.
                patientInformationListBox.Items.Clear();
                patientInformationListView.Items.Clear();

                // Reads and displays data from the file that the user selected.
                ReadandDisplayFile();
            }
            // Error message if user does not select a file.
            else
            {
                MessageBox.Show("Please select a file.");

                // Focuses cursor on choose file button.
                chooseFileButton.Focus();
            }
            
        }

        // Click event to clear the listbox of any patient information.
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clears the listbox and listview.
            patientInformationListBox.Items.Clear();
            patientInformationListView.Items.Clear();

            // Clears file label and resets file name to blank.
            fileLabel.Text = "";
            fileName = "";

            // Focuses cursor on the choose file button.
            chooseFileButton.Focus();
        }

        // Click event to close the program.
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // *Extra* Adds columns to the ListView
        private void Form1_Load(object sender, EventArgs e)
        {
            // Columns are set to 130 width, but may appear differently on different computers.
            patientInformationListView.Columns.Add("Patient Name", 130);
            patientInformationListView.Columns.Add("Average Systolic", 130);
            patientInformationListView.Columns.Add("Average Diastolic", 130);
            patientInformationListView.Columns.Add("Status", 130);
            patientInformationListView.Columns.Add("Physician", 130);
        }

        // Click event to allow the user to choose a file.
        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            // Check if the user selected a file.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // The file path in a variable.
                fileName = openFileDialog1.FileName;

                // Location of last '\' in file path.
                int lastIndexOfBackSlash = fileName.LastIndexOf('\\');

                // Formatting file name to contain only the name of the file and not the entire path.
                fileName = fileName.Substring(lastIndexOfBackSlash + 1);

                // Displays file name in file label.
                fileLabel.Text = fileName;

                // Focuses cursor on display button.
                displayButton.Focus();
            }
        }
    }
}
