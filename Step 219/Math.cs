using System;
using System.Collections.Generic;
using System.Text;

namespace Step_219
{
    public class Math
    {
        public int mathOperation(int num1)
        {
            int result = 7 + num1;
            return result;
        }

        public int mathOperation(decimal num1)
        {
            int result = (int)(7 - num1);
            return result;
        }

        public int mathOperation(string num1)
        {
            int num2 = Convert.ToInt32(num1);
            int result = 7 * num2;
            return result;
        }
    }
}
