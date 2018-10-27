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

namespace Honor_Roll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int SIZE = 15;

        string[] names = new string[SIZE];
        double[] gpa = new double[SIZE];
        string[] status = new string[SIZE];

        private bool ReadFile()
        {
            try
            {
                StreamReader inputFile = File.OpenText("grades.txt");

                int index = 0;

                while (!inputFile.EndOfStream)
                {
                    names[index] = inputFile.ReadLine();
                    gpa[index] = double.Parse(inputFile.ReadLine());

                    index++;
                }

                inputFile.Close();

                return true;
            }
            catch
            {
                MessageBox.Show("The file is unreadable.");

                return false;
            }
            
        }

        private void GetStatus()
        {
            for (int index = 0; index < SIZE; index++)
            {
                if (gpa[index] >= 3.9)
                {
                    status[index] = "Highest Honors";
                }
                else if (gpa[index] < 3.9 && gpa[index] >= 3.75)
                {
                    status[index] = "High Honors";
                }
                else if (gpa[index] < 3.75 && gpa[index] >= 3.5)
                {
                    status[index] = "Honors";
                }
                else
                {
                    status[index] = "";
                }
            }
        }

        private void DisplayInformation()
        {
            for (int index = 0; index < SIZE; index++)
            {
                informationListBox.Items.Add(names[index] + "\t\t\t" + gpa[index].ToString("n2") + "\t\t\t" + status[index]);
                informationListBox.Items.Add("------------------------------------------------------------------------------"
                + "-----------------------------------------------------------------------");
            }
        }

        private void Clear()
        {
            informationListBox.Items.Clear();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            if (ReadFile())
            {
                Clear();
                GetStatus();
                DisplayInformation();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
