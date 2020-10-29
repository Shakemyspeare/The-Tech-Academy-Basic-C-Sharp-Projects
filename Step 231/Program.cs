using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_231
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Please enter a number in numeric format: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            math.divideByTwo(userInput);
            Console.WriteLine("Please enter another number in numeric format: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int num1;
            math.addTwo(userNum, out num1);
            Console.WriteLine(num1);
            Console.WriteLine("Please enter another number in numeric format: ");
            decimal userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number in numeric format: ");
            decimal userNum2 = Convert.ToInt32(Console.ReadLine());
            decimal result = math.addTwo(userNum1, userNum2);
            Console.WriteLine(result);

        }
    }
}
