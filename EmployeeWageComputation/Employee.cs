using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWage
    {
        const int IS_FULLTIME = 1, IS_PARTTIME = 2, EMP_RATE_PER_HOUR = 20, WORKING_DAY = 20;
        int empHrs = 0, empWage = 0, totalEmpWage = 0;
        public void CalulateMonthlyWage()
        {
            for (int day = 0; day < WORKING_DAY; day++)
            {
                Random random = new Random();
                int Check = random.Next(0, 3);
                switch (Check)
                {
                    case IS_FULLTIME:
                        empHrs = 8;
                        Console.WriteLine("Employee is Present for Full-Time Today");
                        break;
                    case IS_PARTTIME:
                        empHrs = 4;
                        Console.WriteLine("Employee is Present for Part-Time Today");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is Absent for Today");
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Today's Wage :" + empWage);
            }
            Console.WriteLine("Total Employee Wage For Month : " + totalEmpWage);
        }
    }
}