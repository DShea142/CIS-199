using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
// By: S2325
// CIS-199-01 Program 3 Due 11/12
// Program makes runs a calculator for businesses to determine the cost of the contract for each shipping company.

namespace Program_3
{
    public partial class Form1 : Form
    {
        //6 arrays: two of them are strings, four of them are int/double.
        //table 1 
        string[] shippingCompany =
        {
            "USPS", "DHL", "FedEx", "UPS"
        };
        decimal[] rateDiscount = { 0.22m, 0.18m, 0.19m, 0.20m };

        //table 2
        string[] nameBusiness =
        {
            "John’s Books" , "Office Supplies" , "J.B's Car Parts", "Gevalia Coffee", "Ceylon Tea", "My Footwear"
        };
        decimal[] startingContPrice = { 50000m, 85000m, 60000m, 75000m, 95000m, 55000m };

        //table 3 
        int[] contractYears = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        decimal[] addedDiscount = { 0, 0, 10000, 10000, 10000, 20000, 20000, 20000, 30000, 30000, 30000 };

        //other variables
        bool validShipping;
        decimal totalDiscount = 0;
        string business;
        int finalContractYears = 0;
        bool validBusiness;
        bool validContract = false; 

        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            validShipping = false;
            string selectedShippingCompany = provCombo.Text;
            for (int x = 0; x < shippingCompany.Length; x++)
            {
                if (selectedShippingCompany == shippingCompany[x])
                {
                    validShipping = true; // changing bool varibale to true
                    shippingCompany[x] = selectedShippingCompany;
                    //set up discount 
                    totalDiscount = startingContPrice[busCombo.SelectedIndex] * rateDiscount[x];
                    providerLabel.Text = provCombo.Text;
                    companyDiscountLabel.Text = rateDiscount[x].ToString("00%");
                    break; // ends loop
                }
            }
            if (!validShipping)
            {
                MessageBox.Show("Invalid Shipping Company");
                return; // returns to top of loop
            }
            for (int x = 0; x < nameBusiness.Length; x++)
            {
                if (busCombo.Text == nameBusiness[x])
                {
                    validBusiness = true;
                    business = nameBusiness[x];
                    break; // adding a break in the loop once the bool is deemed true
                }

            }
            if (!validBusiness)
            {
                MessageBox.Show("Invalid Business");
                return;
            }
            if (int.TryParse(contLengthTB.Text, out finalContractYears) && finalContractYears >= 0 && finalContractYears <= 10)
            {
                validContract = true; // when the user input is between 1-10, bool changes to true 
                totalDiscount += addedDiscount[finalContractYears];
                lengthDiscountLabel.Text = addedDiscount[finalContractYears].ToString("$0.00");
            }
            else
            {
                MessageBox.Show("You must provide a valid number of contract years(Between 1-10)");
            }
            // setting the final label calculations 
            decimal testing = startingContPrice[busCombo.SelectedIndex];
            contractPriceLabel.Text = testing.ToString("$0.00");
            decimal finalPrice = startingContPrice[busCombo.SelectedIndex] - totalDiscount;
            totalCostLabel.Text = finalPrice.ToString("$0.00");
        }
            
    }
}
