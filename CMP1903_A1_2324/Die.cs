using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    //Defines class "die" which represents a single die
    internal class Die
    {
        //Declares an object "RandomNumber" which will be used to generate a random number
        private RandomNumber _randomNumber;
        //Declares an integer to hold the current value on the die
        private int _dieValue;

        //Constructor for die class
        public Die()
        {
            _randomNumber = new RandomNumber();
            Roll(); // Initialises the die with a random value
        }

        //Property to hold the die's current value
        public int DieValue
        {
            get { return _dieValue; }
            private set { _dieValue = value; }
        }

        //Method to roll the die, works using the random number generator
        public int Roll()
        {
            _dieValue = _randomNumber.Next(1, 7); 
            return _dieValue;
        }
    }
}