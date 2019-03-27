using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLoop01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int start = 1;
            int finish = 7;

            while(start <= finish)
            {
                Console.WriteLine($"{start} \t\t {start * 10} \t\t {start * 100}");
                start++;        
            }
            Console.ReadLine();

            start = 1;
            finish = 7;
            for (start = 1; start <= finish; start++)
            {
                Console.WriteLine($"{start} \t\t {start * 10} \t\t {start * 100}");
            }
            Console.ReadLine();

            start = 1;
            finish = 7;
            do
            {
                Console.WriteLine($"{start} \t\t {start * 10} \t\t {start * 100}");
                start++;
            
            } while (start <= finish);
            Console.ReadLine();
        }
    }
}
