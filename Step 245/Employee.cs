using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Step_245
{
    public class Employee
    {
        public int ID { get; set; }

        public static bool operator ==(Employee employee, Employee employee1)
        {
            return employee.ID == employee1.ID;
        }

        public static bool operator !=(Employee employee, Employee employee1)
        {
            return employee.ID != employee1.ID;
        }
    }

}

     
