using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("enter the number:");
            i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.Write("entered number is an even number");
                Console.Read();
            }
            else
            {
                Console.WriteLine("entred number is an odd number");
                Console.Read();
            

            }

        }
    }
}
