/*
 * Count Even Odd
 * Pawelski
 * 10/8/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Run the program to familiarize yourself with how it works.
 * Currently, the program only contains one accumulator variable.
 * What is the name of this variable? Modify the program so that
 * it counts the number of odd numbers as well as the even numbers.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenCount = 0;
            string repeat;
            do
            {
                int number;
                Console.Write("Enter a nummber >> ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 == 0)
                {
                    evenCount++;
                }
                Console.Write("Do you want to enter another number? (yes/no) >> ");
                repeat = Console.ReadLine();
            } while (repeat == "yes");

            Console.WriteLine("You entered " + evenCount + " even numbers.");
        }
    }
}
