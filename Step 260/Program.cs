using System;

namespace Step_260
{
    class Program
    {
        struct Number
        {
            public decimal Amount { get; set; }
        }
        static void Main(string[] args)
        {
            Number number = new Number();

            number.Amount = 15.2m;

            Console.WriteLine(number.Amount);
            Console.ReadLine();


        }
    }
}
