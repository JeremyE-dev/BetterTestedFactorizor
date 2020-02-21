using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorizorTested.UI
{
    public class ConsoleInput
    {
        //asks for number from user
        // determine if valid
        //
        public static int GetNumberFromUser ()
        {
            Console.Clear();
            int output;
            string input;

            while (true)
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out output))
                {
                    return output;
                }
                else
                {
                    Console.WriteLine("That was not a valid number! Press any key to continue...");
                    Console.ReadKey();
                }
            }

        }
    }
}
