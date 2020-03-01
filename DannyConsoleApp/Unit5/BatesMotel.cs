using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ClassConsoleApp.Unit5
{
    /// <summary>
    /// Task 5.6 Independant Study
    /// Daniel Grace
    /// </summary>
    public class BatesMotel
    {
        public const int MAXN_ROOMS = 20;

        public const int MAXN_GUESTS = 4;

        public string[] roomsAvalible;

        private int[] rooms = new int[MAXN_ROOMS + 1];


        public BatesMotel()
        {
            roomsAvalible = new string[]
            {
                "Room one",
                "Room two",
                "Room three",
                "Room four",
                "Room five",
                "Room six",
                "Room seven",
                "Room eight",
                "Room nine",
                "Room ten"
            };
        }

        public void Options()
        {
            Console.Write("Please enter your choice: ");
            string choice = Console.ReadLine();
            int userInput = Convert.ToInt32(choice);

            if(userInput == 1)
            {
            }
        }

        public bool Book(int roomNo, int noGuests)
        {
            if (roomNo >= 1 && roomNo <= 20)
            {
                if (noGuests >= 1 && noGuests <= MAXN_GUESTS)
                {
                    rooms[roomNo] = noGuests;
                    Console.WriteLine("Room " + roomNo + " is free.");
                    return true;
                }
            }

            return false;
        }
        public void Rooms()
        {
           int position = 0;

            foreach (string room in roomsAvalible)
            {
                position++;
                Console.WriteLine("Song " + position + " is " + roomsAvalible);
            }
        }
    }
}