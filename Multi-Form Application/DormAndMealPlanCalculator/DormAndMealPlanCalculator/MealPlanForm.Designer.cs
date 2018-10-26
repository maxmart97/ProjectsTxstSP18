namespace DormAndMealPlanCalculator
{
    partial class MealPlanForm
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
            this.mealPlanGroupBox = new System.Windows.Forms.GroupBox();
            this.mealPlansListBox = new System.Windows.Forms.ListBox();
            this.addMealPlanButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.mealPlanGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mealPlanGroupBox
            // 
            this.mealPlanGroupBox.Controls.Add(this.mealPlansListBox);
            this.mealPlanGroupBox.Location = new System.Drawing.Point(33, 41);
            this.mealPlanGroupBox.Name = "mealPlanGroupBox";
            this.mealPlanGroupBox.Size = new System.Drawing.Size(236, 139);
            this.mealPlanGroupBox.TabIndex = 0;
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
            this.mealPlansListBox.TabIndex = 0;
            // 
            // addMealPlanButton
            // 
            this.addMealPlanButton.Location = new System.Drawing.Point(323, 41);
            this.addMealPlanButton.Name = "addMealPlanButton";
            this.addMealPlanButton.Size = new System.Drawing.Size(133, 60);
            this.addMealPlanButton.TabIndex = 1;
            this.addMealPlanButton.Text = "&Add Meal Plan";
            this.addMealPlanButton.UseVisualStyleBackColor = true;
            this.addMealPlanButton.Click += new System.EventHandler(this.addMealPlanButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(323, 120);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(133, 60);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "C&lose";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MealPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 232);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addMealPlanButton);
            this.Controls.Add(this.mealPlanGroupBox);
            this.Name = "MealPlanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Meal Plans";
            this.mealPlanGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addMealPlanButton;
        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.ListBox mealPlansListBox;
        private System.Windows.Forms.GroupBox mealPlanGroupBox;
    }
}