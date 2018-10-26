namespace Driver_s_License_Exam
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
            this.chooseExamAnswersButton = new System.Windows.Forms.Button();
            this.examAnswersFileLabel = new System.Windows.Forms.Label();
            this.gradeButton = new System.Windows.Forms.Button();
            this.statusDescriptionLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.numberCorrectLabel = new System.Windows.Forms.Label();
            this.totalCorrectDescriptionLabel = new System.Windows.Forms.Label();
            this.numberIncorrectLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.incorrectListBox = new System.Windows.Forms.ListBox();
            this.incorrectGroupBox = new System.Windows.Forms.GroupBox();
            this.openFileDialogExamAnswers = new System.Windows.Forms.OpenFileDialog();
            this.studentAnswersFileLabel = new System.Windows.Forms.Label();
            this.chooseStudentAnswersButton = new System.Windows.Forms.Button();
            this.openFileDialogStudentAnswers = new System.Windows.Forms.OpenFileDialog();
            this.clearButton = new System.Windows.Forms.Button();
            this.incorrectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseExamAnswersButton
            // 
            this.chooseExamAnswersButton.Location = new System.Drawing.Point(34, 56);
            this.chooseExamAnswersButton.Name = "chooseExamAnswersButton";
            this.chooseExamAnswersButton.Size = new System.Drawing.Size(132, 49);
            this.chooseExamAnswersButton.TabIndex = 0;
            this.chooseExamAnswersButton.Text = "Choose &exam answers.";
            this.chooseExamAnswersButton.UseVisualStyleBackColor = true;
            this.chooseExamAnswersButton.Click += new System.EventHandler(this.chooseExamAnswersButton_Click);
            // 
            // examAnswersFileLabel
            // 
            this.examAnswersFileLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.examAnswersFileLabel.Location = new System.Drawing.Point(172, 31);
            this.examAnswersFileLabel.Name = "examAnswersFileLabel";
            this.examAnswersFileLabel.Size = new System.Drawing.Size(342, 102);
            this.examAnswersFileLabel.TabIndex = 1;
            // 
            // gradeButton
            // 
            this.gradeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.gradeButton.Location = new System.Drawing.Point(114, 327);
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.Size = new System.Drawing.Size(112, 42);
            this.gradeButton.TabIndex = 2;
            this.gradeButton.Text = "&Grade exam";
            this.gradeButton.UseVisualStyleBackColor = true;
            this.gradeButton.Click += new System.EventHandler(this.gradeButton_Click);
            // 
            // statusDescriptionLabel
            // 
            this.statusDescriptionLabel.AutoSize = true;
            this.statusDescriptionLabel.Location = new System.Drawing.Point(78, 531);
            this.statusDescriptionLabel.Name = "statusDescriptionLabel";
            this.statusDescriptionLabel.Size = new System.Drawing.Size(52, 17);
            this.statusDescriptionLabel.TabIndex = 3;
            this.statusDescriptionLabel.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Location = new System.Drawing.Point(81, 548);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(145, 23);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberCorrectLabel
            // 
            this.numberCorrectLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberCorrectLabel.Location = new System.Drawing.Point(81, 421);
            this.numberCorrectLabel.Name = "numberCorrectLabel";
            this.numberCorrectLabel.Size = new System.Drawing.Size(145, 23);
            this.numberCorrectLabel.TabIndex = 6;
            this.numberCorrectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCorrectDescriptionLabel
            // 
            this.totalCorrectDescriptionLabel.AutoSize = true;
            this.totalCorrectDescriptionLabel.Location = new System.Drawing.Point(78, 404);
            this.totalCorrectDescriptionLabel.Name = "totalCorrectDescriptionLabel";
            this.totalCorrectDescriptionLabel.Size = new System.Drawing.Size(94, 17);
            this.totalCorrectDescriptionLabel.TabIndex = 5;
            this.totalCorrectDescriptionLabel.Text = "Total Correct:";
            // 
            // numberIncorrectLabel
            // 
            this.numberIncorrectLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberIncorrectLabel.Location = new System.Drawing.Point(81, 485);
            this.numberIncorrectLabel.Name = "numberIncorrectLabel";
            this.numberIncorrectLabel.Size = new System.Drawing.Size(145, 23);
            this.numberIncorrectLabel.TabIndex = 8;
            this.numberIncorrectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Incorrect:";
            // 
            // incorrectListBox
            // 
            this.incorrectListBox.FormattingEnabled = true;
            this.incorrectListBox.ItemHeight = 16;
            this.incorrectListBox.Location = new System.Drawing.Point(6, 18);
            this.incorrectListBox.Name = "incorrectListBox";
            this.incorrectListBox.Size = new System.Drawing.Size(137, 132);
            this.incorrectListBox.TabIndex = 9;
            this.incorrectListBox.TabStop = false;
            // 
            // incorrectGroupBox
            // 
            this.incorrectGroupBox.Controls.Add(this.incorrectListBox);
            this.incorrectGroupBox.Location = new System.Drawing.Point(299, 403);
            this.incorrectGroupBox.Name = "incorrectGroupBox";
            this.incorrectGroupBox.Size = new System.Drawing.Size(149, 168);
            this.incorrectGroupBox.TabIndex = 10;
            this.incorrectGroupBox.TabStop = false;
            this.incorrectGroupBox.Text = "Incorrect Questions";
            // 
            // openFileDialogExamAnswers
            // 
            this.openFileDialogExamAnswers.Title = "Pick file containing exam answers.";
            // 
            // studentAnswersFileLabel
            // 
            this.studentAnswersFileLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentAnswersFileLabel.Location = new System.Drawing.Point(172, 188);
            this.studentAnswersFileLabel.Name = "studentAnswersFileLabel";
            this.studentAnswersFileLabel.Size = new System.Drawing.Size(342, 102);
            this.studentAnswersFileLabel.TabIndex = 12;
            // 
            // chooseStudentAnswersButton
            // 
            this.chooseStudentAnswersButton.Location = new System.Drawing.Point(34, 212);
            this.chooseStudentAnswersButton.Name = "chooseStudentAnswersButton";
            this.chooseStudentAnswersButton.Size = new System.Drawing.Size(132, 49);
            this.chooseStudentAnswersButton.TabIndex = 1;
            this.chooseStudentAnswersButton.Text = "Choose &student answers.";
            this.chooseStudentAnswersButton.UseVisualStyleBackColor = true;
            this.chooseStudentAnswersButton.Click += new System.EventHandler(this.chooseStudentAnswersButton_Click);
            // 
            // openFileDialogStudentAnswers
            // 
            this.openFileDialogStudentAnswers.Title = "Pick file containing student\'s answers.";
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Location = new System.Drawing.Point(299, 327);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 42);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.gradeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(548, 601);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.studentAnswersFileLabel);
            this.Controls.Add(this.chooseStudentAnswersButton);
            this.Controls.Add(this.incorrectGroupBox);
            this.Controls.Add(this.numberIncorrectLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberCorrectLabel);
            this.Controls.Add(this.totalCorrectDescriptionLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusDescriptionLabel);
            this.Controls.Add(this.gradeButton);
            this.Controls.Add(this.examAnswersFileLabel);
            this.Controls.Add(this.chooseExamAnswersButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver\'s License Exam";
            this.incorrectGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseExamAnswersButton;
        private System.Windows.Forms.Label examAnswersFileLabel;
        private System.Windows.Forms.Button gradeButton;
        private System.Windows.Forms.Label statusDescriptionLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label numberCorrectLabel;
        private System.Windows.Forms.Label totalCorrectDescriptionLabel;
        private System.Windows.Forms.Label numberIncorrectLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox incorrectListBox;
        private System.Windows.Forms.GroupBox incorrectGroupBox;
        private System.Windows.Forms.OpenFileDialog openFileDialogExamAnswers;
        private System.Windows.Forms.Label studentAnswersFileLabel;
        private System.Windows.Forms.Button chooseStudentAnswersButton;
        private System.Windows.Forms.OpenFileDialog openFileDialogStudentAnswers;
        private System.Windows.Forms.Button clearButton;
    }
}

