using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Defines class "Game" which is responsible for rolling the dice and calculating the sum
    /// It is also responsible for displaying the menu to allow for navigation between the different states
    /// </summary>
    internal class Game
    {
        // Declares 3 private die objects which are used for the dice roll, the total of all rolls and the round counter
        private Die _dieRoll1;
        private Die _dieRoll2;
        private Die _dieRoll3;
        private int _roundCounter;
        private int _totalSumOfRolls;

        /// <summary>
        /// Constructor for Game class, used to initialise the die objects and round counter and the total rolls
        /// </summary>
        public Game()
        {
            //Initialises the 3 die objects
            _dieRoll1 = new Die();
            _dieRoll2 = new Die();
            _dieRoll3 = new Die();
            _roundCounter = 0;
            _totalSumOfRolls = 0;
        }

        /// <summary>
        /// Gets the result of rolling the three dice from the method RollDice()
        /// </summary>
        /// <returns>A tuple which contains the result of the RollDice() method, this is so it can be accessed in the Testing class</returns>
        public (int, int, int) GetDieRolls()
        {
            return RollDice();
        }

        /// <summary>
        /// Method to roll each individual die and then return the values of each die
        /// </summary>
        /// <returns>A tuple which contains the 3 values of the rolled dice</returns>
        private (int, int, int) RollDice()
        {
            int dieValue1 = _dieRoll1.Roll();
            int dieValue2 = _dieRoll2.Roll();
            int dieValue3 = _dieRoll3.Roll();

            return (dieValue1, dieValue2, dieValue3);
        }
        
        /// <summary>
        /// Displays the user interface to allow player to select whether they want to play, test or quit
        /// </summary>
        static void MenuUI()
        {
            Console.WriteLine("Press 1 to play the game\nPress 2 to test the game\nPress 3 to quit");
            string gameMode = Console.ReadLine();

            switch (gameMode)
            {
                //Plays the game by calling PlayGame() method
                case "1":
                    PlayGame();
                    break;
                //Tests the game by calling TestGame() method
                case "2":
                    TestGame();
                    break;
                //Quits the game 
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    //If the input is invalid, asks user to enter 1, 2 or 3
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    break;
            }
        }

        /// <summary>
        /// Method which lets the player play the dice game
        /// </summary>
        static void PlayGame()
        {
            // Creates new instance of class Game, "game"
            Game game = new Game();
            // Sets a flag to know when the player wants to stop playing the game
            bool playAgain = true;

            // The player can keep rolling dice whilst in this loop
            while (playAgain)
            {
                // Increments round counter
                game._roundCounter++;

                int dieValue1, dieValue2, dieValue3;
                // Rolls each individual die and gets the value of each
                (dieValue1, dieValue2, dieValue3) = game.RollDice();
                // Adds the sum of the die values
                int sumOfRolls = (dieValue1 + dieValue2 + dieValue3);
                game._totalSumOfRolls += sumOfRolls;

                // Displays all the die roll values and sums
                Console.WriteLine($"\nRound: {game._roundCounter}");
                Console.WriteLine($"The first die rolled a: {dieValue1}");
                Console.WriteLine($"The second die rolled a: {dieValue2}");
                Console.WriteLine($"The third die rolled a: {dieValue3}");
                Console.WriteLine($"\nThe sum of rolls this round is: {sumOfRolls}");
                Console.WriteLine($"The sum of rolls this game is: {game._totalSumOfRolls}\n");

                // Asks player if they want to play again, if they do not it sets flag to false ending the loop
                Console.Write("Press 1 to roll again, press any other key to return to menu\n");
                string playAgainChoice = Console.ReadLine();

                // Returns player to menu if they don't want to play again
                if (playAgainChoice != "1")
                {
                    playAgain = false;
                    Console.WriteLine($"\nThe game is over\n");
                    MenuUI();
                }

            }
        }

        

        /// <summary>
        /// Method which lets the player test the game by calling the testing class and calling methods in it
        /// </summary>
        static void TestGame()
        {
            Testing testing = new Testing();
            testing.TestDieRoll();
            testing.TestDieSum();
            Console.WriteLine($"\nTesting complete\nReturning to menu\n");
            MenuUI();
        }

        /// <summary>
        /// Main method which is the entry point when the application starts
        /// </summary>
        /// <param name="args">Command line argument</param>
        static void Main(string[] args)
        {
            while (true)
            {
                MenuUI();
            }
        }
    }
}
