namespace DormAndMealPlanCalculator2
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
            this.addDormButton = new System.Windows.Forms.Button();
            this.addMealPlanButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mealPlanGroupBox = new System.Windows.Forms.GroupBox();
            this.mealPlansListBox = new System.Windows.Forms.ListBox();
            this.showChargesButton = new System.Windows.Forms.Button();
            this.dormGroupBox.SuspendLayout();
            this.mealPlanGroupBox.SuspendLayout();
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
            // addDormButton
            // 
            this.addDormButton.Location = new System.Drawing.Point(47, 212);
            this.addDormButton.Name = "addDormButton";
            this.addDormButton.Size = new System.Drawing.Size(224, 51);
            this.addDormButton.TabIndex = 1;
            this.addDormButton.Text = "&Add Dormitory";
            this.addDormButton.UseVisualStyleBackColor = true;
            this.addDormButton.Click += new System.EventHandler(this.addDormButton_Click);
            // 
            // addMealPlanButton
            // 
            this.addMealPlanButton.Location = new System.Drawing.Point(374, 212);
            this.addMealPlanButton.Name = "addMealPlanButton";
            this.addMealPlanButton.Size = new System.Drawing.Size(191, 51);
            this.addMealPlanButton.TabIndex = 3;
            this.addMealPlanButton.Text = "Add &Meal Plan";
            this.addMealPlanButton.UseVisualStyleBackColor = true;
            this.addMealPlanButton.Click += new System.EventHandler(this.addMealPlanButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(258, 300);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(115, 51);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(379, 300);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 51);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mealPlanGroupBox
            // 
            this.mealPlanGroupBox.Controls.Add(this.mealPlansListBox);
            this.mealPlanGroupBox.Location = new System.Drawing.Point(352, 57);
            this.mealPlanGroupBox.Name = "mealPlanGroupBox";
            this.mealPlanGroupBox.Size = new System.Drawing.Size(236, 139);
            this.mealPlanGroupBox.TabIndex = 2;
            this.mealPlanGroupBox.TabStop = false;
            this.mealPlanGroupBox.Text = "Select a Weekly Meal Plan";
            // 
            // mealPlansListBox
            // 
            this.mealPlansListBox.FormattingEnabled = true;
            this.mealPlansListBox.ItemHeight = 16;
            this.mealPlansListBox.Location = new System.Drawing.Point(22, 31);
            this.mealPlansListBox.Name = "mealPlansListBox";
            this.mealPlansListBox.Size = new System.Drawing.Size(191, 84);
            this.mealPlansListBox.TabIndex = 2;
            // 
            // showChargesButton
            // 
            this.showChargesButton.Enabled = false;
            this.showChargesButton.Location = new System.Drawing.Point(137, 300);
            this.showChargesButton.Name = "showChargesButton";
            this.showChargesButton.Size = new System.Drawing.Size(115, 51);
            this.showChargesButton.TabIndex = 4;
            this.showChargesButton.Text = "&Show Total Charges";
            this.showChargesButton.UseVisualStyleBackColor = true;
            this.showChargesButton.Click += new System.EventHandler(this.showChargesButton_Click);
            // 
            // MainForm1
            // 
            this.AcceptButton = this.showChargesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(613, 385);
            this.Controls.Add(this.showChargesButton);
            this.Controls.Add(this.mealPlanGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.addMealPlanButton);
            this.Controls.Add(this.addDormButton);
            this.Controls.Add(this.dormGroupBox);
            this.Name = "MainForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dorm and Meal Plan Calculator";
            this.Load += new System.EventHandler(this.MainForm1_Load);
            this.dormGroupBox.ResumeLayout(false);
            this.mealPlanGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox dormListBox;
        private System.Windows.Forms.Button addDormButton;
        private System.Windows.Forms.Button addMealPlanButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox dormGroupBox;
        private System.Windows.Forms.GroupBox mealPlanGroupBox;
        private System.Windows.Forms.Button showChargesButton;
        private System.Windows.Forms.ListBox mealPlansListBox;
    }
}

