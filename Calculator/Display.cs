using System;
namespace Calculator
{
    public class Display
    {
        public static string MenuOptions()
        {
            Console.Clear();
            Console.WriteLine("1. Add two numbers");
            Console.WriteLine("2. Add more than two numbers together");
            Console.WriteLine("3. Subtract one number from the other");
            Console.WriteLine("4. Subtract more than two numbers from the first");
            Console.WriteLine("5. Multiply two numbers");
            Console.WriteLine("6. Divide one number by the other");
            Console.Write("\nChoose 1-6 (or q to quit): ");

            string menuChoice = Console.ReadLine().ToLower();
            Console.Clear();

            return menuChoice;
        }
    }
}

