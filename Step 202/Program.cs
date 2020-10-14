using System;
using System.Collections.Generic;


namespace Step_202
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a string array
            string[] namesArray = new string[] { "Zack", "Irine", "Greg", "Susan", "Linda" };
            //user input
            Console.WriteLine("Please enter the time of day ie. morning, afternoon, evening, night:");
            //user input to variable
            string userInput = Console.ReadLine();
            //iterate through each name in namesArray adding the user input.
            foreach (string name in namesArray)
            {
                //print to console.
                Console.WriteLine("It is " + userInput + " where " + name + " is.");
            }
            //iterate through each name in namesArray
            foreach (string name in namesArray)
            {
                //print to console.
                Console.WriteLine(name);
            }
            
            //making an infinite loop
            //while (namesArray[0] == "Zack")
            //{
            //    Console.WriteLine("You are stuck in a infinite loop");
            //}

            //fixing infinite loop
            //while (namesArray[0] == "Zack")
            //{
            //    break;
            //}

            //iterating through namesArray with a foreach loop
            foreach (string name in namesArray)
            {
                //if statement that will print names from the namesArray that are less than 5 characters in length
                if (name.Length < 5)
                {
                    Console.WriteLine(name);
                }
            }

            //iterating through namesArray with a foreach loop
            foreach (string name in namesArray)
            {
                //if statement that will print names from the namesArray that are 5 or less characters in length
                if (name.Length <= 5)
                {
                    Console.WriteLine(name);
                }
            }

            //creating a list of strings
            List<string> cousins = new List<string>();
            cousins.Add("Mojo");
            cousins.Add("Julian");
            cousins.Add("Ada");
            cousins.Add("River");

            //getting user input
            Console.WriteLine("Pick one of the cousins: Mojo, Julian, Ada, or River!");
            string userPreference = Console.ReadLine();
            //creating an empty list to hold the index of the user input
            List<int> cousinsIndex = new List<int>();
            //iterating through cousins list and if the user input equals the cousin temp variable, add it to the cousinIndex list
            foreach (string cousin in cousins)
            {
                if (userPreference == cousin)
                {
                    int indexNumber = cousins.IndexOf(cousin);
                    cousinsIndex.Add(indexNumber);
                }
            }
            //adding if statment that checks to see if there is anything in the cousinIndex list. If there is than display the index of that cousin
            //if not then display a message stating that their entry is not in the list.
            foreach (int cousin in cousinsIndex)
                if (cousinsIndex.Count == 0) 
                {
                    Console.WriteLine("The cousin that you chose does not appear to be in this list.");
                }
                else
                {
                    Console.WriteLine("The cousin that you chose is at index " + cousin + "!");
                }

            //creating a list of strings
            List<string> foods = new List<string>();
            foods.Add("Pizza");
            foods.Add("Salad");
            foods.Add("Curry");
            foods.Add("Ice cream");
            foods.Add("Pizza");

            Console.WriteLine("Please select one of the following foods: Pizza, Salad, Curry, or Ice cream");
            string userFood = Console.ReadLine();
            List<int> foodIndex = new List<int>();

            //iterating through list checking if user input matches an item in the list
            foreach (string food in foods)
            {
                if (userFood == food)
                {
                    int userChoice = foods.IndexOf(food);
                    foodIndex.Add(userChoice);
                }
            }
            foreach (int food in foodIndex) 
                if (foodIndex.Count==0)
                {
                    Console.WriteLine("The food item that you chose does not appear to be in this list.");
                }
                else
                {
                    Console.WriteLine("The food item that you chose is at index " + food + "!");
                    break;
                }
            //creating a new list and adding names to it
            List<String> names = new List<string>();
            names.Add("Zack");
            names.Add("Irine");
            names.Add("Zack");
            names.Add("Jerrie");
            
            //creating an empty list
            List<String> roommates = new List<string>();

            //creating a loop to go through the list of names and display them to the console



            Console.ReadLine();
        }
    }
}
