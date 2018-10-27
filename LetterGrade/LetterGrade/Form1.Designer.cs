namespace LetterGrade
{
    partial class Form1
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
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.computeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.gradeOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(139, 121);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(100, 22);
            this.scoreTextBox.TabIndex = 0;
            // 
            // gradeLabel
            // 
            this.gradeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.gradeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradeLabel.Location = new System.Drawing.Point(297, 112);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(82, 41);
            this.gradeLabel.TabIndex = 1;
            this.gradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(73, 219);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(92, 46);
            this.computeButton.TabIndex = 2;
            this.computeButton.Text = "Compute";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(218, 219);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(92, 46);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(370, 219);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(92, 46);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(145, 85);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(85, 17);
            this.instructionsLabel.TabIndex = 5;
            this.instructionsLabel.Text = "Enter score:";
            // 
            // gradeOutputDescriptionLabel
            // 
            this.gradeOutputDescriptionLabel.AutoSize = true;
            this.gradeOutputDescriptionLabel.Location = new System.Drawing.Point(313, 85);
            this.gradeOutputDescriptionLabel.Name = "gradeOutputDescriptionLabel";
            this.gradeOutputDescriptionLabel.Size = new System.Drawing.Size(48, 17);
            this.gradeOutputDescriptionLabel.TabIndex = 6;
            this.gradeOutputDescriptionLabel.Text = "Grade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 316);
            this.Controls.Add(this.gradeOutputDescriptionLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.scoreTextBox);
            this.Name = "Form1";
            this.Text = "Letter Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label gradeOutputDescriptionLabel;
    }
}

