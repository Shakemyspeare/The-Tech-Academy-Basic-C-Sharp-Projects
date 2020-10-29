using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_261
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week.");
            string day = Console.ReadLine();

            DaysOfTheWeek daysOfTheWeek;

            try
            {
                daysOfTheWeek = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day);
                Console.WriteLine(daysOfTheWeek);
               
            }
            catch 
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }


            Console.ReadLine();


            
        }


    }
}
