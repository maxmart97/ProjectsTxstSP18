namespace Class_Example
{
    partial class SecondForm
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
            this.gradeOutputODLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.returnToMainFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gradeOutputODLabel
            // 
            this.gradeOutputODLabel.AutoSize = true;
            this.gradeOutputODLabel.Location = new System.Drawing.Point(160, 60);
            this.gradeOutputODLabel.Name = "gradeOutputODLabel";
            this.gradeOutputODLabel.Size = new System.Drawing.Size(83, 17);
            this.gradeOutputODLabel.TabIndex = 0;
            this.gradeOutputODLabel.Text = "Your grade:";
            // 
            // gradeLabel
            // 
            this.gradeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.Location = new System.Drawing.Point(163, 105);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(80, 61);
            this.gradeLabel.TabIndex = 1;
            this.gradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(84, 203);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(105, 78);
            this.processButton.TabIndex = 2;
            this.processButton.Text = "Process Button";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // returnToMainFormButton
            // 
            this.returnToMainFormButton.Location = new System.Drawing.Point(217, 203);
            this.returnToMainFormButton.Name = "returnToMainFormButton";
            this.returnToMainFormButton.Size = new System.Drawing.Size(105, 78);
            this.returnToMainFormButton.TabIndex = 3;
            this.returnToMainFormButton.Text = "Return to Main Form";
            this.returnToMainFormButton.UseVisualStyleBackColor = true;
            this.returnToMainFormButton.Click += new System.EventHandler(this.returnToMainFormButton_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 330);
            this.Controls.Add(this.returnToMainFormButton);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.gradeOutputODLabel);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gradeOutputODLabel;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button returnToMainFormButton;
        public System.Windows.Forms.Label gradeLabel;
    }
}