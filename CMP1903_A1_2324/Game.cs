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
        //Declares 3 private die objects which are used for the dice roll and then the total sum
        private Die _dieRoll1;
        private Die _dieRoll2;
        private Die _dieRoll3;

        //Constructor for game class
        public Game()
        {
            //Initialises the 3 die objects
            _dieRoll1 = new Die();
            _dieRoll2 = new Die();
            _dieRoll3 = new Die();
        }

        static void MenuUI()
        {
            Console.WriteLine("Press 1 to play the game, 2 to test the game, or 3 to quit:");
            string gameMode = Console.ReadLine();

            switch (gameMode)
            {
                //Plays the dice roll game
                case "1":
                    PlayGame();
                    break;
                //Calls the testing class to test the game
                //case "2":
                //Test the game
                //testing.TestGame(game);
                //break;
                //Quits the game 
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    //Invalid input, asks user to enter 1, 2 or 3
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    break;
            }
        }

        //Method which lets the user play the dice game
        static void PlayGame()
        {
            Game game = new Game();
            //Sets a flag to know when the player wants to stop playing the game
            bool playAgain = true;

            //The player can keep rolling dice whilst in this loop
            while (playAgain)
            {
                int dieValue1, dieValue2, dieValue3;
                //Rolls each individual die and gets the value of each
                (dieValue1, dieValue2, dieValue3) = game.RollDice();
                //Adds the sum of the die values
                int sumOfRolls = (dieValue1 + dieValue2 + dieValue3);

                //Displays all the die roll values and sums
                Console.WriteLine($"The first die rolled a: {dieValue1}");
                Console.WriteLine($"The second die rolled a: {dieValue2}");
                Console.WriteLine($"The third die rolled a: {dieValue3}");
                Console.WriteLine($"The sum of rolls this game is: {sumOfRolls}");

                //Asks player if they want to play again, if they do not it sets flag to false ending the loop
                Console.Write("Press 1 to roll again: ");
                string playAgainChoice = Console.ReadLine();

                if (playAgainChoice != "1")
                {
                    playAgain = false;
                    Console.WriteLine($"The game is over");
                    MenuUI();
                }

            }
        }

        //Method to roll each dice individually then return the die values
        private (int, int, int) RollDice()
        {
            int dieValue1 = _dieRoll1.Roll();
            int dieValue2 = _dieRoll2.Roll();
            int dieValue3 = _dieRoll3.Roll();

            return (dieValue1, dieValue2, dieValue3);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                MenuUI();
            }
        }
    }
}
