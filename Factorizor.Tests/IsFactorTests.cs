using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorizor.BLL;
using NUnit.Framework;

namespace Factorizor.Tests
{
    [TestFixture]
    class IsFactorTests
    {


        [TestCase(6)]
        [TestCase(100)]
        [TestCase(7)]
        public void NumberPropertyIsSet(int x)
        {
            FactorManager FM = new FactorManager();
            FM.Number = x;
            Assert.AreEqual(x, FM.Number);
            Assert.AreNotEqual(0, FM.Number);        

        }

        [TestCase(6)]
        [TestCase(100)]
        [TestCase(7)]
        public void NumberPropertyIsNotNull (int x)
        {
            FactorManager FM = new FactorManager();
            Assert.IsNotNull(FM);
        }
   

       
        [Test]
        public void FactorsAreCorrect()
        {
            int[] array6 = { 1, 2, 3, 6 };
            int[] array30 = { 1, 2, 3, 5, 6, 10, 15, 30 };
            int[] array88 = { 1, 2, 4, 8, 11, 22, 44, 88 };
            int[] array123 = { 1, 3, 41, 123 };
            int[][] arrays = new int[][] { array6, array30, array88, array123 };
            
            FactorManager FM = new FactorManager();

            foreach (int[] array in arrays)
            {
                int x = array.Length - 1;
                FM.Number = array[x];
                int[] actual = FM.FactorFinder();
                int[] expected = array;

                Assert.IsTrue(expected.SequenceEqual(actual));
            }
        }



    }

    [TestFixture]
    class IsPerfectTests
    {
      
        [TestCase(6)]
        [TestCase(28)]
        [TestCase(496)]

        public void isPerfectIsTrue(int x)
        {
            FactorManager FM = new FactorManager();
            FM.Number = x;
            Assert.IsTrue(FM.PerfectChecker());

        }

        [TestCase(0)]
        [TestCase(7)]
        [TestCase(29)]
        [TestCase(497)]

        public void isPerfectIsFalse(int x)
        {
            FactorManager FM = new FactorManager();
            FM.Number = x;
            Assert.IsFalse(FM.PerfectChecker());

        }

        [TestCase(-6)]
        [TestCase(-28)]
        [TestCase(-496)]
        public void NegativePerfectNumberIsFalse (int x)
        {
            FactorManager FM = new FactorManager();
            FM.Number = x;
            Assert.IsFalse(FM.PerfectChecker());
        }



    }

    class IsPrimeTests
    {
        [TestCase(3)]
        [TestCase(23)]
        [TestCase(53)]
        [TestCase(89)]
        [TestCase(97)]
        [TestCase(2)]
        public void IsPrimeIsTrue(int x)
        {
            FactorManager FM = new FactorManager();
            FM.Number = x;
            Assert.IsTrue(FM.PrimeChecker());

        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(30)]
        [TestCase(54)]
        [TestCase(74)]
        [TestCase(96)]
        public void IsPrimeIsFalse(int x)
        {
            FactorManager FM = new FactorManager();
            FM.Number = x;
            Assert.IsFalse(FM.PrimeChecker());
        }
        [TestCase(-3)]
        [TestCase(-23)]
        [TestCase(-53)]
        [TestCase(-89)]
        [TestCase(-97)]
        [TestCase(-2)]
        public void NegativePrimeIsFalse(int x)
        {
            FactorManager FM = new FactorManager();
            FM.Number = x;
            Assert.IsFalse(FM.PrimeChecker());
        }

    }

    
}
