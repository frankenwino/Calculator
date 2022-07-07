using System;
using Calculator;

bool continueApplication = true;

while (continueApplication)
{
    decimal firstNumber;
    decimal secondNumber;
    decimal[] numbers;
    string result = String.Empty;
    string menuChoice = Display.MenuOptions();

    switch (menuChoice)
    {       
        case "1": // Add two numbers
            firstNumber = Utilities.InputNumber();
            secondNumber = Utilities.InputNumber();
            result = Operation.Add(firstNumber, secondNumber);
            break;
        case "2": // Add multiple numbers
            numbers = Utilities.CreateDecimalArray();
            result = Operation.Add(numbers);
            break;
        case "3": // Subtract one number from the other
            firstNumber = Utilities.InputNumber();
            secondNumber = Utilities.InputNumber();
            result = Operation.Subtract(firstNumber, secondNumber);
            break;
        case "4": // Subtract more than one number from the first
            numbers = Utilities.CreateDecimalArray();
            result = Operation.Subtract(numbers);
            break;
        case "5": // Multiply two numbers
            firstNumber = Utilities.InputNumber();
            secondNumber = Utilities.InputNumber();
            result = Operation.Multiply(firstNumber, secondNumber);
            break;
        case "6": // Divide one number by the other
            firstNumber = Utilities.InputNumber();
            secondNumber = Utilities.InputNumber();
            result = Operation.Divide(firstNumber, secondNumber);
            break;
        case "q":
            continueApplication = false;
            break;
        default:
            result = "Invalid choice. Please choose [1-6] or 'q' to quit.";
            break;
    }

    if (menuChoice != "q")
    {
        Console.WriteLine(result);
        Utilities.EnterToContinue();
    }
    else
    {
        Console.WriteLine("Bye!");
    }
}