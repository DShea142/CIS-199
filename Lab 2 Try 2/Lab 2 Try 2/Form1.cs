// CIS-199-01
// Lab 2
// Due 9/17/2023
// By: S2325
// This Program Shows Tips for different money amounts
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_Try_2
{
    public partial class Form1 : Form
    {

        //Setting the constants for the tip rates 
        private const decimal TIP_RATE_LOW = 0.15m; //15%
        private const decimal TIP_RATE_MEDIUM = 0.18m; //18%
        private const decimal TIP_RATE_HIGH = 0.20m; //20%
        decimal TotalAmount;
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //This is where I will get the total amount variable to use later
            TotalAmount = int.Parse(textBox1.Text);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //This is where I will calculate each tip percentage
            decimal TotAmtHigh = TotalAmount * TIP_RATE_HIGH; //Calcualting tip amount 
            label6.Text = TotAmtHigh.ToString(); //running the amount into the form
            decimal TotAmtMid = TotalAmount * TIP_RATE_MEDIUM; //Calcualting tip amount 
            label5.Text = TotAmtMid.ToString(); //running the amount into the form
            decimal TotAmtLow = TotalAmount * TIP_RATE_LOW; //Calcualting tip amount 
            label4.Text = TotAmtLow.ToString(); //running the amount into the form
        }

    }
}