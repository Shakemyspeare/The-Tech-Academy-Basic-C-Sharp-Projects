using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Step_245
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        Employee employee = new Employee();

        public static bool operator ==(Employee employee, Employee employee1)
        {
            if (employee.ID == employee1.ID)
            {
                return false;
            }
        }




    }
}
