namespace MovieTime
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
            this.movieTimeLabel = new System.Windows.Forms.Label();
            this.showGroupBox = new System.Windows.Forms.GroupBox();
            this.fridayThe13RadioButton = new System.Windows.Forms.RadioButton();
            this.susperiaRadioButton = new System.Windows.Forms.RadioButton();
            this.draculaRadioButton = new System.Windows.Forms.RadioButton();
            this.seatingGroupBox = new System.Windows.Forms.GroupBox();
            this.regularRadioButton = new System.Windows.Forms.RadioButton();
            this.amphitheaterRadioButton = new System.Windows.Forms.RadioButton();
            this.stadiumRadioButton = new System.Windows.Forms.RadioButton();
            this.refreshmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.chocolateAlmondsCheckBox = new System.Windows.Forms.CheckBox();
            this.hotDogCheckBox = new System.Windows.Forms.CheckBox();
            this.cokeCheckBox = new System.Windows.Forms.CheckBox();
            this.butterPopcornCheckBox = new System.Windows.Forms.CheckBox();
            this.plainPopcornCheckBox = new System.Windows.Forms.CheckBox();
            this.computeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.discountTextBox = new System.Windows.Forms.CheckBox();
            this.totalOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.showGroupBox.SuspendLayout();
            this.seatingGroupBox.SuspendLayout();
            this.refreshmentsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // movieTimeLabel
            // 
            this.movieTimeLabel.AutoSize = true;
            this.movieTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTimeLabel.ForeColor = System.Drawing.Color.Maroon;
            this.movieTimeLabel.Location = new System.Drawing.Point(530, 54);
            this.movieTimeLabel.Name = "movieTimeLabel";
            this.movieTimeLabel.Size = new System.Drawing.Size(147, 29);
            this.movieTimeLabel.TabIndex = 0;
            this.movieTimeLabel.Text = "MOVIETIME";
            // 
            // showGroupBox
            // 
            this.showGroupBox.Controls.Add(this.fridayThe13RadioButton);
            this.showGroupBox.Controls.Add(this.susperiaRadioButton);
            this.showGroupBox.Controls.Add(this.draculaRadioButton);
            this.showGroupBox.Location = new System.Drawing.Point(62, 136);
            this.showGroupBox.Name = "showGroupBox";
            this.showGroupBox.Size = new System.Drawing.Size(311, 234);
            this.showGroupBox.TabIndex = 1;
            this.showGroupBox.TabStop = false;
            this.showGroupBox.Text = "Select Your Show";
            // 
            // fridayThe13RadioButton
            // 
            this.fridayThe13RadioButton.AutoSize = true;
            this.fridayThe13RadioButton.Location = new System.Drawing.Point(92, 155);
            this.fridayThe13RadioButton.Name = "fridayThe13RadioButton";
            this.fridayThe13RadioButton.Size = new System.Drawing.Size(129, 21);
            this.fridayThe13RadioButton.TabIndex = 2;
            this.fridayThe13RadioButton.Text = "Friday The 13th";
            this.fridayThe13RadioButton.UseVisualStyleBackColor = true;
            // 
            // susperiaRadioButton
            // 
            this.susperiaRadioButton.AutoSize = true;
            this.susperiaRadioButton.Location = new System.Drawing.Point(92, 104);
            this.susperiaRadioButton.Name = "susperiaRadioButton";
            this.susperiaRadioButton.Size = new System.Drawing.Size(85, 21);
            this.susperiaRadioButton.TabIndex = 1;
            this.susperiaRadioButton.Text = "Susperia";
            this.susperiaRadioButton.UseVisualStyleBackColor = true;
            // 
            // draculaRadioButton
            // 
            this.draculaRadioButton.AutoSize = true;
            this.draculaRadioButton.Checked = true;
            this.draculaRadioButton.Location = new System.Drawing.Point(92, 57);
            this.draculaRadioButton.Name = "draculaRadioButton";
            this.draculaRadioButton.Size = new System.Drawing.Size(78, 21);
            this.draculaRadioButton.TabIndex = 0;
            this.draculaRadioButton.TabStop = true;
            this.draculaRadioButton.Text = "Dracula";
            this.draculaRadioButton.UseVisualStyleBackColor = true;
            // 
            // seatingGroupBox
            // 
            this.seatingGroupBox.Controls.Add(this.regularRadioButton);
            this.seatingGroupBox.Controls.Add(this.amphitheaterRadioButton);
            this.seatingGroupBox.Controls.Add(this.stadiumRadioButton);
            this.seatingGroupBox.Location = new System.Drawing.Point(452, 136);
            this.seatingGroupBox.Name = "seatingGroupBox";
            this.seatingGroupBox.Size = new System.Drawing.Size(311, 234);
            this.seatingGroupBox.TabIndex = 2;
            this.seatingGroupBox.TabStop = false;
            this.seatingGroupBox.Text = "Select Seating";
            // 
            // regularRadioButton
            // 
            this.regularRadioButton.AutoSize = true;
            this.regularRadioButton.Location = new System.Drawing.Point(97, 155);
            this.regularRadioButton.Name = "regularRadioButton";
            this.regularRadioButton.Size = new System.Drawing.Size(79, 21);
            this.regularRadioButton.TabIndex = 5;
            this.regularRadioButton.Text = "Regular";
            this.regularRadioButton.UseVisualStyleBackColor = true;
            // 
            // amphitheaterRadioButton
            // 
            this.amphitheaterRadioButton.AutoSize = true;
            this.amphitheaterRadioButton.Location = new System.Drawing.Point(97, 104);
            this.amphitheaterRadioButton.Name = "amphitheaterRadioButton";
            this.amphitheaterRadioButton.Size = new System.Drawing.Size(113, 21);
            this.amphitheaterRadioButton.TabIndex = 4;
            this.amphitheaterRadioButton.Text = "Amphitheater";
            this.amphitheaterRadioButton.UseVisualStyleBackColor = true;
            // 
            // stadiumRadioButton
            // 
            this.stadiumRadioButton.AutoSize = true;
            this.stadiumRadioButton.Checked = true;
            this.stadiumRadioButton.Location = new System.Drawing.Point(97, 57);
            this.stadiumRadioButton.Name = "stadiumRadioButton";
            this.stadiumRadioButton.Size = new System.Drawing.Size(80, 21);
            this.stadiumRadioButton.TabIndex = 3;
            this.stadiumRadioButton.TabStop = true;
            this.stadiumRadioButton.Text = "Stadium";
            this.stadiumRadioButton.UseVisualStyleBackColor = true;
            // 
            // refreshmentsGroupBox
            // 
            this.refreshmentsGroupBox.Controls.Add(this.chocolateAlmondsCheckBox);
            this.refreshmentsGroupBox.Controls.Add(this.hotDogCheckBox);
            this.refreshmentsGroupBox.Controls.Add(this.cokeCheckBox);
            this.refreshmentsGroupBox.Controls.Add(this.butterPopcornCheckBox);
            this.refreshmentsGroupBox.Controls.Add(this.plainPopcornCheckBox);
            this.refreshmentsGroupBox.Location = new System.Drawing.Point(837, 136);
            this.refreshmentsGroupBox.Name = "refreshmentsGroupBox";
            this.refreshmentsGroupBox.Size = new System.Drawing.Size(311, 234);
            this.refreshmentsGroupBox.TabIndex = 3;
            this.refreshmentsGroupBox.TabStop = false;
            this.refreshmentsGroupBox.Text = "Select Munchies";
            // 
            // chocolateAlmondsCheckBox
            // 
            this.chocolateAlmondsCheckBox.AutoSize = true;
            this.chocolateAlmondsCheckBox.Location = new System.Drawing.Point(38, 193);
            this.chocolateAlmondsCheckBox.Name = "chocolateAlmondsCheckBox";
            this.chocolateAlmondsCheckBox.Size = new System.Drawing.Size(208, 21);
            this.chocolateAlmondsCheckBox.TabIndex = 8;
            this.chocolateAlmondsCheckBox.Text = "Chocolate Covered Almonds";
            this.chocolateAlmondsCheckBox.UseVisualStyleBackColor = true;
            // 
            // hotDogCheckBox
            // 
            this.hotDogCheckBox.AutoSize = true;
            this.hotDogCheckBox.Location = new System.Drawing.Point(38, 155);
            this.hotDogCheckBox.Name = "hotDogCheckBox";
            this.hotDogCheckBox.Size = new System.Drawing.Size(112, 21);
            this.hotDogCheckBox.TabIndex = 7;
            this.hotDogCheckBox.Text = "Hot Dog XXL";
            this.hotDogCheckBox.UseVisualStyleBackColor = true;
            // 
            // cokeCheckBox
            // 
            this.cokeCheckBox.AutoSize = true;
            this.cokeCheckBox.Location = new System.Drawing.Point(38, 114);
            this.cokeCheckBox.Name = "cokeCheckBox";
            this.cokeCheckBox.Size = new System.Drawing.Size(92, 21);
            this.cokeCheckBox.TabIndex = 6;
            this.cokeCheckBox.Text = "Coke XXL";
            this.cokeCheckBox.UseVisualStyleBackColor = true;
            // 
            // butterPopcornCheckBox
            // 
            this.butterPopcornCheckBox.AutoSize = true;
            this.butterPopcornCheckBox.Location = new System.Drawing.Point(38, 74);
            this.butterPopcornCheckBox.Name = "butterPopcornCheckBox";
            this.butterPopcornCheckBox.Size = new System.Drawing.Size(125, 21);
            this.butterPopcornCheckBox.TabIndex = 5;
            this.butterPopcornCheckBox.Text = "Popcorn Butter";
            this.butterPopcornCheckBox.UseVisualStyleBackColor = true;
            // 
            // plainPopcornCheckBox
            // 
            this.plainPopcornCheckBox.AutoSize = true;
            this.plainPopcornCheckBox.Location = new System.Drawing.Point(38, 38);
            this.plainPopcornCheckBox.Name = "plainPopcornCheckBox";
            this.plainPopcornCheckBox.Size = new System.Drawing.Size(118, 21);
            this.plainPopcornCheckBox.TabIndex = 4;
            this.plainPopcornCheckBox.Text = "Popcorn Plain";
            this.plainPopcornCheckBox.UseVisualStyleBackColor = true;
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(282, 450);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(119, 56);
            this.computeButton.TabIndex = 10;
            this.computeButton.Text = "&Compute Price";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(535, 450);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(119, 56);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "C&lear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(774, 450);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 56);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // discountTextBox
            // 
            this.discountTextBox.AutoSize = true;
            this.discountTextBox.Location = new System.Drawing.Point(293, 399);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(85, 21);
            this.discountTextBox.TabIndex = 9;
            this.discountTextBox.Text = "Discount";
            this.discountTextBox.UseVisualStyleBackColor = true;
            // 
            // totalOutputDescriptionLabel
            // 
            this.totalOutputDescriptionLabel.AutoSize = true;
            this.totalOutputDescriptionLabel.Location = new System.Drawing.Point(492, 399);
            this.totalOutputDescriptionLabel.Name = "totalOutputDescriptionLabel";
            this.totalOutputDescriptionLabel.Size = new System.Drawing.Size(44, 17);
            this.totalOutputDescriptionLabel.TabIndex = 7;
            this.totalOutputDescriptionLabel.Text = "Total:";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(542, 397);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(164, 23);
            this.totalLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.computeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1212, 539);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalOutputDescriptionLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.seatingGroupBox);
            this.Controls.Add(this.refreshmentsGroupBox);
            this.Controls.Add(this.showGroupBox);
            this.Controls.Add(this.movieTimeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.showGroupBox.ResumeLayout(false);
            this.showGroupBox.PerformLayout();
            this.seatingGroupBox.ResumeLayout(false);
            this.seatingGroupBox.PerformLayout();
            this.refreshmentsGroupBox.ResumeLayout(false);
            this.refreshmentsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label movieTimeLabel;
        private System.Windows.Forms.GroupBox showGroupBox;
        private System.Windows.Forms.GroupBox seatingGroupBox;
        private System.Windows.Forms.GroupBox refreshmentsGroupBox;
        private System.Windows.Forms.RadioButton fridayThe13RadioButton;
        private System.Windows.Forms.RadioButton susperiaRadioButton;
        private System.Windows.Forms.RadioButton draculaRadioButton;
        private System.Windows.Forms.RadioButton regularRadioButton;
        private System.Windows.Forms.RadioButton amphitheaterRadioButton;
        private System.Windows.Forms.RadioButton stadiumRadioButton;
        private System.Windows.Forms.CheckBox chocolateAlmondsCheckBox;
        private System.Windows.Forms.CheckBox hotDogCheckBox;
        private System.Windows.Forms.CheckBox cokeCheckBox;
        private System.Windows.Forms.CheckBox butterPopcornCheckBox;
        private System.Windows.Forms.CheckBox plainPopcornCheckBox;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox discountTextBox;
        private System.Windows.Forms.Label totalOutputDescriptionLabel;
        private System.Windows.Forms.Label totalLabel;
    }
}

