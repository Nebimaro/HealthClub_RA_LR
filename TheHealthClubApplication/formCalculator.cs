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
            // Set the status strip to a neutral state when they click calculate
            statusLabel.ForeColor = Color.Black;
            statusLabel.Text = "Calculating...";

            // 1. VALIDATE FIRST NAME
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Error: Please enter the client's First Name.";
                firstNameTextBox.Focus();
                return;
            } 
            // Prevent numbers in the First Name
     else if (int.TryParse(firstNameTextBox.Text, out _))
                {
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "Error: First Name cannot be a number.";
                    firstNameTextBox.Focus();
                    return;
                }
                // 2. VALIDATE LAST NAME
                if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Error: Please enter the client's Last Name.";
                lastNameTextBox.Focus();
                return;
            }
            // Prevent numbers in the Last Name
     else if (int.TryParse(lastNameTextBox.Text, out _))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Error: Last Name cannot be a number.";
                lastNameTextBox.Focus();
                return;
            }

            // 3. VALIDATE MEMBERSHIP TYPE
            if (!standardRadioButton.Checked && !childRadioButton.Checked && !studentRadioButton.Checked && !seniorRadioButton.Checked)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Error: Please select a Membership Type.";
                return;
            }

            // 4. VALIDATE MONTHS (Using TryParse from Chapter 4)
            int months;
            if (!int.TryParse(monthsTextBox.Text, out months))
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Error: Please enter a numeric value for the number of months.";
                monthsTextBox.Focus();
                return;
            }

            // Business Rule: Minimum 1 month, Maximum 24 months
            if (months < 1 || months > 24)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Error: The number of months must be between 1 and 24.";
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

            // 7. SUCCESS MESSAGE
            statusLabel.ForeColor = Color.Green;
            statusLabel.Text = "Calculation successful.";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear textboxes
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            monthsTextBox.Clear();

            // Clear labels
            monthlyFeeLabel.Text = "";
            totalFeeLabel.Text = "";

            // Uncheck RadioButtons
            standardRadioButton.Checked = false;
            childRadioButton.Checked = false;
            studentRadioButton.Checked = false;
            seniorRadioButton.Checked = false;

            // Uncheck CheckBoxes
            yogaCheckBox.Checked = false;
            karateCheckBox.Checked = false;
            personalTrainerCheckBox.Checked = false;

            // Move cursor to first textbox
            firstNameTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

