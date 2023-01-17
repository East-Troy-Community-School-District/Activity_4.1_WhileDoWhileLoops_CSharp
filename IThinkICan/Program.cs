/*
 * I Think I Can
 * 1/16/2023
 * C#.NET I
 * 
 * Instrucitons:
 * First, trace the program to predict what it currently does.
 * Check your prediction by running the program. Next, modify
 * the program so that it displays the numbers 0 to 999 with
 * each number on a seperate line. Then, modify the program
 * so that it displays all teh even numbers between 0 and
 * 1000, inclusive. Again, the numbers should be on seperate
 * lines. Finally, modify the program so that it displays the
 * numbers 1 through 100 on the same line with commas between
 * each number.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IThinkICan
{
    class Program
    {
        static void Main(string[] args)
        {
            const string PHRASE = "I think I can...";

            int i = 0;
            while (i < 1000)
            {
                Console.WriteLine(PHRASE);
                i++;
            }
        }
    }
}
