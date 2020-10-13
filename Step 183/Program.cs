using System;

namespace Step_183
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name that begins with with letter \"Z\".");
            string name =  Console.ReadLine();
            bool correctName = name == "Zack";

            do
            {
                switch (name)
                {
                    case "Zek":
                        Console.WriteLine("You guessed Zek. I'm not even sure if that is a name...");
                        Console.WriteLine("Try again.");
                        break;
                    case "Zach":
                        Console.WriteLine("That's close. You are almost there!");
                        Console.WriteLine("Try again.");
                        break;
                    case "Zack":
                        Console.WriteLine("You did it!");
                        correctName = true;
                        break;
                    default:
                        Console.WriteLine("You should try harder!");
                        Console.WriteLine("Try again.");
                        break;
                }
            }
            while (correctName);

            Console.ReadLine();


        }
    }
}
