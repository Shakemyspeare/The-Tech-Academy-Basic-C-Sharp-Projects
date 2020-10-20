using System;

namespace Step_307
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting user input 
            Console.WriteLine("Please enter you age: ");
            string userInput = Console.ReadLine();

            //Creating the age object
            Age age = new Age(userInput);

            //Starting a try catch block to ensure user input can be used
            try
            {
                age.GetAge(userInput);
            }
            //Custom exception that will catch if the user input is zero or less
            catch (ZeroOrLessException)
            {
                Console.WriteLine("Please enter a number greater than zero!");
                Console.ReadLine();
                return;
            }
            //Exception with a custom message 
            catch (FormatException)
            {
                Console.WriteLine("Please use a numeric format with no decimals.");
                Console.ReadLine();
                return;
            }
            //General exception with a custom message
            catch (Exception)
            {
                Console.WriteLine("Something went wrong. Please try again.");
                Console.ReadLine();
                return;
            }
        }
    }
}
