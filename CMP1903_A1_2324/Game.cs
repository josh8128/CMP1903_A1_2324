using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    //Defines class "game" which is responsible for rolling the dice and calculating the sum
    internal class Game
    {
        //Declares 3 private die objects which are used for the dice roll
        private Die dieRoll1;
        private Die dieRoll2;
        private Die dieRoll3;

        //Constructor for game class
        public Game()
        {
            //Initialises the 3 die objects
            dieRoll1 = new Die();
            dieRoll2 = new Die();
            dieRoll3 = new Die();
        }

        //Method to roll each dice individually, calculate the sum and display it all
        public int RollDice()
        {
            Console.WriteLine($"The first die rolled a: {dieRoll1.Roll()}");
            Console.WriteLine($"The second die rolled a: {dieRoll2.Roll()}");
            Console.WriteLine($"The third die rolled a: {dieRoll3.Roll()}");
            int sumOfRolls = dieRoll1.Roll() + dieRoll2.Roll() + dieRoll3.Roll();
            Console.WriteLine($"The sum of the dice rolls is: {sumOfRolls}");
            return sumOfRolls;
        }
    }
}
