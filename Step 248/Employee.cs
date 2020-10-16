using System;
using System.Collections.Generic;
using System.Text;

namespace Step_237
{
    public class Employee<T> : Person, IQuittable
    {
        public int ID { get; set; }
        public List<T> things { get; set; }

        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("I quit!");
        }





       
    }
}
