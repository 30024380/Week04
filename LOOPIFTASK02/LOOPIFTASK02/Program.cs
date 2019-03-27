//Name: Logan Tawhiri
//Purpose: LOOP 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOOPIFTASK02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            

            Console.WriteLine("Please Enter a Character/Symbol");
            string pop = Console.ReadLine();

            Console.WriteLine("Please Enter a Number");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i <= num; i++)
            {
                Console.WriteLine(pop);
            }
            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
