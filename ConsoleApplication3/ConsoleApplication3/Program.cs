using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number to multiply");
            int n = int.Parse(Console.ReadLine());


            for (int j = 1; j <= n; j++)
            {
                for (int i = 1; i <= n; i++)
                {
                   int print= ( i * j);
                    Console.Write("{0} ", print);
                }
                Console.WriteLine();
            }
            Console.ReadKey(); 
        }
    }
}
