using System;

namespace Step_219
{
    class Program
    {
        public static void Main(string[] args)
        {
            Math add = new Math();

            Console.WriteLine("Please choose a number in numeric format:");
            int toPass = Convert.ToInt32(Console.ReadLine());
            int result = add.mathOperation(toPass);
            Console.WriteLine(result);
            Console.ReadLine();


            Math subtract = new Math();

            Console.WriteLine("Please choose a decimal in numeric format:");
            decimal toPass1 = Convert.ToDecimal(Console.ReadLine());
            decimal result1 = subtract.mathOperation(toPass1);
            Console.WriteLine(result1);
            Console.ReadLine();

            Math multipy = new Math();

            Console.WriteLine("Please choose a whole number and enter it in numeric format:");
            string toPass2= Console.ReadLine();
            int result2 = multipy.mathOperation(toPass2);
            Console.WriteLine(result2);
            Console.ReadLine();
        }
     }
 }


