// ID: S2325
// Lab 4
// CIS-199-01
// Code has a running count if a student has the gpa, test scores for a university acceptance
// lab number, due date, course section, and brief description of what the program does.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private int acceptedCount = 0;
        private int rejectedCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            // TryParse the code the double
            if (double.TryParse(textBoxGPA.Text, out double gpa) && int.TryParse(textBoxTestScore.Text, out int admissionScore))
            {
                // check admission criteria and display the result.
                if ((gpa >= 3.0 && admissionScore >= 60) || (gpa < 3.0 && admissionScore >= 80))
                {
                    resultLabel.Text = "Accept";
                    acceptedCount++;
                }
                else
                {
                    resultLabel.Text = "Reject";
                    rejectedCount++;
                }

                //display the running totals.
                acceptedDyanmic.Text = acceptedCount.ToString();
                rejectedDyanmic.Text = rejectedCount.ToString();
            }
        }
    }
}
