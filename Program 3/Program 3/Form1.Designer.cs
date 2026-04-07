namespace Program_3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.provCombo = new System.Windows.Forms.ComboBox();
            this.busCombo = new System.Windows.Forms.ComboBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.providerLabel = new System.Windows.Forms.Label();
            this.contractPriceLabel = new System.Windows.Forms.Label();
            this.companyDiscountLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.lengthDiscountLabel = new System.Windows.Forms.Label();
            this.contLengthTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provider:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Business:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contract Length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Shopping Contract Calculator";
            // 
            // provCombo
            // 
            this.provCombo.FormattingEnabled = true;
            this.provCombo.Items.AddRange(new object[] {
            "USPS",
            "DHL",
            "FedEx",
            "UPS"});
            this.provCombo.Location = new System.Drawing.Point(339, 90);
            this.provCombo.Name = "provCombo";
            this.provCombo.Size = new System.Drawing.Size(208, 33);
            this.provCombo.TabIndex = 4;
            // 
            // busCombo
            // 
            this.busCombo.FormattingEnabled = true;
            this.busCombo.Items.AddRange(new object[] {
            "John’s Books",
            "Office Supplies",
            "J.B\'s Car Parts",
            "Gevalia Coffee",
            "Ceylon Tea",
            "My Footwear "});
            this.busCombo.Location = new System.Drawing.Point(339, 151);
            this.busCombo.Name = "busCombo";
            this.busCombo.Size = new System.Drawing.Size(208, 33);
            this.busCombo.TabIndex = 6;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(333, 280);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(214, 34);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Shipping Provider";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Length Discount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Company Discount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "First Contract Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 591);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total Cost:";
            // 
            // providerLabel
            // 
            this.providerLabel.AutoSize = true;
            this.providerLabel.Location = new System.Drawing.Point(369, 359);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(0, 25);
            this.providerLabel.TabIndex = 13;
            // 
            // contractPriceLabel
            // 
            this.contractPriceLabel.AutoSize = true;
            this.contractPriceLabel.Location = new System.Drawing.Point(369, 409);
            this.contractPriceLabel.Name = "contractPriceLabel";
            this.contractPriceLabel.Size = new System.Drawing.Size(0, 25);
            this.contractPriceLabel.TabIndex = 14;
            // 
            // companyDiscountLabel
            // 
            this.companyDiscountLabel.AutoSize = true;
            this.companyDiscountLabel.Location = new System.Drawing.Point(369, 470);
            this.companyDiscountLabel.Name = "companyDiscountLabel";
            this.companyDiscountLabel.Size = new System.Drawing.Size(0, 25);
            this.companyDiscountLabel.TabIndex = 15;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(369, 591);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(0, 25);
            this.totalCostLabel.TabIndex = 16;
            // 
            // lengthDiscountLabel
            // 
            this.lengthDiscountLabel.AutoSize = true;
            this.lengthDiscountLabel.Location = new System.Drawing.Point(369, 537);
            this.lengthDiscountLabel.Name = "lengthDiscountLabel";
            this.lengthDiscountLabel.Size = new System.Drawing.Size(0, 25);
            this.lengthDiscountLabel.TabIndex = 17;
            // 
            // contLengthTB
            // 
            this.contLengthTB.Location = new System.Drawing.Point(339, 217);
            this.contLengthTB.Name = "contLengthTB";
            this.contLengthTB.Size = new System.Drawing.Size(208, 31);
            this.contLengthTB.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 986);
            this.Controls.Add(this.contLengthTB);
            this.Controls.Add(this.lengthDiscountLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.companyDiscountLabel);
            this.Controls.Add(this.contractPriceLabel);
            this.Controls.Add(this.providerLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.busCombo);
            this.Controls.Add(this.provCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Contract Calculator ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox provCombo;
        private System.Windows.Forms.ComboBox busCombo;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label providerLabel;
        private System.Windows.Forms.Label contractPriceLabel;
        private System.Windows.Forms.Label companyDiscountLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label lengthDiscountLabel;
        private System.Windows.Forms.TextBox contLengthTB;
    }
}

