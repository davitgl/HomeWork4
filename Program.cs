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

            //clear
            Console.Clear();

            // Print first and last name
            Console.WriteLine("First Name: davit");
            Console.WriteLine("Last Name: glonti");

            // Request input from the user
            Console.Write("Enter your input: ");
            string userInput = Console.ReadLine();

            

            Console.ReadKey();


        }
    }
}
