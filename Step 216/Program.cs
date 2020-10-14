using System;

namespace Step_216
{
    class Program
    {
        public static void Main(string[] args)
        {
            //getting user input 
            Console.WriteLine("Choose a number in numeric format:");
            int toPass = Convert.ToInt32(Console.ReadLine());

            //setting up three results variables for the three methods in the "Math" class.
            int result1 = Math.addTwoNumbers(toPass);
            int result2 = Math.subtractTwoNumbers(toPass);
            int result3 = Math.multiplyTwoNumber(toPass);

            //displaying the results from the three methods in the "Math" class.
            Console.WriteLine("15 plus " + toPass + " equals " + result1 + ".");
            Console.WriteLine("15 minus " + toPass + " equals " + result2 + ".");
            Console.WriteLine("15 multiplied by " + toPass + " equals " + result3 + ".");
            Console.ReadLine();

        }
    }
}
