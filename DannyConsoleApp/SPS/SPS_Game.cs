﻿using System;

namespace CO453ClassConsoleApp.SPS
{
    public enum RPS_Players
    {
        NONE,
        COMPUTER,
        PLAYER
    }

    public enum RPS_Choices
    {
        UNKOWN,
        ROCK,
        PAPER,
        SCISSORS,
    }

    /// <summary>
    /// This class plays ...
    /// Author: Daniel
    /// Started: 12/02/2019
    /// Modified : 26/02/2020
    /// </summary>
    public class RPS_Game
    {
        public const string COMPUTER_NAME = "Computer";

        public string PlayerName { get; set; }
        //public string ComputerName { get; set; }
        public string WinnerName { get; set; }

        public RPS_Choices ComputerChoice { get; set; }
        public RPS_Choices PlayerChoice { get; set; }

        private Random randomGenerator = new Random(123);

        public void Start(string player)
        {
            PlayerName = player;
            WinnerName = "Unkown";
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void End()
        {
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void GetComputerChoice()
        {
            int choice;
            choice = randomGenerator.Next(3);

            if (choice == 0)
            {
                ComputerChoice = RPS_Choices.ROCK;
            }
            else if (choice == 1)
            {
                ComputerChoice = RPS_Choices.PAPER;
            }
            else
            {
                ComputerChoice = RPS_Choices.SCISSORS;
            }
        }


        /// <summary>
        /// *******************************************************
        /// This will determine whether the computer has won / drawn
        /// or the player has won / drawn
        /// *******************************************************
        /// </summary>
        public void WorkoutWinner()
        {
            if (PlayerChoice == ComputerChoice)
            {
                WinnerName = "You have Drawn!!!";
            }
            else if (PlayerChoice == RPS_Choices.ROCK && ComputerChoice == RPS_Choices.SCISSORS)
            {
                WinnerName = PlayerName;
            }
            else if (PlayerChoice == RPS_Choices.ROCK && ComputerChoice == RPS_Choices.PAPER)
            {
                WinnerName = COMPUTER_NAME;
            }
            else if (PlayerChoice == RPS_Choices.SCISSORS && ComputerChoice == RPS_Choices.PAPER)
            {
                WinnerName = PlayerName;
            }
            else if (PlayerChoice == RPS_Choices.SCISSORS && ComputerChoice == RPS_Choices.ROCK)
            {
                WinnerName = COMPUTER_NAME;
            }

            else if (PlayerChoice == RPS_Choices.PAPER && ComputerChoice == RPS_Choices.ROCK)
            {
                WinnerName = PlayerName;
            ;}
            else if (PlayerChoice == RPS_Choices.PAPER && ComputerChoice == RPS_Choices.SCISSORS)
            {
                WinnerName = PlayerName;
            }
            else
            {
                WinnerName = "You've drawn!!!";
            }

        }
    }
}