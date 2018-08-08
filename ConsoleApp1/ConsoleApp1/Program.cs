using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nike = "";
            int call = 0;
            int hunter = 0;
            int predator = 0;
            string value = "";
            string play = "";



            Console.WriteLine("Welcome to PREY, where we will discover which of us is the predator, and which is the prey.");
            Console.ReadKey();
            Console.WriteLine("The rules are simple, we will both think of a number between 1 and 500. First to guess the opponent's number wins.");
            Console.WriteLine("After you guess, I will tell you if my number is more or less. After my guess, you will do the same. Just say 'hit' when I catch you. ");
            Console.WriteLine("Are you ready? (y/n)");
            nike = Console.ReadLine();

            if (nike != "y")
            {
                Console.WriteLine("COWARD!!!1!");
                
            }
            else
            {
                do
                {
                    Random rnd = new Random();
                    predator = rnd.Next(1, 501);
                    Console.WriteLine("but who should go first?");
                    Console.WriteLine("Let's settle this with heads or tails. Call it.");
                    Console.WriteLine("(heads/tails)");
                    string coin = Console.ReadLine();
                    if (coin == "heads")
                    {
                        call = 1;
                    }
                    else
                    {
                        call = 2;
                    }
                    int toss = rnd.Next(1, 4);
                    if (toss == call)
                    {
                        Console.WriteLine("You called it. Make your guess.");
                        string guess = Console.ReadLine();
                        hunter = Convert.ToInt32(guess);
                        if (hunter == predator)
                        {
                            Console.WriteLine("IMPOSSIBLE! We must play again.");
                            Console.ReadKey();

                        }
                        else if (hunter < predator)
                        {
                            Console.WriteLine("more");
                        }
                        else if (hunter > predator)
                        {
                            Console.WriteLine("less");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You were wrong, I'll guess first");
                    }

                    int minGuess = 0;
                    int maxGuess = 501;
                    do
                    {
                        int compGuess = rnd.Next(minGuess += 1, maxGuess);
                        Console.WriteLine("My Guess: " + compGuess);
                        value = Console.ReadLine();
                        if (value == "hit")
                        {
                            Console.WriteLine("I knew I'd get you.");
                            break;
                        }
                        else if (value == "more")
                        {
                            minGuess = compGuess;
                        }
                        else if (value == "less")
                        {
                            maxGuess = compGuess;
                        }
                        Console.WriteLine("Your guess?");
                        string guess = Console.ReadLine();
                        hunter = Convert.ToInt32(guess);
                        if (hunter == predator)
                        {
                            Console.WriteLine("IMPOSSIBLE! We must play again.");
                            Console.ReadKey();
                            break;
                        }
                        else if (hunter < predator)
                        {
                            Console.WriteLine("more");
                        }
                        else if (hunter > predator)
                        {
                            Console.WriteLine("less");
                        }


                    } while (hunter != predator || value != "hit");

                    Console.WriteLine("Play again? (y/n)");
                    play = Console.ReadLine();
                    if (play == "n")
                    {
                        break;
                    }
                } while (play != "n");


            }
                
            }
                
        }
    }

