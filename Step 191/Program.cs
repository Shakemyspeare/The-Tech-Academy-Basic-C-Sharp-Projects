using System;
using System.Collections.Generic;



    class Program
    {
        static void Main()
        {
            //string array
            string[] arrayNames = { "Zack", "Irine", "Mojo" };
            //int array
            int[] arrayNums = { 1, 2, 3, 4, 5 };
            //list of strings
            List<string> relatives = new List<string>();
            relatives.Add("Linda");
            relatives.Add("Richard");
            relatives.Add("Greg");
            relatives.Add("Susan");


            //user intput to display name from arrayNames
            Console.WriteLine("Please select a number from 0-2 to display a name from the Names array.");
            int nameChoice = Convert.ToInt32(Console.ReadLine());
            //if statement to display message if user input is outside the array.
            if (nameChoice > 2 || nameChoice < 0)
            {
                Console.WriteLine("Please select a number from 0-2");
            }
            //display name that user selects
            Console.WriteLine(arrayNames[nameChoice]);

            //user input to display number from arrayNums
            Console.WriteLine("Please select a number from 0-4 to display a name from the Nums array.");
            int numChoice = Convert.ToInt32(Console.ReadLine());
            //if statement to display message if user input is outside the array.
            if (numChoice > 4 || numChoice < 0)
            {
                Console.WriteLine("Please select a number from 0-4");
            }
            //display number that user selects
            Console.WriteLine(arrayNums[nameChoice]);

            //user input to display name from relatives list
            Console.WriteLine("Please select a number from 0-3 to display a name from the relatives list.");
            int relativeChoice = Convert.ToInt32(Console.ReadLine());
            //if statement to display message if user input os outside the list
            if (relativeChoice > 3 || relativeChoice <0)
            {
                Console.WriteLine("Please select a number from 0-3");
            }
            //display the relative that the user selects
            Console.WriteLine(relatives[relativeChoice]);
            Console.ReadLine();
        }
    }

