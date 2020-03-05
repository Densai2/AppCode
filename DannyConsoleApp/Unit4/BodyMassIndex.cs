using System;
using System.Collections.Generic;
using System.Text;

namespace BodyMassIndexCalcualtor
{
    public class BMI
    {
        /// <summary>
        /// This gets the user's weight & height, and then converts it to a double.
        /// </summary>
        public static void Calculator()
        {
            Console.Write("Enter your weight (kg): ");
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is your height(metres): ");
            double metres = Convert.ToDouble(Console.ReadLine());   

            double BMI = kg / (metres * metres);
            Console.WriteLine("Your BMI is: " + Math.Round(BMI, 2));


            if (BMI <= 16)
            {
                Console.WriteLine("You're severely underweight")
            ;
            }
            else if (BMI <= 18.5)
            {
                Console.WriteLine("You're underweight");
            }
            else if (BMI <= 25)
            {
                Console.WriteLine("You're a normal weight");
            }
            else if (BMI <= 30)
            {
                Console.WriteLine("You're overweight");
            }
            else if (BMI <= 35)
            {
                Console.WriteLine("You're moderately obese");
            }
            else
            {
                Console.WriteLine("You're severely obese");
            }
        }
    }
}

