namespace Looping
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
            this.outputListbox = new System.Windows.Forms.ListBox();
            this.startButtonWhileLoop = new System.Windows.Forms.Button();
            this.startButtonDoWhileLoop = new System.Windows.Forms.Button();
            this.startButtonForLoop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputListbox
            // 
            this.outputListbox.FormattingEnabled = true;
            this.outputListbox.ItemHeight = 16;
            this.outputListbox.Location = new System.Drawing.Point(420, 39);
            this.outputListbox.Name = "outputListbox";
            this.outputListbox.Size = new System.Drawing.Size(305, 468);
            this.outputListbox.TabIndex = 0;
            // 
            // startButtonWhileLoop
            // 
            this.startButtonWhileLoop.Location = new System.Drawing.Point(101, 61);
            this.startButtonWhileLoop.Name = "startButtonWhileLoop";
            this.startButtonWhileLoop.Size = new System.Drawing.Size(212, 101);
            this.startButtonWhileLoop.TabIndex = 1;
            this.startButtonWhileLoop.Text = "Start (While Loop)";
            this.startButtonWhileLoop.UseVisualStyleBackColor = true;
            this.startButtonWhileLoop.Click += new System.EventHandler(this.startButton_Click);
            // 
            // startButtonDoWhileLoop
            // 
            this.startButtonDoWhileLoop.Location = new System.Drawing.Point(101, 233);
            this.startButtonDoWhileLoop.Name = "startButtonDoWhileLoop";
            this.startButtonDoWhileLoop.Size = new System.Drawing.Size(212, 101);
            this.startButtonDoWhileLoop.TabIndex = 2;
            this.startButtonDoWhileLoop.Text = "Start (Do-While Loop)";
            this.startButtonDoWhileLoop.UseVisualStyleBackColor = true;
            this.startButtonDoWhileLoop.Click += new System.EventHandler(this.startButtonDoWhileLoop_Click);
            // 
            // startButtonForLoop
            // 
            this.startButtonForLoop.Location = new System.Drawing.Point(101, 406);
            this.startButtonForLoop.Name = "startButtonForLoop";
            this.startButtonForLoop.Size = new System.Drawing.Size(212, 101);
            this.startButtonForLoop.TabIndex = 3;
            this.startButtonForLoop.Text = "Start (For Loop)";
            this.startButtonForLoop.UseVisualStyleBackColor = true;
            this.startButtonForLoop.Click += new System.EventHandler(this.startButtonForLoop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 590);
            this.Controls.Add(this.startButtonForLoop);
            this.Controls.Add(this.startButtonDoWhileLoop);
            this.Controls.Add(this.startButtonWhileLoop);
            this.Controls.Add(this.outputListbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox outputListbox;
        private System.Windows.Forms.Button startButtonWhileLoop;
        private System.Windows.Forms.Button startButtonDoWhileLoop;
        private System.Windows.Forms.Button startButtonForLoop;
    }
}

