using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Here are 5 random numbers from 1 to 500: ");
            Console.WriteLine();

            int[] array1 = new int[5];
            Random randNums = new Random();
            for (int i = 0; i <= 4; i++)
            {
                array1 [i] = randNums.Next(1, 501);
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
