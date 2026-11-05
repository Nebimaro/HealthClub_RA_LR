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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCalculator));
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
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MembershipTypeGoupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthsTextBox
            // 
            this.monthsTextBox.Location = new System.Drawing.Point(60, 119);
            this.monthsTextBox.Name = "monthsTextBox";
            this.monthsTextBox.Size = new System.Drawing.Size(217, 35);
            this.monthsTextBox.TabIndex = 0;
            // 
            // standardRadioButton
            // 
            this.standardRadioButton.AutoSize = true;
            this.standardRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardRadioButton.Location = new System.Drawing.Point(26, 40);
            this.standardRadioButton.Name = "standardRadioButton";
            this.standardRadioButton.Size = new System.Drawing.Size(201, 33);
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
            this.yogaCheckBox.Size = new System.Drawing.Size(102, 33);
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
            this.MembershipTypeGoupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MembershipTypeGoupBox.Location = new System.Drawing.Point(65, 164);
            this.MembershipTypeGoupBox.Name = "MembershipTypeGoupBox";
            this.MembershipTypeGoupBox.Size = new System.Drawing.Size(343, 260);
            this.MembershipTypeGoupBox.TabIndex = 2;
            this.MembershipTypeGoupBox.TabStop = false;
            this.MembershipTypeGoupBox.Text = "Type of Membership";
            this.MembershipTypeGoupBox.Enter += new System.EventHandler(this.MembershipTypeGoupBox_Enter);
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seniorRadioButton.Location = new System.Drawing.Point(26, 201);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(115, 33);
            this.seniorRadioButton.TabIndex = 3;
            this.seniorRadioButton.TabStop = true;
            this.seniorRadioButton.Text = "S&enior";
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            this.seniorRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRadioButton.Location = new System.Drawing.Point(25, 146);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(126, 33);
            this.studentRadioButton.TabIndex = 2;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "&Student";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            this.studentRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // childRadioButton
            // 
            this.childRadioButton.AutoSize = true;
            this.childRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childRadioButton.Location = new System.Drawing.Point(25, 96);
            this.childRadioButton.Name = "childRadioButton";
            this.childRadioButton.Size = new System.Drawing.Size(238, 33);
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
            this.label1.Size = new System.Drawing.Size(323, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Number of Months:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(63, 719);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(220, 80);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(476, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 207);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra options";
            // 
            // personalTrainerCheckBox
            // 
            this.personalTrainerCheckBox.AutoSize = true;
            this.personalTrainerCheckBox.Location = new System.Drawing.Point(26, 162);
            this.personalTrainerCheckBox.Name = "personalTrainerCheckBox";
            this.personalTrainerCheckBox.Size = new System.Drawing.Size(225, 33);
            this.personalTrainerCheckBox.TabIndex = 2;
            this.personalTrainerCheckBox.Text = "&Personal Trainer";
            this.personalTrainerCheckBox.UseVisualStyleBackColor = true;
            // 
            // karateCheckBox
            // 
            this.karateCheckBox.AutoSize = true;
            this.karateCheckBox.Location = new System.Drawing.Point(26, 107);
            this.karateCheckBox.Name = "karateCheckBox";
            this.karateCheckBox.Size = new System.Drawing.Size(115, 33);
            this.karateCheckBox.TabIndex = 1;
            this.karateCheckBox.Text = "&Karate";
            this.karateCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.monthsTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(65, 456);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 213);
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
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(476, 456);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 228);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Membership Fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
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
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monthly Fee:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(336, 719);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(220, 80);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(603, 719);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(220, 80);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 798);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(854, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "READY";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 12);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(222, 29);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(217, 31);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(222, 79);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(217, 31);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Last Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(551, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // formCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 820);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}