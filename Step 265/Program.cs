using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Step_265
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Zack", lastName = "Bonin", ID = 1 };
            Employee employee1 = new Employee() { firstName = "Joe", lastName = "Bonin", ID = 2 };
            Employee employee2 = new Employee() { firstName = "Irine", lastName = "Fabrigas", ID = 3 };
            Employee employee3 = new Employee() { firstName = "Mojo", lastName = "Bonin", ID = 4 };
            Employee employee4 = new Employee() { firstName = "Jerrie", lastName = "Fabrigas", ID = 5 };
            Employee employee5 = new Employee() { firstName = "Linda", lastName = "Bonin", ID = 6 };
            Employee employee6 = new Employee() { firstName = "Richard", lastName = "Rivera", ID = 7 };
            Employee employee7 = new Employee() { firstName = "Joe", lastName = "Fabrigas", ID = 8 };
            Employee employee8 = new Employee() { firstName = "Jeff", lastName = "Fabrigas", ID = 9 };
            Employee employee9 = new Employee() { firstName = "Jane", lastName = "Fabrigas", ID = 10 };


            List<Employee> employeeList = new List<Employee>() { employee, employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8, employee9 };
            List<Employee> joeList = employeeList.Where(x => x.firstName == "Joe").ToList();
            List<Employee> newList = employeeList.Where(x => x.ID > 5).ToList();
            //foreach (Employee name in employeeList)
            //{
            //    if (name.firstName == "Joe")
            //    {
            //        joeList.Add(name);
            //    }
            //}

             

            Console.ReadLine();

        }
    }
}
