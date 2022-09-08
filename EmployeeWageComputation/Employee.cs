using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmployeeWage
    {
        const int IS_FULLTIME = 1, IS_PARTTIME = 2;             // const for declare a constant local variables 
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;  
        public int EMP_RATE_PER_HOUR = 20, WORKING_DAY = 20, MONTHLY_HRS = 100, totalEmpWage;
        public string Company;
        public EmployeeWage(string Company, int EMP_RATE_PER_HOUR, int WORKING_DAY, int MONTHLY_HRS) //Constructors
        {                                        // Use "this" to qualify the members of the class instead of the constructor parameters
            this.Company = Company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.WORKING_DAY = WORKING_DAY;
            this.MONTHLY_HRS = MONTHLY_HRS;
        }
        public void ComputingWage()     //Method for calucalating wage and attendance
        { 
            while (totalEmpHrs <= MONTHLY_HRS && totalWorkingDays < WORKING_DAY )
            {
                totalWorkingDays++;
                Random random = new Random();
                int Check = random.Next(0, 3);
                switch (Check)          // checking the statements
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
                totalEmpHrs += empHrs;   // total Working Days and hours
                Console.WriteLine("Day:" + totalWorkingDays + " Employee Working Hrs:" + empHrs);
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR; // total employee wage for different companys
            Console.WriteLine("Total Salary of Employee per Month in Company {0} wage is {1} ", Company, totalEmpWage);
        }  
        public string ToString()    // returning to the current string
        {
            return "Total Employee Wage for Company " + this.Company + " is " + this.totalEmpWage;
        }
    }
}