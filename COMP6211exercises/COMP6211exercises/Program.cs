using System;
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
            // Create a numeric array of size 10 to hold course IDs

            int[] courseIDs = new int[10];

            courseIDs[0] = 6001;
            courseIDs[1] = 6002;
            courseIDs[2] = 6003;
            courseIDs[3] = 6004;
            courseIDs[4] = 6005;
            courseIDs[5] = 6006;
            courseIDs[6] = 6007;
            courseIDs[7] = 6008;
            courseIDs[8] = 6009;
            courseIDs[9] = 6010;


            Console.WriteLine();
            Console.WriteLine("The length of the Course IDs array is " + courseIDs.Length);
            Console.WriteLine();

            Console.WriteLine("Course ID numbers: ");
            foreach (var item in courseIDs)
            {
                Console.Write(item.ToString() + "\t");
            }
            Console.WriteLine();
            Console.ReadLine();

            int[] courseNums = new int[10];
            Array.Copy(courseIDs, courseNums, 10);

            Console.WriteLine("Course ID numbers in copy array: ");
            foreach (var item in courseNums)
            {
                Console.Write(item.ToString() + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("The array type for Course IDs is: " + courseIDs.GetType());
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("The value of index 5 in Course IDs is: " + courseIDs[5]);
            Console.WriteLine();
            Console.ReadLine();

            // Search for a user defined course ID number

            Console.WriteLine();
            Console.Write("Enter the Course ID Number to search: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            bool found = false;
            for (int i = 0; i < courseIDs.Length; i++)
            {
                if (num == courseIDs[i])
                {
                    found = true;
                    break;
                }
            }
            if (found)
                Console.WriteLine("Element found");
            else
                Console.WriteLine("Element not found");
            Console.WriteLine();
            Console.ReadLine();


            // Reverse the array

            Array.Reverse(courseIDs);
            Console.WriteLine("Reversed array: ");

            foreach (int i in courseIDs)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Console.ReadLine();


            // Change the value at location 5

            Console.WriteLine();

            Console.WriteLine(courseIDs.SetValue(4, 6010));


            // Create a string array containing 10 course names

            string[] courseNames = new string[] { "IT Essentials", "Infrastructure", "Prof Skills", "Programming",
                "Networking", "Statistics", "Software", "Multimedia", "Web Development", "Business Systems"};

            Console.WriteLine();
            Console.WriteLine("The length of the Course Names array is " + courseNames.Length);
            Console.WriteLine();

            Console.WriteLine("Items in Course Names array:");
            foreach (var item in courseNames)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            Console.ReadLine();

            string[] courseTitles = new string[10];
            Array.Copy(courseNames, courseTitles, 10);

            Console.WriteLine("Items in Course Titles array: ");
            foreach (var item in courseTitles)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("The array type for Course Names is: " + courseNames.GetType());
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("The value of index 5 in Course Names is: " + courseNames[5]);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
