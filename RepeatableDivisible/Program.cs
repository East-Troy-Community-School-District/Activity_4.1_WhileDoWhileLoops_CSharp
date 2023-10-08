/*
 * Repeatable Divisible
 * Pawelski
 * 10/8/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Run the program to familiarize yourself with how it works.
 * What do you need to enter to run the program again? Modify
 * the program so that it accepts "y" to repeat the program.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatableDivisible
{
    class Program
    {
        static void Main(string[] args)
        {
            String repeat = "yes";
            while (repeat == "yes")
            {
                int divident, divisor;

                Console.Write("Enter the divident >> ");
                divident = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the divisor >> ");
                divisor = Convert.ToInt32(Console.ReadLine());

                if (divident % divisor == 0)
                {
                    Console.WriteLine(divident + " is divisible by " + divisor);
                }
                else
                {
                    Console.WriteLine(divident + " is not divisible by " + divisor);
                }

                Console.Write("Do you want to check two other numbers? (yes/no) >> ");
                repeat = Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}
