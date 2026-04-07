using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    public class Car
    {
        //Constants
        public const int _defaultYear = 2016;
        //Properties
        public string Model { get; }
        public string Make { get; }
        public bool SaleStatus { get; private set; }
        public string Condition { get; set; }
        public int Miles { get; set; }

        // backing for the year Properity
        private int _year;

        public int Year
        {
            get => _year; // get the value of the private backing field 
            set => _year = (value >= 1975) ? value : 2023; // Setter validates and sets the year value
        }

        public Car(string model, string make, int miles, int year, string condition ,bool saleStatus)
        {
            Model = model; // Set the Car Model using the provided value
            Make = make;   // Set the Car Make using the provided value
            Condition = condition; //Set the Car Condition 
            Miles = miles; // Set the Car Miles using the provided value
            Year = year;   // Set the Car Year using the provided value 
            SaleStatus = saleStatus; // Set the Sale Status using the provided value
        }
        public void Sell()
        {
            SaleStatus = true; //Setting if there was a sale to true

    }
        public void Return()
        {
            SaleStatus = false; //if the car is returned, the bool changes to false

    }
        //method to check if the car is sold
        public bool IsSold()
        {
            return SaleStatus;
        }
        public override string ToString()
        {
            return $"Make: {Make}{Environment.NewLine}" +
                   $"Model: {Model}{Environment.NewLine}" +
                   $"Miles: {Miles}{Environment.NewLine}" +
                   $"Year: {Year}{Environment.NewLine}" +
                   $"Condition: {Condition}{Environment.NewLine}" +
                   $"Sale Status: {SaleStatus}";
        }
    }
}
