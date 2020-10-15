using System;

namespace Step_221
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Please enter a number in numeric format:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number in numeric format:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            math.mathOperation(number1, number2);
            Console.ReadLine();

            math.mathOperation(num1 : 5, num2 : 4);
            Console.ReadLine();
        }
    }
}
