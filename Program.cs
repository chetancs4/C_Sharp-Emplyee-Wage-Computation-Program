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


            /* Random random = new Random();
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
             }*/


            /*Random random = new Random();
            int attendance = random.Next(0, 3);

            int salary = 0;

            //Constant variables
            const byte IS_PRESENT_FULL_TIME = 1;
            const byte IS_PRESENT_PART_TIME = 2;
            const byte FULL_DAY_HOUR = 8;
            const byte PART_TIME_HOUR = 4;
            const byte WAGE_PER_HOUR = 20;

            //Checking if the Employee is Present or not
            if (attendance == IS_PRESENT_FULL_TIME)
            {
                //Calculating the salary for Full time Employee
                salary = FULL_DAY_HOUR * WAGE_PER_HOUR;
                Console.WriteLine("Employee is Present for Full time and the Salary is Rs." + salary);
            }
            else if (attendance == IS_PRESENT_PART_TIME)
            {
                //Calculating the salary for Part time Employee
                salary = PART_TIME_HOUR * WAGE_PER_HOUR;
                Console.WriteLine("Employee is Present for Part time and the Salary is Rs." + salary);
            }
            else
            {
                Console.WriteLine("Employee is Absent and the Salary is Rs." + salary);
            }*/

            //Using Switch Case
            Random random = new Random();
            int attendance = random.Next(0, 3);
            int Salary = 0, daily_hour = 0;

            //Constant variables
            const byte IS_PRESENT_FULL_TIME = 1;
            const byte IS_PRESENT_PART_TIME = 2;
            const byte WAGE_PER_HOUR = 20;

            switch (attendance)
            {
                case IS_PRESENT_FULL_TIME:
                    daily_hour = 8;
                    Console.WriteLine("Employee is Present for Full time.");
                    break;

                case IS_PRESENT_PART_TIME:
                    daily_hour = 4;
                    Console.WriteLine("Employee is Present for Part time.");
                    break;

                default:
                    Console.WriteLine("Employee is Absent.");
                    break;
            }
            Salary = daily_hour * WAGE_PER_HOUR;
            Console.WriteLine("Salary of the Employee is Rs: " + Salary);
            Console.ReadLine();
        }
    }
}
