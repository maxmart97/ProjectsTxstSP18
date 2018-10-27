namespace Tickets
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
            this.lotteryPictureBox = new System.Windows.Forms.PictureBox();
            this.randomNumberTextBox1 = new System.Windows.Forms.TextBox();
            this.randomNumberTextBox2 = new System.Windows.Forms.TextBox();
            this.randomNumberTextBox3 = new System.Windows.Forms.TextBox();
            this.randomNumberTextBox4 = new System.Windows.Forms.TextBox();
            this.drawTicketButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.shutDownButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lotteryPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lotteryPictureBox
            // 
            this.lotteryPictureBox.Image = global::Tickets.Properties.Resources.Lottery_Balls;
            this.lotteryPictureBox.Location = new System.Drawing.Point(292, 38);
            this.lotteryPictureBox.Name = "lotteryPictureBox";
            this.lotteryPictureBox.Size = new System.Drawing.Size(227, 199);
            this.lotteryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lotteryPictureBox.TabIndex = 0;
            this.lotteryPictureBox.TabStop = false;
            // 
            // randomNumberTextBox1
            // 
            this.randomNumberTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomNumberTextBox1.Location = new System.Drawing.Point(79, 368);
            this.randomNumberTextBox1.Name = "randomNumberTextBox1";
            this.randomNumberTextBox1.Size = new System.Drawing.Size(100, 30);
            this.randomNumberTextBox1.TabIndex = 1;
            // 
            // randomNumberTextBox2
            // 
            this.randomNumberTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomNumberTextBox2.Location = new System.Drawing.Point(257, 368);
            this.randomNumberTextBox2.Name = "randomNumberTextBox2";
            this.randomNumberTextBox2.Size = new System.Drawing.Size(100, 30);
            this.randomNumberTextBox2.TabIndex = 2;
            // 
            // randomNumberTextBox3
            // 
            this.randomNumberTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomNumberTextBox3.Location = new System.Drawing.Point(441, 368);
            this.randomNumberTextBox3.Name = "randomNumberTextBox3";
            this.randomNumberTextBox3.Size = new System.Drawing.Size(100, 30);
            this.randomNumberTextBox3.TabIndex = 3;
            // 
            // randomNumberTextBox4
            // 
            this.randomNumberTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomNumberTextBox4.Location = new System.Drawing.Point(619, 368);
            this.randomNumberTextBox4.Name = "randomNumberTextBox4";
            this.randomNumberTextBox4.Size = new System.Drawing.Size(100, 30);
            this.randomNumberTextBox4.TabIndex = 4;
            // 
            // drawTicketButton
            // 
            this.drawTicketButton.Location = new System.Drawing.Point(107, 492);
            this.drawTicketButton.Name = "drawTicketButton";
            this.drawTicketButton.Size = new System.Drawing.Size(129, 62);
            this.drawTicketButton.TabIndex = 5;
            this.drawTicketButton.Text = "Draw Ticket";
            this.drawTicketButton.UseVisualStyleBackColor = true;
            this.drawTicketButton.Click += new System.EventHandler(this.drawTicketButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(334, 492);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(129, 62);
            this.clearAllButton.TabIndex = 6;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // shutDownButton
            // 
            this.shutDownButton.Location = new System.Drawing.Point(554, 492);
            this.shutDownButton.Name = "shutDownButton";
            this.shutDownButton.Size = new System.Drawing.Size(129, 62);
            this.shutDownButton.TabIndex = 7;
            this.shutDownButton.Text = "Shut Down";
            this.shutDownButton.UseVisualStyleBackColor = true;
            this.shutDownButton.Click += new System.EventHandler(this.shutDownButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 611);
            this.Controls.Add(this.shutDownButton);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.drawTicketButton);
            this.Controls.Add(this.randomNumberTextBox4);
            this.Controls.Add(this.randomNumberTextBox3);
            this.Controls.Add(this.randomNumberTextBox2);
            this.Controls.Add(this.randomNumberTextBox1);
            this.Controls.Add(this.lotteryPictureBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lotteryPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lotteryPictureBox;
        private System.Windows.Forms.TextBox randomNumberTextBox1;
        private System.Windows.Forms.TextBox randomNumberTextBox2;
        private System.Windows.Forms.TextBox randomNumberTextBox3;
        private System.Windows.Forms.TextBox randomNumberTextBox4;
        private System.Windows.Forms.Button drawTicketButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button shutDownButton;
    }
}

