using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawTicketButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int randomNumber1, randomNumber2, randomNumber3, randomNumber4;

            randomNumber1 = rand.Next(100);
            randomNumber2 = rand.Next(100);
            randomNumber3 = rand.Next(100);
            randomNumber4 = rand.Next(100);

            randomNumberTextBox1.Text = randomNumber1.ToString();
            randomNumberTextBox2.Text = randomNumber2.ToString();
            randomNumberTextBox3.Text = randomNumber3.ToString();
            randomNumberTextBox4.Text = randomNumber4.ToString();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            randomNumberTextBox1.Clear();
            randomNumberTextBox2.Clear();
            randomNumberTextBox3.Clear();
            randomNumberTextBox4.Clear();
        }

        private void shutDownButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Same thing: "this.Close();"
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("The lottery machine is about to launch.");
        }
    }
}
