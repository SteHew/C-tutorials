using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial_program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            */

            /*
            int maxInt = int.MaxValue;
            Console.WriteLine("Maximum integer: " + maxInt);

            int minInt = int.MinValue;
            Console.WriteLine("Minimum integer: " + minInt);

            long maxLong = long.MaxValue;
            Console.WriteLine("Maximum long number: " + maxLong);

            decimal maxDec = decimal.MaxValue;
            Console.WriteLine("Maximum decimal value: " + maxDec);

            decimal minDec = decimal.MinValue;
            Console.WriteLine("Minimum decimal value: " + minDec);

            float maxFloat = float.MaxValue;
            Console.WriteLine("Maximum float value: " + maxFloat);

            float minFloat = float.MinValue;
            Console.WriteLine("Minimum float value: " + minFloat);

            double maxDouble = double.MaxValue;
            Console.WriteLine("Maximum double value: " + maxDouble);
            */

            var hisName = "Amadeus";
            Console.WriteLine("The variable called hisName is a {0}", hisName.GetTypeCode());
        }
    }
}
