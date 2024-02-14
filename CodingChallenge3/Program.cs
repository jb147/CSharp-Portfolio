//John Coulter
//2024-02-09

namespace CodingChallenge3
{
    /// <summary>
    /// This Program is a Rock, Paper, Scissors game that let's a user play against an AI
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variables
            bool continueGame = true; //to determine if the game should continue
            int userChoice = -1; //user choice stored as an integer
            int aiChoice = 0; //ai choice
            int rndLower = 0; //lower value that rnd will generate
            int rndUpper = 3; //upper value that rnd will generate
            int gamesPlayed = 0; //count number of games played 
            int wins = 0; //count player wins
            int losses = 0; //count player losses            
            int playerRocks = 0, playerPapers = 0, playerScissors = 0; //count distribution of player guesses
            string playerStyle = "random"; //the players preferred option (bias) calculated by GetPlayerStyle method
            string gameState = "CURRENT";

            //while loop continues until player opts to stop playing
            while (continueGame)
            {
                Console.Clear();
                userChoice = -1;

                //while loop to get a valid choice from the user
                while (userChoice < 0)
                {
                    userChoice = GetUserChoice(ref playerRocks, ref playerPapers, ref playerScissors);                   
                }
                playerStyle = GetPlayerStyle(playerRocks, playerPapers, playerScissors, ref playerStyle, gamesPlayed);
                aiChoice = GetAIChoice(rndUpper, rndLower, playerStyle);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Showdown(userChoice, aiChoice, ref wins, ref losses, ref rndUpper, ref rndLower, ref gamesPlayed);  
                Console.ResetColor();
                DisplayStats(ref gamesPlayed, wins, losses, gameState);
                continueGame = ContinueGame(ref gamesPlayed, wins, losses, gameState);
                





                //GameDebug(rndUpper, rndLower, playerStyle);//To debug the game and nake it balanced
            }
                       
        }

        /// <summary>
        /// This method sets the users playing style, based on how often they chose a specific option
        /// </summary>
        /// <param name="playerRocks"></param>
        /// <param name="playerPapers"></param>
        /// <param name="playerScissors"></param>
        /// <param name="playerStyle"></param>
        /// <param name="gamesPlayed"></param>
        /// <returns></returns>
        static string GetPlayerStyle(int playerRocks, int playerPapers, int playerScissors, ref string playerStyle, int gamesPlayed)
        {
            double rocks, papers, scissors, bias;
            const double biasThreshold = 0.38;//This sets the threshold to 38%
            rocks = (double)playerRocks/gamesPlayed;
            papers = (double)playerPapers/gamesPlayed;
            scissors = (double)playerScissors/gamesPlayed;

            if (gamesPlayed > 6)//6 games needed to collect data about player style
            {
                //if statements will determine what option the player selects most
                //if that option has been selected more than 38% of the time, then the player style is set, else the player style will be random
                if (rocks > scissors && rocks > papers)
                {
                    bias = rocks;
                    if(bias >= biasThreshold)
                    {
                        return "rocks";
                    }
                    else
                    {
                        return "random";                        
                    }
                }
                else if (papers >= scissors && papers > rocks)
                {
                    bias = papers;
                    if (bias > biasThreshold)
                    {
                        return "papers";                  
                    }
                    else
                    {
                        return "random";
                    }
                }
                else if ((scissors >= rocks && scissors > papers))
                {
                    bias = scissors;
                    if (bias > biasThreshold)
                    {
                        return "scissors";
                    }
                    else
                    {
                        return "random";
                    }
                }
                
            }
            else
            {
                return "random";//if less than 6 games played return random
            }

            return "random";//in case no other path is found returns random

        }

        
        /// <summary>
        /// This method is to view info about the game, and check correct player style is chosen
        /// </summary>
        /// <param name="rndUpper"></param>
        /// <param name="rndLower"></param>
        /// <param name="playerStyle"></param>
        static void GameDebug(int rndUpper, int rndLower, string playerStyle)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("### DEBUGGING ###");
            
            
            Console.WriteLine($"UPPER RND RANGE: {rndUpper}  LOWER RND RANGE: {rndLower} ");
            Console.WriteLine($"RANGE AVAILABLE: {rndUpper - rndLower}");
            Console.WriteLine($"Player Style: {playerStyle}");
            Console.ResetColor();
            Console.ReadKey();
            
        }

        /// <summary>
        /// This method lets the user decide if they want to keep playing
        /// </summary>
        /// <returns></returns>
        static bool ContinueGame(ref int gamesPlayed, int wins, int losses, string gameState)
        {
            string continueGame = "";
            char _continueGame = ' ';
            Console.Write("\nWould you like to play another game? [Y/N]: ");
            continueGame = Console.ReadLine()!;
            continueGame = continueGame.ToLower();

            if (continueGame == "")//error checking to avoid crash when nothing is entered
            {
                _continueGame = 'y';
            }
            else
            {
                _continueGame = continueGame[0];//if something is entered, takes the first character of the value entered
            }

            switch(_continueGame)//switch returns true, or false if 'n' was entered
            {
                case 'y':
                    return true;

                case 'n':
                    DisplayStats(ref gamesPlayed, wins, losses, gameState = "FINAL");
                    return false;

                default: return true;

            }

        }

        /// <summary>
        /// This method displays the statistics of the game session
        /// </summary>
        /// <param name="gamesPlayed"></param>
        /// <param name="wins"></param>
        /// <param name="losses"></param>
        static void DisplayStats(ref int gamesPlayed, int wins, int losses, string gameState)
        {
            Console.WriteLine("Press any key to view session stats...");
            Console.ReadKey();//pause lets the user see the result of the recent game

            Console.Clear();
            

            Console.WriteLine("##########################################");
            Console.WriteLine($"---------------{gameState} STATS--------------");
            Console.WriteLine("##########################################\n");
            Console.WriteLine($"Games Played: {gamesPlayed}");
            Console.WriteLine($"Player Wins: {wins}");
            Console.WriteLine($"AI Wins: {losses}");
            Console.WriteLine($"TIES: {(gamesPlayed)-losses-wins}");
            Console.WriteLine($"Player's Win %: {((decimal)wins / gamesPlayed) * 100}%");
            Console.WriteLine($"AI's Win %: {((decimal)losses / gamesPlayed) * 100}%");
            Console.WriteLine($"TIED GAMES %: {(decimal)((gamesPlayed)-losses-wins) / gamesPlayed * 100}%");
            if(gameState == "FINAL") { Console.WriteLine("\nThanks for Playing!"); Console.ReadKey(); }
            



        }
        /// <summary>
        /// This method decides the winner of the game
        /// </summary>
        /// <param name="userChoice"></param>
        /// <param name="aiChoice"></param>
        /// <param name="wins"></param>
        /// <param name="losses"></param>
        /// <param name="rndUpper"></param>
        /// <param name="rndLower"></param>
        static void Showdown(int userChoice, int aiChoice, ref int wins, ref int losses, ref int rndUpper, ref int rndLower,ref int gamesPlayed)
        {
            // 0=ROCK :: 1=PAPER :: 2=SCISSORS
            //switch takes userchoice and compares it to aichoice to decide a winner
            //and increment wins/losses by 1
            Console.WriteLine();
            gamesPlayed++;//increase games played by 1

            switch (userChoice)
            {
                case 0: //PLAYER = ROCK
                    if (aiChoice == 0)//AI = ROCK
                    {
                        Console.Write($"AI chose ROCK: ");
                        Console.WriteLine("Game is tied\n");
                        break;
                    }
                    else if(aiChoice == 1)// AI = PAPER
                    {
                        Console.Write($"AI chose PAPER: ");
                        Console.WriteLine("AI WINS!\n");
                        losses += 1;
                        break;
                    }
                    else//AI = SCISSORS
                    {
                        Console.Write($"AI chose SCISSORS: ");
                        Console.WriteLine("PLAYER WINS\n");
                        wins += 1;
                                                
                        break;
                    }
                case 1: //PLAYER = PAPER
                    if (aiChoice == 0) // AI = ROCK
                    {
                        Console.Write($"AI chose ROCK: ");
                        Console.WriteLine("PLAYER WINS!\n");
                        wins += 1;
                                                                       
                        break;
                    }
                    else if (aiChoice == 1) // AI = PAPER
                    {
                        Console.Write($"AI chose PAPER: ");
                        Console.WriteLine("Game is tied\n");
                        break;                       
                    }
                    else //AI = SCISSORS
                    {
                        Console.Write($"AI chose SCISSORS: ");
                        Console.WriteLine("AI WINS!\n");
                        losses += 1;
                        break;
                    }
                default: //PLAYER = SCISSORS
                    if (aiChoice == 0) // AI = ROCK
                    {
                        Console.Write($"AI chose ROCK: ");
                        Console.WriteLine("AI WINS!\n");
                        losses += 1;
                        break;
                    }
                    else if (aiChoice == 1) // AI = PAPER
                    {
                        Console.Write($"AI chose PAPER: ");
                        Console.WriteLine("PLAYER WINS!\n");
                        wins += 1;                       
                        break;
                    }
                    else //AI = SCISSORS
                    {
                        Console.Write($"AI chose SCISSORS: ");
                        Console.WriteLine("Game is tied\n");
                        break;
                    }

            }
                            
            
        }
        /// <summary>
        /// This method gets input from the user, Rock, Paper, or Scissors
        /// </summary>
        /// <param name="playerRocks"></param>
        /// <param name="playerPapers"></param>
        /// <param name="playerScissors"></param>
        /// <returns></returns>
        static int GetUserChoice(ref int playerRocks, ref int playerPapers, ref int playerScissors)
        {
            string choice = "";
            char _choice = ' ';

            Console.Write("Choose between: Rock [R], Paper [P], Scissors [S]: ");
            choice = Console.ReadLine()!;
            choice = choice.ToLower();//set any input to lower case

            if (choice == "")//error check incase user enters nothing
            {
                choice = "x";//set users choice to x to make user choose again
            }
            else// if something was entered, then take the first character
            {
                _choice = choice[0];
            }
        
            //switch statement returns the user choice as integer
            //and increments their choice by 1
            switch (_choice)
            {
                case 'r':
                    playerRocks++;
                    return 0;
                case 'p':                    
                    playerPapers++;
                    return 1;
                case 's':
                    playerScissors++;                    
                    return 2;
                default://if user enters bad choice -1 is returned, and the program will start this method again
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("ERROR: ");
                    Console.ResetColor();
                    return -1;
            }
        }

        /// <summary>
        /// This method is where the AI will decide what to pick<br></br>
        /// Choice will depend on the players playing style/bias
        /// </summary>
        /// <param name="rndUpper"></param>
        /// <param name="rndLower"></param>
        /// <param name="playerStyle"></param>
        /// <returns></returns>
        static int GetAIChoice(int rndUpper, int rndLower, string playerStyle)
        {
            Random rnd = new Random();
            //rocks =0, papers =1, scissors =2
            int aiChoice = 0;//stores the AI choice
            int balancing = 0;//to add randomness this variable will store a random value between 0-99
            const int balancingThreshold = 55;// balancing threshold 55% (AI will choose best option 55% of the time)
            const int balancingMaxThreshold = 90;// balancing threshold 90% (AI will choose worst option 10% of the time & middle option 35% of the time )
            balancing = rnd.Next(0, 100);
            Console.WriteLine();
            //Console.WriteLine($"Balancing = {balancing}");//for testing, need to see what balancing is
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.SetCursorPosition(0, Console.CursorTop - 1);

            //switch statement decides what AI should choose
            switch (playerStyle)
            {
                
                case "papers"://If the player is biased towards choosing Paper
                    
                    if (balancing >= balancingMaxThreshold)//10% of the time AI chooses Rock
                    {
                        return 0;
                    }
                    else if (balancing >= balancingThreshold)//35% of the time AI chooses Paper
                    {
                        return 1;
                    }
                    else return 2; //55% of the time AI chooses Scissors

                case "rocks"://If the player is biased towards choosing Rock

                    if (balancing >= balancingMaxThreshold)//10% of the time AI chooses Scissors
                    {
                        return 2;
                    }
                    else if (balancing >= balancingThreshold)//35 % of the time AI chooses Rock
                    {
                        return 0;
                    }
                    else return 1;//55% of the time AI chooses Paper

                case  "scissors"://If the player is biased towards choosing Scissors
                    if (balancing >= balancingMaxThreshold)//10% of the time AI chooses Scissors
                    {
                        return 1;
                    }
                    else if (balancing >= balancingThreshold)//35 % of the time AI chooses Scissors
                    {
                        return 2;
                    }
                    else return 0;//55% of the time AI chooses Rock

                default://If the player is Random, AI chooses at random
                    aiChoice = rnd.Next(rndLower, rndUpper);
                    return aiChoice;
            }
        }
    }
}



