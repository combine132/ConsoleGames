using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGames
{
    class GuessNumber
    {
        public static void GuessingGame() {
            Random rng = new Random();

            int number = rng.Next(1, 101);
            int guesses = 0;
            bool win = false;

            Console.WriteLine($"Guess a number between 1-100");
            do {
                try {
                    int guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > number) {
                        Console.WriteLine($"Number is lower than {guess}");
                        guesses++;
                    }
                    else if (guess < number) {
                        Console.WriteLine($"Number is higher than {guess}");
                        guesses++;
                    }
                    else if (guess == number) {
                        guesses++;
                        Console.WriteLine($"Correct! Number was {number}!\nGuesses used: {guesses}");
                        win = true;
                        Console.WriteLine($"Press any key to return");
                        Program.totalWins++;
                    }
                    else {
                        Console.WriteLine("Error");
                        win = true;
                    }
                }
                catch (FormatException) {

                    Console.WriteLine("Input has to be a number");
                }

            } while (win != true);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
