namespace Internet_Service_Provider_1
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
            this.subscriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.packageCRadioButton = new System.Windows.Forms.RadioButton();
            this.packageBRadioButton = new System.Windows.Forms.RadioButton();
            this.packageARadioButton = new System.Windows.Forms.RadioButton();
            this.discountGroupBox = new System.Windows.Forms.GroupBox();
            this.nonProfitCheckBox = new System.Windows.Forms.CheckBox();
            this.hoursUsedPromptLabel = new System.Windows.Forms.Label();
            this.totalOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.subscriptionGroupBox.SuspendLayout();
            this.discountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // subscriptionGroupBox
            // 
            this.subscriptionGroupBox.Controls.Add(this.packageCRadioButton);
            this.subscriptionGroupBox.Controls.Add(this.packageBRadioButton);
            this.subscriptionGroupBox.Controls.Add(this.packageARadioButton);
            this.subscriptionGroupBox.Controls.Add(this.discountGroupBox);
            this.subscriptionGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subscriptionGroupBox.Location = new System.Drawing.Point(33, 44);
            this.subscriptionGroupBox.Name = "subscriptionGroupBox";
            this.subscriptionGroupBox.Size = new System.Drawing.Size(470, 166);
            this.subscriptionGroupBox.TabIndex = 0;
            this.subscriptionGroupBox.TabStop = false;
            this.subscriptionGroupBox.Text = "Select a Subscription Package";
            // 
            // packageCRadioButton
            // 
            this.packageCRadioButton.AutoSize = true;
            this.packageCRadioButton.Location = new System.Drawing.Point(41, 106);
            this.packageCRadioButton.Name = "packageCRadioButton";
            this.packageCRadioButton.Size = new System.Drawing.Size(97, 21);
            this.packageCRadioButton.TabIndex = 3;
            this.packageCRadioButton.TabStop = true;
            this.packageCRadioButton.Text = "Package C";
            this.packageCRadioButton.UseVisualStyleBackColor = true;
            // 
            // packageBRadioButton
            // 
            this.packageBRadioButton.AutoSize = true;
            this.packageBRadioButton.Location = new System.Drawing.Point(41, 70);
            this.packageBRadioButton.Name = "packageBRadioButton";
            this.packageBRadioButton.Size = new System.Drawing.Size(97, 21);
            this.packageBRadioButton.TabIndex = 2;
            this.packageBRadioButton.TabStop = true;
            this.packageBRadioButton.Text = "Package B";
            this.packageBRadioButton.UseVisualStyleBackColor = true;
            // 
            // packageARadioButton
            // 
            this.packageARadioButton.AutoSize = true;
            this.packageARadioButton.Checked = true;
            this.packageARadioButton.Location = new System.Drawing.Point(41, 34);
            this.packageARadioButton.Name = "packageARadioButton";
            this.packageARadioButton.Size = new System.Drawing.Size(97, 21);
            this.packageARadioButton.TabIndex = 1;
            this.packageARadioButton.TabStop = true;
            this.packageARadioButton.Text = "Package A";
            this.packageARadioButton.UseVisualStyleBackColor = true;
            // 
            // discountGroupBox
            // 
            this.discountGroupBox.Controls.Add(this.nonProfitCheckBox);
            this.discountGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discountGroupBox.Location = new System.Drawing.Point(234, 93);
            this.discountGroupBox.Name = "discountGroupBox";
            this.discountGroupBox.Size = new System.Drawing.Size(236, 73);
            this.discountGroupBox.TabIndex = 4;
            this.discountGroupBox.TabStop = false;
            this.discountGroupBox.Text = "Select a Discount";
            // 
            // nonProfitCheckBox
            // 
            this.nonProfitCheckBox.AutoSize = true;
            this.nonProfitCheckBox.Location = new System.Drawing.Point(16, 31);
            this.nonProfitCheckBox.Name = "nonProfitCheckBox";
            this.nonProfitCheckBox.Size = new System.Drawing.Size(173, 21);
            this.nonProfitCheckBox.TabIndex = 5;
            this.nonProfitCheckBox.Text = "Nonprofit Organization";
            this.nonProfitCheckBox.UseVisualStyleBackColor = true;
            // 
            // hoursUsedPromptLabel
            // 
            this.hoursUsedPromptLabel.AutoSize = true;
            this.hoursUsedPromptLabel.Location = new System.Drawing.Point(102, 237);
            this.hoursUsedPromptLabel.Name = "hoursUsedPromptLabel";
            this.hoursUsedPromptLabel.Size = new System.Drawing.Size(219, 17);
            this.hoursUsedPromptLabel.TabIndex = 1;
            this.hoursUsedPromptLabel.Text = "Enter the Number of Hours Used:";
            // 
            // totalOutputDescriptionLabel
            // 
            this.totalOutputDescriptionLabel.AutoSize = true;
            this.totalOutputDescriptionLabel.Location = new System.Drawing.Point(195, 287);
            this.totalOutputDescriptionLabel.Name = "totalOutputDescriptionLabel";
            this.totalOutputDescriptionLabel.Size = new System.Drawing.Size(126, 17);
            this.totalOutputDescriptionLabel.TabIndex = 2;
            this.totalOutputDescriptionLabel.Text = "Total Amount Due:";
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(327, 232);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(176, 22);
            this.hoursTextBox.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(63, 356);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(110, 47);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Location = new System.Drawing.Point(327, 281);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(176, 23);
            this.totalLabel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(358, 356);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(110, 47);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(211, 356);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(110, 47);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(537, 434);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.totalOutputDescriptionLabel);
            this.Controls.Add(this.hoursUsedPromptLabel);
            this.Controls.Add(this.subscriptionGroupBox);
            this.Name = "Form1";
            this.Text = "Internet Service Provider, Part 1";
            this.subscriptionGroupBox.ResumeLayout(false);
            this.subscriptionGroupBox.PerformLayout();
            this.discountGroupBox.ResumeLayout(false);
            this.discountGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox subscriptionGroupBox;
        private System.Windows.Forms.RadioButton packageCRadioButton;
        private System.Windows.Forms.RadioButton packageBRadioButton;
        private System.Windows.Forms.RadioButton packageARadioButton;
        private System.Windows.Forms.GroupBox discountGroupBox;
        private System.Windows.Forms.CheckBox nonProfitCheckBox;
        private System.Windows.Forms.Label hoursUsedPromptLabel;
        private System.Windows.Forms.Label totalOutputDescriptionLabel;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

