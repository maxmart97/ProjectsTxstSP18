namespace Blood_Pressure_Monitor
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
            this.patientInformationListBox = new System.Windows.Forms.ListBox();
            this.patientNameOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.avgSystolicOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.avgDiastolicOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.statusOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.physicianOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.patientInformationListView = new System.Windows.Forms.ListView();
            this.listViewInfoLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // patientInformationListBox
            // 
            this.patientInformationListBox.FormattingEnabled = true;
            this.patientInformationListBox.ItemHeight = 16;
            this.patientInformationListBox.Location = new System.Drawing.Point(30, 90);
            this.patientInformationListBox.Name = "patientInformationListBox";
            this.patientInformationListBox.Size = new System.Drawing.Size(871, 228);
            this.patientInformationListBox.TabIndex = 0;
            this.patientInformationListBox.TabStop = false;
            // 
            // patientNameOutputDescriptionLabel
            // 
            this.patientNameOutputDescriptionLabel.AutoSize = true;
            this.patientNameOutputDescriptionLabel.Location = new System.Drawing.Point(67, 48);
            this.patientNameOutputDescriptionLabel.Name = "patientNameOutputDescriptionLabel";
            this.patientNameOutputDescriptionLabel.Size = new System.Drawing.Size(93, 17);
            this.patientNameOutputDescriptionLabel.TabIndex = 2;
            this.patientNameOutputDescriptionLabel.Text = "Patient Name";
            // 
            // avgSystolicOutputDescriptionLabel
            // 
            this.avgSystolicOutputDescriptionLabel.AutoSize = true;
            this.avgSystolicOutputDescriptionLabel.Location = new System.Drawing.Point(352, 48);
            this.avgSystolicOutputDescriptionLabel.Name = "avgSystolicOutputDescriptionLabel";
            this.avgSystolicOutputDescriptionLabel.Size = new System.Drawing.Size(84, 17);
            this.avgSystolicOutputDescriptionLabel.TabIndex = 3;
            this.avgSystolicOutputDescriptionLabel.Text = "Avg Systolic";
            // 
            // avgDiastolicOutputDescriptionLabel
            // 
            this.avgDiastolicOutputDescriptionLabel.AutoSize = true;
            this.avgDiastolicOutputDescriptionLabel.Location = new System.Drawing.Point(497, 48);
            this.avgDiastolicOutputDescriptionLabel.Name = "avgDiastolicOutputDescriptionLabel";
            this.avgDiastolicOutputDescriptionLabel.Size = new System.Drawing.Size(89, 17);
            this.avgDiastolicOutputDescriptionLabel.TabIndex = 4;
            this.avgDiastolicOutputDescriptionLabel.Text = "Avg Diastolic";
            // 
            // statusOutputDescriptionLabel
            // 
            this.statusOutputDescriptionLabel.AutoSize = true;
            this.statusOutputDescriptionLabel.Location = new System.Drawing.Point(652, 48);
            this.statusOutputDescriptionLabel.Name = "statusOutputDescriptionLabel";
            this.statusOutputDescriptionLabel.Size = new System.Drawing.Size(48, 17);
            this.statusOutputDescriptionLabel.TabIndex = 5;
            this.statusOutputDescriptionLabel.Text = "Status";
            // 
            // physicianOutputDescriptionLabel
            // 
            this.physicianOutputDescriptionLabel.AutoSize = true;
            this.physicianOutputDescriptionLabel.Location = new System.Drawing.Point(795, 48);
            this.physicianOutputDescriptionLabel.Name = "physicianOutputDescriptionLabel";
            this.physicianOutputDescriptionLabel.Size = new System.Drawing.Size(68, 17);
            this.physicianOutputDescriptionLabel.TabIndex = 6;
            this.physicianOutputDescriptionLabel.Text = "Physician";
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(93, 626);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(119, 71);
            this.displayButton.TabIndex = 1;
            this.displayButton.Text = "&Display Patient Status";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(397, 626);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(119, 71);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "&Clear Monitor";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(698, 626);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(119, 71);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "&Exit System";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // patientInformationListView
            // 
            this.patientInformationListView.GridLines = true;
            this.patientInformationListView.Location = new System.Drawing.Point(30, 432);
            this.patientInformationListView.Name = "patientInformationListView";
            this.patientInformationListView.Size = new System.Drawing.Size(871, 173);
            this.patientInformationListView.TabIndex = 7;
            this.patientInformationListView.TabStop = false;
            this.patientInformationListView.UseCompatibleStateImageBehavior = false;
            this.patientInformationListView.View = System.Windows.Forms.View.Details;
            // 
            // listViewInfoLabel
            // 
            this.listViewInfoLabel.AutoSize = true;
            this.listViewInfoLabel.Location = new System.Drawing.Point(67, 412);
            this.listViewInfoLabel.Name = "listViewInfoLabel";
            this.listViewInfoLabel.Size = new System.Drawing.Size(490, 17);
            this.listViewInfoLabel.TabIndex = 8;
            this.listViewInfoLabel.Text = "*Below is a ListView. ListViews work a lot better than ListBoxes for formatting.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(30, 346);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(215, 30);
            this.chooseFileButton.TabIndex = 0;
            this.chooseFileButton.Text = "Choose &File";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fileLabel.Location = new System.Drawing.Point(251, 346);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(197, 30);
            this.fileLabel.TabIndex = 10;
            this.fileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.displayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(936, 720);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.chooseFileButton);
            this.Controls.Add(this.listViewInfoLabel);
            this.Controls.Add(this.patientInformationListView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.physicianOutputDescriptionLabel);
            this.Controls.Add(this.statusOutputDescriptionLabel);
            this.Controls.Add(this.avgDiastolicOutputDescriptionLabel);
            this.Controls.Add(this.avgSystolicOutputDescriptionLabel);
            this.Controls.Add(this.patientNameOutputDescriptionLabel);
            this.Controls.Add(this.patientInformationListBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Pressure Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox patientInformationListBox;
        private System.Windows.Forms.Label patientNameOutputDescriptionLabel;
        private System.Windows.Forms.Label avgSystolicOutputDescriptionLabel;
        private System.Windows.Forms.Label avgDiastolicOutputDescriptionLabel;
        private System.Windows.Forms.Label statusOutputDescriptionLabel;
        private System.Windows.Forms.Label physicianOutputDescriptionLabel;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListView patientInformationListView;
        private System.Windows.Forms.Label listViewInfoLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Label fileLabel;
    }
}

