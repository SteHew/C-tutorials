using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //To declare an array, need to start with data type e.g.
                        //int[] randNumArray;

            int[] randArray = new int[5];

            int[] randArray2 = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array length: " + randArray2.Length);

            Console.WriteLine("Item 0 " + randArray2[0]);

            //To cycle through the contents of an array, can use a 'for loop'

            for(int i=0; i<randArray2.Length; i++)
            {
                Console.WriteLine("{0}:{1}", i, randArray2[i]);
            }

            //Can also use a 'foreach' statement to list each item

            foreach(int num in randArray2)
            {
                Console.WriteLine(num);
            }

            //To locate an item within an array, use the IndexOf function
            //Console.WriteLine("Where is 3: " + Array.IndexOf(randArray2, 4));

            //Can create string arrays
            string[] names = { "Tom", "Paul", "Sally" };

            Console.WriteLine(names);

            //Can join a string to an array
            string nameStr = string.Join(", ", names);

            Console.WriteLine(nameStr);

            //where the string called nameStr is joined to the string array called names

            //Can also split a string into two arrays.

            //Integer multi-dimensional arrays:

            int[,] multArray = new int[5, 3];

            int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            foreach(int num in multArray2)
            {
                Console.WriteLine(num);
            }

            for(int x=0; x<multArray2.GetLength(0); x++)
            {
                for(int y=0; y<multArray2.GetLength(1); y++)
                {
                    Console.WriteLine("{0}|{1}:{2}", x, y, multArray2[x, y]);
                }
            }

        }
    }
}
