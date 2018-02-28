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

            string sampString = "This is a long sentence filled with many words.";


            /*
            Console.WriteLine("Index of sentence: " + sampString.IndexOf("sentence"));

            Console.WriteLine("4th word in sentence: " + sampString.Substring(10, 5));
            */

            /*
            Console.WriteLine("Is empty " + String.IsNullOrEmpty(sampString));

            Console.WriteLine("Is empty " + String.IsNullOrWhiteSpace(sampString));

            Console.WriteLine("String Length " + sampString.Length);
            */

            string sampString2 = "Here is another sentence containing more words.";

            /*
            Console.WriteLine("The strings are equal in length: " + sampString.Equals(sampString2));

            Console.WriteLine("The first string starts with \"This is\": " + sampString.StartsWith("This is"));

            Console.WriteLine("The second string ends with 'words': " + sampString2.EndsWith("words."));
            */

            // Use this command to replace words/items in a string:
            //sampString = sampString.Replace("words", "characters");

            //Console.WriteLine("The first string with the last word replaced: " + sampString);

            // Use this command to remove words/items in a string:
            //sampString = sampString.Remove(0, 5);

            // Use this command to create a new string:
            //string[] names = new string[3] { "Matt", "Joe", "Paul" };

            //Console.WriteLine("Name list: " + String.Join(", ", names));


            //Can define formats
            string sampString3 = String.Format("{0:c}, {1:00.00}, {2:#.00}, {3:0,0}", 1.56, 15.567, 0.56, 10000);

            Console.WriteLine(sampString3);

        }
    }
}
