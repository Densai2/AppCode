using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentUnit5
{
    class Tournament
    {
        const int MAXN_SCORES = 6;

        // Another way of initialising attributes
        private int[] scores;

        private string[] names;

        /// <summary>
        /// Class Constructor for testing
        /// </summary>
        public Tournament()
        {
            scores = new int[MAXN_SCORES];
            names = new string[]
            {
                "Henry",
                "Daisy",
                "Hannah",
                "Dylan",
                "Sue",
                "Frank"
            };
        }
        //<summery>
        //Asks for scores, and then stores it as an interger.
        //</summery>
        public void GetScores()
        {
            CO453ClassConsoleApp.SimpleIO.WriteTitle("Enter Tournament Scores", "Task 5.1");

            for (int i = 0; i < MAXN_SCORES; i++)
            {
                Console.Write("Enter score for player " + (i + 1) + " > ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //<summery>
        //This will get the names and scores for all of the players
        //</summery>
        public void GetDetails()
        {
            CO453ClassConsoleApp.SimpleIO.WriteTitle("Enter Tournament scores", "Task 5.1");
            for (int index = 0; index < MAXN_SCORES; index++)
            {
                Console.WriteLine("Enter name for player " + (index + 1));
                names[index] = Console.ReadLine();

                Console.WriteLine("Enter score for player" + (index + 1));
                scores[index] = Convert.ToInt32(Console.ReadLine());
            }
        }
            
        //<summery>
        //Shows the players and their scores to the user
        public void ShowDetails()
        {
            CO453ClassConsoleApp.SimpleIO.WriteTitle("Show tournament scores", "Task 5.1");
            for (int i = 0; i < MAXN_SCORES; i++)
            {
                Console.WriteLine("Player " + names[i] + " scored " + scores[i]); 
            }
        }
    }
}
