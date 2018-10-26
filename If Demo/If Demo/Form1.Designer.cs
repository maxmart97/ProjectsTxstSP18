namespace If_Demo
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
            this.gpaPromptLabel = new System.Windows.Forms.Label();
            this.gpaTextBox = new System.Windows.Forms.TextBox();
            this.honorRollLabel = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.scorePromptLabel = new System.Windows.Forms.Label();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.gradeOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpaPromptLabel
            // 
            this.gpaPromptLabel.AutoSize = true;
            this.gpaPromptLabel.Location = new System.Drawing.Point(137, 33);
            this.gpaPromptLabel.Name = "gpaPromptLabel";
            this.gpaPromptLabel.Size = new System.Drawing.Size(37, 17);
            this.gpaPromptLabel.TabIndex = 0;
            this.gpaPromptLabel.Text = "GPA";
            // 
            // gpaTextBox
            // 
            this.gpaTextBox.Location = new System.Drawing.Point(104, 72);
            this.gpaTextBox.Name = "gpaTextBox";
            this.gpaTextBox.Size = new System.Drawing.Size(100, 22);
            this.gpaTextBox.TabIndex = 1;
            // 
            // honorRollLabel
            // 
            this.honorRollLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.honorRollLabel.Location = new System.Drawing.Point(132, 130);
            this.honorRollLabel.Name = "honorRollLabel";
            this.honorRollLabel.Size = new System.Drawing.Size(182, 23);
            this.honorRollLabel.TabIndex = 6;
            this.honorRollLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(61, 238);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(100, 32);
            this.processButton.TabIndex = 3;
            this.processButton.Text = "&Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(199, 238);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 32);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(332, 238);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 32);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // scorePromptLabel
            // 
            this.scorePromptLabel.AutoSize = true;
            this.scorePromptLabel.Location = new System.Drawing.Point(269, 33);
            this.scorePromptLabel.Name = "scorePromptLabel";
            this.scorePromptLabel.Size = new System.Drawing.Size(45, 17);
            this.scorePromptLabel.TabIndex = 7;
            this.scorePromptLabel.Text = "Score";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(241, 72);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(100, 22);
            this.scoreTextBox.TabIndex = 2;
            // 
            // gradeLabel
            // 
            this.gradeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradeLabel.Location = new System.Drawing.Point(421, 124);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(45, 29);
            this.gradeLabel.TabIndex = 9;
            this.gradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradeOutputDescriptionLabel
            // 
            this.gradeOutputDescriptionLabel.AutoSize = true;
            this.gradeOutputDescriptionLabel.Location = new System.Drawing.Point(367, 130);
            this.gradeOutputDescriptionLabel.Name = "gradeOutputDescriptionLabel";
            this.gradeOutputDescriptionLabel.Size = new System.Drawing.Size(48, 17);
            this.gradeOutputDescriptionLabel.TabIndex = 10;
            this.gradeOutputDescriptionLabel.Text = "Grade";
            // 
            // Form1
            // 
            this.AcceptButton = this.processButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(516, 339);
            this.Controls.Add(this.gradeOutputDescriptionLabel);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.scorePromptLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.honorRollLabel);
            this.Controls.Add(this.gpaTextBox);
            this.Controls.Add(this.gpaPromptLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "If Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpaPromptLabel;
        private System.Windows.Forms.TextBox gpaTextBox;
        private System.Windows.Forms.Label honorRollLabel;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label scorePromptLabel;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label gradeOutputDescriptionLabel;
    }
}

