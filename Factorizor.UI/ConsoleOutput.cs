using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorizor.BLL;

namespace Factorizor.UI
{
    class ConsoleOutput
    {

        public static void DisplayTitle()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Better, Testable, Guessing Game!\n\n");
            Console.WriteLine("Press any key to start the game...");
            Console.ReadKey();
        }


   
        public static void DisplayFactors(FactorManager FM) 
        {
            int[] factorArray = FM.FactorFinder();

            string factorString = String.Join(",", factorArray);

            Console.WriteLine("The Factors of {0} are {1}", FM.Number, factorString );

        }

        public static void DisplayIsPrime(FactorManager FM)
        {
            if(FM.PrimeChecker())
            {
                Console.WriteLine("{0} is a Prime Number", FM.Number);
            }

            else
            {

                Console.WriteLine("{0} is NOT Prime Number", FM.Number);
            }

        }

        public static void DisplayIsPerfect (FactorManager FM)
        {
            if (FM.PerfectChecker())
            {
                Console.WriteLine("{0} is a Perfect Number", FM.Number);
            }

            else
            {

                Console.WriteLine("{0} is NOT Perfect Number", FM.Number);
            }
        }

        




    }
}
