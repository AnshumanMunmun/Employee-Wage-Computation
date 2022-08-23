using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWage
    {
        const int IS_FULLTIME = 1, EMP_RATE_PER_HOUR = 20;
        int empHrs = 0, empWage = 0;
        public void EmpWage()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_FULLTIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee is Present");
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