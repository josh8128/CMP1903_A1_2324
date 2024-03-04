using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Defines class "Die" which represents a single die
    /// Is responsible for generating the number for each die
    /// </summary>
    internal class Die
    {
        // Uses Random which will be used to generate a random number
        private static Random _randomNumber;
        // Declares an integer to hold the current value on the die
        private int _dieValue;

        /// <summary>
        /// Constructor for Die class, used to initialise the random number generator and call the roll method
        /// </summary>
        public Die()
        {
            // Initialises the die with a random value
            _randomNumber = new Random();
            Roll(); 
        }

        /// <summary>
        /// Property which holds the current value of the die
        /// </summary>
        public int DieValue
        {
            get { return _dieValue; }
            private set { _dieValue = value; }
        }

        /// <summary>
        /// Method to roll the die, works using the random number generator
        /// </summary>
        /// <returns>Value the die has after being "rolled"</returns>
        public int Roll()
        {
            _dieValue = _randomNumber.Next(1, 7); 
            return _dieValue;
        }
    }
}