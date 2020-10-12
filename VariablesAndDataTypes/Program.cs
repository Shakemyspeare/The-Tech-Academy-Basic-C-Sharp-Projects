using System;
using System.IO;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is : " + total);
            //Console.ReadLine();

            //bool isStudying = false;
            //byte hoursWorked = 42;
            //sbyte currentTemp = -23;

            Console.WriteLine("The Tech Academy \nStudent Daily Report");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string coursePage = Console.ReadLine();
            int numCoursePage = Convert.ToInt32(coursePage);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string courseQuestion = Console.ReadLine();
            bool courseHelp = Convert.ToBoolean(courseQuestion);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string yourExperience = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string yourStudy = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(yourStudy);


        }
    }
}
