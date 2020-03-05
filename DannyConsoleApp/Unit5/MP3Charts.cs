using System;
using System.Collections.Generic;
using System.Text;

namespace CO453ClassConsoleApp.Unit5
{
    /// <summary>
    /// Task 5.2 Class Example
    /// This class get votes for an array of song titles currently
    /// in the top ten uk chart
    /// Daniel Grace
    /// </summary>
    public class MP3Chart
    {
        public const int MAXN_SONGS = 10;
        private string[] chart;
        private int[] votes = new int[MAXN_SONGS];

        public MP3Chart()
        {
            chart = new string[]
            {
                "Don't Start Now",
                "Dance Monkey",
                "Own It",
                "Blinding Lights",
                "The Box",
                "This is Real",
                "Good as Hell",
                "South of the Border",
                "Physical",
                "Post Malone"
            };
        }

        /// <summary>
        /// Prints the title, gets user's song choice
        /// and then adds one onto the total votes.
        /// </summary>
        public int GetVotes()
        {
            SimpleIO.WriteTitle("Vote for UK Top 10 Chart Singles", "Task 5.2");
            Console.WriteLine("Enter 0 to quit");
            Console.WriteLine();

            int songNo = SimpleIO.GetInt("Enter song no: ");

            if (songNo > 0 && songNo < MAXN_SONGS) votes[songNo - 1]++;

            return songNo;
        }
        /// <summary>
        /// At the end of the process this will display the 
        /// results back to the user.
        /// </summary>
        public void ShowVotes()
        {
            SimpleIO.WriteTitle("UK Top 10 Chart Singles", "Task 5.2");

            int index = 0;

            foreach (string song in chart)
            {
                Console.Write("Song " + (index + 1) + " is " + song);
                Console.WriteLine(" No of votes is " + votes[index]);
                index++;
            }

        }
        /// <summary>
        /// Begins by showing the song choice to the user.
        /// </summary>
        public void ShowSongs()
        {
            SimpleIO.WriteTitle("UK Top 10 Chart Singles", "Task 5.2");

            int position = 0;

            foreach (string song in chart)
            {
                position++;
                Console.WriteLine("Song " + position + " is " + song);
            }
        }
    }
}