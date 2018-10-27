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

namespace Sample_One
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //This  method creates a new file in the default location (bin -> Debug)

            try
            {
                String fileName = "Students.txt";
                StreamWriter outputFile = File.CreateText(fileName);
                outputFile.WriteLine("Johnny Depp");
                outputFile.WriteLine("Justin Bieber");
                outputFile.WriteLine("Bruce Willis");
                outputFile.WriteLine("Jennifer Aniston");

                outputFile.Close();

                MessageBox.Show("The file: \'" + fileName + "\' has been created in the default location.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            //This file reads records from a default location and displays them in a listbox.

            try
            {
                String fileName = "Students.txt";

                StreamReader inputFile = File.OpenText(fileName);

                string name;

                namesListBox.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    name = inputFile.ReadLine();
                    namesListBox.Items.Add(name);
                }

                inputFile.Close();

                MessageBox.Show("The contents of the file \'" + fileName + "\' have been added to the \'" + namesListBox.Name +
                    "\' listbox.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void readButtonWithDialogBox_Click(object sender, EventArgs e)
        {
            //This code reads a file that the user chooses from an open file dialog box and displays its contents in a listbox.

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK) 
                {
                    StreamReader inputFile = File.OpenText(openFileDialog1.FileName);

                    String fileName = openFileDialog1.FileName;

                    while (!inputFile.EndOfStream)
                    {
                        namesListBox2.Items.Add(inputFile.ReadLine());
                    }

                    inputFile.Close();

                    String shortenedFileName = fileName.Substring(fileName.LastIndexOf("\\") + 1);

                    MessageBox.Show("The contents of the file \'" + shortenedFileName + "\' have been added to the \'" + namesListBox2.Name +
                    "\' listbox.");

                }
                else
                {
                    MessageBox.Show("The operation has been canceled.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void writeButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter outputFile = File.CreateText(saveFileDialog1.FileName);

                    outputFile.WriteLine("Intro to C#");
                    outputFile.WriteLine("Advanced C#");
                    outputFile.WriteLine("Systems Analysis");
                    outputFile.WriteLine("Database Design");

                    outputFile.Close();
                }
                else
                {
                    MessageBox.Show("The operation was canceled.");
                }

                String shortenedFileName = saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.LastIndexOf("\\") + 1);

                MessageBox.Show("The file: \'" + shortenedFileName + "\' has been created.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
