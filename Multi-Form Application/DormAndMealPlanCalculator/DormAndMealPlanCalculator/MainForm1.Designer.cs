namespace DormAndMealPlanCalculator
{
    partial class MainForm1
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
            this.dormGroupBox = new System.Windows.Forms.GroupBox();
            this.dormListBox = new System.Windows.Forms.ListBox();
            this.chargesGroupBox = new System.Windows.Forms.GroupBox();
            this.totalChargesLabel = new System.Windows.Forms.Label();
            this.totalODLabel = new System.Windows.Forms.Label();
            this.mealPlanChargesLabel = new System.Windows.Forms.Label();
            this.mealPlanChargesODLabel = new System.Windows.Forms.Label();
            this.dormChargesLabel = new System.Windows.Forms.Label();
            this.dormODLabel = new System.Windows.Forms.Label();
            this.addDormButton = new System.Windows.Forms.Button();
            this.viewMealPlansButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.dormGroupBox.SuspendLayout();
            this.chargesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dormGroupBox
            // 
            this.dormGroupBox.Controls.Add(this.dormListBox);
            this.dormGroupBox.Location = new System.Drawing.Point(27, 37);
            this.dormGroupBox.Name = "dormGroupBox";
            this.dormGroupBox.Size = new System.Drawing.Size(266, 159);
            this.dormGroupBox.TabIndex = 0;
            this.dormGroupBox.TabStop = false;
            this.dormGroupBox.Text = "Select a Dormitory";
            // 
            // dormListBox
            // 
            this.dormListBox.FormattingEnabled = true;
            this.dormListBox.ItemHeight = 16;
            this.dormListBox.Location = new System.Drawing.Point(20, 37);
            this.dormListBox.Name = "dormListBox";
            this.dormListBox.Size = new System.Drawing.Size(224, 100);
            this.dormListBox.TabIndex = 0;
            // 
            // chargesGroupBox
            // 
            this.chargesGroupBox.Controls.Add(this.totalChargesLabel);
            this.chargesGroupBox.Controls.Add(this.totalODLabel);
            this.chargesGroupBox.Controls.Add(this.mealPlanChargesLabel);
            this.chargesGroupBox.Controls.Add(this.mealPlanChargesODLabel);
            this.chargesGroupBox.Controls.Add(this.dormChargesLabel);
            this.chargesGroupBox.Controls.Add(this.dormODLabel);
            this.chargesGroupBox.Location = new System.Drawing.Point(322, 37);
            this.chargesGroupBox.Name = "chargesGroupBox";
            this.chargesGroupBox.Size = new System.Drawing.Size(266, 159);
            this.chargesGroupBox.TabIndex = 2;
            this.chargesGroupBox.TabStop = false;
            this.chargesGroupBox.Text = "Charges for the Semester";
            // 
            // totalChargesLabel
            // 
            this.totalChargesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalChargesLabel.Location = new System.Drawing.Point(127, 111);
            this.totalChargesLabel.Name = "totalChargesLabel";
            this.totalChargesLabel.Size = new System.Drawing.Size(101, 30);
            this.totalChargesLabel.TabIndex = 8;
            this.totalChargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalODLabel
            // 
            this.totalODLabel.AutoSize = true;
            this.totalODLabel.Location = new System.Drawing.Point(71, 124);
            this.totalODLabel.Name = "totalODLabel";
            this.totalODLabel.Size = new System.Drawing.Size(40, 17);
            this.totalODLabel.TabIndex = 7;
            this.totalODLabel.Text = "Total";
            // 
            // mealPlanChargesLabel
            // 
            this.mealPlanChargesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mealPlanChargesLabel.Location = new System.Drawing.Point(127, 71);
            this.mealPlanChargesLabel.Name = "mealPlanChargesLabel";
            this.mealPlanChargesLabel.Size = new System.Drawing.Size(101, 30);
            this.mealPlanChargesLabel.TabIndex = 6;
            this.mealPlanChargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mealPlanChargesODLabel
            // 
            this.mealPlanChargesODLabel.AutoSize = true;
            this.mealPlanChargesODLabel.Location = new System.Drawing.Point(41, 84);
            this.mealPlanChargesODLabel.Name = "mealPlanChargesODLabel";
            this.mealPlanChargesODLabel.Size = new System.Drawing.Size(70, 17);
            this.mealPlanChargesODLabel.TabIndex = 5;
            this.mealPlanChargesODLabel.Text = "Meal Plan";
            // 
            // dormChargesLabel
            // 
            this.dormChargesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dormChargesLabel.Location = new System.Drawing.Point(127, 30);
            this.dormChargesLabel.Name = "dormChargesLabel";
            this.dormChargesLabel.Size = new System.Drawing.Size(101, 30);
            this.dormChargesLabel.TabIndex = 4;
            this.dormChargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dormODLabel
            // 
            this.dormODLabel.AutoSize = true;
            this.dormODLabel.Location = new System.Drawing.Point(42, 43);
            this.dormODLabel.Name = "dormODLabel";
            this.dormODLabel.Size = new System.Drawing.Size(69, 17);
            this.dormODLabel.TabIndex = 3;
            this.dormODLabel.Text = "Dormitory";
            // 
            // addDormButton
            // 
            this.addDormButton.Location = new System.Drawing.Point(27, 233);
            this.addDormButton.Name = "addDormButton";
            this.addDormButton.Size = new System.Drawing.Size(115, 51);
            this.addDormButton.TabIndex = 1;
            this.addDormButton.Text = "&Add Dormitory";
            this.addDormButton.UseVisualStyleBackColor = true;
            this.addDormButton.Click += new System.EventHandler(this.addDormButton_Click);
            // 
            // viewMealPlansButton
            // 
            this.viewMealPlansButton.Location = new System.Drawing.Point(176, 233);
            this.viewMealPlansButton.Name = "viewMealPlansButton";
            this.viewMealPlansButton.Size = new System.Drawing.Size(115, 51);
            this.viewMealPlansButton.TabIndex = 2;
            this.viewMealPlansButton.Text = "&View Meal Plans";
            this.viewMealPlansButton.UseVisualStyleBackColor = true;
            this.viewMealPlansButton.Click += new System.EventHandler(this.viewMealPlansButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(322, 233);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(115, 51);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(473, 233);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 51);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm1
            // 
            this.AcceptButton = this.addDormButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(614, 313);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.viewMealPlansButton);
            this.Controls.Add(this.addDormButton);
            this.Controls.Add(this.chargesGroupBox);
            this.Controls.Add(this.dormGroupBox);
            this.Name = "MainForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dorm and Meal Plan Calculator";
            this.Load += new System.EventHandler(this.MainForm1_Load);
            this.dormGroupBox.ResumeLayout(false);
            this.chargesGroupBox.ResumeLayout(false);
            this.chargesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox dormListBox;
        private System.Windows.Forms.Label totalChargesLabel;
        private System.Windows.Forms.Label totalODLabel;
        private System.Windows.Forms.Label mealPlanChargesODLabel;
        private System.Windows.Forms.Label dormChargesLabel;
        private System.Windows.Forms.Label dormODLabel;
        private System.Windows.Forms.Button addDormButton;
        private System.Windows.Forms.Button viewMealPlansButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        public System.Windows.Forms.Label mealPlanChargesLabel;
        public System.Windows.Forms.GroupBox chargesGroupBox;
        private System.Windows.Forms.GroupBox dormGroupBox;
    }
}

