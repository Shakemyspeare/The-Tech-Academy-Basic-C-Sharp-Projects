using System;

namespace Step_151
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiply by 50
            Console.WriteLine("Please enter a number in numeric format.");
            string userInput1 = Console.ReadLine();
            int multiInput = Convert.ToInt32(userInput1) * 50;
            Console.WriteLine(multiInput);
            Console.ReadLine();

            //Add 25
            Console.WriteLine("Please enter a number in numeric format.");
            string userInput2 = Console.ReadLine();
            int addInput = Convert.ToInt32(userInput2) + 25;
            Console.WriteLine(addInput);
            Console.ReadLine();

            //Divide by 12.5
            Console.WriteLine("Please enter a number in numeric format.");
            string userInput3 = Console.ReadLine();
            float divideInput = Convert.ToInt32(userInput3) / 12.5f;
            Console.WriteLine(divideInput);
            Console.ReadLine();

            //Greater than 50
            Console.WriteLine("Please enter a number in numeric format.");
            string userInput4 = Console.ReadLine();
            bool greaterThanInput = Convert.ToInt32(userInput4) > 50;
            Console.WriteLine(greaterThanInput);
            Console.ReadLine();

            //Remainder
            Console.WriteLine("Please enter a number in numeric format.");
            string userInput5 = Console.ReadLine();
            int remainderInput = Convert.ToInt32(userInput5) % 7;
            Console.WriteLine(remainderInput);
            Console.ReadLine();
        }
    }
}
