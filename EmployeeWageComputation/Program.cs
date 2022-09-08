namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage Dell = new EmployeeWage("Dell", 20, 2, 10);
            Dell.ComputingWage();
            Console.WriteLine(Dell.ToString());
            EmployeeWage HTC = new EmployeeWage("HTC", 10, 4, 20);
            HTC.ComputingWage();
            Console.WriteLine(HTC.ToString());
            EmployeeWage HP = new EmployeeWage("HP", 18, 24, 80);
            HP.ComputingWage();
            Console.WriteLine(HP.ToString());
        }
    }
}