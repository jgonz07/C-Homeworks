﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input some integers")
                int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("input some integers")
                int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("input some integers")
                int num1 = int.Parse(Console.ReadLine());
            int[] numbers = { num1, num2, num3 }

                Console.WriteLine("the largest number is {0}!", Max(numbers));
            Console.ReadLine();

        }

        public static void Max(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers[2];
        }



    }
}