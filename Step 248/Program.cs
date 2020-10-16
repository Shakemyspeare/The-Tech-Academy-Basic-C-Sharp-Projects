using System;

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

            Employee<string> employee1 = new Employee<string>();
            employee1.things.Add("Zack");
            employee1.things.Add("Irine");
            employee1.things.Add("Mojo");

            Console.WriteLine(employee1);
            Console.ReadLine();
        }

    }
}
