using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string sampString = "A long sentence full of words";

            Console.WriteLine("Is empty " + String.IsNullOrEmpty(sampString));

            Console.WriteLine("Is empty " + String.IsNullOrWhiteSpace(sampString));

            Console.WriteLine("String Length " + sampString.Length);
        }
    }
}
