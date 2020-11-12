using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGames.Games
{
    class Mg
    {
        public static void MathGame() {
            Random rng1 = new Random();

            double answer = 0;
            Random r = new Random();

            int numOne = rng1.Next(1, 101);
            int numTwo = rng1.Next(1, 101);
            while (numTwo == numOne) {
                numTwo = rng1.Next(1, 101);
            }

            char[] option = { '+', '-', '*', '/' };
            char math = option[r.Next(option.Length)];

            Console.WriteLine($"What is {numOne} {math} {numTwo}?");

            switch (math) {
                case '+':
                    answer = numOne + numTwo;
                    break;
                case '-':
                    answer = numOne - numTwo;
                    break;
                case '*':
                    answer = numOne * numTwo;
                    break;
                case '/':
                    answer = Math.Round((double)numOne / (double)numTwo, 2);
                    break;
                default:
                    break;
            }

            int plyAnswer = Convert.ToInt32(Console.ReadLine());

            if (plyAnswer == answer) {
                Console.WriteLine("Correct! +1 point");
                Program.totalWins++;
            }
            else {
                Console.WriteLine("Incorrect. Better luck next time.");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
