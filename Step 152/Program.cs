using System;

namespace Step_152
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1: What is your hourly rate?");
            string p1HR = Console.ReadLine();
            int p1HourlyRate = Convert.ToInt32(p1HR);
            Console.WriteLine("Person 1: How many hours a week do you work?");
            string p1HW = Console.ReadLine();
            int p1HoursWeek = Convert.ToInt32(p1HW);
            int p1AnnualRate = (p1HourlyRate * p1HoursWeek) * 52;
            Console.WriteLine("Person 2: What is your hourly rate?");
            string p2HR = Console.ReadLine();
            int p2HourlyRate = Convert.ToInt32(p2HR);
            Console.WriteLine("Person 2: How many hours a week do you work?");
            string p2HW = Console.ReadLine();
            int p2HoursWeek = Convert.ToInt32(p2HW);
            int p2AnnualRate = (p2HourlyRate * p2HoursWeek) * 52;
            Console.WriteLine("Annual salary of Person 1: " + Convert.ToString(p1AnnualRate) + ".");
            Console.WriteLine("Annual salary of Person 2: " + Convert.ToString(p2AnnualRate) + ".");
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(p1AnnualRate > p2AnnualRate);
            Console.ReadLine();

        }
    }
}
