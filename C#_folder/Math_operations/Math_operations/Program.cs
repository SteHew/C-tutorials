using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double number1 = 10.4;
            double number2 = 15;

            Console.WriteLine("Math.Abs (absolute number1): " + (Math.Abs(number1)));
            Console.WriteLine("Math.Ceiling (number1 rounded up): " + (Math.Ceiling(number1)));
            Console.WriteLine("Math.Floor(number1 rounded down): " + (Math.Floor(number1)));
            Console.WriteLine("Math.Max(the higher of number1 and number2): " + (Math.Max(number1, number2)));
            Console.WriteLine("Math.Min(the lower of number1 and number2): " + (Math.Min(number1, number2)));
            Console.WriteLine("Math.Pow(number1 to the power of 2): " + (Math.Pow(number1, 2)));
            Console.WriteLine("Math.Round(number1 rounded to nearest round number): " + (Math.Round(number1)));
            Console.WriteLine("Math.Sqrt(square root of number2): " + (Math.Sqrt(number2)));
            */

            
            
            Random variableName = new Random();
            for (int i = 1; i < 26; i++)
            {
                    Console.WriteLine("Random number - Item " + i + ": " + (variableName.Next(1,101)));
            }

            

            //int age = 4;

            /*
            if ((age>=5) && (age<=9))
            {
                Console.WriteLine("Go to Primary school.");
            } else if ((age>9) && (age<13))
            {
                Console.WriteLine("Go to intermediate school.");
            } else
            {
                Console.WriteLine("Go to high school.");
            }
            */

            /*
            // ternary operator
            bool canDrive = age >= 16 ? true : false;
            {
                Console.WriteLine("This person is old enough to drive. True or False? " + canDrive);
            }
            */

            /*
            // switch statements
            switch (age)
            {
                case 0:
                    Console.WriteLine("Baby");
                    break;
                case 1:
                    Console.WriteLine("Infant");
                    break;
                case 2:
                    Console.WriteLine("Toddler");
                    break;
                default:
                    Console.WriteLine("Child");
                    break;
            }
            */
        }
    }
}
