//Name: Logan Tawhiri
//Purpose: For, While, Do-while

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

            int limit = 5;

            Console.WriteLine("N\t\t10*N\t\t100*N\t\t1000*N");
            for (int counter = 1; counter <= limit; counter++)
            {                
                Console.Write(counter * 10 + "\t\t");               
                Console.Write(counter * 100 + "\t\t");
                Console.Write(counter * 1000 + "\t\t");
                Console.ReadLine();

            }

            Console.WriteLine(" ");
            Console.WriteLine("Loop End");
            Console.WriteLine(" ");

            int gg = 1;

            while (gg <= limit)
            {
                Console.Write(gg * 10 + "\t\t");
                Console.Write(gg * 100 + "\t\t");
                Console.Write(gg * 1000 + "\t\t");
                gg++;
                Console.ReadLine();

            }

            Console.WriteLine(" ");
            Console.WriteLine("Loop End");
            Console.WriteLine(" ");

            gg = 1;
            do
            {
                Console.Write(gg * 10 + "\t\t");
                Console.Write(gg * 100 + "\t\t");
                Console.Write(gg * 1000 + "\t\t");
                gg++;
                Console.ReadLine();

            } while (gg <= limit);
            Console.ReadLine();

            int start1 = 1;
            int finish = 5;

            Console.WriteLine("N\t\t10*N\t\t100*N\t\t1000*N");
            for (int i = start1; i <= finish; i++)
            {
                Console.WriteLine($"{i}\t\t{i * 10}\t\t{i * 100}\t\t{i * 1000}");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Loop End");
            Console.ReadLine();

            start1 = 1;
            while (start1 <= finish)
            {
                Console.WriteLine($"{start1}\t\t{start1 * 10}\t\t{start1 * 100}\t\t{start1 * 1000}");
                start1++;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Loop End");
            Console.ReadLine();
            start1 = 1;
            do
            {
                Console.WriteLine($"{start1}\t\t{start1 * 10}\t\t{start1 * 100}\t\t{start1 * 1000}");
                start1++;
            } while (start1 <= finish);

            Console.WriteLine(" ");
            Console.WriteLine("Loop End");
            Console.ReadLine();



        }
    }



}
