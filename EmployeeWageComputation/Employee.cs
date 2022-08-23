using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWage
    {
        const int IS_FULLTIME = 1, IS_HALFTIME = 2, EMP_RATE_PER_HOUR = 20;
        int empHrs = 0, empWage = 0;
        public void PartTime()
        {
            Random random = new Random();
            int check = random.Next(0, 3);
            if (check == IS_FULLTIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee is Present for Fulltime");
            }
            else if (check == IS_HALFTIME)
            {
                empHrs = 4;
                Console.WriteLine("Employee is Present for Halfime");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage :" + empWage);
        }
    }
}