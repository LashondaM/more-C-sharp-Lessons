
using System;

namespace TestConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("To the C# World...");

            int NumberOfStudents = 17;
            var TotalInClass = NumberOfStudents + 2;
            //Console.WriteLine($"Number of students is " + NumberOfStudents + ", the total is " + TotalInClass);
            Console.WriteLine($"Number of students is {NumberOfStudents}, total is {TotalInClass}");
            var MyNme = "Lashonda";
            Console.WriteLine($"{MyNme} is one of the {NumberOfStudents} students");

            //var NonStudents = TotalInClass - NumberOfStudents;
            //Console.WriteLine($"That means {NonStudents} are not students");

            Console.WriteLine($"That means {TotalInClass - NumberOfStudents} are non-students");
        }
    }
}
