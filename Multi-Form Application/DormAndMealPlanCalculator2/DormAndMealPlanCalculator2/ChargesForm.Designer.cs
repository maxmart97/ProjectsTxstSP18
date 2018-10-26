namespace DormAndMealPlanCalculator2
{
    partial class ChargesForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.chargesGroupBox = new System.Windows.Forms.GroupBox();
            this.totalChargesLabel = new System.Windows.Forms.Label();
            this.totalODLabel = new System.Windows.Forms.Label();
            this.mealPlanChargesLabel = new System.Windows.Forms.Label();
            this.mealPlanChargesODLabel = new System.Windows.Forms.Label();
            this.dormChargesLabel = new System.Windows.Forms.Label();
            this.dormODLabel = new System.Windows.Forms.Label();
            this.chargesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(331, 74);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(133, 60);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "C&lose";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // chargesGroupBox
            // 
            this.chargesGroupBox.Controls.Add(this.totalChargesLabel);
            this.chargesGroupBox.Controls.Add(this.totalODLabel);
            this.chargesGroupBox.Controls.Add(this.mealPlanChargesLabel);
            this.chargesGroupBox.Controls.Add(this.mealPlanChargesODLabel);
            this.chargesGroupBox.Controls.Add(this.dormChargesLabel);
            this.chargesGroupBox.Controls.Add(this.dormODLabel);
            this.chargesGroupBox.Location = new System.Drawing.Point(23, 31);
            this.chargesGroupBox.Name = "chargesGroupBox";
            this.chargesGroupBox.Size = new System.Drawing.Size(266, 159);
            this.chargesGroupBox.TabIndex = 3;
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
            // ChargesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 232);
            this.Controls.Add(this.chargesGroupBox);
            this.Controls.Add(this.closeButton);
            this.Name = "ChargesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Charges";
            this.chargesGroupBox.ResumeLayout(false);
            this.chargesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label totalODLabel;
        public System.Windows.Forms.Label mealPlanChargesLabel;
        private System.Windows.Forms.Label mealPlanChargesODLabel;
        private System.Windows.Forms.Label dormODLabel;
        public System.Windows.Forms.Label totalChargesLabel;
        public System.Windows.Forms.Label dormChargesLabel;
        private System.Windows.Forms.GroupBox chargesGroupBox;
    }
}