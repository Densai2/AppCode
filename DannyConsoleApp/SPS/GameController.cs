using System;
using CO453ClassConsoleApp.SPS;

namespace CO453ClassConsoleApp.SPS
{
    /// <summary>
    /// Thuis class will handle the input and output
    /// of the RPS Game
    /// </summary>
    public class GameController
    {
        public static string Title = "Scissors-Paper-Rock Game";
        
        public const string ROCK = "ROCK";
        public const string PAPER = "PAPER";
        public const string SCISSORS = "SCISSORS";
        public const int MAXN_TURNS = 3;

        private RPS_Game game = new RPS_Game();

        private int turn;

        public void RunGame()
        {
            SetupScreen();
            StartGame();
            
            for(turn = 1; turn <= MAXN_TURNS; turn++)
            {
                GetPlayerChoice();
                game.GetComputerChoice();

                ShowChoices();

                game.WorkOutWinner();
                ShowResult();

                Console.WriteLine();
                Console.Write("Press any key!");
                Console.ReadKey();
            }

            game.End();

            EndGame();
        }

        /// <summary>
        /// 
        /// </summary>
        public void EndGame()
        {
            Console.Clear();
            SimpleIO.WriteTitle(Title, "Week 3");
            game.OverAllWinner();
         
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void GetPlayerChoice()
        {
            Console.Clear();
            SimpleIO.WriteTitle(Title, "Week 3");

            Console.WriteLine("Turn no " + turn + " of " + MAXN_TURNS);

            string[] choices = new string [] 
            { 
                ROCK, 
                PAPER, 
                SCISSORS 
            };

            int choiceNo = SimpleIO.GetChoice(choices);
            
            if(choiceNo == 1)
            {
                game.PlayerChoice = RPS_Choices.ROCK;
            }
            else if(choiceNo == 2)
            {
                game.PlayerChoice = RPS_Choices.PAPER;

            }
            else game.PlayerChoice = RPS_Choices.SCISSORS;

            Console.WriteLine();
        }

        /// <summary>
        /// This method draws out an image of the choice for
        /// either the computer, or the player.  The player's
        /// choice is drawn at (x = 5, y = 14) and the computers 
        /// choice at (x = 50, y = 14)
        /// FIND THE SINGLE MISTAKE!!!
        /// </summary>
        public void DrawChoice(RPS_Players player)
        {
            RPS_Choices choice;

            int x;
            int y = 14;

            if (player == RPS_Players.COMPUTER)
            {
                x = 55;
                choice = game.ComputerChoice;
            }
            else
            {
                choice = game.PlayerChoice;
                x = 5;
            }

            if (choice == RPS_Choices.SCISSORS)
            {
                Images.DrawScissors(x, y);
            }
            else if (choice == RPS_Choices.PAPER)
            {
                Images.DrawPaper(x, y);
            }
            else if (choice == RPS_Choices.ROCK)
            {
                Images.DrawStone(x, y);
            }
        }
        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void ShowChoices()
        {
            DrawChoice(RPS_Players.PLAYER);
            DrawChoice(RPS_Players.COMPUTER);

            Console.WriteLine("\n\t" + game.PlayerName + " picked " + game.PlayerChoice);
            Console.WriteLine("\tThe computer choice is " + game.ComputerChoice);
            Console.WriteLine();
        }
       
        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void ShowResult()
        {
            Console.WriteLine("\t" + game.PlayerName + " score: " + game.PlayerScore);
            Console.WriteLine("\tThe computer's score: " + game.ComputerScore);
            Console.WriteLine("\tThe winner is " + game.WinnerName);

        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void SetupScreen()
        {
            Console.Title = Title;

            Console.SetWindowSize(100, 36);
            Console.SetBufferSize(100, 36);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();  // clear screen in chosen colour
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void StartGame()
        {
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
            SimpleIO.WriteTitle(Title, "Week 3");
            game.Start(userName);
        }
   
    }
}