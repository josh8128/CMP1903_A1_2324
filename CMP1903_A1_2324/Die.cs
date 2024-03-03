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
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */
        //Declares an object "RandomNumber" which will be used to generate a random number
        private RandomNumber randomNumber;
        //Declares an integer to hold the current value on the die
        private int dieValue;

        //Property


        //Method
    //Constructor for die class
        public Die()
        {
            randomNumber = new RandomNumber();
            Roll(); // Initialises the die with a random value
        }

    //Property to hold the die's current value
        public int DieValue
        {
            get { return dieValue; }
            private set { dieValue = value; }
        }

    //Method to roll the die, works using the random number generator
         int Roll()
        {
            dieValue = randomNumber.Next(1, 7); 
            return dieValue;
        }
    }
}