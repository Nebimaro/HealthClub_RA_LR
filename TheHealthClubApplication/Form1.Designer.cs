namespace TheHealthClubApplication
{
    partial class mainForm
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
            this.feeCalculatorButton = new System.Windows.Forms.Button();
            this.staffButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // feeCalculatorButton
            // 
            this.feeCalculatorButton.Location = new System.Drawing.Point(105, 285);
            this.feeCalculatorButton.Name = "feeCalculatorButton";
            this.feeCalculatorButton.Size = new System.Drawing.Size(221, 89);
            this.feeCalculatorButton.TabIndex = 0;
            this.feeCalculatorButton.Text = "Fee Calculator";
            this.feeCalculatorButton.UseVisualStyleBackColor = true;
            this.feeCalculatorButton.Click += new System.EventHandler(this.feeCalculatorButton_Click);
            // 
            // staffButton
            // 
            this.staffButton.Location = new System.Drawing.Point(459, 280);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(242, 94);
            this.staffButton.TabIndex = 1;
            this.staffButton.Text = "Staff";
            this.staffButton.UseVisualStyleBackColor = true;
            this.staffButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 99);
            this.label1.TabIndex = 2;
            this.label1.Text = "Health Club Staff Form";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.staffButton);
            this.Controls.Add(this.feeCalculatorButton);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Health Club - Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button feeCalculatorButton;
        private System.Windows.Forms.Button staffButton;
        private System.Windows.Forms.Label label1;
    }
}

