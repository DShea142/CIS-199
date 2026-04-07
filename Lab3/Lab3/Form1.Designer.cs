namespace Lab3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PBTopRight = new System.Windows.Forms.PictureBox();
            this.PBottomLeft = new System.Windows.Forms.PictureBox();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.DiameterStatic = new System.Windows.Forms.Label();
            this.DiameterDynamic = new System.Windows.Forms.Label();
            this.SurfaceAreaStatic = new System.Windows.Forms.Label();
            this.VolumeStatic = new System.Windows.Forms.Label();
            this.DiameterDynamic2 = new System.Windows.Forms.Label();
            this.SurfaceDynamic = new System.Windows.Forms.Label();
            this.VolumeDyanmic = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTopRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBottomLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PBTopRight
            // 
            this.PBTopRight.Image = global::Lab3.Properties.Resources.Sphere_and_Ball_CIS_199;
            this.PBTopRight.Location = new System.Drawing.Point(157, 122);
            this.PBTopRight.Name = "PBTopRight";
            this.PBTopRight.Size = new System.Drawing.Size(300, 300);
            this.PBTopRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBTopRight.TabIndex = 1;
            this.PBTopRight.TabStop = false;
            // 
            // PBottomLeft
            // 
            this.PBottomLeft.Image = global::Lab3.Properties.Resources.Sphere_and_Ball_CIS_199;
            this.PBottomLeft.Location = new System.Drawing.Point(644, 576);
            this.PBottomLeft.Name = "PBottomLeft";
            this.PBottomLeft.Size = new System.Drawing.Size(300, 300);
            this.PBottomLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBottomLeft.TabIndex = 2;
            this.PBottomLeft.TabStop = false;
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(543, 162);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(231, 25);
            this.RadiusLabel.TabIndex = 3;
            this.RadiusLabel.Text = "Radius Of The Sphere:";
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(809, 162);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(216, 31);
            this.RadiusTextBox.TabIndex = 4;
            this.RadiusTextBox.TextChanged += new System.EventHandler(this.RadiusTextBox_TextChanged);
            // 
            // DiameterStatic
            // 
            this.DiameterStatic.AutoSize = true;
            this.DiameterStatic.Location = new System.Drawing.Point(152, 576);
            this.DiameterStatic.Name = "DiameterStatic";
            this.DiameterStatic.Size = new System.Drawing.Size(104, 25);
            this.DiameterStatic.TabIndex = 5;
            this.DiameterStatic.Text = "Diameter:";
            // 
            // DiameterDynamic
            // 
            this.DiameterDynamic.AutoSize = true;
            this.DiameterDynamic.Location = new System.Drawing.Point(384, 576);
            this.DiameterDynamic.Name = "DiameterDynamic";
            this.DiameterDynamic.Size = new System.Drawing.Size(0, 25);
            this.DiameterDynamic.TabIndex = 6;
            // 
            // SurfaceAreaStatic
            // 
            this.SurfaceAreaStatic.AutoSize = true;
            this.SurfaceAreaStatic.Location = new System.Drawing.Point(152, 684);
            this.SurfaceAreaStatic.Name = "SurfaceAreaStatic";
            this.SurfaceAreaStatic.Size = new System.Drawing.Size(143, 25);
            this.SurfaceAreaStatic.TabIndex = 7;
            this.SurfaceAreaStatic.Text = "Surface Area:";
            // 
            // VolumeStatic
            // 
            this.VolumeStatic.AutoSize = true;
            this.VolumeStatic.Location = new System.Drawing.Point(152, 779);
            this.VolumeStatic.Name = "VolumeStatic";
            this.VolumeStatic.Size = new System.Drawing.Size(90, 25);
            this.VolumeStatic.TabIndex = 8;
            this.VolumeStatic.Text = "Volume:";
            // 
            // DiameterDynamic2
            // 
            this.DiameterDynamic2.AutoSize = true;
            this.DiameterDynamic2.Location = new System.Drawing.Point(425, 576);
            this.DiameterDynamic2.Name = "DiameterDynamic2";
            this.DiameterDynamic2.Size = new System.Drawing.Size(0, 25);
            this.DiameterDynamic2.TabIndex = 9;
            // 
            // SurfaceDynamic
            // 
            this.SurfaceDynamic.AutoSize = true;
            this.SurfaceDynamic.Location = new System.Drawing.Point(425, 684);
            this.SurfaceDynamic.Name = "SurfaceDynamic";
            this.SurfaceDynamic.Size = new System.Drawing.Size(0, 25);
            this.SurfaceDynamic.TabIndex = 10;
            // 
            // VolumeDyanmic
            // 
            this.VolumeDyanmic.AutoSize = true;
            this.VolumeDyanmic.Location = new System.Drawing.Point(425, 779);
            this.VolumeDyanmic.Name = "VolumeDyanmic";
            this.VolumeDyanmic.Size = new System.Drawing.Size(0, 25);
            this.VolumeDyanmic.TabIndex = 11;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(809, 239);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(216, 41);
            this.CalcButton.TabIndex = 12;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 1073);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.VolumeDyanmic);
            this.Controls.Add(this.SurfaceDynamic);
            this.Controls.Add(this.DiameterDynamic2);
            this.Controls.Add(this.VolumeStatic);
            this.Controls.Add(this.SurfaceAreaStatic);
            this.Controls.Add(this.DiameterDynamic);
            this.Controls.Add(this.DiameterStatic);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.RadiusLabel);
            this.Controls.Add(this.PBottomLeft);
            this.Controls.Add(this.PBTopRight);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTopRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBottomLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PBTopRight;
        private System.Windows.Forms.PictureBox PBottomLeft;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.Label DiameterStatic;
        private System.Windows.Forms.Label DiameterDynamic;
        private System.Windows.Forms.Label SurfaceAreaStatic;
        private System.Windows.Forms.Label VolumeStatic;
        private System.Windows.Forms.Label DiameterDynamic2;
        private System.Windows.Forms.Label SurfaceDynamic;
        private System.Windows.Forms.Label VolumeDyanmic;
        private System.Windows.Forms.Button CalcButton;
    }
}

