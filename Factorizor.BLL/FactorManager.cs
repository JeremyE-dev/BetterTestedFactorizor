using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor.BLL
{
   public class FactorManager
   {
        public int Number { get; set;}


        
        public int[] FactorFinder()
        {
            int[] array = new int[Number];
            int index = 0;

            for (int i = 1; i <= Number; i++)
            {
                if (Number % i == 0)
                {
                    array[index] = i;
                    index++;

                }
            }

            Array.Resize(ref array, index);

            return array;


        }

        public bool PerfectChecker()
        {

            int sum = 0;
            bool isPerfect; 

            if (Number == 0)
            {
                return false;
            }

            for (int i = 1; i < Number; i++)
            {

                if (Number % i == 0)
                {

                    sum += i;
                }

            }

            if (sum == Number)
            {
                isPerfect = true; ;
            }

            else
            {
                isPerfect = false;
            }

            return isPerfect; ;

        }


        public bool PrimeChecker()
        {
            

            if (Number < 2)
            {
                return false;
            }

            for (int i = 1; i <= Number; i++)
            {
                if (Number % i == 0 && i != 1 && i != Number)
                {

                    return false;

                }
            }

            return true;

        }
       


    }

}
