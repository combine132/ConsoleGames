using ConsoleGames.Games;
using System;

namespace ConsoleGames
{
    class Program
    {
        public static int totalWins = 0;

        static void Main(string[] args) {
            bool loop = true;
            do {
                Console.Title = $"The Game - Current Wins: {totalWins}";
                Console.WriteLine($"Welcome to the GAME\nSelect an item below\n--------------------------\n" +
                    $"  - 1. Guess a number\n" +
                    $"  - 2. Rock Paper Scissors\n" +
                    $"  - 3. 200 IQ Super Quiz\n" +
                    $"  - 4. Random Math Questions\n" +
                    $"  - 5. \n" + 
                    $"  - 6. \n" +
                    $"  - 7. \n" +
                    $"  - 8. Roll The Dice\n" +
                    $"  - 9. Heads or Tails\n" +
                    $"  - 0. Exit");

                try {
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input) {
                        case 1:
                            Console.Clear();
                            GuessNumber.GuessingGame();
                            break;
                        case 2:
                            Console.Clear();
                            RockPaperScissor.RockPaperScissors();
                            break;
                        case 3:
                            Console.Clear();
                            Quiz.The200IQSuperQuiz();
                            break;
                        case 4:
                            Console.Clear();
                            Mg.MathGame();
                            break;
                        case 5:
                            Console.Clear();
                            //none yet
                            break;
                        case 6:
                            Console.Clear();
                            //none yet
                            break;
                        case 7:
                            Console.Clear();
                            //none yet
                            break;
                        case 8:
                            Console.Clear();
                            RTD.RollTheDice();
                            break;
                        case 9:
                            CoinFlips.CoinFlip();
                            Console.Clear();
                            break;
                        case 0:
                            loop = false;
                            break;
                        default:
                            Console.Clear();
                            break;
                    }
                }
                catch (FormatException) {
                    Console.Clear();
                    Console.WriteLine("Input has to be a number.\n");
                }
            } while (loop); 
        }
    }
}
