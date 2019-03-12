using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOOPTASK01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int limit = 10;

            for (int counter = 1; counter <= limit; counter++)
            {                
                Console.Write(counter * 10 + "\t");               
                Console.Write(counter * 100 + "\t");
                Console.Write(counter * 1000 + "\t");
                Console.ReadLine();
            }
        }
    }



}
