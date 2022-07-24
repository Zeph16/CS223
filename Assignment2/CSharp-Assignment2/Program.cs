using System;

namespace Program
{
    class GTN
    {
        static void Main(String[] args)
        {
            int num, diff, guess, pts, loops ;
            bool guessed, valid = true;
            guess = pts = loops = 0;
            

            while (true)
            {
                guessed = false;
                num = rng(1, 9);
                diff = menu(pts, loops);
                switch (diff)
                {
                    case 1:
                        diff = 5;
                        break;
                    case 2:
                        diff = 3;
                        break;
                    case 3:
                        diff = 1;
                        break;
                }

                Console.Clear();
                for (int i = 1; i <= diff; i++)
                {

                    Console.WriteLine(" ~~~~~~~~~~~~~~~~ Games: " + loops + " ~~~~~~~~~ Score: " + pts + " ~~~~~~~~~~~~~~~~");
                    if (diff != 1)
                        Console.WriteLine("  -> I'm thinking of a number between 1 and 9, including both. \n" +
                                          "  ...I'll give you " + diff + " tries, take a guess!");
                    else
                        Console.WriteLine("  -> I'm thinking of a number between 1 and 9, including both. \n" +
                                          "  ...I'll give you only " + diff + " try, see if you can get it!");
                    Console.WriteLine(" Guess #" + i);
                    if (i != 1 && valid)
                        Console.WriteLine(respond(guess, false) + " Try again!");

                    try
                    {
                        Console.Write(" >> ");
                        guess = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        valid = false;
                        Console.Clear();
                        Console.WriteLine(" Can you not read? I said guess a number...");
                        i--;
                        continue;
                    }
                    if (guess > 9 || guess < 1)
                    {
                        valid = false;
                        Console.Clear();
                        Console.WriteLine(" I just said my number was between 1 and 9...");
                        i--;
                        continue;
                    }

                    if (guess == num)
                    {
                        guessed = true;
                        break;
                    }
                    else if (i != diff)
                        Console.Clear();
                    valid = true;
                }
                loops++;

                Console.WriteLine();
                if (guessed)
                {
                    Console.WriteLine(respond(guess, true));
                    if (diff == 1)
                        pts += 10;
                    else if (diff == 3)
                        pts += 3;
                    else
                        pts += 1;
                }
                else
                    Console.WriteLine(" Welp! You're out of tries. My number was " + num + "!");
                Console.Write(" Press any key to return to the main menu...");
                Console.ReadKey();
            }
        }

        static int rng(int start, int end)
        {
            Random rand = new Random();
            return rand.Next(start, end + 1);
        }

        static string respond(int n, bool right)
        {
            string[] negative = {" Nope! It's not " + n + ".",
                                 " It's not " + n + "!",
                                 " I'm not thinking of " + n + "."};
            string[] positive = {" Yes! My number was " + n + "!",
                                 " You got it, it was " + n + "!",
                                 " My number was " + n + ", you got insane luck!"};
            Random rand = new Random();
            int selection = rand.Next(0, 3);
            if (right)
                return positive[selection];
            return negative[selection];
        }

        static int menu(int pts, int games)
        {
            string choice;
            int sel;
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" ~~~~~~~~~~~~~~~~ Games: " + games + " ~~~~~~~~~ Score: " + pts + " ~~~~~~~~~~~~~~~~");
                Console.WriteLine(" Welcome to Guess The Number! Select a difficulty: \n" +
                                  " (Higher difficulties grant higher scores)");
                Console.WriteLine("\t1.Easy\t2.Hard\t3.Impossible\t4.Exit");
                Console.Write(" >> ");
                try
                {
                    choice = Console.ReadLine();
                    if (choice == "4" || choice.ToLower() == "exit")
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.Write(" You played a total of " + games + " times with a score of " + pts + "!\n" +
                                      " Thanks for trying out the program, press any key to exit...");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else if (choice.ToLower() == "easy")
                        choice = "1";
                    else if (choice.ToLower() == "hard")
                        choice = "2";
                    else if (choice.ToLower() == "impossible")
                        choice = "3";
                    sel = int.Parse(choice);
                }
                catch
                {
                    continue;
                }
                if (sel != 1 && sel != 2 && sel != 3)
                    continue;

                return sel;
            }
        }

    }
}