using System;
using System.Collections.Generic;

namespace Step_237
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            //employee.SayName();
            //employee.Quit();
            //Console.ReadLine();


            Employee<string> employee = new Employee<string>();
            employee.things = new List<string>();
            employee.things.Add("Zack");
            employee.things.Add("Irine");
            employee.things.Add("Mojo");



            Employee<int> employee1 = new Employee<int>();
            employee1.things = new List<int>();
            employee1.things.Add(15);
            employee1.things.Add(75);
            employee1.things.Add(32);

            foreach (string name in employee.things)
            {
                Console.WriteLine(name);
            }
            foreach (int num in employee1.things)
            {
                Console.WriteLine(num);
            }


            Console.ReadLine();
        }

    }
}
