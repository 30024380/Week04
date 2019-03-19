using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOOPTASK03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int first = 0;
            int last = 10;

            for (int lol = 0; lol <= last; lol++)
            {

                Console.WriteLine($"{lol}\t\t{lol*lol}\t\t{lol*lol*lol}");

            }
            Console.WriteLine(" ");
            Console.WriteLine("Loop End");
            Console.WriteLine(" ");
            Console.ReadLine();

            while (first <= last)
            {
                Console.WriteLine($"{first}\t\t{first * first}\t\t{first * first * first}");
                first++;

            }

            Console.WriteLine(" ");
            Console.WriteLine("Loop End");
            Console.WriteLine(" ");
            Console.ReadLine();

            first = 0;

            do
            {
                Console.WriteLine($"{first}\t\t{first * first}\t\t{first * first * first}");
                first++;

            } while (first <= last);

            Console.WriteLine(" ");
            Console.WriteLine("Loop End");
            Console.WriteLine(" ");
            Console.ReadLine();


        }
    }
}
