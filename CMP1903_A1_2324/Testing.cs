using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        private Die _testDieRoll1;
        private Die _testDieRoll2;
        private Die _testDieRoll3;

        public Testing()
        {
            //Initialises the 3 test die objects
            _testDieRoll1 = new Die();
            _testDieRoll2 = new Die();
            _testDieRoll3 = new Die();
        }

        public void TestDieRoll()
        {
            int testDieValue1 = _testDieRoll1.Roll();
            int testDieValue2 = _testDieRoll2.Roll();
            int testDieValue3 = _testDieRoll3.Roll();

            Debug.Assert(testDieValue1 >= 1 && testDieValue1 <= 6, "Die roll 2 is out of range (1-6)");
            Debug.Assert(testDieValue2 >= 1 && testDieValue2 <= 6, "Die roll 2 is out of range (1-6)");
            Debug.Assert(testDieValue3 >= 1 && testDieValue3 <= 6, "Die roll 3 is out of range (1-6)");
        }

        public void TestDieSum()
        {
            int testDieValue1 = _testDieRoll1.Roll();
            int testDieValue2 = _testDieRoll2.Roll();
            int testDieValue3 = _testDieRoll3.Roll();

            int testSumOfRolls = testDieValue1 + testDieValue2 + testDieValue3;


            Debug.Assert(testSumOfRolls >= 3 && testSumOfRolls <= 18, "The sum of the die rolls is out of range (3-18)");
        }
    }
}
