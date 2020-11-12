using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGames.Games
{
    class RTD
    {
        public static void RollTheDice() {
            Random random = new Random();
            bool loop = true;

            do {
                int dice = random.Next(1, 7);
                Console.WriteLine($"Dice: {dice}\nType 'n' to exit, or any key to roll again.");

                string inp = Console.ReadLine();
                if (inp != "n") {
                    continue;
                }
                else
                    loop = false;
            } while (loop);
            Console.Clear();
        }
    }
}
