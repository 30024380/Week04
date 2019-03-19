using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopIFTask01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int start = 76;
            int finish = 46;

            while(start >= finish)
            {                             
                if(start % 2 != 0)
                
                Console.WriteLine(start);
                start--;                 
                
                
            }
            Console.ReadLine();
        }
    }
}
