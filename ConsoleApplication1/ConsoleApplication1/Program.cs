using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length of long side");
            int longside = int.Parse(Console.ReadLine()) ;

            Console.WriteLine("enter length of short side");
            int shortside = int.Parse(Console.ReadLine());

            
            Console.WriteLine("the area of your rectangle would be {0} !", multiply(longside, shortside));
            Console.ReadLine();
        }

        public static int multiply (int x,int y)
        {
            return (x * y);
        }
    }
}
