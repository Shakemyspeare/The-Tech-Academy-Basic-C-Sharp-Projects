using System;
using System.Collections.Generic;

namespace Step_207
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //creating a list of integers
                List<int> numbers = new List<int>();
                numbers.Add(8);
                numbers.Add(7);
                numbers.Add(15);

                //ask user to input a number to be divided by the numbers in the "numbers" list
                Console.WriteLine("Please enter a whole number in a numeric format:");
                int userInput = Convert.ToInt32(Console.ReadLine());

                //create foreach loop to divide user input by "numbers" list
                foreach (int number in numbers)
                {
                    Console.WriteLine(number + " divided by " + userInput + " equals " + (number / userInput) + " rounded down.");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not use zero");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter in a number in a numeric format, not written out.");
            }
           finally
            {
                Console.WriteLine("\nThis program has run through it's exception handling and has displayed any errors that might have occurred.");
            }

            Console.ReadLine();
        }
    }
}
