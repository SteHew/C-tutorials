﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP6211exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Exercise1 - Hello greeting

            Console.WriteLine();
            Console.WriteLine("Hello.");
            Console.WriteLine();
            Console.WriteLine("My name is Stephen Hewlett.");

            Console.ReadLine();
            */
            /*
            // Exercise 2 - Addition

            int x = 74;
            int y = 36;
            int z = x + y;

            Console.WriteLine();
            Console.WriteLine("The sum of {0} plus {1} is: {2}", x, y, z);
            Console.ReadLine();

            
            // Exercise 3 - Division

            int a = 50;
            int b = 3;
            int c = a / b;

            Console.WriteLine("{0} divided by {1} results in {2} with a remainder of 2.", a, b, c);
            Console.ReadLine();
            Console.WriteLine();


            // Exercise 4 - Product of user defined numbers

            Console.Write("Please enter a number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Now enter a second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int product = firstNumber * secondNumber;

            Console.WriteLine("When the two numbers are multiplied, the answer is: " + product);
            Console.ReadLine();
            Console.WriteLine();


            // Exercise 5 - multiplication table

            Console.Write("Please enter another number: ");
            int anyNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Here is a multiplication table for the number you entered:");
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", anyNumber, i, anyNumber * i);
            }
            Console.WriteLine();


            // Exercise 6 - circle area and perimeter

            double radius = 7.5;
            double pi = Math.PI;
            double area = pi * (radius * radius);
            double perim = pi * radius * 2;

            Console.WriteLine();
            Console.WriteLine("A circle with radius 7.5 has an area of {0} and a perimeter of {1}.", 
                area, perim);
            Console.WriteLine();
            */


            // Exercise 7 - swap two variables

            Console.WriteLine();
            Console.WriteLine("This program starts with two variables in alpha order, " +
                "then it swaps the order of the two variables.");
            Console.WriteLine();
            Console.WriteLine("Press enter.");
            Console.ReadLine();

            string variables = "  X  " + "  Y  ";
            Console.WriteLine("The two variables are: " + variables);
            Console.WriteLine();
            Console.WriteLine("Press enter again to swap the order of the variables.");
            Console.WriteLine();
            Console.ReadLine();

            char[] charArray = variables.ToCharArray();
            Array.Reverse(charArray);
            /*
            foreach (char variablesChar in charArray)
            {
                Console.Write(variablesChar);
            }
            */
            Console.Write("The variables are now: ");
            Console.WriteLine(charArray);
            Console.ReadLine();
        }
    }
}
