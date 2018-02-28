using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder is used when the code calls for editing a string, and not creating a new string.

            StringBuilder sb = new StringBuilder();

            sb.Append("This is the first sentence. ");
            sb.AppendFormat("My name is {0} and I live in {1}.", "Derek", "Pennsylvania");

            //sb.Replace("a", "e");

            //sb.Remove(5, 7);

            Console.WriteLine(sb.ToString());

        }
    }
}
