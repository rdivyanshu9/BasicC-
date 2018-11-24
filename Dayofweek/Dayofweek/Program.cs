using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dayofweek
{
    class Program
    {
        static void Main(string[] args)
        {
            int myday;

            Console.WriteLine("input any number");
            myday = int.Parse(Console.ReadLine());
            switch (myday)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("invalid day");
                    break;
            }
            Console.ReadLine();

        }
    }
}
