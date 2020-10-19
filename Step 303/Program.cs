using System;

namespace Step_303
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring a constant
            const string greeting = "Hello there!";
            //declaring a variable with the var data type
            var additionalGreeting = " Is there anything that I can assist you with?";

            //using both the constand that the var variables
            Console.WriteLine("{0}, my lucky number is {1}!",greeting, additionalGreeting);

            //getting userinput
            Console.WriteLine("Please enter your name: ");
            string greeterName = Console.ReadLine();
            Console.WriteLine("Please enter your employee id: ");
            int greeterId = Convert.ToInt32(Console.ReadLine());

            //constructing the new greeter
            Greeter greeter = new Greeter(greeterName, greeterId);

            //displaying a message using the greeter object
            Console.WriteLine("Remember {0}, always greet the customer with {1}{2}!", greeter.Name, greeting, additionalGreeting);

            Console.ReadLine();
 
        }
    }
}
