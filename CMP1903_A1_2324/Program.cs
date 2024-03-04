// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace CMP1903_A1_2324
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Game game = new Game();
//             Testing testing = new Testing();

//             bool gameRunning = true;

//             while (gameRunning)
//             {
//                 Console.WriteLine("Press 1 to play the game, 2 to test the game, or 3 to quit:");
//                 string gameMode = Console.ReadLine();

//                 switch (gameMode)
//                 {
//                     //Plays the dice roll game
//                     case "1":
//                         StartGame(game);
//                         break;
//                     //Calls the testing class to test the game
//                     case "2":
//                         //Test the game
//                         testing.TestGame(game);
//                         break;
//                     //Quits the game 
//                     case "3":
//                         gameRunning = false;
//                         Environment.Exit(0);
//                     default:
//                         //Invalid input, asks user to enter 1, 2 or 3
//                         Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
//                         break;
//                 }
//             }
//         }

//         static void StartGame(Game game)
//         {
//             game.PlayGame();
//         }
//     }
// }
