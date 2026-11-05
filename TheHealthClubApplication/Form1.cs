using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheHealthClubApplication
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        //Open the Staff Memeber Form when the button is clicked
        private void button2_Click(object sender, EventArgs e)
        {
            StaffForm staff = new StaffForm();
            staff.Show();
        }

        private void feeCalculatorButton_Click(object sender, EventArgs e)
        {
            formCalculator calculator = new formCalculator();
            calculator.Show(); // or calculator.ShowDialog(); if you want to block the main form
        }

        //Close the Whole App
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close(); //
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
