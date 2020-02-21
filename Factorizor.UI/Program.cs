using FactorizorTested.UI;
using Factorizor.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Factorizor.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramFlow factorcalc = new ProgramFlow();

            factorcalc.RunFactorizor();
            factorcalc.DisplayOutput();
            Console.ReadLine();

            //START HERE 2/20/20
            //add feature to ask user if they want to enter another number
            // i.e press any key to enter another number
            //Console.Writeline("Press Q to quit or any other Key to enter another number");
            // write 3 unit tests for each BLL method
        }

      
        
    }
}
