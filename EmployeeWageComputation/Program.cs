namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.ComputingWage("Dell", 20, 20, 100);
            employeeWage.ComputingWage("HTC", 19, 25, 70);
            employeeWage.ComputingWage("HP", 18, 24, 80);
        }
    }
}