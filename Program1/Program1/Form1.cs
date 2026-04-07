// Grading ID: S2325
// CIS-199-01
// Program 1
// Due Date: 9/28/2023
// Program runs a form that calculates the total cost, and type of case for a law firm
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Program1
{
    public partial class Form1 : Form
    {
        // Setting all the constants
        const int attorneyRate = 250;
        const double pagePrice = 0.10;
        const int paralegalRate = 300;
        //Setting Variables for..
        string nameClient;// Client Name
        string typeOfCase;// Case Type
        string descriptionCase; // Case Decription
        double hoursAttorney; // Attorney Hours
        int daysOfParalegal; // Paralegal Days
        int printedPages; // Pages Printed
        double amtReams; // Amount of Reams
        double serviceResearch; // the cost of research service if chosen
        double pageCost; // Cost per page
        




        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            //setting the values to the text boxes, they can be pulled for the bottom output
            double optionalResearchFee = 750; // Flat research fee
            nameClient = ClientNameTB.ToString(); 
            typeOfCase = TypeOfCaseTB.ToString(); 
            descriptionCase = CaseDescriptionTB.ToString(); 
            hoursAttorney = double.Parse(AmtOfAttHoursTB.Text);
            daysOfParalegal = int.Parse(AmtOfParaDaysTB.Text);
            printedPages = int.Parse(AmtOfPagesTB.Text);
            serviceResearch = double.Parse(ResearchServiceTB.Text);
            double totalResearchFee = serviceResearch;

            double reamsEquation = printedPages * (1.1) / 500; //setting the value of how many reams needed

            double paperCost = printedPages * pagePrice; // setting paper cost

            double totalAttorneyCost = hoursAttorney * attorneyRate; //setting attorney cost
            
            int paralegalCost = daysOfParalegal * paralegalRate; // setting paralegal cost 


            if (serviceResearch == 1) // setting the research cost 
            {
                totalResearchFee = optionalResearchFee;
            } 
            else
            {
                totalResearchFee = 0;
            }

            double totalCost = totalResearchFee + totalAttorneyCost + paralegalCost + paperCost;

            //establishing the outputs for the bottom part 

            ClientNameOUTLab.Text = "Client Name: " + ClientNameTB.Text;
            TypeOfCaseOUTLAB.Text = "Type of Case: " + TypeOfCaseTB.Text;
            DescOfCaseOUTLAB.Text = "Description of Case: " + CaseDescriptionTB.Text;
            ReamsNeededOUTLAB.Text = "Reams of Paper Needed: " + reamsEquation;
            AttoneryCostOUTLAB.Text = "Attorney Cost: " + totalAttorneyCost.ToString("$0.00");
            ParaCostOutLab.Text = "Paralegal Cost: " + paralegalCost.ToString("$0.00");
            TotalCostOUTLAB.Text = "Total Cost:" + totalCost.ToString("$0.00");

        }
    }
}
