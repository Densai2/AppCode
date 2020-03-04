using CO453_ClassConsoleApp.Unit4;
using CO453_ClassConsoleApp.Unit5;
using BodyMassIndexCalcualtor;
using CO453ClassConsoleApp.SPS;
using CO453ClassConsoleApp.Unit4;
using CO453ClassConsoleApp.Unit5;
using System;
using TournamentUnit5;

namespace CO453ClassConsoleApp
{
    /// <summary>
    /// This class create objects for each of the tasks as
    /// defined in Part A of CO453 and tests that each object
    /// works
    /// 
    /// Objects include: DistanceConverter,  Book, torunament,
    /// song list, BMI calculator, motel booking and RPS game.
    /// 
    /// Author: Daniel Grace
    /// </summary>
    class Program
    {
        /// <summary>
        /// This method is called first when the program is executed
        /// </summary>
        static void Main(string[] args)
        {
            TestDistanceConverter();    // T4.1
            //TestBook();                 // T4.2 and T4.3
            //TestTournament();           // T5.1 and 5.3
            //TestSongs();                // T5.2
            //TestBMI();
            //TestMotelBooking();         // T5.6
            //TestRPS_Game();
        }

       private static void TestBMI()
        {
            BMI bMI = new BMI();

            BMI.Calculator();
        }

        private static void TestRPS_Game()
        {
            GameController controller = new GameController();
            controller.RunGame();
        }

        /// <summary>
        /// Task 5.6
        /// A simple room booking system
        /// </summary>
        private static void TestMotelBooking()
        {
            BatesMotel motel = new BatesMotel();

            SimpleIO.WriteTitle("The Bates Motel", "Task 5.6");

            string[] choices =
            {
                "1. Book a Room",
                "2. Vacate a Room",
                "3. Display All Rooms",
                "4. Vacate All Rooms",
                "5. Quit"
            };

            int choice = SimpleIO.GetChoice(choices);

            switch (choice)
            {
                case 1:
                    motel.Book(1, 2);
                    break;
                case 2:
                    break;

                default:
                    break;
            }
        }
        /// <summary>
        /// Task 5.2
        /// </summary>
        private static void TestSongs()
        {
            MP3Chart chart = new MP3Chart();

            chart.ShowSongs();

            bool finish = false;

            while (!finish)
            {
                int songNo = chart.GetVotes();
                if (songNo == 0) finish = true;

            }

            chart.ShowVotes();
        }
        /*
        private static void TestBMI()
        {
            BMI BMI = new BMI();
        }
        */

        private static void testSongs()
        {
            MP3Chart chart = new MP3Chart();

            chart.ShowSongs();
            chart.GetVotes();
            chart.ShowVotes();
        }

        /// <summary>
        /// Task 5.1 Create a new Tournamnet object
        /// get the scores for players and show them
        /// </summary>
        private static void TestTournament()
        {
            Tournament tournament = new Tournament();

            tournament.GetDetails();
            tournament.ShowDetails();
            
        }


        /// <summary>
        /// Task 4.2 Create a Book object and test that it writes chapter 1 and 2
        /// Task 4.3 Add a Book Constructor method to initialise all the attributes
        /// </summary>
        private static void TestBook()
        {
            Book book = new Book();

            SimpleIO.WriteTitle("Horror Story", "Task 4.1");

            //book.GetDetails();
            book.GetDetails();
            book.WriteChapter1();
            book.WriteChapter2();
        }

        /// <summary>
        /// Task 4.1 Create a Converter and check that it converts between
        /// miles and feet using double numbers
        /// </summary>
        public static void TestDistanceConverter()
        {
            double miles = 1;
            double feet = 0;

            Console.WriteLine("Danny's Distance Converter");

            DistanceConverter converter = new DistanceConverter();

            int choice = 3;

            string[] choices = new string[]
            {
                "1. Convert Miles to Feet",
                "2. Convert Feet to Miles",
                "3. Quit Test"
            };

            do
            {
                choice = SimpleIO.GetChoice(choices);

                if (choice == 1)
                {
                    miles = converter.GetDouble("Miles");
                    feet = converter.ToFeet(miles);

                    Console.WriteLine("The no of miles = " + miles);
                    Console.WriteLine("The no of feet  = " + feet);
                }
                else if (choice == 2)
                {
                    feet = converter.GetDouble("Feet");
                    miles = converter.ToMiles(feet);

                    Console.WriteLine("The no of feet  = " + feet);
                    Console.WriteLine("The no of miles = " + miles);
                }


            } while (choice != 3);

        }

    }
}