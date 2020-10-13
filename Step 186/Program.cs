using System;
using System.Text;

namespace Step_186
{
    class Program
    {
        static void Main(string[] args)
        {
            //first three lines of "To be or not to be"
            string firstLine = "To be or not to be, that is the question.\n";
            string secondLine = "Whether 'tis nobler in the mind to suffer,\n";
            string thirdLine = "The slings and arrows of outrageous fortune\n";
            //concatenate the first three lines
            string threeLines = firstLine + secondLine + thirdLine;
            //will convert to uppercase
            string fourthLine = "Or to take arms against a sea of troubles\n";
            //use sting builder to build the next five lines
            StringBuilder sb = new StringBuilder();
            sb.Append("And by opposing end then. To die to sleep\n");
            sb.Append("No more; and by a sleep to say we end\n");
            sb.Append("The heartache and the thousand natural shocks\n");
            sb.Append("That flesh is heir to: 'tis a consummation\n");
            sb.Append("To be wished. To die, to sleep, no more.");
            Console.WriteLine(threeLines + fourthLine.ToUpper() + sb);
            Console.ReadLine();
        }
    }
}
