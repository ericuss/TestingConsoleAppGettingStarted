
namespace GettingStarted.Calculator.UnitTests.Calculator
{
    using Xunit;
    using GettingStarted.Calculator;

    public class CalculatorTests
    {
        [Fact]
        public void Send_Correct_Parameters_And_Return_Correct_Result()
        {
            // Arrange 
            var dummy_parameter1 = "1";
            var dummy_parameter2 = "2";
            var expected_result = 3;

            var calculator = new Calculator();

            // Act
            var result = calculator.Sum(dummy_parameter1, dummy_parameter2);

            // Assert
            Assert.Equal(expected_result, result);
        }

        [Theory]
        [InlineData("1", "1", 2)]
        [InlineData("26", "26", 52)]
        [InlineData("30", "30", 60)]
        public void Send_List_Correct_Parameters_And_Return_Correct_Result(string parameter1, string parameter2, int expected_result)
        {
            // Arrange 

            var calculator = new Calculator();

            // Act
            var result = calculator.Sum(parameter1, parameter2);

            // Assert
            Assert.Equal(expected_result, result);
        }
    }
}
