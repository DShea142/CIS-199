using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//By:s2325
// CIS 199-01 Program 4 Due 12/1
// Writing a program involving car arrays in 2 seperate files


namespace Program4
{
    class Program
    {
        static void Main()
        {
            // Create an array to store Car objects
            Car[] cars = new Car[5];

            // Initialize Car objects with test data
            cars[0] = new Car("Sedan", "Toyota", 5000, 2022, "Excellent", false);
            cars[1] = new Car("SUV", "Honda", 8000, 2021, "Good", false);
            cars[2] = new Car("Convertible", "Ford", 3000, 2023, "Fair", false);
            cars[3] = new Car("Truck", "Chevrolet", 10000, 2020, "Poor", false);
            cars[4] = new Car("Hatchback", "Volkswagen", 6000, 2022,"Excellent", false);

            // Print original data
            PrintCarData(cars, "Current Stock of Cars");

            // Modify car data (e.g., sell cars)
            cars[0].Sell();
            cars[2].Sell();

            // Print updated data after modifications
            PrintCarData(cars, "After Changes");

            // Return the sold cars
            cars[0].Return();
            cars[2].Return();

            // Print data after returning the sold cars
            PrintCarData(cars, "Data After Returning Sold Cars");
        }

        // Static method to print car data
        static void PrintCarData(Car[] cars, string title)
        {
            Console.WriteLine($"--- {title} ---");

            foreach (var car in cars)
            {
                Console.WriteLine(car);
                Console.WriteLine("---------------");
            }

            Console.WriteLine();
        }
    }
}
