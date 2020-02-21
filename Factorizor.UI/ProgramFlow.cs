using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorizor.BLL;
using FactorizorTested.UI;

namespace Factorizor.UI
{
    class ProgramFlow
    {
        FactorManager _manager;

        //creates instance of FM
        //Displays welcome message, starts game
        //gets input from user
        //stores number in _manager.Number
        public void RunFactorizor()
        {
            _manager = new FactorManager();
            ConsoleOutput.DisplayTitle();

            _manager.Number = ConsoleInput.GetNumberFromUser();

        }

        public void DisplayOutput()
        {
            ConsoleOutput.DisplayFactors(_manager);
            ConsoleOutput.DisplayIsPrime(_manager);
            ConsoleOutput.DisplayIsPerfect(_manager);
        }

      
    }
}
