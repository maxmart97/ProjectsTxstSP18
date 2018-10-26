namespace Student_Records
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.advisorLabel = new System.Windows.Forms.Label();
            this.studentInformationListBox = new System.Windows.Forms.ListBox();
            this.processButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.recordsNumberOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.numberOfRecordsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(347, 48);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(169, 23);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Student Status Roll";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(112, 96);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(71, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Full Name";
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(297, 96);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(37, 17);
            this.gpaLabel.TabIndex = 2;
            this.gpaLabel.Text = "GPA";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(508, 96);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(48, 17);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Status";
            // 
            // advisorLabel
            // 
            this.advisorLabel.AutoSize = true;
            this.advisorLabel.Location = new System.Drawing.Point(708, 96);
            this.advisorLabel.Name = "advisorLabel";
            this.advisorLabel.Size = new System.Drawing.Size(55, 17);
            this.advisorLabel.TabIndex = 4;
            this.advisorLabel.Text = "Advisor";
            // 
            // studentInformationListBox
            // 
            this.studentInformationListBox.FormattingEnabled = true;
            this.studentInformationListBox.ItemHeight = 16;
            this.studentInformationListBox.Location = new System.Drawing.Point(45, 130);
            this.studentInformationListBox.Name = "studentInformationListBox";
            this.studentInformationListBox.Size = new System.Drawing.Size(799, 244);
            this.studentInformationListBox.TabIndex = 5;
            this.studentInformationListBox.TabStop = false;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(160, 497);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(89, 49);
            this.processButton.TabIndex = 0;
            this.processButton.Text = "&Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(394, 497);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(89, 49);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(643, 497);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 49);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Choose a file.";
            // 
            // recordsNumberOutputDescriptionLabel
            // 
            this.recordsNumberOutputDescriptionLabel.AutoSize = true;
            this.recordsNumberOutputDescriptionLabel.Location = new System.Drawing.Point(232, 429);
            this.recordsNumberOutputDescriptionLabel.Name = "recordsNumberOutputDescriptionLabel";
            this.recordsNumberOutputDescriptionLabel.Size = new System.Drawing.Size(251, 17);
            this.recordsNumberOutputDescriptionLabel.TabIndex = 9;
            this.recordsNumberOutputDescriptionLabel.Text = "Number of student records processed:";
            // 
            // numberOfRecordsLabel
            // 
            this.numberOfRecordsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numberOfRecordsLabel.Location = new System.Drawing.Point(489, 418);
            this.numberOfRecordsLabel.Name = "numberOfRecordsLabel";
            this.numberOfRecordsLabel.Size = new System.Drawing.Size(78, 34);
            this.numberOfRecordsLabel.TabIndex = 10;
            this.numberOfRecordsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.processButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(884, 574);
            this.Controls.Add(this.numberOfRecordsLabel);
            this.Controls.Add(this.recordsNumberOutputDescriptionLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.studentInformationListBox);
            this.Controls.Add(this.advisorLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.gpaLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "Form1";
            this.Text = "University Status Roll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label advisorLabel;
        private System.Windows.Forms.ListBox studentInformationListBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label recordsNumberOutputDescriptionLabel;
        private System.Windows.Forms.Label numberOfRecordsLabel;
    }
}

