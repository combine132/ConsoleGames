using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGames.Games
{
    class CoinFlips
    {
        public static void CoinFlip() {
            Random rng = new Random();
            Console.WriteLine($"Press 1 to flip a coin.");
            bool loop = true;

            do {
                int r = rng.Next(101);

                int i = Convert.ToInt32(Console.ReadLine());

                if (i == 1) {
                    if (r < 50) {
                        Console.WriteLine("Heads");
                        Console.WriteLine($"Press 1 to flip another coin.");
                    }
                    else {
                        Console.WriteLine("Tails");
                        Console.WriteLine($"Press 1 to flip another coin.");
                    }
                }
                else
                    loop = false;

            } while (loop);

        }
    }
}
