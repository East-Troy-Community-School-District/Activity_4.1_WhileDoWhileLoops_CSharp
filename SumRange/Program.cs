/*
 * Sum Range
 * 1/21/2025
 * 
 * Instructions:
 * 1.   Predict what the program will do. Run the program to check your
 *      prediction. In addition, explain what the marked lines of code
 *      do.
 * 2.   There is an accumulator variable in the program. What variable
 *      is the accumulator?
 * 3.   The amount of times the loop executes is dependent on the user's
 *      input. How was this accomplished?
 * 4.   How did I prevent the last plus sign from being displayed after
 *      the last number? (HINT: look at the if statement)
 * 5.   Modify the program so that the last number is included in
 *      the total.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, end, sum = 0;
            Console.Write("What is the starting number of the range? >> ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the last number of the range (exclusive)? >> ");
            end = Convert.ToInt32(Console.ReadLine());
            int count = start;
            while (count < end)     // What does this line of code do?
            {
                sum += count;       // What does this line of code do?
                if (count < end - 1)    // What does this line of code do? Why is it necessary?
                {
                    Console.Write(count + " + ");
                }
                else
                {
                    Console.Write(count);
                }
                count++;
            }
            Console.WriteLine(" = " + sum);
        }
    }
}
