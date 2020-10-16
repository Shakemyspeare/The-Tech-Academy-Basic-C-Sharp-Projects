using System;
using System.Reflection.Metadata;

namespace Step_254
{
    class Program
    {
        enum daysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thusday,
            Friday,
            Saturday,
            Sunday
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Please enter in the current day of the week: ");
            string userInput = Console.ReadLine();
            foreach(daysOfTheWeek days in Enum.GetValues(typeof(daysOfTheWeek)))
            {
                if (userInput == days) 
                {
                    Console.WriteLine(userInput);
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week");
                }
            }
            Console.ReadLine();

        }
    }
}
