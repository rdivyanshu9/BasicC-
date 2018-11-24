using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circle
{
    class Program
    {

        static void Main(string[] args)
        {
            const double pi = 3.14;
            float r, d;
            double area, perimeter;

            Console.WriteLine("Enter Radius");
            r = float.Parse(Console.ReadLine());

            d = 2 * r;
            perimeter = 2 * pi * r;
            area = pi * r * r;

            Console.WriteLine(" The Diameter is {0} , The Perimeter is {1} , The Area is {2}", d, perimeter, area);
            Console.ReadLine();



        }
    }
}
