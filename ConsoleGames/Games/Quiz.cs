using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGames.Games
{
    class Quiz
    {
        public static void The200IQSuperQuiz() {
            Console.WriteLine($"Welcome, lucky contestant, to the 200 IQ Super Quiz!\n" +
                $"The rules are as follows\n" +
                $"1. Answer the question right to move on to the next.\n" +
                $"2. You will be given 3 lives. If you use all your lives, you get no points\n" +
                $"3. Answer incorrectly and you will lose a life.\n" +
                $"4. You answer with 1, 2, 3 and 4\n" +
                $"Simple right? Lets get started then.\n" +
                $"We will start off easy.\n");

            int lives = 3;
            int questions = 1;
            do {
                switch (questions) {

                    case 1:
                        Console.WriteLine($"How many days are there in a week?\n" +
                            "1. 5 days\n" +
                            "2. 6 days\n" +
                            "3. 7 days\n" +
                            "4. 8 days");
                        int input = Convert.ToInt32(Console.ReadLine());

                        switch (input) {
                            case 1:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 2:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 3:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                break;
                            case 4:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine($"What is Bilbo Baggins?\n" +
                            "1. An Elf\n" +
                            "2. A Dwarf\n" +
                            "3. A Human\n" +
                            "4. A Hobbit");
                        int input2 = Convert.ToInt32(Console.ReadLine());

                        switch (input2) {
                            case 1:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 2:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 3:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 4:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine($"What is the music of life?\n" +
                            "1. Um... the lute? No, drums!\n" +
                            "2. Silence, my brother.\n" +
                            "3. Screaming?\n" +
                            "4. Some kind of choir. With chanting.");
                        int input3 = Convert.ToInt32(Console.ReadLine());

                        switch (input3) {
                            case 1:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 2:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                break;
                            case 3:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 4:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine($"When was Half-Life first released?\n" +
                            "1. November 4th, 1998\n" +
                            "2. November 8th, 1998\n" +
                            "3. November 15th, 1998\n" +
                            "4. November 19th, 1998");
                        int input4 = Convert.ToInt32(Console.ReadLine());

                        switch (input4) {
                            case 1:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 2:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 3:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 4:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine($"What is the correct way to print/write a line in C#?\n" +
                            "1. Console.WriteLine(\"\");\n" +
                            "2. print(\"\")\n" +
                            "3. cout << \"\";\n" +
                            "4. System.out.println(\"\");");
                        int input5 = Convert.ToInt32(Console.ReadLine());

                        switch (input5) {
                            case 1:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                break;
                            case 2:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 3:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 4:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine($"How many stars are on the US flag?\n" +
                            "1. 52\n" +
                            "2. 50\n" +
                            "3. 53\n" +
                            "4. 51");
                        int input6 = Convert.ToInt32(Console.ReadLine());

                        switch (input6) {
                            case 1:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 2:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                break;
                            case 3:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 4:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 7:
                        Console.WriteLine($"What does a geiger counter measure?\n" +
                            "1. Radon\n" +
                            "2. Geiger\n" +
                            "3. Radiation\n" +
                            "4. Microwave");
                        int input7 = Convert.ToInt32(Console.ReadLine());

                        switch (input7) {
                            case 1:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 2:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 3:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                break;
                            case 4:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 8:
                        Console.WriteLine($"How many months have 28 days?\n" +
                            "1. 1\n" +
                            "2. 12\n" +
                            "3. 4\n" +
                            "4. 7");
                        int input8 = Convert.ToInt32(Console.ReadLine());

                        switch (input8) {
                            case 1:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 2:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                break;
                            case 3:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 4:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 9:
                        Console.WriteLine($"Connor's father had three children. The first named April, the second named May. What was the third child named?\n" +
                            "1. June\n" +
                            "2. John\n" +
                            "3. August\n" +
                            "4. Connor");
                        int input9 = Convert.ToInt32(Console.ReadLine());

                        switch (input9) {
                            case 1:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 2:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 3:
                                lives--;
                                Console.WriteLine("Incorrect");
                                break;
                            case 4:
                                questions++;
                                Console.Clear();
                                Console.WriteLine("Correct!\n");
                                goto TheWin;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            } while (lives > 0);
            if (lives == 0) {
                questions = 0;
                Console.WriteLine("You lost. No points gained.");
            }
        TheWin:
            {
                Console.WriteLine($"Congratulations!\nYou've gained points for every question, and one for winning.\nYou have {lives} live(s) left\nPress any key to return.");
                Program.totalWins = Program.totalWins + questions;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
