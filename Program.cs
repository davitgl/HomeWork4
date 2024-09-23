using System;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Change console background and foreground colors
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            // Clear to apply background color
            Console.Clear();

            // Print first and last name
            Console.WriteLine("First Name: davit");
            Console.WriteLine("Last Name: glonti");

            // Request input from the user
            Console.Write("Enter your input: ");
            string userInput = Console.ReadLine();

            // Print the user input
            Console.WriteLine("You entered: " + userInput);


            Console.ReadKey();


        }
    }
}
