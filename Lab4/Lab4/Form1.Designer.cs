namespace Lab4
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
            this.testScore = new System.Windows.Forms.Label();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.textBoxGPA = new System.Windows.Forms.TextBox();
            this.textBoxTestScore = new System.Windows.Forms.TextBox();
            this.acceptedStatic = new System.Windows.Forms.Label();
            this.rejectedStatic = new System.Windows.Forms.Label();
            this.acceptedDyanmic = new System.Windows.Forms.Label();
            this.rejectedDyanmic = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testScore
            // 
            this.testScore.AutoSize = true;
            this.testScore.Location = new System.Drawing.Point(151, 174);
            this.testScore.Name = "testScore";
            this.testScore.Size = new System.Drawing.Size(122, 25);
            this.testScore.TabIndex = 0;
            this.testScore.Text = "Test Score:";
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(211, 111);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(62, 25);
            this.gpaLabel.TabIndex = 1;
            this.gpaLabel.Text = "GPA:";
            // 
            // textBoxGPA
            // 
            this.textBoxGPA.Location = new System.Drawing.Point(312, 108);
            this.textBoxGPA.Name = "textBoxGPA";
            this.textBoxGPA.Size = new System.Drawing.Size(100, 31);
            this.textBoxGPA.TabIndex = 2;
            // 
            // textBoxTestScore
            // 
            this.textBoxTestScore.Location = new System.Drawing.Point(312, 174);
            this.textBoxTestScore.Name = "textBoxTestScore";
            this.textBoxTestScore.Size = new System.Drawing.Size(100, 31);
            this.textBoxTestScore.TabIndex = 3;
            // 
            // acceptedStatic
            // 
            this.acceptedStatic.AutoSize = true;
            this.acceptedStatic.Location = new System.Drawing.Point(516, 108);
            this.acceptedStatic.Name = "acceptedStatic";
            this.acceptedStatic.Size = new System.Drawing.Size(108, 25);
            this.acceptedStatic.TabIndex = 4;
            this.acceptedStatic.Text = "Accepted:";
            // 
            // rejectedStatic
            // 
            this.rejectedStatic.AutoSize = true;
            this.rejectedStatic.Location = new System.Drawing.Point(516, 174);
            this.rejectedStatic.Name = "rejectedStatic";
            this.rejectedStatic.Size = new System.Drawing.Size(103, 25);
            this.rejectedStatic.TabIndex = 5;
            this.rejectedStatic.Text = "Rejected:";
            // 
            // acceptedDyanmic
            // 
            this.acceptedDyanmic.AutoSize = true;
            this.acceptedDyanmic.Location = new System.Drawing.Point(677, 108);
            this.acceptedDyanmic.Name = "acceptedDyanmic";
            this.acceptedDyanmic.Size = new System.Drawing.Size(0, 25);
            this.acceptedDyanmic.TabIndex = 6;
            // 
            // rejectedDyanmic
            // 
            this.rejectedDyanmic.AutoSize = true;
            this.rejectedDyanmic.Location = new System.Drawing.Point(677, 180);
            this.rejectedDyanmic.Name = "rejectedDyanmic";
            this.rejectedDyanmic.Size = new System.Drawing.Size(0, 25);
            this.rejectedDyanmic.TabIndex = 7;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(266, 287);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(146, 36);
            this.CalcButton.TabIndex = 8;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(290, 237);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 25);
            this.resultLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 621);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.rejectedDyanmic);
            this.Controls.Add(this.acceptedDyanmic);
            this.Controls.Add(this.rejectedStatic);
            this.Controls.Add(this.acceptedStatic);
            this.Controls.Add(this.textBoxTestScore);
            this.Controls.Add(this.textBoxGPA);
            this.Controls.Add(this.gpaLabel);
            this.Controls.Add(this.testScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testScore;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.TextBox textBoxGPA;
        private System.Windows.Forms.TextBox textBoxTestScore;
        private System.Windows.Forms.Label acceptedStatic;
        private System.Windows.Forms.Label rejectedStatic;
        private System.Windows.Forms.Label acceptedDyanmic;
        private System.Windows.Forms.Label rejectedDyanmic;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

