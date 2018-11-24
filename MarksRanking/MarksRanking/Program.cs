using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarksRanking
{
    class Program
    {
        static void Main(string[] args)
        {
        int marks;
        Console.WriteLine("input marks");
        marks = int.Parse(Console.ReadLine());
        if (marks > 90)
            Console.WriteLine("A+ Grade");
        else  if (marks > 80) 
            Console.WriteLine("A Grade");
        else  if (marks > 70) 
            Console.WriteLine("B+ Grade");
        else if (marks > 60)
            Console.WriteLine("B Grade");
        else if (marks > 50)
            Console.WriteLine("C+ Grade");
        else if (marks > 40)
            Console.WriteLine("C Grade");
        else if (marks > 30)
            Console.WriteLine("D Grade");
        else 
            Console.WriteLine("Fail");

        Console.ReadLine();

        }
    }
}
