using System;

namespace Step_293
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assigning now the current time
            DateTime now = DateTime.Now;
            //Displaying the time in the variable now
            Console.WriteLine(now);
            Console.WriteLine("Please choose a number in numeric format: ");
            //The datetime AddHours function takes a double type argument. Converting user input to a double type to be used later.
            double userInput = Convert.ToDouble(Console.ReadLine());
            //Adding the user input to the now variable
            DateTime nowPlusUserInput = now.AddHours(userInput);
            //Displaying the time with the now variable plus the user input.
            Console.WriteLine("It will be {0} in {1} hours", nowPlusUserInput, userInput);
            Console.ReadLine();
        }
    }
}
