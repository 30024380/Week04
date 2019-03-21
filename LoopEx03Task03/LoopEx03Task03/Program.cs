using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopEx03Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Enter A Number" + "\t");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= num; i++)
            {
                if (i != 0 && i % 2 == 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine("DONEZO");
            Console.ReadLine();
        }
    }
}
