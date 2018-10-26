namespace Price_and_Tip_Calculator
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
            this.pricePromptLabel = new System.Windows.Forms.Label();
            this.tipOutputLabel = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.thankYouLabel = new System.Windows.Forms.Label();
            this.smileyFacePictureBox1 = new System.Windows.Forms.PictureBox();
            this.smileyFacePictureBox2 = new System.Windows.Forms.PictureBox();
            this.tipAmtPromptLabel = new System.Windows.Forms.Label();
            this.tipPercentTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.smileyFacePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smileyFacePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pricePromptLabel
            // 
            this.pricePromptLabel.AutoSize = true;
            this.pricePromptLabel.Location = new System.Drawing.Point(215, 51);
            this.pricePromptLabel.Name = "pricePromptLabel";
            this.pricePromptLabel.Size = new System.Drawing.Size(179, 17);
            this.pricePromptLabel.TabIndex = 0;
            this.pricePromptLabel.Text = "Enter the price of the meal:";
            // 
            // tipOutputLabel
            // 
            this.tipOutputLabel.AutoSize = true;
            this.tipOutputLabel.Location = new System.Drawing.Point(215, 132);
            this.tipOutputLabel.Name = "tipOutputLabel";
            this.tipOutputLabel.Size = new System.Drawing.Size(32, 17);
            this.tipOutputLabel.TabIndex = 1;
            this.tipOutputLabel.Text = "Tip:";
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.AutoSize = true;
            this.totalOutputLabel.Location = new System.Drawing.Point(215, 177);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(44, 17);
            this.totalOutputLabel.TabIndex = 2;
            this.totalOutputLabel.Text = "Total:";
            // 
            // tipLabel
            // 
            this.tipLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipLabel.Location = new System.Drawing.Point(428, 126);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(100, 23);
            this.tipLabel.TabIndex = 3;
            this.tipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(428, 171);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(428, 48);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceTextBox.TabIndex = 1;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(218, 356);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(86, 33);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(339, 356);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(84, 55);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(450, 356);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(78, 33);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // thankYouLabel
            // 
            this.thankYouLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.thankYouLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thankYouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thankYouLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.thankYouLabel.Location = new System.Drawing.Point(270, 213);
            this.thankYouLabel.Name = "thankYouLabel";
            this.thankYouLabel.Size = new System.Drawing.Size(201, 114);
            this.thankYouLabel.TabIndex = 9;
            this.thankYouLabel.Text = "Thank you! Please come back!";
            this.thankYouLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.thankYouLabel.Visible = false;
            // 
            // smileyFacePictureBox1
            // 
            this.smileyFacePictureBox1.Image = global::Price_And_Tip_Calculator.Properties.Resources.Smile_Face;
            this.smileyFacePictureBox1.Location = new System.Drawing.Point(42, 213);
            this.smileyFacePictureBox1.Name = "smileyFacePictureBox1";
            this.smileyFacePictureBox1.Size = new System.Drawing.Size(143, 123);
            this.smileyFacePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.smileyFacePictureBox1.TabIndex = 10;
            this.smileyFacePictureBox1.TabStop = false;
            this.smileyFacePictureBox1.Visible = false;
            // 
            // smileyFacePictureBox2
            // 
            this.smileyFacePictureBox2.Image = global::Price_And_Tip_Calculator.Properties.Resources.Smile_Face;
            this.smileyFacePictureBox2.Location = new System.Drawing.Point(564, 213);
            this.smileyFacePictureBox2.Name = "smileyFacePictureBox2";
            this.smileyFacePictureBox2.Size = new System.Drawing.Size(143, 123);
            this.smileyFacePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.smileyFacePictureBox2.TabIndex = 11;
            this.smileyFacePictureBox2.TabStop = false;
            this.smileyFacePictureBox2.Visible = false;
            // 
            // tipAmtPromptLabel
            // 
            this.tipAmtPromptLabel.AutoSize = true;
            this.tipAmtPromptLabel.Location = new System.Drawing.Point(215, 91);
            this.tipAmtPromptLabel.Name = "tipAmtPromptLabel";
            this.tipAmtPromptLabel.Size = new System.Drawing.Size(199, 17);
            this.tipAmtPromptLabel.TabIndex = 12;
            this.tipAmtPromptLabel.Text = "Enter tip amount (% - I.E.  20):";
            // 
            // tipPercentTextBox
            // 
            this.tipPercentTextBox.Location = new System.Drawing.Point(428, 88);
            this.tipPercentTextBox.Name = "tipPercentTextBox";
            this.tipPercentTextBox.Size = new System.Drawing.Size(100, 22);
            this.tipPercentTextBox.TabIndex = 2;
            this.tipPercentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(755, 481);
            this.Controls.Add(this.tipPercentTextBox);
            this.Controls.Add(this.tipAmtPromptLabel);
            this.Controls.Add(this.smileyFacePictureBox2);
            this.Controls.Add(this.smileyFacePictureBox1);
            this.Controls.Add(this.thankYouLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.totalOutputLabel);
            this.Controls.Add(this.tipOutputLabel);
            this.Controls.Add(this.pricePromptLabel);
            this.Name = "Form1";
            this.Text = "Price and Tip Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.smileyFacePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smileyFacePictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pricePromptLabel;
        private System.Windows.Forms.Label tipOutputLabel;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label thankYouLabel;
        private System.Windows.Forms.PictureBox smileyFacePictureBox1;
        private System.Windows.Forms.PictureBox smileyFacePictureBox2;
        private System.Windows.Forms.Label tipAmtPromptLabel;
        private System.Windows.Forms.TextBox tipPercentTextBox;
    }
}

