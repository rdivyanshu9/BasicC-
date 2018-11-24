using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList num = new ArrayList();
            num.Add(21);
            num.Add(25);
            num.Add(54);
            num.Add(78);
            num.Add(85);
            num.Add(76);
            num.Add(83);
		    float sum = 0, avg = 0;

            foreach (int i in num)
                sum += i;
            avg = sum / num.Capacity;

            Console.WriteLine("Sum is : {0} Average is : {1}", sum, avg);

            Console.ReadLine();
        }
    }
}
