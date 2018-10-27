namespace Class_Example
{
    partial class MainForm
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.letterGradeTextBox = new System.Windows.Forms.TextBox();
            this.totalPointsODLabel = new System.Windows.Forms.Label();
            this.totalPointsLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.displaySecondForm = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(138, 57);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(171, 17);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Enter a letter grade (A-F):";
            // 
            // letterGradeTextBox
            // 
            this.letterGradeTextBox.Location = new System.Drawing.Point(167, 100);
            this.letterGradeTextBox.Name = "letterGradeTextBox";
            this.letterGradeTextBox.Size = new System.Drawing.Size(100, 22);
            this.letterGradeTextBox.TabIndex = 1;
            this.letterGradeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalPointsODLabel
            // 
            this.totalPointsODLabel.AutoSize = true;
            this.totalPointsODLabel.Location = new System.Drawing.Point(117, 229);
            this.totalPointsODLabel.Name = "totalPointsODLabel";
            this.totalPointsODLabel.Size = new System.Drawing.Size(87, 17);
            this.totalPointsODLabel.TabIndex = 2;
            this.totalPointsODLabel.Text = "Total Points:";
            // 
            // totalPointsLabel
            // 
            this.totalPointsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalPointsLabel.Location = new System.Drawing.Point(214, 213);
            this.totalPointsLabel.Name = "totalPointsLabel";
            this.totalPointsLabel.Size = new System.Drawing.Size(124, 48);
            this.totalPointsLabel.TabIndex = 3;
            this.totalPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Location = new System.Drawing.Point(141, 144);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(150, 37);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displaySecondForm
            // 
            this.displaySecondForm.Location = new System.Drawing.Point(97, 295);
            this.displaySecondForm.Name = "displaySecondForm";
            this.displaySecondForm.Size = new System.Drawing.Size(107, 73);
            this.displaySecondForm.TabIndex = 5;
            this.displaySecondForm.Text = "Display Grade in Second Form";
            this.displaySecondForm.UseVisualStyleBackColor = true;
            this.displaySecondForm.Click += new System.EventHandler(this.displaySecondForm_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(237, 295);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 73);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 431);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displaySecondForm);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.totalPointsLabel);
            this.Controls.Add(this.totalPointsODLabel);
            this.Controls.Add(this.letterGradeTextBox);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "MainForm";
            this.Text = "Grade Displayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox letterGradeTextBox;
        private System.Windows.Forms.Label totalPointsODLabel;
        private System.Windows.Forms.Label totalPointsLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button displaySecondForm;
        private System.Windows.Forms.Button exitButton;
    }
}

