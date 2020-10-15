using System;

namespace Step_237
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            employee.SayName();
            employee.Quit();
            Console.ReadLine();
        }
    }
}
