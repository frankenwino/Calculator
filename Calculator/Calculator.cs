using System;
namespace Calculator
{
    public class Operation
    {
        public static string Add(decimal firstNumber, decimal secondNumber)
        {
            decimal result = firstNumber + secondNumber;
            string resultString = $"{firstNumber} + {secondNumber} = {result}";

            return resultString;
        }

        public static string Add(params decimal[] numbers)
        {
            decimal result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            string lhs = String.Join(" + ", numbers);
            string resultString = $"{lhs} = {result}";

            return resultString;
        }

        public static string Subtract(decimal firstNumber, decimal secondNumber)
        {
            decimal result = firstNumber - secondNumber;
            string resultString = $"{firstNumber} - {secondNumber} = {result}";

            return resultString;
        }

        public static string Subtract(params decimal[] numbers)
        {
            decimal result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }

            string lhs = String.Join(" - ", numbers);
            string resultString = $"{lhs} = {result}";

            return resultString;
        }

        public static string Multiply(decimal firstNumber, decimal secondNumber)
        {
            decimal result = firstNumber * secondNumber;
            string resultString = $"{firstNumber} * {secondNumber} = {result}";

            return resultString;
        }

        public static string Divide(decimal firstNumber, decimal secondNumber)
        {
            string resultString;
            try
            {
                decimal result = firstNumber / secondNumber;
                resultString = $"{firstNumber} / {secondNumber} = {result}";
            }
            catch (System.DivideByZeroException ex)
            {
                resultString = $"DivideByZeroException caught: {ex.Message}";
            }

            return resultString;
        }
    }
}
