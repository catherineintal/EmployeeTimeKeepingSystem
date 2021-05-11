using System;
using System.Collections.Generic;

namespace EmployeeTimeKeepingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|----------------------------------------------|");
            Console.WriteLine("|----------------------------------------------|");
            Console.WriteLine("|         Employee Time Keeping System         |");
            Console.WriteLine("|----------------------------------------------|");
            Console.WriteLine("|----------------------------------------------|");

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

            Console.WriteLine();
            Console.WriteLine("Inserted Successfully!");

            Console.WriteLine("======================================");

            Console.WriteLine("Employee Name: " + firstName + lastName);
            Console.WriteLine("Date Today:  " + Date);
            Console.WriteLine("Time-In: " + TimeIn);
            Console.WriteLine("Time-Out: " + TimeOut);
            Console.ReadLine();

            Console.WriteLine("======================================");

                Console.WriteLine("  Employee Attendance  System   ");

                var EmployeeAttendance = new List<string>()
                {" 05/02/21 - Time In: 8:00am - Time Out: 5:00pm",       "05/03/21 - Time In: 9:00am - Time Out: 6:00pm",
                 " 05/04/21 - Time In: 7:00am - Time Out: 7:00pm",       "05/05/21 - Time In: 10:00am - Time Out: 8:00pm" };

                foreach (var AttendanceLog in EmployeeAttendance)
                {
                    Console.WriteLine($"{AttendanceLog}");


                }
            }

        }
    }


