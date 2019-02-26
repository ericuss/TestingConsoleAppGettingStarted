
namespace GettingStarted.Calculator.UnitTests.CalculatorIntegration
{
    using Xunit;
    using GettingStarted.Calculator;
    using GettingStarted.Calculator.UnitTests.Mocks;

    public class CalculatorIntegrationTests
    {
        [Theory]
        [InlineData("1", "1", 2)]
        [InlineData("26", "26", 52)]
        [InlineData("30", "30", 60)]
        public void Send_List_Correct_Parameters_And_Return_Correct_Result(string parameter1, string parameter2, int expected_result)
        {
            // Arrange 

            var calculator = new CalculatorIntegration(new SumServiceMock());

            // Act
            var result = calculator.Sum(parameter1, parameter2);

            // Assert
            Assert.Equal(expected_result, result);
        }
    }
}
