using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Defines class "Testing" which is responsible for testing functionality of the game
    /// It checks that the die rolls are within a given range and that when totaled up their sum doesn't exceed an amount
    /// </summary>
    internal class Testing
    {
        // Declares a private instance of the Game class, "_testGame"
        private Game _testGame;

        /// <summary>
        /// Constructor for Testing class, used to initialise the new instance of the game class, "_testGame" to be used for testing
        /// </summary>
        public Testing()
        {
            //Initialises the _testGame object
            _testGame = new Game();
        }

        /// <summary>
        /// Method to test that each die roll is within the range of 1-6
        /// </summary>
        public void TestDieRoll()
        {
            int testDieValue1, testDieValue2, testDieValue3;
            (testDieValue1, testDieValue2, testDieValue3) = _testGame.GetDieRolls();

            // Checks to see each roll is within the range 1-6 or it will give the error message given
            Debug.Assert(testDieValue1 >= 1 && testDieValue1 <= 6, "Die roll 1 is out of range (1-6)");
            Debug.Assert(testDieValue2 >= 1 && testDieValue2 <= 6, "Die roll 2 is out of range (1-6)");
            Debug.Assert(testDieValue3 >= 1 && testDieValue3 <= 6, "Die roll 3 is out of range (1-6)");
        }

        /// <summary>
        /// Method to test that the sum of the 3 rolls is within the range of 3-18
        /// </summary>
        public void TestDieSum()
        {
            int testDieValue1, testDieValue2, testDieValue3;
            (testDieValue1, testDieValue2, testDieValue3) = _testGame.GetDieRolls();

            int testSumOfRolls = testDieValue1 + testDieValue2 + testDieValue3;

            // Checks to see the sum of the 3 rolls is within the range 3-18 or it will give the error message given
            Debug.Assert(testSumOfRolls >= 3 && testSumOfRolls <= 18, "The sum of the die rolls is out of range (3-18)");
        }
    }
}
