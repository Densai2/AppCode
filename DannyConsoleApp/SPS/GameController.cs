using System;

namespace CO453ClassConsoleApp.SPS
{
    /// <summary>
    /// Thuis class will handle the input and output
    /// of the SPS Game
    /// </summary>
    public class GameController
    {
        public static string Title = "Scissors-Paper-Stone Game";

        public const int MAXN_TURNS = 3;

        private static string playerName = "Derek";

        private static int turn;

        public static void RunGame()
        {
            SetupScreen();
            StartGame();

            for (turn = 1; turn <= MAXN_TURNS; turn++)
            {
                GetPlayerChoice();
                SPS_Game.GetComputerChoice();

                ShowChoices();

                SPS_Game.WorkoutWinner();
                ShowResult();

                Console.WriteLine();
                Console.Write("Press any key!");
                Console.ReadKey();
            }

            SPS_Game.End();
            EndGame();
        }

        /// <summary>
        /// 
        /// </summary>
        private static void EndGame()
        {
            Console.Clear();
            SimpleIO.WriteTitle(Title, "Week 3");

            Console.WriteLine("The overall winner is " + SPS_Game.Winner);
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private static void GetPlayerChoice()
        {
            Console.Clear();
            SimpleIO.WriteTitle(Title, "Week 3");

            Console.WriteLine("Turn no " + turn + " of " + MAXN_TURNS);

            string[] choices = new string[]
            {
                SPS_Game.SCISSORS,
                SPS_Game.PAPER,
                SPS_Game.STONE
            };

            int choiceNo = SimpleIO.GetChoice(choices);
            SPS_Game.PlayerChoice = choices[choiceNo - 1];

            Console.WriteLine();
        }

        /// <summary>
        /// This method draws out an image of the choice for
        /// either the computer, or the player.  The player's
        /// choice is drawn at (x = 5, y = 14) and the computers 
        /// choice at (x = 50, y = 14)
        /// FIND THE SINGLE MISTAKE!!!
        /// </summary>
        private static void DrawChoice(Players player)
        {
            string choice;
            int x;
            int y = 14;

            if (player == Players.COMPUTER)
            {
                x = 5;
                choice = SPS_Game.ComputerChoice;
            }
            else
            {
                choice = SPS_Game.PlayerChoice;
                x = 5;
            }

            if (choice == SPS_Game.SCISSORS)
            {
                Images.DrawScissors(x, y);
            }
            else if (choice == SPS_Game.PAPER)
            {
                Images.DrawPaper(x, y);
            }
            else if (choice == SPS_Game.STONE)
            {
                Images.DrawStone(x, y);
            }
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private static void ShowChoices()
        {
            DrawChoice(Players.PLAYER);
            DrawChoice(Players.COMPUTER);

            Console.WriteLine("\n\tYou picked " + SPS_Game.PlayerChoice);
            Console.WriteLine("\tThe computer choice is " + SPS_Game.ComputerChoice);
            Console.WriteLine();
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private static void ShowResult()
        {
            Console.WriteLine("\tThe current winner is the " + SPS_Game.Winner);
            Console.WriteLine();
            Console.WriteLine("\tThe player has won ");
            Console.WriteLine("\tThe computer has won ");
        }


        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private static void SetupScreen()
        {
            Console.Title = Title;

            Console.SetWindowSize(100, 36);
            Console.SetBufferSize(100, 36);

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();  // clear screen in chosen colour
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private static void StartGame()
        {
            SimpleIO.WriteTitle(Title, "Week 3");
            SPS_Game.Start();
        }
    }
}