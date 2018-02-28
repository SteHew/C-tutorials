using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 0;

            while(i<10)
            {
                if(i==7)
                {
                    i++;
                    continue;
                }

                if(i==9)
                {
                    break;
                }

                if((i%2)>0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            */

            /*
            string guess;

            do
            {
                Console.WriteLine("Guess a number: ");
                guess = Console.ReadLine();

            } while (!guess.Equals("15"));
            */

            /*
            for (int i=0; i<10; i++)
            {
                if ((i % 2)>0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            string randStr = "Here is a set of characters ";

            foreach(char c in randStr)
            {
                Console.WriteLine(c);
            }


        }   
    }
}
