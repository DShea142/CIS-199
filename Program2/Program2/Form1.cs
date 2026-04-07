using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
// By: S2325
// CIS-199-01
// Due by 10/19
// Making a form to calculate health and car insurance per customer
namespace Program2
{
    public partial class Form1 : Form
    {
        int age;
        int carValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            //setting the range of possible values for the text boxes
            if (int.TryParse(ageText.Text, out age) && age >= 15 && age <= 120)
            {
                ageText.Text = age.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Age. Try Again");
            }

            if (int.TryParse(valueText.Text, out carValue) && carValue >= 0)
            {
                valueText.Text = carValue.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Value. Try Again");
            }

            age = int.Parse(ageText.Text);
            carValue = int.Parse(valueText.Text);

            //start of health cost, setting up possibilities
            double healthStartCost = 0;
            if (comboBoxHealth.SelectedIndex == 0)
            {
                healthStartCost = 160;
                if (YesButtonSmoke.Checked)
                {
                    healthStartCost += 70;
                }
            }
            else if (comboBoxHealth.SelectedIndex == 1)
            {
                healthStartCost = 20;
            }
            else if(comboBoxHealth.SelectedIndex == 2)
            {
                healthStartCost = 30;
            }
            //start of car calulation, setting up all of the if x happens then add this much. 
            double carStartCost = 0;
            if(comboBoxCar.SelectedIndex == 0)
            {
                carStartCost = 110;
                if (carValue < 15000)
                    carStartCost -= (carStartCost * 0.12);
                if (YesButtonAccident.Checked) 
                {
                    carStartCost *= 1.2;
                }
                if(age < 21)
                {
                    carStartCost += 25;
                }
            }
            if (comboBoxCar.SelectedIndex == 1)
            {
                carStartCost = 50;
            }
            // Calculating bottom labels 
            double carTotalCost = carStartCost * 12;
            double healthTotalCost = healthStartCost * 12;
            double totalCost = carTotalCost + healthTotalCost; 

            healthCovYear.Text = healthTotalCost.ToString("$0.00");
            carCovPerYear.Text = carTotalCost.ToString("$0.00");
            EndingTotalCost.Text = totalCost.ToString("$0.00");

        }
    }
}
