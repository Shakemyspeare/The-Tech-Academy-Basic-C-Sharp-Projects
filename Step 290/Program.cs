using System;
using System.IO;

namespace Step_290
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting user input
            Console.WriteLine("Please choose a number");
            string userAnswer = Console.ReadLine();

            //Declaring the filepath a variable for ease of reusablility
            string filePath = @"C:\Users\Zack\Desktop\log.txt";
            //Writing the user input to the desired file
            File.WriteAllText(filePath, userAnswer);

            //Assigning the content of the file to a variable
            string userInput = File.ReadAllText(filePath);
            //Displaying what is in the file
            Console.WriteLine(userInput);

            Console.ReadLine();
        }
    }
}
