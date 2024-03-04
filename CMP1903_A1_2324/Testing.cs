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
        
        public void TestDieRoll()
        {
            int testDieValue1 = _testDieRoll1.Roll();
            int testDieValue2 = _testDieRoll2.Roll();
            int testDieValue3 = _testDieRoll3.Roll();

            Debug.Assert(testDieValue1Value1 >= 1 && testDieValue1Value1 <= 6, "Die 1 roll out of range");
            Debug.Assert(testDieValue2Value2 >= 1 && testDieValue2Value2 <= 6, "Die 2 roll out of range");
            Debug.Assert(testDieValue3Value3 >= 1 && testDieValue3Value3 <= 6, "Die 3 roll out of range");
        }
        
        public void TestDieSum()
        {

        }
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        }
    }
}
