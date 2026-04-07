// By: S2325
// CIS-199-01-4238
// Lab 3
// Program has user input a radius for a sphere, and calculates the diameter, surface area and volume
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        //Setting Constants and Equations
        double radiusCircle;
        double radiusSquared;
        double surfaceArea;
        double sphereVolume;

        public Form1()
        {
            InitializeComponent();
        }

        private void RadiusTextBox_TextChanged(object sender, EventArgs e)
        {
            //setting the variable so it can be used later
            radiusCircle = int.Parse(RadiusTextBox.Text);
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            //Setting Equations
            double radiusSqaured = radiusCircle * radiusCircle; 
            double surfaceArea = 4 * Math.PI * radiusSqaured;
            double sphereVolume = 4.0 / 3 * Math.PI * (radiusCircle * radiusCircle * radiusCircle);

            //Setting the Output for the code
            double totalDiameter = radiusCircle * 2;
            DiameterDynamic2.Text = totalDiameter.ToString();
            double totalSurfaceArea = surfaceArea;
            SurfaceDynamic.Text = totalSurfaceArea.ToString();
            double totalVolume = sphereVolume;
            VolumeDyanmic.Text = totalVolume.ToString();




        }
    }
}
