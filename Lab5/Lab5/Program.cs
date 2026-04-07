// S2325
//Lab 5
// 10/15/23
// Enter Temps between -20 and 130 degrees and it will show the mean temp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;


namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp; //input temp
            int totalTemps = 0; // Count of the number of tmeps
            double sum = 0; //sum of the temps
            double meanTemp; //mean of all temps
            const int limit = 999;

            WriteLine($"Enter temperatures from -20 to 130({limit} to stop)");
            Write("Enter temparture: "); //Enter the temp
            temp = int.Parse(ReadLine());

            while (temp < -20 || temp > 130) //Setting up if tempature is not valid
            {
                WriteLine("Valid tempatures range from -20 to 130. Please reenter tempatures.");
                Write("Enter Tempature: ");
                temp = int.Parse(ReadLine());
            }

            while (temp >= -20 && temp <= 130) //Setting up if temp is in desired range
            {
                Write("Enter Temperature: ");
                temp = int.Parse(ReadLine());
                sum += temp;
                ++totalTemps;
            }

            meanTemp = (sum - 999)  / totalTemps; //mean equation

            WriteLine($"You entered {totalTemps} valid tempatures. ");
            WriteLine($"The Mean tempature is {meanTemp} degress");
        }
    }
}
