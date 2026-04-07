namespace Program2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxHealth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCar = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NoButton = new System.Windows.Forms.RadioButton();
            this.YesButtonSmoke = new System.Windows.Forms.RadioButton();
            this.ageText = new System.Windows.Forms.TextBox();
            this.valueText = new System.Windows.Forms.TextBox();
            this.carAccidentGB = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.YesButtonAccident = new System.Windows.Forms.RadioButton();
            this.CalcButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.healthCovYear = new System.Windows.Forms.Label();
            this.carCovPerYear = new System.Windows.Forms.Label();
            this.EndingTotalCost = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.carAccidentGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estimated Value of Car:";
            // 
            // comboBoxHealth
            // 
            this.comboBoxHealth.FormattingEnabled = true;
            this.comboBoxHealth.Items.AddRange(new object[] {
            "Medical",
            "Dental",
            "Vision"});
            this.comboBoxHealth.Location = new System.Drawing.Point(656, 306);
            this.comboBoxHealth.Name = "comboBoxHealth";
            this.comboBoxHealth.Size = new System.Drawing.Size(121, 33);
            this.comboBoxHealth.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Health Insurance Coverage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Car Insurance Coverage:";
            // 
            // comboBoxCar
            // 
            this.comboBoxCar.FormattingEnabled = true;
            this.comboBoxCar.Items.AddRange(new object[] {
            "Full",
            "Liability"});
            this.comboBoxCar.Location = new System.Drawing.Point(656, 363);
            this.comboBoxCar.Name = "comboBoxCar";
            this.comboBoxCar.Size = new System.Drawing.Size(121, 33);
            this.comboBoxCar.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoButton);
            this.groupBox1.Controls.Add(this.YesButtonSmoke);
            this.groupBox1.Location = new System.Drawing.Point(333, 438);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 106);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Do You Smoke?";
            // 
            // NoButton
            // 
            this.NoButton.AutoSize = true;
            this.NoButton.Location = new System.Drawing.Point(283, 35);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(70, 29);
            this.NoButton.TabIndex = 1;
            this.NoButton.TabStop = true;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            // 
            // YesButtonSmoke
            // 
            this.YesButtonSmoke.AutoSize = true;
            this.YesButtonSmoke.Location = new System.Drawing.Point(272, 0);
            this.YesButtonSmoke.Name = "YesButtonSmoke";
            this.YesButtonSmoke.Size = new System.Drawing.Size(81, 29);
            this.YesButtonSmoke.TabIndex = 0;
            this.YesButtonSmoke.TabStop = true;
            this.YesButtonSmoke.Text = "Yes";
            this.YesButtonSmoke.UseVisualStyleBackColor = true;
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(656, 170);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(100, 31);
            this.ageText.TabIndex = 7;
            // 
            // valueText
            // 
            this.valueText.Location = new System.Drawing.Point(656, 244);
            this.valueText.Name = "valueText";
            this.valueText.Size = new System.Drawing.Size(100, 31);
            this.valueText.TabIndex = 8;
            // 
            // carAccidentGB
            // 
            this.carAccidentGB.Controls.Add(this.radioButton1);
            this.carAccidentGB.Controls.Add(this.YesButtonAccident);
            this.carAccidentGB.Location = new System.Drawing.Point(274, 550);
            this.carAccidentGB.Name = "carAccidentGB";
            this.carAccidentGB.Size = new System.Drawing.Size(503, 106);
            this.carAccidentGB.TabIndex = 7;
            this.carAccidentGB.TabStop = false;
            this.carAccidentGB.Text = "Car Accident in the Past Year?";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(324, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 29);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "No";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // YesButtonAccident
            // 
            this.YesButtonAccident.AutoSize = true;
            this.YesButtonAccident.Location = new System.Drawing.Point(324, 0);
            this.YesButtonAccident.Name = "YesButtonAccident";
            this.YesButtonAccident.Size = new System.Drawing.Size(81, 29);
            this.YesButtonAccident.TabIndex = 0;
            this.YesButtonAccident.TabStop = true;
            this.YesButtonAccident.Text = "Yes";
            this.YesButtonAccident.UseVisualStyleBackColor = true;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(455, 681);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(322, 36);
            this.CalcButton.TabIndex = 9;
            this.CalcButton.Text = "Calculate Policy Premuims";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 775);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Health Coverage Cost Per Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 844);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Car Coverage Cost Per Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 913);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total Cost Per Year";
            // 
            // healthCovYear
            // 
            this.healthCovYear.AutoSize = true;
            this.healthCovYear.Location = new System.Drawing.Point(663, 775);
            this.healthCovYear.Name = "healthCovYear";
            this.healthCovYear.Size = new System.Drawing.Size(70, 25);
            this.healthCovYear.TabIndex = 13;
            this.healthCovYear.Text = "label8";
            // 
            // carCovPerYear
            // 
            this.carCovPerYear.AutoSize = true;
            this.carCovPerYear.Location = new System.Drawing.Point(663, 844);
            this.carCovPerYear.Name = "carCovPerYear";
            this.carCovPerYear.Size = new System.Drawing.Size(70, 25);
            this.carCovPerYear.TabIndex = 14;
            this.carCovPerYear.Text = "label8";
            // 
            // EndingTotalCost
            // 
            this.EndingTotalCost.AutoSize = true;
            this.EndingTotalCost.Location = new System.Drawing.Point(663, 913);
            this.EndingTotalCost.Name = "EndingTotalCost";
            this.EndingTotalCost.Size = new System.Drawing.Size(70, 25);
            this.EndingTotalCost.TabIndex = 15;
            this.EndingTotalCost.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 1140);
            this.Controls.Add(this.EndingTotalCost);
            this.Controls.Add(this.carCovPerYear);
            this.Controls.Add(this.healthCovYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.carAccidentGB);
            this.Controls.Add(this.valueText);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxHealth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.carAccidentGB.ResumeLayout(false);
            this.carAccidentGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxHealth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NoButton;
        private System.Windows.Forms.RadioButton YesButtonSmoke;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.TextBox valueText;
        private System.Windows.Forms.GroupBox carAccidentGB;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton YesButtonAccident;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label healthCovYear;
        private System.Windows.Forms.Label carCovPerYear;
        private System.Windows.Forms.Label EndingTotalCost;
    }
}

