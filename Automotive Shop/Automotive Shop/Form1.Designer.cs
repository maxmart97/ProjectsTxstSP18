namespace Automotive_Shop
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
            this.oilAndLubeGroupBox = new System.Windows.Forms.GroupBox();
            this.oilTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.syntheticOilRadioButton = new System.Windows.Forms.RadioButton();
            this.mixedOilRadioButton = new System.Windows.Forms.RadioButton();
            this.regularOilRadioButton = new System.Windows.Forms.RadioButton();
            this.lubeJobCheckBox = new System.Windows.Forms.CheckBox();
            this.oilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.flushesGroupBox = new System.Windows.Forms.GroupBox();
            this.transmissionFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.miscGroupBox = new System.Windows.Forms.GroupBox();
            this.tireRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceMufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.partsAndLaborGroupBox = new System.Windows.Forms.GroupBox();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.laborPromptLabel = new System.Windows.Forms.Label();
            this.partsPromptLabel = new System.Windows.Forms.Label();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.totalChargesLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.serviceAndLaborLabel = new System.Windows.Forms.Label();
            this.totalOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.taxOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.partsOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.serviceAndLaborOutputDescriptionLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.carwashGroupBox = new System.Windows.Forms.GroupBox();
            this.premiumCarwashRadioButton = new System.Windows.Forms.RadioButton();
            this.fullServiceCarwashRadioButton = new System.Windows.Forms.RadioButton();
            this.compCarwashRadioButton = new System.Windows.Forms.RadioButton();
            this.noCarwashRadioButton = new System.Windows.Forms.RadioButton();
            this.oilAndLubeGroupBox.SuspendLayout();
            this.oilTypeGroupBox.SuspendLayout();
            this.flushesGroupBox.SuspendLayout();
            this.miscGroupBox.SuspendLayout();
            this.partsAndLaborGroupBox.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            this.carwashGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilAndLubeGroupBox
            // 
            this.oilAndLubeGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.oilAndLubeGroupBox.Controls.Add(this.oilTypeGroupBox);
            this.oilAndLubeGroupBox.Controls.Add(this.lubeJobCheckBox);
            this.oilAndLubeGroupBox.Controls.Add(this.oilChangeCheckBox);
            this.oilAndLubeGroupBox.ForeColor = System.Drawing.Color.Black;
            this.oilAndLubeGroupBox.Location = new System.Drawing.Point(106, 38);
            this.oilAndLubeGroupBox.Name = "oilAndLubeGroupBox";
            this.oilAndLubeGroupBox.Size = new System.Drawing.Size(234, 254);
            this.oilAndLubeGroupBox.TabIndex = 0;
            this.oilAndLubeGroupBox.TabStop = false;
            this.oilAndLubeGroupBox.Text = "Oil and Lube";
            // 
            // oilTypeGroupBox
            // 
            this.oilTypeGroupBox.Controls.Add(this.syntheticOilRadioButton);
            this.oilTypeGroupBox.Controls.Add(this.mixedOilRadioButton);
            this.oilTypeGroupBox.Controls.Add(this.regularOilRadioButton);
            this.oilTypeGroupBox.ForeColor = System.Drawing.Color.Black;
            this.oilTypeGroupBox.Location = new System.Drawing.Point(15, 59);
            this.oilTypeGroupBox.Name = "oilTypeGroupBox";
            this.oilTypeGroupBox.Size = new System.Drawing.Size(200, 148);
            this.oilTypeGroupBox.TabIndex = 7;
            this.oilTypeGroupBox.TabStop = false;
            this.oilTypeGroupBox.Text = "Oil Type";
            // 
            // syntheticOilRadioButton
            // 
            this.syntheticOilRadioButton.AutoSize = true;
            this.syntheticOilRadioButton.Enabled = false;
            this.syntheticOilRadioButton.Location = new System.Drawing.Point(20, 95);
            this.syntheticOilRadioButton.Name = "syntheticOilRadioButton";
            this.syntheticOilRadioButton.Size = new System.Drawing.Size(171, 21);
            this.syntheticOilRadioButton.TabIndex = 9;
            this.syntheticOilRadioButton.Text = "Full Synthetic ($20.00)";
            this.syntheticOilRadioButton.UseVisualStyleBackColor = true;
            // 
            // mixedOilRadioButton
            // 
            this.mixedOilRadioButton.AutoSize = true;
            this.mixedOilRadioButton.Enabled = false;
            this.mixedOilRadioButton.ForeColor = System.Drawing.Color.Black;
            this.mixedOilRadioButton.Location = new System.Drawing.Point(20, 68);
            this.mixedOilRadioButton.Name = "mixedOilRadioButton";
            this.mixedOilRadioButton.Size = new System.Drawing.Size(123, 21);
            this.mixedOilRadioButton.TabIndex = 8;
            this.mixedOilRadioButton.Text = "Mixed ($10.00)";
            this.mixedOilRadioButton.UseVisualStyleBackColor = true;
            // 
            // regularOilRadioButton
            // 
            this.regularOilRadioButton.AutoSize = true;
            this.regularOilRadioButton.Checked = true;
            this.regularOilRadioButton.Enabled = false;
            this.regularOilRadioButton.ForeColor = System.Drawing.Color.Black;
            this.regularOilRadioButton.Location = new System.Drawing.Point(20, 41);
            this.regularOilRadioButton.Name = "regularOilRadioButton";
            this.regularOilRadioButton.Size = new System.Drawing.Size(129, 21);
            this.regularOilRadioButton.TabIndex = 7;
            this.regularOilRadioButton.TabStop = true;
            this.regularOilRadioButton.Text = "Regular ($0.00)";
            this.regularOilRadioButton.UseVisualStyleBackColor = true;
            // 
            // lubeJobCheckBox
            // 
            this.lubeJobCheckBox.AutoSize = true;
            this.lubeJobCheckBox.Location = new System.Drawing.Point(15, 213);
            this.lubeJobCheckBox.Name = "lubeJobCheckBox";
            this.lubeJobCheckBox.Size = new System.Drawing.Size(143, 21);
            this.lubeJobCheckBox.TabIndex = 6;
            this.lubeJobCheckBox.Text = "Lube job ($18.00)";
            this.lubeJobCheckBox.UseVisualStyleBackColor = true;
            // 
            // oilChangeCheckBox
            // 
            this.oilChangeCheckBox.AutoSize = true;
            this.oilChangeCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.oilChangeCheckBox.ForeColor = System.Drawing.Color.Black;
            this.oilChangeCheckBox.Location = new System.Drawing.Point(15, 32);
            this.oilChangeCheckBox.Name = "oilChangeCheckBox";
            this.oilChangeCheckBox.Size = new System.Drawing.Size(158, 21);
            this.oilChangeCheckBox.TabIndex = 5;
            this.oilChangeCheckBox.Text = "Oil Change ($26.00)";
            this.oilChangeCheckBox.UseVisualStyleBackColor = false;
            this.oilChangeCheckBox.CheckedChanged += new System.EventHandler(this.oilChangeCheckBox_CheckedChanged);
            // 
            // flushesGroupBox
            // 
            this.flushesGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.flushesGroupBox.Controls.Add(this.transmissionFlushCheckBox);
            this.flushesGroupBox.Controls.Add(this.radiatorFlushCheckBox);
            this.flushesGroupBox.ForeColor = System.Drawing.Color.Black;
            this.flushesGroupBox.Location = new System.Drawing.Point(383, 192);
            this.flushesGroupBox.Name = "flushesGroupBox";
            this.flushesGroupBox.Size = new System.Drawing.Size(239, 100);
            this.flushesGroupBox.TabIndex = 2;
            this.flushesGroupBox.TabStop = false;
            this.flushesGroupBox.Text = "Flushes";
            // 
            // transmissionFlushCheckBox
            // 
            this.transmissionFlushCheckBox.AutoSize = true;
            this.transmissionFlushCheckBox.Location = new System.Drawing.Point(17, 59);
            this.transmissionFlushCheckBox.Name = "transmissionFlushCheckBox";
            this.transmissionFlushCheckBox.Size = new System.Drawing.Size(210, 21);
            this.transmissionFlushCheckBox.TabIndex = 6;
            this.transmissionFlushCheckBox.Text = "Transmission Flush ($80.00)";
            this.transmissionFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // radiatorFlushCheckBox
            // 
            this.radiatorFlushCheckBox.AutoSize = true;
            this.radiatorFlushCheckBox.Location = new System.Drawing.Point(17, 32);
            this.radiatorFlushCheckBox.Name = "radiatorFlushCheckBox";
            this.radiatorFlushCheckBox.Size = new System.Drawing.Size(180, 21);
            this.radiatorFlushCheckBox.TabIndex = 5;
            this.radiatorFlushCheckBox.Text = "Radiator Flush ($30.00)";
            this.radiatorFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // miscGroupBox
            // 
            this.miscGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.miscGroupBox.Controls.Add(this.tireRotationCheckBox);
            this.miscGroupBox.Controls.Add(this.replaceMufflerCheckBox);
            this.miscGroupBox.Controls.Add(this.inspectionCheckBox);
            this.miscGroupBox.ForeColor = System.Drawing.Color.Black;
            this.miscGroupBox.Location = new System.Drawing.Point(106, 298);
            this.miscGroupBox.Name = "miscGroupBox";
            this.miscGroupBox.Size = new System.Drawing.Size(234, 118);
            this.miscGroupBox.TabIndex = 3;
            this.miscGroupBox.TabStop = false;
            this.miscGroupBox.Text = "Misc";
            // 
            // tireRotationCheckBox
            // 
            this.tireRotationCheckBox.AutoSize = true;
            this.tireRotationCheckBox.Location = new System.Drawing.Point(15, 84);
            this.tireRotationCheckBox.Name = "tireRotationCheckBox";
            this.tireRotationCheckBox.Size = new System.Drawing.Size(170, 21);
            this.tireRotationCheckBox.TabIndex = 2;
            this.tireRotationCheckBox.Text = "Tire Rotation ($20.00)";
            this.tireRotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // replaceMufflerCheckBox
            // 
            this.replaceMufflerCheckBox.AutoSize = true;
            this.replaceMufflerCheckBox.Location = new System.Drawing.Point(15, 57);
            this.replaceMufflerCheckBox.Name = "replaceMufflerCheckBox";
            this.replaceMufflerCheckBox.Size = new System.Drawing.Size(195, 21);
            this.replaceMufflerCheckBox.TabIndex = 1;
            this.replaceMufflerCheckBox.Text = "Replace Muffler ($100.00)";
            this.replaceMufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(15, 30);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(152, 21);
            this.inspectionCheckBox.TabIndex = 0;
            this.inspectionCheckBox.Text = "Inspection ($15.00)";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // partsAndLaborGroupBox
            // 
            this.partsAndLaborGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.partsAndLaborGroupBox.Controls.Add(this.laborTextBox);
            this.partsAndLaborGroupBox.Controls.Add(this.partsTextBox);
            this.partsAndLaborGroupBox.Controls.Add(this.laborPromptLabel);
            this.partsAndLaborGroupBox.Controls.Add(this.partsPromptLabel);
            this.partsAndLaborGroupBox.ForeColor = System.Drawing.Color.Black;
            this.partsAndLaborGroupBox.Location = new System.Drawing.Point(383, 298);
            this.partsAndLaborGroupBox.Name = "partsAndLaborGroupBox";
            this.partsAndLaborGroupBox.Size = new System.Drawing.Size(239, 118);
            this.partsAndLaborGroupBox.TabIndex = 4;
            this.partsAndLaborGroupBox.TabStop = false;
            this.partsAndLaborGroupBox.Text = "Parts and Labor";
            // 
            // laborTextBox
            // 
            this.laborTextBox.BackColor = System.Drawing.Color.White;
            this.laborTextBox.ForeColor = System.Drawing.Color.Black;
            this.laborTextBox.Location = new System.Drawing.Point(122, 67);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(75, 22);
            this.laborTextBox.TabIndex = 6;
            // 
            // partsTextBox
            // 
            this.partsTextBox.BackColor = System.Drawing.Color.White;
            this.partsTextBox.ForeColor = System.Drawing.Color.Black;
            this.partsTextBox.Location = new System.Drawing.Point(122, 29);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(75, 22);
            this.partsTextBox.TabIndex = 5;
            // 
            // laborPromptLabel
            // 
            this.laborPromptLabel.AutoSize = true;
            this.laborPromptLabel.Location = new System.Drawing.Point(21, 72);
            this.laborPromptLabel.Name = "laborPromptLabel";
            this.laborPromptLabel.Size = new System.Drawing.Size(81, 17);
            this.laborPromptLabel.TabIndex = 1;
            this.laborPromptLabel.Text = "Labor (Hrs)";
            // 
            // partsPromptLabel
            // 
            this.partsPromptLabel.AutoSize = true;
            this.partsPromptLabel.Location = new System.Drawing.Point(39, 32);
            this.partsPromptLabel.Name = "partsPromptLabel";
            this.partsPromptLabel.Size = new System.Drawing.Size(63, 17);
            this.partsPromptLabel.TabIndex = 0;
            this.partsPromptLabel.Text = "Parts ($)";
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.summaryGroupBox.Controls.Add(this.totalChargesLabel);
            this.summaryGroupBox.Controls.Add(this.taxLabel);
            this.summaryGroupBox.Controls.Add(this.partsLabel);
            this.summaryGroupBox.Controls.Add(this.serviceAndLaborLabel);
            this.summaryGroupBox.Controls.Add(this.totalOutputDescriptionLabel);
            this.summaryGroupBox.Controls.Add(this.taxOutputDescriptionLabel);
            this.summaryGroupBox.Controls.Add(this.partsOutputDescriptionLabel);
            this.summaryGroupBox.Controls.Add(this.serviceAndLaborOutputDescriptionLabel);
            this.summaryGroupBox.ForeColor = System.Drawing.Color.Black;
            this.summaryGroupBox.Location = new System.Drawing.Point(126, 422);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(479, 213);
            this.summaryGroupBox.TabIndex = 1;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary";
            // 
            // totalChargesLabel
            // 
            this.totalChargesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalChargesLabel.Location = new System.Drawing.Point(185, 155);
            this.totalChargesLabel.Name = "totalChargesLabel";
            this.totalChargesLabel.Size = new System.Drawing.Size(157, 28);
            this.totalChargesLabel.TabIndex = 7;
            this.totalChargesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxLabel
            // 
            this.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxLabel.Location = new System.Drawing.Point(185, 111);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(157, 28);
            this.taxLabel.TabIndex = 6;
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // partsLabel
            // 
            this.partsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partsLabel.Location = new System.Drawing.Point(185, 74);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(157, 28);
            this.partsLabel.TabIndex = 5;
            this.partsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serviceAndLaborLabel
            // 
            this.serviceAndLaborLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serviceAndLaborLabel.Location = new System.Drawing.Point(185, 37);
            this.serviceAndLaborLabel.Name = "serviceAndLaborLabel";
            this.serviceAndLaborLabel.Size = new System.Drawing.Size(157, 28);
            this.serviceAndLaborLabel.TabIndex = 4;
            this.serviceAndLaborLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalOutputDescriptionLabel
            // 
            this.totalOutputDescriptionLabel.AutoSize = true;
            this.totalOutputDescriptionLabel.Location = new System.Drawing.Point(76, 166);
            this.totalOutputDescriptionLabel.Name = "totalOutputDescriptionLabel";
            this.totalOutputDescriptionLabel.Size = new System.Drawing.Size(97, 17);
            this.totalOutputDescriptionLabel.TabIndex = 3;
            this.totalOutputDescriptionLabel.Text = "Total Charges";
            // 
            // taxOutputDescriptionLabel
            // 
            this.taxOutputDescriptionLabel.AutoSize = true;
            this.taxOutputDescriptionLabel.Location = new System.Drawing.Point(76, 122);
            this.taxOutputDescriptionLabel.Name = "taxOutputDescriptionLabel";
            this.taxOutputDescriptionLabel.Size = new System.Drawing.Size(97, 17);
            this.taxOutputDescriptionLabel.TabIndex = 2;
            this.taxOutputDescriptionLabel.Text = "Tax (on parts)";
            // 
            // partsOutputDescriptionLabel
            // 
            this.partsOutputDescriptionLabel.AutoSize = true;
            this.partsOutputDescriptionLabel.Location = new System.Drawing.Point(126, 85);
            this.partsOutputDescriptionLabel.Name = "partsOutputDescriptionLabel";
            this.partsOutputDescriptionLabel.Size = new System.Drawing.Size(41, 17);
            this.partsOutputDescriptionLabel.TabIndex = 1;
            this.partsOutputDescriptionLabel.Text = "Parts";
            // 
            // serviceAndLaborOutputDescriptionLabel
            // 
            this.serviceAndLaborOutputDescriptionLabel.AutoSize = true;
            this.serviceAndLaborOutputDescriptionLabel.Location = new System.Drawing.Point(43, 48);
            this.serviceAndLaborOutputDescriptionLabel.Name = "serviceAndLaborOutputDescriptionLabel";
            this.serviceAndLaborOutputDescriptionLabel.Size = new System.Drawing.Size(124, 17);
            this.serviceAndLaborOutputDescriptionLabel.TabIndex = 0;
            this.serviceAndLaborOutputDescriptionLabel.Text = "Service and Labor";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.Control;
            this.calculateButton.ForeColor = System.Drawing.Color.Black;
            this.calculateButton.Location = new System.Drawing.Point(126, 659);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(105, 43);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.Control;
            this.clearButton.ForeColor = System.Drawing.Color.Black;
            this.clearButton.Location = new System.Drawing.Point(313, 659);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(105, 43);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.Control;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(500, 659);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 43);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // carwashGroupBox
            // 
            this.carwashGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.carwashGroupBox.Controls.Add(this.premiumCarwashRadioButton);
            this.carwashGroupBox.Controls.Add(this.fullServiceCarwashRadioButton);
            this.carwashGroupBox.Controls.Add(this.compCarwashRadioButton);
            this.carwashGroupBox.Controls.Add(this.noCarwashRadioButton);
            this.carwashGroupBox.ForeColor = System.Drawing.Color.Black;
            this.carwashGroupBox.Location = new System.Drawing.Point(383, 38);
            this.carwashGroupBox.Name = "carwashGroupBox";
            this.carwashGroupBox.Size = new System.Drawing.Size(239, 148);
            this.carwashGroupBox.TabIndex = 1;
            this.carwashGroupBox.TabStop = false;
            this.carwashGroupBox.Text = "Carwash";
            // 
            // premiumCarwashRadioButton
            // 
            this.premiumCarwashRadioButton.AutoSize = true;
            this.premiumCarwashRadioButton.Location = new System.Drawing.Point(17, 112);
            this.premiumCarwashRadioButton.Name = "premiumCarwashRadioButton";
            this.premiumCarwashRadioButton.Size = new System.Drawing.Size(134, 21);
            this.premiumCarwashRadioButton.TabIndex = 11;
            this.premiumCarwashRadioButton.Text = "Premium ($9.00)";
            this.premiumCarwashRadioButton.UseVisualStyleBackColor = true;
            // 
            // fullServiceCarwashRadioButton
            // 
            this.fullServiceCarwashRadioButton.AutoSize = true;
            this.fullServiceCarwashRadioButton.Location = new System.Drawing.Point(17, 85);
            this.fullServiceCarwashRadioButton.Name = "fullServiceCarwashRadioButton";
            this.fullServiceCarwashRadioButton.Size = new System.Drawing.Size(152, 21);
            this.fullServiceCarwashRadioButton.TabIndex = 10;
            this.fullServiceCarwashRadioButton.Text = "Full Service ($6.00)";
            this.fullServiceCarwashRadioButton.UseVisualStyleBackColor = true;
            // 
            // compCarwashRadioButton
            // 
            this.compCarwashRadioButton.AutoSize = true;
            this.compCarwashRadioButton.Location = new System.Drawing.Point(17, 58);
            this.compCarwashRadioButton.Name = "compCarwashRadioButton";
            this.compCarwashRadioButton.Size = new System.Drawing.Size(172, 21);
            this.compCarwashRadioButton.TabIndex = 9;
            this.compCarwashRadioButton.Text = "Complimentary ($0.00)";
            this.compCarwashRadioButton.UseVisualStyleBackColor = true;
            // 
            // noCarwashRadioButton
            // 
            this.noCarwashRadioButton.AutoSize = true;
            this.noCarwashRadioButton.Checked = true;
            this.noCarwashRadioButton.Location = new System.Drawing.Point(17, 31);
            this.noCarwashRadioButton.Name = "noCarwashRadioButton";
            this.noCarwashRadioButton.Size = new System.Drawing.Size(63, 21);
            this.noCarwashRadioButton.TabIndex = 8;
            this.noCarwashRadioButton.TabStop = true;
            this.noCarwashRadioButton.Text = "None";
            this.noCarwashRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(728, 730);
            this.Controls.Add(this.carwashGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.partsAndLaborGroupBox);
            this.Controls.Add(this.miscGroupBox);
            this.Controls.Add(this.flushesGroupBox);
            this.Controls.Add(this.oilAndLubeGroupBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automotive Shop";
            this.oilAndLubeGroupBox.ResumeLayout(false);
            this.oilAndLubeGroupBox.PerformLayout();
            this.oilTypeGroupBox.ResumeLayout(false);
            this.oilTypeGroupBox.PerformLayout();
            this.flushesGroupBox.ResumeLayout(false);
            this.flushesGroupBox.PerformLayout();
            this.miscGroupBox.ResumeLayout(false);
            this.miscGroupBox.PerformLayout();
            this.partsAndLaborGroupBox.ResumeLayout(false);
            this.partsAndLaborGroupBox.PerformLayout();
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.carwashGroupBox.ResumeLayout(false);
            this.carwashGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilAndLubeGroupBox;
        private System.Windows.Forms.CheckBox lubeJobCheckBox;
        private System.Windows.Forms.CheckBox oilChangeCheckBox;
        private System.Windows.Forms.GroupBox flushesGroupBox;
        private System.Windows.Forms.CheckBox transmissionFlushCheckBox;
        private System.Windows.Forms.CheckBox radiatorFlushCheckBox;
        private System.Windows.Forms.GroupBox miscGroupBox;
        private System.Windows.Forms.CheckBox tireRotationCheckBox;
        private System.Windows.Forms.CheckBox replaceMufflerCheckBox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.GroupBox partsAndLaborGroupBox;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.Label laborPromptLabel;
        private System.Windows.Forms.Label partsPromptLabel;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalChargesLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label serviceAndLaborLabel;
        private System.Windows.Forms.Label totalOutputDescriptionLabel;
        private System.Windows.Forms.Label taxOutputDescriptionLabel;
        private System.Windows.Forms.Label partsOutputDescriptionLabel;
        private System.Windows.Forms.Label serviceAndLaborOutputDescriptionLabel;
        private System.Windows.Forms.GroupBox oilTypeGroupBox;
        private System.Windows.Forms.RadioButton syntheticOilRadioButton;
        private System.Windows.Forms.RadioButton mixedOilRadioButton;
        private System.Windows.Forms.RadioButton regularOilRadioButton;
        private System.Windows.Forms.GroupBox carwashGroupBox;
        private System.Windows.Forms.RadioButton premiumCarwashRadioButton;
        private System.Windows.Forms.RadioButton fullServiceCarwashRadioButton;
        private System.Windows.Forms.RadioButton compCarwashRadioButton;
        private System.Windows.Forms.RadioButton noCarwashRadioButton;
    }

}

