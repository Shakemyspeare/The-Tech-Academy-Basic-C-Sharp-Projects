using System;

namespace Step_178
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nWhat is the weight of the package that you wish to ship?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50) 
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            Console.WriteLine("What is the width of the package that you wish to ship?");
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of the package that you wish to ship?");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the length of the package that you wish to ship?");
            int packageLength = Convert.ToInt32(Console.ReadLine());
            if (packageWidth + packageHeight + packageLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            int dimensions = packageWidth * packageHeight * packageLength;
            decimal quote = (dimensions * packageWeight) / 100;
            Console.WriteLine("Your estimated total for shipping this package is:\n$" + quote);
            Console.ReadLine();

        }
    }
}
