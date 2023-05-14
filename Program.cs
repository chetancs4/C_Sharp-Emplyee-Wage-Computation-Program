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
            Console.WriteLine("Employee Wage Computation Program");
            Console.WriteLine("--------------------------------------------");

            //Random random = new Random();
            //int attendance = random.Next(0, 2);

            ////Checking if the Employee is Present or Absent.

            //if (attendance == 1)
            //{
            //    Console.WriteLine("Employee is Present.");
            //}
            //else
            //{
            //    Console.WriteLine("Employee is Absent.");
            //}
          


            Random random = new Random();
            int attendance = random.Next(0, 2);

            int Salary = 0;

            //Constant variables
            const byte FULL_DAY_HOUR = 8;
            const byte WAGE_PER_HOUR = 20;

            //Calculate Employee Present Salary and Absent Salary.
            if (attendance == 1)
            {
                Salary = FULL_DAY_HOUR * WAGE_PER_HOUR;
                Console.WriteLine("Employee is Present for Full time and the Salary is Rs: " + Salary);
            }
            else
            {
                Console.WriteLine("Employee is Absent and the Salary is Rs: " + Salary);
            }
            Console.ReadLine();
        }
    }
}
