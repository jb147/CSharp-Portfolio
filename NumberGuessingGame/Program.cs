using Microsoft.VisualBasic;
using System.Reflection.Metadata.Ecma335;

namespace NumberGuessingGame
{
    internal class Program
    {
        private static readonly Random rnd = new Random(); //random instance created main program to ensure randomness
        static void Main(string[] args)
        {
            int magicNumber = 0;
            int userGuess = 0;
            int games = 0;
            int wins = 0;
            int losses = 0;
            decimal pct = 0;
;           string continueGame = "";

            do
            {

                games++;
                GenMagicNumber(ref magicNumber);
                Console.WriteLine(magicNumber); //cheat
                UserGuess(ref userGuess, ref magicNumber, ref wins, ref losses);
                ContinueGame(ref continueGame);
                Stats(ref games, ref wins, losses, ref pct);
            } while (continueGame != "n");
            

        }

        static void Stats (ref int games, ref int wins, int losses, ref decimal pct)
        {
            
            Console.WriteLine($"Games Played: {games}");
            Console.WriteLine($"Wins: {wins}");
            Console.WriteLine($"Losses: {losses}");
            pct = (decimal)wins / games;
            Console.WriteLine($"Win Percent: {pct.ToString("%0.00")}");
           


        }

        static void ContinueGame(ref string continueGame)
        {
            Console.WriteLine("\nWould you like to play another game? [Y/N]");
            continueGame = Console.ReadLine()!;
            continueGame.ToLower();
            Console.Clear();
            
        }

        static void GenMagicNumber(ref int magicNumber)
        {
            magicNumber = rnd.Next(1, 100);
        }

        static void UserGuess(ref int userGuess, ref int magicNumber,ref int wins,ref int losses)
        {
            int i = 1;
            Console.WriteLine("The magic number is between 1 & 100. You have 5 attempts to guess the magic number. I will tell you if your guess was higher or lower\n");
            
            do
            {
                



                while (i < 7)
                {
                    Console.WriteLine(i);
                    if (i == 6)
                    {
                        losses++;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"You are out of guesses! The magic number was {magicNumber}.");
                        Console.ResetColor();

                        return;

                    }
                    else if (i > 6) 
                    {
                        break;
                    }

                    Console.Write($"Guess {i}: ");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    Logic(ref userGuess, ref magicNumber, ref i, ref wins);


                }
            } while (userGuess != magicNumber);
        }

        static void Logic(ref int userGuess, ref int magicNumber, ref int i, ref int wins)
        {
            if (userGuess == magicNumber)
            {
                wins++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nYour guess is correct!, {userGuess} was indeed the magic number.");
                Console.ResetColor();
                Console.WriteLine($"You needed {i} guesses\n");
                i = 7;
                

            }
            else if (userGuess > magicNumber) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYour guess is not correct!, The magic number is lower than that.");
                Console.ResetColor();
                Console.WriteLine($"Guesses Remaining: {5 - i}\n");
                i++;
            }
            else if (userGuess < magicNumber)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYour guess is not correct!, The magic number is higher than that.");
                Console.ResetColor();
                Console.WriteLine($"Guesses Remaining: {5 - i}\n");
                i++;
            }
        }
    }
}