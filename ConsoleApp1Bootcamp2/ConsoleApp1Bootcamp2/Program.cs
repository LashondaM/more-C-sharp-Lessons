using System;

namespace ConsoleApp1Bootcamp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var total = 15500.0; //this also works with var
            //var days = 65.0;
            double total = 15500;
            double days = 65;
            double PricePerDay = total / days; // made other ways to do it
            Console.WriteLine($"Bootcamp costs ${total / days} per day");
            // Console.WriteLine("Bootcamp costs $" + total / days + " per day");
            //Console.WriteLine($"Bootcamp costs ${PricePerDay} per day");
        }
    }
}
