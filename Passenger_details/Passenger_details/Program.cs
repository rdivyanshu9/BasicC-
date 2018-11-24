using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Passenger_details
{
    class Program
    {
        static void Main(string[] args)
        {
            string basic_details;
            uint seats;
            bool concession;

            Console.WriteLine("Enter name, station from, station to");
            Console.WriteLine("Enter number of seats");
            Console.WriteLine("concession");

            basic_details = Console.ReadLine();
            seats = uint.Parse(Console.ReadLine());
            concession = bool.Parse(Console.ReadLine());

            Console.WriteLine("Name, Boarding Staion, Destination station are {0} number of seats are {1} concession {2} ", basic_details, seats, concession);
            Console.ReadLine();
            
        }
    }
}
