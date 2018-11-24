using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace average
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c; // datatype for storing non decimals
            Console.WriteLine("enter two numbers");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            c = (a + b) / 2;
            Console.WriteLine("avg is {0}", c);
            Console.ReadLine();

        }
    }
}
