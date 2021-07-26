using System;

namespace Lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Tristin", "Ray", "Jeff" };
            string[] food = { "Chocolate", "Tacos", "Apples" };
            string[] title = { "CCS", "Trainer", "Tech guru" };
            bool nameCheck;
            bool check2;
            bool ynLoop;
            bool keepGoing;
            int choice;
            string choice2;
            string yn;
            // Displays names/number choices
            //for (int i = 0; i < name.Length; i++) 
            //{
            //    Console.WriteLine($"{i} {name[i]}");
            //}

            // Checks to make sure student exists
            do
            {

                Console.Write("Welcome to our DevBuild class. Which student would you like to know about (0-2)?: ");
                choice = Int32.Parse(Console.ReadLine());
                do
                {
                    if (choice == 0 || choice == 1 || choice == 2)
                    {
                        nameCheck = false;
                    }
                    else
                    {
                        Console.Write("\nThat option is not valid. Please Enter a valid input (0-2): ");
                        choice = Int32.Parse(Console.ReadLine());
                        nameCheck = true;
                    }
                } while (nameCheck);


                Console.WriteLine($"\nStudent {choice} is {name[choice]}. What would you like to know about {name[choice]} (enter \"favorite food\" or \"previous title\")?");
                choice2 = Console.ReadLine().ToLower();
                do
                {
                    if (choice2 == "favorite food")
                    {
                        Console.WriteLine($"\n{name[choice]}'s favorite food is {food[choice]}.");
                        check2 = false;
                    }
                    else if (choice2 == "previous title")
                    {
                        Console.WriteLine($"\n{name[choice]}'s previos title was {title[choice]}.");
                        check2 = false;
                    }
                    else
                    {
                        Console.Write("\nThat data does not exist. Please try again. (enter \"favorite food\" or \"previous title\"): ");
                        choice2 = Console.ReadLine().ToLower();
                        check2 = true;
                    }
                } while (check2);
                do
                {
                    Console.Write("\nWould you like to go again (y/n)?: ");
                    yn = Console.ReadLine().ToLower();
                    if (yn == "y")
                    {
                        keepGoing = true;
                        ynLoop = false;
                    }
                    else if (yn == "n")
                    {
                        keepGoing = false;
                        ynLoop = false;
                    }
                    else
                    {
                        Console.WriteLine("\nThat is not a valid input.");
                        ynLoop = true;
                        keepGoing = false;
                    }
                } while (ynLoop);
            } while (keepGoing);
            Console.WriteLine("\nThanks!");
        }
    }
}
