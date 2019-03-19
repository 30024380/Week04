using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOOPTASK02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int start = 1;
            int finish = 12;
            int num = 7;

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Loop End");
            Console.WriteLine(" ");

            while (start <= finish)
            {
                Console.WriteLine($"{start} x {num} = {start * num}");
                start++; 
            }

            Console.WriteLine(" ");
            Console.WriteLine("Loop End");
            Console.WriteLine(" ");

            start = 1;
            do
            {
                Console.WriteLine($"{start} x {num} = {start * num}");
                start++;

            } while (start <= finish);

            Console.WriteLine(" ");
            Console.WriteLine("Loop");
            Console.ReadLine();

        }   
    }
}
