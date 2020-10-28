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
            Console.ReadLine();
        }
    }
}
