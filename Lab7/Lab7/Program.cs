using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// By: S2325
// Lab 7
// CIS-199-01
// Due 11/19/23
// Takes a pattern 
namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numStars;

            do
            {
                Console.WriteLine("Enter an integer");

                // sets the arguement that if the int value is greater than 0, to run the StarsSquared Method
                if (int.TryParse(Console.ReadLine(), out numStars) && numStars > 0)
                {
                    StarsSquared(numStars);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer");
                }
            } while (true); //loop until the loop is true
        }

        private static void StarsSquared(int numStars)
        {
            // loop each row 
            for (int rows = 1; rows <= numStars; rows++)
            {
                // put out an asterisk for each column
                for (int stars = 1; stars <= numStars; stars++)
                {
                    // print the asterisk
                    Console.Write("*");
                }
                // move to the next line
                Console.WriteLine(); 
            }
        }
    }
}
