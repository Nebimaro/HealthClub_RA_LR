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
    public partial class formCalculator : Form
    {
        public formCalculator()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MembershipTypeGoupBox_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 1. VALIDATE FIRST NAME
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                MessageBox.Show("Please enter the client's First Name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstNameTextBox.Focus();
                return;
            }

            // 2. VALIDATE LAST NAME
            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBox.Show("Please enter the client's Last Name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lastNameTextBox.Focus();
                return;
            }

            // 3. VALIDATE MEMBERSHIP TYPE
            if (!standardRadioButton.Checked && !childRadioButton.Checked && !studentRadioButton.Checked && !seniorRadioButton.Checked)
            {
                MessageBox.Show("Please select a Membership Type.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. VALIDATE MONTHS (Using TryParse from Chapter 4)
            int months;
            if (!int.TryParse(monthsTextBox.Text, out months))
            {
                MessageBox.Show("Invalid input. Please enter a numeric value for the number of months.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                monthsTextBox.Focus();
                return;
            }

            // Business Rule: Minimum 1 month, Maximum 24 months
            if (months < 1 || months > 24)
            {
                MessageBox.Show("The number of months must be between 1 and 24.", "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                monthsTextBox.Focus();
                return;
            }

            // 5. CALCULATIONS
            // Using decimal for financial accuracy (Chapter 3)
            decimal monthlyFee = 0;

            if (standardRadioButton.Checked) monthlyFee += 40;
            else if (childRadioButton.Checked) monthlyFee += 20;
            else if (studentRadioButton.Checked) monthlyFee += 25;
            else if (seniorRadioButton.Checked) monthlyFee += 30;

            if (karateCheckBox.Checked) monthlyFee += 10;
            if (yogaCheckBox.Checked) monthlyFee += 30;
            if (personalTrainerCheckBox.Checked) monthlyFee += 50;

            decimal totalFee = monthlyFee * months;

            // 6. DISPLAY RESULTS (Formatting as Currency)
            monthlyFeeLabel.Text = monthlyFee.ToString("C");
            totalFeeLabel.Text = totalFee.ToString("C");
        }
    }
    }

