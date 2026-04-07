using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Console;
// By: S2325
// Lab 6
// CIS-199-01
// Due Date: 10/29
// Making patterns using nested loops

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pattern A
            WriteLine("Pattern A");
            for (int x = 1; x <= 10; x++)         
            {
                for (int y = 1; y <= x; y++)
                {
                    Write("*");
                }
                WriteLine();
            }
            // Pattern B
            WriteLine("\nPattern B");
            for (int x = 10; x >= 1; x--)
            {
                for (int y = 1; y <= x; y++)
                {
                    Write("*");
                }
                WriteLine();
            }
            //Pattern C
            WriteLine("\nPattern C");
            for (int x = 1; x <= 10; x++)
            {
                for (int y = 1; y < x; y++)
                {
                    Write(" ");
                }
                for (int z = x; z <= 10; z++)
                {
                    Write("*");
                }
                WriteLine();
            }
            //Pattern D
            WriteLine("\nPattern D");
            for(int x = 10; x >= 1; x--)
            {
                for (int y = 1; y < x; y++)
                {
                    Write(" ");
                }
                for(int z = x;z <= 10; z++)
                {
                    Write("*");
                }
                WriteLine();
            }
            
        }
    }
}
