using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopEx03Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            double total = 0;

            int num = 1;

            for (num = 1; num <= 10; num++)
            {
                Console.Write("Enter A Number Brother" + "\t");           
                total += double.Parse(Console.ReadLine());
            }

            Console.WriteLine(total);
            Console.WriteLine("DONEZO");
            Console.ReadLine();                                 
        }

    }
}
