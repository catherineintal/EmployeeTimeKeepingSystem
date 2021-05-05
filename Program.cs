using System;

namespace EmployeeTimeKeepingSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=======================================");
            Console.WriteLine("      Employee Time Keeping System     ");
            Console.WriteLine("======================================");

            Console.WriteLine();

            string firstName;
            Console.Write("Enter your First Name:  ");
            firstName = Console.ReadLine();

            string lastName;
            Console.Write("Enter your Last Name:   ");
            lastName = Console.ReadLine();

            string Date;
            Console.Write("Enter the date today:   ");
            Date = Console.ReadLine();

            string TimeIn;
            Console.Write("Enter your Time In:    ");
            TimeIn = Console.ReadLine();

            string TimeOut;
            Console.Write("Enter your Time Out:    ");
            TimeOut = Console.ReadLine();

            Console.WriteLine("======================================");

            Console.WriteLine("Employee Name: " + firstName + lastName);
            Console.WriteLine("Date Today:  " + Date);
            Console.WriteLine("Time-In: " + TimeIn);
            Console.WriteLine("Time-Out: " + TimeOut);
            Console.WriteLine("Inserted Successfully!");
            Console.ReadLine();

            Console.WriteLine("======================================");



        }
    }
}
