using System;

namespace Step_220
{
    class Program
    {
        public static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Please choose a number in numeric format:");
            int toPass1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose another number if you want. It is not required:");
            string optionalArg = Console.ReadLine();
            if (optionalArg == "")
            {
                int result = math.mathOperation(toPass1);
                Console.WriteLine("The result of " + toPass1 + " plus 5 equals " + result + "!");
            }
            else
            {
                int toPass2 = Convert.ToInt32(optionalArg);
                int result = math.mathOperation(toPass1, toPass2);
                Console.WriteLine("The result of " + toPass1 + " plus " + toPass2 + " equals " + result + "!");
            }

            Console.ReadLine();
        }
    }
}
