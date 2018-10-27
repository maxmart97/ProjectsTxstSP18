namespace Honor_Roll
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
            this.informationListBox = new System.Windows.Forms.ListBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.honorsLabel = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // informationListBox
            // 
            this.informationListBox.FormattingEnabled = true;
            this.informationListBox.ItemHeight = 16;
            this.informationListBox.Location = new System.Drawing.Point(46, 71);
            this.informationListBox.Name = "informationListBox";
            this.informationListBox.Size = new System.Drawing.Size(575, 212);
            this.informationListBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(89, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(70, 25);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "NAME";
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpaLabel.Location = new System.Drawing.Point(295, 37);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(54, 25);
            this.gpaLabel.TabIndex = 2;
            this.gpaLabel.Text = "GPA";
            // 
            // honorsLabel
            // 
            this.honorsLabel.AutoSize = true;
            this.honorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.honorsLabel.Location = new System.Drawing.Point(485, 37);
            this.honorsLabel.Name = "honorsLabel";
            this.honorsLabel.Size = new System.Drawing.Size(99, 25);
            this.honorsLabel.TabIndex = 3;
            this.honorsLabel.Text = "HONORS";
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(81, 312);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(100, 67);
            this.displayButton.TabIndex = 4;
            this.displayButton.Text = "Display Student Status";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(277, 312);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 67);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(490, 312);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 67);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 418);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.honorsLabel);
            this.Controls.Add(this.gpaLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.informationListBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Honor Roll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox informationListBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Label honorsLabel;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

