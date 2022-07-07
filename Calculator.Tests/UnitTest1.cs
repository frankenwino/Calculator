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
