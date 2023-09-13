using System;
using System.ComponentModel.Design;

namespace MyFirstProgram
{
    // Olov Olsson Sundqvist .NET23
    internal class Program
    {
        static void Main(string[] args)
        {   // Welcome user to program and ask for input
            Console.WriteLine("Hej");
            Console.WriteLine("Vänligen skriv ett tal"); // Jag vet att vi kunde sätta värdet på talet själv, men tyckte det kändes bättre att fråga om det.
            // Converting user input to int
            int number = Convert.ToInt32(Console.ReadLine());
            // See if input value is over or under 10
            if (number > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else
            {
                Console.WriteLine("Oj. Lågt tal!");
            }
            // Ask for user input
            Console.WriteLine("\nVad heter du?");
            string name = Console.ReadLine();
            // Output user input
            Console.WriteLine("Hej " + name + "!\n");
            // Loop that outputs all numbers from 0 to the number the user input in int number
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }
            // Closing program
            Console.WriteLine("\n\nTryck på valfri tangent för att stänga...");
            Console.ReadKey();

        }
    }
}