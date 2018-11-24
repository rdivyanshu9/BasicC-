using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoWhileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            do
            {
                Console.WriteLine(number);
                number = number + 1;
            } while (number < 5);
            Console.ReadLine();

        }
        

    }
}
