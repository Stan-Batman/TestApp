// See https://aka.ms/new-console-template for more information
using System;

namespace SimpleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            int age = 0;
            bool isValidAge = false;

            while (!isValidAge)
            {
                Console.Write("Enter your age: ");
                string ageInput = Console.ReadLine();
                isValidAge = int.TryParse(ageInput, out age) && age > 0;

                if (!isValidAge)
                {
                    Console.WriteLine("Please enter a valid positive integer for age.");
                }
            }

            Console.WriteLine($"Hello, {name}! You are {age} years old.");
        }
    }
}
