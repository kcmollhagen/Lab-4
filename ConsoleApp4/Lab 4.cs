using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string y;

            // Do Loop - guarenteed to execute at least one time
            do
            {
                // The user is prompted to enter a number
                // That number will then be squared and cubed from 1 to the value entered
                int n, Square, Cube;
                Console.WriteLine("Enter a number");
                n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    // Formulas to square and cube
                    Square = i * i;
                    Cube = i * i * i;
                    Console.WriteLine("\nSquare of " + i + " is " + Square + "\nCube of " + i + " is " + Cube);
                 
                }
                Console.WriteLine("Would you like to continue?" + "y/n");
                y = Console.ReadLine();

            }
            // While Loop - repeatedly executes target statement as long as given condition is true
            while (y == "y");
        }
    }
}