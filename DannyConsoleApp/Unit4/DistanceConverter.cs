using System;
using System.Collections.Generic;
using System.Text;

namespace CO453_ClassConsoleApp.Unit4
{
    /// <summary>
    /// This class will convert miles to feet, or feet to miles
    /// Author: Daniel Grace
    /// </summary>
    public class DistanceConverter
    {
        public double ToFeet(double miles)
        {
            return miles * 1760.00 * 3;
        }

        public double ToMiles(double feet)
        {
            return feet / (1760.00 * 3);
        }

        public double GetDouble(string prompt)
        {
            Console.WriteLine("Please enter the number of " + prompt);

            string input = Console.ReadLine();
            double number = Convert.ToDouble(input);


            return number;
        }
    }
}