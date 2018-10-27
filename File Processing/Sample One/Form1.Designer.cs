namespace Sample_One
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
            this.createButton = new System.Windows.Forms.Button();
            this.namesListBox = new System.Windows.Forms.ListBox();
            this.readButton = new System.Windows.Forms.Button();
            this.readButtonWithDialogBox = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.namesListBox2 = new System.Windows.Forms.ListBox();
            this.writeButton2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(107, 63);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(125, 70);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create new file in default location.";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // namesListBox
            // 
            this.namesListBox.FormattingEnabled = true;
            this.namesListBox.ItemHeight = 16;
            this.namesListBox.Location = new System.Drawing.Point(293, 165);
            this.namesListBox.Name = "namesListBox";
            this.namesListBox.Size = new System.Drawing.Size(156, 84);
            this.namesListBox.TabIndex = 1;
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(107, 179);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(125, 70);
            this.readButton.TabIndex = 2;
            this.readButton.Text = "Read a file from the default location.";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // readButtonWithDialogBox
            // 
            this.readButtonWithDialogBox.Location = new System.Drawing.Point(107, 324);
            this.readButtonWithDialogBox.Name = "readButtonWithDialogBox";
            this.readButtonWithDialogBox.Size = new System.Drawing.Size(125, 70);
            this.readButtonWithDialogBox.TabIndex = 3;
            this.readButtonWithDialogBox.Text = "Read a file using a dialog box.";
            this.readButtonWithDialogBox.UseVisualStyleBackColor = true;
            this.readButtonWithDialogBox.Click += new System.EventHandler(this.readButtonWithDialogBox_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // namesListBox2
            // 
            this.namesListBox2.FormattingEnabled = true;
            this.namesListBox2.ItemHeight = 16;
            this.namesListBox2.Location = new System.Drawing.Point(293, 310);
            this.namesListBox2.Name = "namesListBox2";
            this.namesListBox2.Size = new System.Drawing.Size(156, 84);
            this.namesListBox2.TabIndex = 4;
            // 
            // writeButton2
            // 
            this.writeButton2.Location = new System.Drawing.Point(539, 63);
            this.writeButton2.Name = "writeButton2";
            this.writeButton2.Size = new System.Drawing.Size(125, 70);
            this.writeButton2.TabIndex = 5;
            this.writeButton2.Text = "Write a file and save it using a dialog box.";
            this.writeButton2.UseVisualStyleBackColor = true;
            this.writeButton2.Click += new System.EventHandler(this.writeButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 497);
            this.Controls.Add(this.writeButton2);
            this.Controls.Add(this.namesListBox2);
            this.Controls.Add(this.readButtonWithDialogBox);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.namesListBox);
            this.Controls.Add(this.createButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ListBox namesListBox;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button readButtonWithDialogBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox namesListBox2;
        private System.Windows.Forms.Button writeButton2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

