using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWage
    {
        const int IS_FULLTIME = 1;
        public void Attendance()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_FULLTIME)
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}