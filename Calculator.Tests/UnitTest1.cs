using Calculator;
using Xunit;

namespace Calculator.Tests;

public class AddTest
{
    [Fact]
    public void AddTwoNumbersTest()
    {

        //arrange
        decimal firstNumber = 1;
        decimal secondNumber = 1;

        //act
        string result = Operation.Add(firstNumber, secondNumber);

        //assert
        Assert.Equal("1 + 1 = 2", result);
    }

    [Fact]
    public void AddArrayOfNumbersTest()
    {

        //arrange
        decimal[] numbers = { 1, 1, 1 };

        //act
        string result = Operation.Add(numbers);

        //assert
        Assert.Equal("1 + 1 + 1 = 3", result);
    }
}

public class SubtractTest
{
    [Fact]
    public void SubtractOneFromOtherTest()
    {
        //arrange
        decimal firstNumber = 2;
        decimal secondNumber = 3;

        //act
        string result = Operation.Subtract(firstNumber, secondNumber);

        //assert
        Assert.Equal("2 - 3 = -1", result);
    }

    [Fact]
    public void SubtractArrayOfNumbersTest()
    {

        //arrange
        decimal[] numbers = { 10, 3, 2, 1 };

        //act
        string result = Operation.Subtract(numbers);

        //assert
        Assert.Equal("10 - 3 - 2 - 1 = 4", result);
    }
}

public class MultiplyTest
{
    [Fact]
    public void MultiplyTwoNumbersTest()
    {
        //arrange
        decimal firstNumber = 5;
        decimal secondNumber = 5;

        //act
        string result = Operation.Multiply(firstNumber, secondNumber);

        //assert
        Assert.Equal("5 * 5 = 25", result);
    }
}


public class DivideTest
{
    [Fact]
    public void DivideTwoNumbersTest()
    {
        //arrange
        decimal firstNumber = 10;
        decimal secondNumber = 2;

        //act
        string result = Operation.Divide(firstNumber, secondNumber);

        //assert
        Assert.Equal("10 / 2 = 5", result);
    }

    [Fact]
    public void DivideByZeroTest()
    {
        //arrange
        decimal firstNumber = 10;
        decimal secondNumber = 0;

        //act
        string result = Operation.Divide(firstNumber, secondNumber);

        //assert
        Assert.Equal("DivideByZeroException caught: Attempted to divide by zero.", result);
    }
}