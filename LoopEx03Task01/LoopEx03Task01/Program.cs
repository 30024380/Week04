using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopEx03Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int finish = 50;

            for(int start = 1; start <= finish; start++)
            {    
                
                if(start % 5 == 0)
                Console.Write("\t" + start);               
            }
            Console.ReadLine();
        }
    }
}
