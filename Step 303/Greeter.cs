using System;
using System.Collections.Generic;
using System.Text;

namespace Step_303
{
    public class Greeter
    {
        //Constructor
        public Greeter(string name, int id)
        {
            Name = name;
            ID = id;
        }
        //Chaining two constructors together
        public Greeter(string name) : this(name, 4834)
        {
        }

        //Greeter properties
        public string Name { get; set; }
        public int ID { get; set; } 


        
        
    }
}
