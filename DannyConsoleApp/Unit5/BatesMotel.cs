using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// This program will run a simple Motel booking and checking system.
/// </summary>
namespace BatesMotel.Unit5
{
    /// <summary>
    /// The variables are set for later use in the code.
    /// </summary>
    public class RunBatesMotel
    {
        public const int MAXN_ROOMS = 20;
        public const int MAXN_GUESTS = 4;
        private static int[] rooms;
        private int roomNumber, guests;
        private static int roomsBooked = 0, totalGuests = 0;

        public void MotelRooms()
        {
            rooms = new int[MAXN_ROOMS + 1];
        }
        /// <summary>
        /// Prints the menu to the user and gives number choices
        /// when a number matches a choice, it will send the 
        /// user to the correct area.
        /// </summary>
        public void RunBates()
        {
            string choice = "";

            do
            {
                Console.Clear();
                Console.WriteLine("The Bates Motel");
                Console.WriteLine("==================");
                Console.WriteLine("Enter a number for the task you wish to do");
                Console.WriteLine("1. Book a room");
                Console.WriteLine("2. Vacate a room");
                Console.WriteLine("3. Display all rooms");
                Console.WriteLine("4. Vacate all rooms");
                Console.WriteLine("5. Quit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                if(choice == "1")
                {
                    BookRoom();
                }
                if(choice == "2")
                {
                    VacateARoom();
                }
                if(choice == "3")
                {
                    DisplayRooms();
                }
                if(choice == "4")
                {
                    VacateAllRooms();
                }
            } while (choice != "5");
        } 
        /// <summary>
        /// Asks user for a room number, and checks if
        /// conditions are met to book the room.
        /// </summary>
        public void BookRoom()
        {
            Console.WriteLine("===============");
            Console.WriteLine("The Bates Motel");
            Console.WriteLine("===============");
            Console.WriteLine("Book a room");

            Console.Write("Enter a room number: ");
            do
            {
                roomNumber = Convert.ToInt32(Console.ReadLine());
                if(rooms[roomNumber] != 0)
                {
                    Console.WriteLine("Sorry this room is booked");
                    Console.Write("Please choose a different room");
                }
            } while (rooms[roomNumber] != 0);

            Console.Write("How many guests?: ");

            do
            {
                guests = Convert.ToInt32(Console.ReadLine());
                if (guests > MAXN_GUESTS)
                {
                    Console.WriteLine("You can only have 4 guests in a room " + roomNumber);
                    Console.Write("How many guests?: ");
                }
            } while (guests > MAXN_GUESTS);
            
            rooms[roomNumber] = guests;

            totalGuests += guests;
            roomsBooked++;
        }
        /// <summary>
        /// Asks for a room to vatcate and returns
        /// the room's value to 0.
        /// </summary>
        public void VacateARoom()
        {
            Console.Write("Which room would you like to vacate?: ");
            roomNumber = Convert.ToInt32(Console.ReadLine());
            totalGuests -= rooms[roomNumber];
            rooms[roomNumber] = 0;
            Console.WriteLine("Room " + roomNumber + " has been vacated");
            roomsBooked -= 1;
            Console.ReadKey();
        }
        /// <summary>
        /// Displays all of the rooms with the amount
        /// of guests that they have.
        /// </summary>
        public void DisplayRooms()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Bates Motel room status");
            Console.WriteLine("=======================");

            for(int i=1; i < MAXN_ROOMS + 1; i++)
            {
                Console.WriteLine("Room " + i + "\t" + rooms[i] + " guests");
            } Console.ReadKey();
        }
        /// <summary>
        /// Clears the entire Motel of bookings.
        /// </summary>
        public void VacateAllRooms()
        {
            Array.Clear(rooms, 0, rooms.Length);

            Console.WriteLine("All rooms ahve been vacated!");
        }
    }
}