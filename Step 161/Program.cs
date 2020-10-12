using System;

namespace Step_161
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age? Please use a numeric format.");
            string userAge = Console.ReadLine();
            int age = Convert.ToInt32(userAge);
            Console.WriteLine("Have you ever had a DUI? Please use \"true\" or \"false\".");
            string userDUI = Console.ReadLine();
            bool dui = Convert.ToBoolean(userDUI);
            Console.WriteLine("How many speeding tickets do you have. Please us a numeric format.");
            string userTicket = Console.ReadLine();
            int ticket = Convert.ToInt32(userTicket);
            bool qualified = age > 15 && dui == false && ticket <= 3;
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
