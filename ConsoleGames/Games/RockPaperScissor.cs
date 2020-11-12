using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGames.Games
{
    class RockPaperScissor
    {
        public static void RockPaperScissors() {
            Console.WriteLine($"Choose one;\n - 1. Rock\n - 2. Paper\n - 3. Scissors");

            bool win = false;

            do {
                try {
                    Random rng = new Random();

                    int enemyChoice = rng.Next(1, 4);

                    int input = Convert.ToInt32(Console.ReadLine());

                    if (enemyChoice == 1) {
                        if (input == 1) {
                            Console.WriteLine("Computer chose Rock");
                            Console.WriteLine("It is a tie.");
                        }
                        else if (input == 2) {
                            Console.WriteLine("Computer chose Rock");
                            Console.WriteLine("You win.");
                            Program.totalWins++;
                        }
                        else if (input == 3) {
                            Console.WriteLine("Computer chose Rock");
                            Console.WriteLine("You lose.");
                        }
                    }
                    else if (enemyChoice == 2) {
                        if (input == 1) {
                            Console.WriteLine("Computer chose Paper");
                            Console.WriteLine("You lose.");
                        }
                        else if (input == 2) {
                            Console.WriteLine("Computer chose Paper");
                            Console.WriteLine("It is a tie.");
                        }
                        else if (input == 3) {
                            Console.WriteLine("Computer chose Paper");
                            Console.WriteLine("You win.");
                            Program.totalWins++;
                        }
                    }
                    else if (enemyChoice == 3) {
                        if (input == 1) {
                            Console.WriteLine("Computer chose Scissors");
                            Console.WriteLine("You win.");
                            Program.totalWins++;
                        }
                        else if (input == 2) {
                            Console.WriteLine("Computer chose Scissors");
                            Console.WriteLine("You lose.");
                        }
                        else if (input == 3) {
                            Console.WriteLine("Computer chose Scissors");
                            Console.WriteLine("It is a tie.");
                        }
                    }
                }
                catch (FormatException) {

                    Console.WriteLine("Exiting..");
                    win = true;
                }
            } while (win != true);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
