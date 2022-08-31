using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWage
    {
        const int IS_FULLTIME = 1, IS_PARTTIME = 2, EMP_RATE_PER_HOUR = 20, WORKING_DAY = 20, MONTHLY_HRS = 100;
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        public void ComputingWage()
        {
            while (totalEmpHrs <= MONTHLY_HRS && totalWorkingDays < WORKING_DAY )
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day:" + totalWorkingDays + " Employee Working Hrs:" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wage:" + totalEmpWage);
        }
    }
}