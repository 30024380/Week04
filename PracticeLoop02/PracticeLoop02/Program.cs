using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLoop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Enter A Number");
            int unum = int.Parse(Console.ReadLine());

            int num = 0;
            int sum= num ;

            for (num = 0; num <= unum; num++)
            {
                Console.WriteLine($"{num}");
                sum = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
