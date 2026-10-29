namespace TheHealthClubApplication
{
    partial class formCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthsTextBox = new System.Windows.Forms.TextBox();
            this.standardRadioButton = new System.Windows.Forms.RadioButton();
            this.yogaCheckBox = new System.Windows.Forms.CheckBox();
            this.MembershipTypeGoupBox = new System.Windows.Forms.GroupBox();
            this.seniorRadioButton = new System.Windows.Forms.RadioButton();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.childRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.personalTrainerCheckBox = new System.Windows.Forms.CheckBox();
            this.karateCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalFeeLabel = new System.Windows.Forms.Label();
            this.monthlyFeeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MembershipTypeGoupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthsTextBox
            // 
            this.monthsTextBox.Location = new System.Drawing.Point(84, 129);
            this.monthsTextBox.Name = "monthsTextBox";
            this.monthsTextBox.Size = new System.Drawing.Size(217, 31);
            this.monthsTextBox.TabIndex = 0;
            // 
            // standardRadioButton
            // 
            this.standardRadioButton.AutoSize = true;
            this.standardRadioButton.Location = new System.Drawing.Point(26, 56);
            this.standardRadioButton.Name = "standardRadioButton";
            this.standardRadioButton.Size = new System.Drawing.Size(185, 29);
            this.standardRadioButton.TabIndex = 0;
            this.standardRadioButton.TabStop = true;
            this.standardRadioButton.Text = "Standard &Adult";
            this.standardRadioButton.UseVisualStyleBackColor = true;
            this.standardRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // yogaCheckBox
            // 
            this.yogaCheckBox.AutoSize = true;
            this.yogaCheckBox.Location = new System.Drawing.Point(26, 56);
            this.yogaCheckBox.Name = "yogaCheckBox";
            this.yogaCheckBox.Size = new System.Drawing.Size(95, 29);
            this.yogaCheckBox.TabIndex = 0;
            this.yogaCheckBox.Text = "&Yoga";
            this.yogaCheckBox.UseVisualStyleBackColor = true;
            this.yogaCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MembershipTypeGoupBox
            // 
            this.MembershipTypeGoupBox.Controls.Add(this.seniorRadioButton);
            this.MembershipTypeGoupBox.Controls.Add(this.studentRadioButton);
            this.MembershipTypeGoupBox.Controls.Add(this.childRadioButton);
            this.MembershipTypeGoupBox.Controls.Add(this.standardRadioButton);
            this.MembershipTypeGoupBox.Location = new System.Drawing.Point(73, 164);
            this.MembershipTypeGoupBox.Name = "MembershipTypeGoupBox";
            this.MembershipTypeGoupBox.Size = new System.Drawing.Size(308, 260);
            this.MembershipTypeGoupBox.TabIndex = 2;
            this.MembershipTypeGoupBox.TabStop = false;
            this.MembershipTypeGoupBox.Text = "Type of Membership";
            this.MembershipTypeGoupBox.Enter += new System.EventHandler(this.MembershipTypeGoupBox_Enter);
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.Location = new System.Drawing.Point(26, 161);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(105, 29);
            this.seniorRadioButton.TabIndex = 3;
            this.seniorRadioButton.TabStop = true;
            this.seniorRadioButton.Text = "S&enior";
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            this.seniorRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Location = new System.Drawing.Point(26, 126);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(117, 29);
            this.studentRadioButton.TabIndex = 2;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "&Student";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            this.studentRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // childRadioButton
            // 
            this.childRadioButton.AutoSize = true;
            this.childRadioButton.Location = new System.Drawing.Point(26, 91);
            this.childRadioButton.Name = "childRadioButton";
            this.childRadioButton.Size = new System.Drawing.Size(217, 29);
            this.childRadioButton.TabIndex = 1;
            this.childRadioButton.TabStop = true;
            this.childRadioButton.Text = "Chil&d (12 && under)";
            this.childRadioButton.UseVisualStyleBackColor = true;
            this.childRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Number of Months:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(125, 719);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(143, 67);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.personalTrainerCheckBox);
            this.groupBox1.Controls.Add(this.karateCheckBox);
            this.groupBox1.Controls.Add(this.yogaCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(482, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 260);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra options";
            // 
            // personalTrainerCheckBox
            // 
            this.personalTrainerCheckBox.AutoSize = true;
            this.personalTrainerCheckBox.Location = new System.Drawing.Point(26, 162);
            this.personalTrainerCheckBox.Name = "personalTrainerCheckBox";
            this.personalTrainerCheckBox.Size = new System.Drawing.Size(203, 29);
            this.personalTrainerCheckBox.TabIndex = 2;
            this.personalTrainerCheckBox.Text = "&Personal Trainer";
            this.personalTrainerCheckBox.UseVisualStyleBackColor = true;
            // 
            // karateCheckBox
            // 
            this.karateCheckBox.AutoSize = true;
            this.karateCheckBox.Location = new System.Drawing.Point(26, 107);
            this.karateCheckBox.Name = "karateCheckBox";
            this.karateCheckBox.Size = new System.Drawing.Size(107, 29);
            this.karateCheckBox.TabIndex = 1;
            this.karateCheckBox.Text = "&Karate";
            this.karateCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.monthsTextBox);
            this.groupBox2.Location = new System.Drawing.Point(41, 430);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 213);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Membership Lenght";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.totalFeeLabel);
            this.groupBox3.Controls.Add(this.monthlyFeeLabel);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(452, 430);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 228);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Membership Fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // totalFeeLabel
            // 
            this.totalFeeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalFeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalFeeLabel.Location = new System.Drawing.Point(169, 113);
            this.totalFeeLabel.Name = "totalFeeLabel";
            this.totalFeeLabel.Size = new System.Drawing.Size(137, 25);
            this.totalFeeLabel.TabIndex = 1;
            // 
            // monthlyFeeLabel
            // 
            this.monthlyFeeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.monthlyFeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthlyFeeLabel.Location = new System.Drawing.Point(169, 64);
            this.monthlyFeeLabel.Name = "monthlyFeeLabel";
            this.monthlyFeeLabel.Size = new System.Drawing.Size(137, 25);
            this.monthlyFeeLabel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monthly Fee:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(374, 719);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(161, 67);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(620, 719);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(149, 67);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 828);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(930, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "READY";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(207, 32);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(217, 31);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(207, 83);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(217, 31);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Last Name:";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 28);
            // 
            // formCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 850);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.MembershipTypeGoupBox);
            this.Name = "formCalculator";
            this.Text = "formCalculator";
            this.MembershipTypeGoupBox.ResumeLayout(false);
            this.MembershipTypeGoupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox monthsTextBox;
        private System.Windows.Forms.RadioButton standardRadioButton;
        private System.Windows.Forms.CheckBox yogaCheckBox;
        private System.Windows.Forms.GroupBox MembershipTypeGoupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.RadioButton seniorRadioButton;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.RadioButton childRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox karateCheckBox;
        private System.Windows.Forms.CheckBox personalTrainerCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label monthlyFeeLabel;
        private System.Windows.Forms.Label totalFeeLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}