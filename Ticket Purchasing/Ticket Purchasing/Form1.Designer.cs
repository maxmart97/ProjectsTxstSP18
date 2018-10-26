namespace Ticket_Purchasing
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.ticketsTextBox = new System.Windows.Forms.TextBox();
            this.dayListBox = new System.Windows.Forms.ListBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.totalOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.computeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.purchaseInformationListBox = new System.Windows.Forms.ListBox();
            this.grandTotalButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.grandTotalOutputLabel = new System.Windows.Forms.Label();
            this.grandTotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(83, 53);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(364, 17);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = "Please enter the amount of tickets you wish to purchase.";
            // 
            // ticketsTextBox
            // 
            this.ticketsTextBox.Location = new System.Drawing.Point(86, 95);
            this.ticketsTextBox.Name = "ticketsTextBox";
            this.ticketsTextBox.Size = new System.Drawing.Size(100, 22);
            this.ticketsTextBox.TabIndex = 1;
            // 
            // dayListBox
            // 
            this.dayListBox.FormattingEnabled = true;
            this.dayListBox.ItemHeight = 16;
            this.dayListBox.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.dayListBox.Location = new System.Drawing.Point(86, 158);
            this.dayListBox.Name = "dayListBox";
            this.dayListBox.Size = new System.Drawing.Size(140, 116);
            this.dayListBox.TabIndex = 2;
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.ItemHeight = 16;
            this.locationListBox.Items.AddRange(new object[] {
            "IMAX",
            "South",
            "Capitol",
            "River"});
            this.locationListBox.Location = new System.Drawing.Point(289, 158);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(140, 116);
            this.locationListBox.TabIndex = 3;
            // 
            // totalOutputDescriptionLabel
            // 
            this.totalOutputDescriptionLabel.AutoSize = true;
            this.totalOutputDescriptionLabel.Location = new System.Drawing.Point(112, 357);
            this.totalOutputDescriptionLabel.Name = "totalOutputDescriptionLabel";
            this.totalOutputDescriptionLabel.Size = new System.Drawing.Size(74, 17);
            this.totalOutputDescriptionLabel.TabIndex = 4;
            this.totalOutputDescriptionLabel.Text = "Total Due:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(202, 357);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalTextBox.TabIndex = 4;
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(86, 434);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(112, 46);
            this.computeButton.TabIndex = 5;
            this.computeButton.Text = "&Compute";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(670, 434);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 46);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(391, 434);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 46);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // purchaseInformationListBox
            // 
            this.purchaseInformationListBox.FormattingEnabled = true;
            this.purchaseInformationListBox.ItemHeight = 16;
            this.purchaseInformationListBox.Location = new System.Drawing.Point(503, 158);
            this.purchaseInformationListBox.Name = "purchaseInformationListBox";
            this.purchaseInformationListBox.Size = new System.Drawing.Size(270, 116);
            this.purchaseInformationListBox.TabIndex = 8;
            // 
            // grandTotalButton
            // 
            this.grandTotalButton.Location = new System.Drawing.Point(241, 434);
            this.grandTotalButton.Name = "grandTotalButton";
            this.grandTotalButton.Size = new System.Drawing.Size(112, 46);
            this.grandTotalButton.TabIndex = 9;
            this.grandTotalButton.Text = "Display Grand Total";
            this.grandTotalButton.UseVisualStyleBackColor = true;
            this.grandTotalButton.Click += new System.EventHandler(this.grandTotalButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(534, 434);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(112, 46);
            this.clearAllButton.TabIndex = 10;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // grandTotalOutputLabel
            // 
            this.grandTotalOutputLabel.AutoSize = true;
            this.grandTotalOutputLabel.Location = new System.Drawing.Point(415, 357);
            this.grandTotalOutputLabel.Name = "grandTotalOutputLabel";
            this.grandTotalOutputLabel.Size = new System.Drawing.Size(88, 17);
            this.grandTotalOutputLabel.TabIndex = 11;
            this.grandTotalOutputLabel.Text = "Grand Total:";
            // 
            // grandTotalLabel
            // 
            this.grandTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grandTotalLabel.Location = new System.Drawing.Point(509, 356);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.grandTotalLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AcceptButton = this.computeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(868, 536);
            this.Controls.Add(this.grandTotalLabel);
            this.Controls.Add(this.grandTotalOutputLabel);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.grandTotalButton);
            this.Controls.Add(this.purchaseInformationListBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.totalOutputDescriptionLabel);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.dayListBox);
            this.Controls.Add(this.ticketsTextBox);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "Form1";
            this.Text = "Ticket Purchasing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox ticketsTextBox;
        private System.Windows.Forms.ListBox dayListBox;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.Label totalOutputDescriptionLabel;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListBox purchaseInformationListBox;
        private System.Windows.Forms.Button grandTotalButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Label grandTotalOutputLabel;
        private System.Windows.Forms.Label grandTotalLabel;
    }
}

