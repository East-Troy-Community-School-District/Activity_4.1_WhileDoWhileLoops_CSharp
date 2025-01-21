/*
 * I Think I Can
 * 1/21/2025
 * 
 * Instrucitons:
 * 1.   Predict what the program does. Check your prediction by running the program.
 * 2.   Where there is a comment, explain what that specific line does.
 * 3.   Modify the program so that it displays the numbers 0 to 999 with
 *      each number on a seperate line. 
 * 4.   Modify the program so that it displays all the even numbers between 0 and
 *      1000, inclusive. Again, the numbers should be on seperate lines.
 * 5.   Modify the program so that it displays the numbers 1 through 100 on the 
 *      same line with a space between each number.
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

            int i = 0;                      // What does this line do?
            while (i < 1000)                // What does this line do?
            {
                Console.WriteLine(PHRASE);
                i++;                        // What does this line do?
            }
        }
    }
}
