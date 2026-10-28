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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void feeCalculatorButton_Click(object sender, EventArgs e)
        {
            formCalculator calculator = new formCalculator();
            calculator.Show(); // or calculator.ShowDialog(); if you want to block the main form
        }
    }
}
