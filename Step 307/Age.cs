using System;
using System.Collections.Generic;
using System.Text;

namespace Step_307
{
    public class Age
    {
        //constructor
        public Age(string userAge)
        {
            EnteredAge = userAge;
        }
        public string EnteredAge { get; set; }

        //Getting users birth year
        public void GetAge(string userInput)
        {
            int age = Convert.ToInt32(userInput);
            //If user input is less than zero throw the custom exception ZeroOrLess
            if (age <= 0)
            {
                throw new ZeroOrLessException();
            }
            //Assigning the users birth year to the integer byear
            int byear = 2020 - age;
            //Writing the users birth year to the console
            Console.WriteLine(byear);
            Console.ReadLine();
        }

    }
}
