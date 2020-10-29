using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_231
{
    public class Math
    {
        public void divideByTwo(int num)
        {
            int result = num / 2;
            Console.WriteLine(result);
        }

        public void addTwo(int num, out int num1)
        {
            num1 = num + 2;
        }

        public decimal addTwo(decimal num, decimal num1)
        {
            decimal result = num + num1;
            return (result);
        }
    }
}
