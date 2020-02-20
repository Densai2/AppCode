using System;

namespace CO453ClassConsoleApp.SPS
{
    public enum Players
    {
        COMPUTER,
        PLAYER
    }

    /// <summary>
    /// This class plays ...
    /// Author: 
    /// Started: 12/02/2019
    /// </summary>
    public static class SPS_Game
    {
        public const string SCISSORS = "SCISSORS";
        public const string STONE = "STONE";
        public const string PAPER = "PAPER";
        public const string UNKOWN = "UNKNOWN";

        public static string PlayerName { get; set; }
        public static string ComputerName { get; set; }
        public static string ComputerChoice { get; set; }
        public static string PlayerChoice { get; set; }
        public static string Winner { get; set; }

        private static Random randomGenerator = new Random();

        public static void Start()
        {
            PlayerName = "Derek";
            ComputerName = "Computer";
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public static void End()
        {
            Winner = "No Winner";
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public static void GetComputerChoice()
        {
            int choice;
            choice = randomGenerator.Next(3);

            if (choice == 0)
            {
                ComputerChoice = SCISSORS;
            }
            else
            {
                ComputerChoice = UNKOWN;
            }
        }


        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public static void WorkoutWinner()
        {
            if (PlayerChoice == ComputerChoice)
            {
                Winner = "You have Drawn!!!";
            }
            else
            {
                Winner = "Not Yet Determined!!!";
            }

        }
    }
}