using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1_CheckAttendance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION PROGRAM");
            Console.WriteLine("--------------------------------------------");

            Random random = new Random();
            int attendance = random.Next(0, 2);

            //Checking if the Employee is Present or not
            if (attendance == 1)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}
