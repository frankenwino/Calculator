namespace Calculator
{
    public class Utilities
    {
        public static void EnterToContinue()
        {
            Console.WriteLine("\nPress ENTER to continue");
            Console.ReadLine();
        }

        public static decimal InputNumber(string inputQuestion= "Enter a number: ")
        {
            decimal number;
            bool isdecimal;
            do
            {
                Console.Write(inputQuestion);
                string userInput = Console.ReadLine().Trim();
                isdecimal = decimal.TryParse(userInput, out number);

                if (!isdecimal)
                {
                    Console.WriteLine("Error! Numbers only!");
                }

            } while (!isdecimal);

            return number;
        }

        public static decimal[] CreateDecimalArray()
        {
            List<decimal> numbersList = new();
            string userInput = string.Empty;
            bool continueAdding = true;

            while (continueAdding)
            {
                Console.Write("Enter a number (or q to quit): ");
                userInput = Console.ReadLine().Trim().ToLower();

                if (userInput == "q" && numbersList.Count > 2)
                {
                    continueAdding = false;
                }
                else if (userInput == "q" && numbersList.Count < 3)
                {
                    Console.WriteLine($"Error! You have input only {numbersList.Count} number(s). Need at least three numbers.");
                }
                else
                {
                    decimal number;
                    bool isdecimal = decimal.TryParse(userInput, out number);

                    if (!isdecimal)
                    {
                        Console.WriteLine("Error! Numbers only!");
                    }
                    else
                    {
                        numbersList.Add(number);
                    }
                } 
            }

            decimal[] numbersdecimalArray = numbersList.ToArray();

            return numbersdecimalArray;
        }
    }
}

