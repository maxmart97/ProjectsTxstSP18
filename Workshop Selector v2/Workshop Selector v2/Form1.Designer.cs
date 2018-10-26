namespace Workshop_Selector_v2
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
            this.workshopGroupBox = new System.Windows.Forms.GroupBox();
            this.workshopListBox = new System.Windows.Forms.ListBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.locationGroupBox = new System.Windows.Forms.GroupBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.pricingGroupBox = new System.Windows.Forms.GroupBox();
            this.pricingListBox = new System.Windows.Forms.ListBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.workshopGroupBox.SuspendLayout();
            this.locationGroupBox.SuspendLayout();
            this.pricingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // workshopGroupBox
            // 
            this.workshopGroupBox.Controls.Add(this.workshopListBox);
            this.workshopGroupBox.Location = new System.Drawing.Point(80, 120);
            this.workshopGroupBox.Name = "workshopGroupBox";
            this.workshopGroupBox.Size = new System.Drawing.Size(267, 230);
            this.workshopGroupBox.TabIndex = 0;
            this.workshopGroupBox.TabStop = false;
            this.workshopGroupBox.Text = "Workshop";
            // 
            // workshopListBox
            // 
            this.workshopListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshopListBox.FormattingEnabled = true;
            this.workshopListBox.ItemHeight = 22;
            this.workshopListBox.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.workshopListBox.Location = new System.Drawing.Point(31, 33);
            this.workshopListBox.Name = "workshopListBox";
            this.workshopListBox.Size = new System.Drawing.Size(204, 158);
            this.workshopListBox.TabIndex = 0;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(227, 49);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(513, 17);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Select a workshop and a location and then press calculate to see pricing details." +
    "";
            // 
            // locationGroupBox
            // 
            this.locationGroupBox.Controls.Add(this.locationListBox);
            this.locationGroupBox.Location = new System.Drawing.Point(385, 120);
            this.locationGroupBox.Name = "locationGroupBox";
            this.locationGroupBox.Size = new System.Drawing.Size(267, 230);
            this.locationGroupBox.TabIndex = 1;
            this.locationGroupBox.TabStop = false;
            this.locationGroupBox.Text = "Location";
            // 
            // locationListBox
            // 
            this.locationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.ItemHeight = 22;
            this.locationListBox.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.locationListBox.Location = new System.Drawing.Point(31, 33);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(204, 158);
            this.locationListBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(111, 386);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(142, 55);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // pricingGroupBox
            // 
            this.pricingGroupBox.Controls.Add(this.pricingListBox);
            this.pricingGroupBox.Location = new System.Drawing.Point(690, 153);
            this.pricingGroupBox.Name = "pricingGroupBox";
            this.pricingGroupBox.Size = new System.Drawing.Size(267, 132);
            this.pricingGroupBox.TabIndex = 2;
            this.pricingGroupBox.TabStop = false;
            this.pricingGroupBox.Text = "Pricing";
            // 
            // pricingListBox
            // 
            this.pricingListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricingListBox.FormattingEnabled = true;
            this.pricingListBox.ItemHeight = 18;
            this.pricingListBox.Location = new System.Drawing.Point(6, 33);
            this.pricingListBox.Name = "pricingListBox";
            this.pricingListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.pricingListBox.Size = new System.Drawing.Size(255, 94);
            this.pricingListBox.TabIndex = 2;
            this.pricingListBox.TabStop = false;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(296, 386);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(142, 55);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(478, 386);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(142, 55);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(990, 494);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.pricingGroupBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.locationGroupBox);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.workshopGroupBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workshop Selector v2";
            this.workshopGroupBox.ResumeLayout(false);
            this.locationGroupBox.ResumeLayout(false);
            this.pricingGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox workshopGroupBox;
        private System.Windows.Forms.ListBox workshopListBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.GroupBox locationGroupBox;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox pricingGroupBox;
        private System.Windows.Forms.ListBox pricingListBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

